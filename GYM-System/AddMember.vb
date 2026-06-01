Imports System.Data.SqlClient

Public Class AddMember
    Private Sub btnaddmember_Click(sender As Object, e As EventArgs) Handles btnaddmember.Click
        If String.IsNullOrEmpty(txtFullName.Text.Trim()) Then
            MsgBox("Please enter the full name.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtPhone.Text.Replace("-", "").Trim()) Then
            MsgBox("Please enter the phone number.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        If cmbPlan.SelectedIndex = -1 Then
            MsgBox("Please select a Subscription Plan.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        Dim startDate As Date = dtpStartDate.Value.Date
        Dim expiryDate As Date = startDate.AddMonths(1)

        Dim query As String = "INSERT INTO Members (FullName, Phone, Weight, Height, JoinDate, ExpiryDate, SubscriptionStatus, PlanID) " &
                             "VALUES (@FullName, @Phone, @Weight, @Height, @JoinDate, @ExpiryDate, @Status, @PlanID)"

        Try
            OpenConnection()

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim())
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                cmd.Parameters.AddWithValue("@Weight", numWeight.Value)
                cmd.Parameters.AddWithValue("@Height", numHeight.Value)
                cmd.Parameters.AddWithValue("@JoinDate", startDate)
                cmd.Parameters.AddWithValue("@ExpiryDate", expiryDate)
                cmd.Parameters.AddWithValue("@Status", "Active")
                cmd.Parameters.AddWithValue("@PlanID", cmbPlan.SelectedValue)

                Dim affectedRows As Integer = cmd.ExecuteNonQuery()

                If affectedRows > 0 Then
                    MsgBox("Member added successfully.", MsgBoxStyle.Information, "Success")
                    ClearFeilds()
                Else
                    MsgBox("Failed to add the member.", MsgBoxStyle.Exclamation, "Error")
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error adding member: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub ClearFeilds()
        txtFullName.Clear()
        txtPhone.Clear()
        rbMale.Checked = True
        numHeight.Value = 0
        numWeight.Value = 0
        cmbPlan.SelectedIndex = -1
        dtpStartDate.Value = DateTime.Now
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        ClearFeilds()
    End Sub

    Private Sub AddMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT PlanID, PlanName FROM MembershipPlans"
        Dim dt As New DataTable()

        Try
            OpenConnection()
            Using cmd As New SqlCommand(query, conn)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            cmbPlan.DataSource = dt
            cmbPlan.DisplayMember = "PlanName"
            cmbPlan.ValueMember = "PlanID"
            cmbPlan.SelectedIndex = -1

        Catch ex As Exception
            MsgBox("Error loading subscription plans: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub
End Class