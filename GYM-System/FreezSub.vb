Imports System.Data.SqlClient

Public Class FreezSub
    Private originalExpiryDate As Date

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrEmpty(txtSearch.Text.Trim()) Then
            MsgBox("Please enter a Member Name or ID to search.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        Dim query As String = "SELECT M.MemberID, M.FullName, P.PlanName, M.ExpiryDate " &
                             "FROM Members M " &
                             "INNER JOIN MembershipPlans P ON M.PlanID = P.PlanID " &
                             "WHERE M.FullName = @Search OR CAST(M.MemberID AS NVARCHAR) = @Search"

        Try
            OpenConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Search", txtSearch.Text.Trim())

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtID.Text = reader("MemberID").ToString()
                        txtFullName.Text = reader("FullName").ToString()
                        txtCurrentPlan.Text = reader("PlanName").ToString()

                        originalExpiryDate = Convert.ToDateTime(reader("ExpiryDate"))
                        txtEndDate.Text = originalExpiryDate.ToString("yyyy-MM-dd")

                        numFreezeDays.Value = 0
                        txtNewEndDate.Clear()
                    Else
                        MsgBox("No member found with this Name or ID.", MsgBoxStyle.Exclamation, "Not Found")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error fetching member data: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub
    Private Sub numFreezeDays_ValueChanged(sender As Object, e As EventArgs) Handles numFreezeDays.ValueChanged
        If Not String.IsNullOrEmpty(txtID.Text) AndAlso numFreezeDays.Value > 0 Then
            Dim calculatedDate As Date = originalExpiryDate.AddDays(Convert.ToDouble(numFreezeDays.Value))
            txtNewEndDate.Text = calculatedDate.ToString("yyyy-MM-dd")
        Else
            txtNewEndDate.Clear()
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MsgBox("Please search and select a member first.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        If numFreezeDays.Value <= 0 OrElse String.IsNullOrEmpty(txtNewEndDate.Text) Then
            MsgBox("Please enter the number of freeze days.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        Dim query As String = "UPDATE Members SET ExpiryDate = @NewExpiry, SubscriptionStatus = @Status WHERE MemberID = @ID"

        Try
            OpenConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@NewExpiry", Date.Parse(txtNewEndDate.Text))
                cmd.Parameters.AddWithValue("@Status", "Frozen")
                cmd.Parameters.AddWithValue("@ID", txtID.Text)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Subscription frozen successfully! Expiry date extended.", MsgBoxStyle.Information, "Success")
                    btnCancel.PerformClick()
                Else
                    MsgBox("Failed to update subscription.", MsgBoxStyle.Exclamation, "Error")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error confirming freeze: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        txtSearch.Clear()
        txtID.Clear()
        txtFullName.Clear()
        txtCurrentPlan.Clear()
        txtEndDate.Clear()
        numFreezeDays.Value = 0
        txtNewEndDate.Clear()
    End Sub


End Class