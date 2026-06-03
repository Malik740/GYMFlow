Imports System.Data.SqlClient

Public Class EditMember
    ' --- 1. تعبئة الـ ComboBox بالخطط وضبط حدود العدادات غصب عن السيستم ---
    Private Sub EditMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' الضربة القاضية لمشكلة الـ 175 (رفع الحد الأقصى للعدادات)
        numHeight.Maximum = 300
        numWeight.Maximum = 300

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
            MsgBox("Error loading plans: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrEmpty(txtSearchID.Text.Trim()) Then
            MsgBox("Please enter a Member Name or ID to search.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        Dim query As String = "SELECT MemberID, FullName, Phone, Weight, Height, JoinDate, PlanID FROM Members " &
                             "WHERE FullName = @Search OR CAST(MemberID AS NVARCHAR) = @Search"

        Try
            OpenConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Search", txtSearchID.Text.Trim())

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtID.Text = reader("MemberID").ToString()
                        txtFullName.Text = reader("FullName").ToString()
                        txtPhone.Text = reader("Phone").ToString()
                        numWeight.Value = Convert.ToDecimal(reader("Weight"))
                        numHeight.Value = Convert.ToDecimal(reader("Height"))
                        dtpStartDate.Value = Convert.ToDateTime(reader("JoinDate"))
                        cmbPlan.SelectedValue = reader("PlanID")
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            MsgBox("Please search and select a member first before saving changes.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtFullName.Text.Trim()) OrElse cmbPlan.SelectedIndex = -1 Then
            MsgBox("Full Name and Subscription Plan cannot be empty.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        Dim query As String = "UPDATE Members SET FullName = @FullName, Phone = @Phone, Weight = @Weight, " &
                             "Height = @Height, JoinDate = @JoinDate, PlanID = @PlanID WHERE MemberID = @ID"

        Try
            OpenConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text.Trim())
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())
                cmd.Parameters.AddWithValue("@Weight", numWeight.Value)
                cmd.Parameters.AddWithValue("@Height", numHeight.Value)
                cmd.Parameters.AddWithValue("@JoinDate", dtpStartDate.Value.Date)
                cmd.Parameters.AddWithValue("@PlanID", cmbPlan.SelectedValue)
                cmd.Parameters.AddWithValue("@ID", txtID.Text)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MsgBox("Member information updated successfully!", MsgBoxStyle.Information, "Success")
                Else
                    MsgBox("Update failed. Member might not exist.", MsgBoxStyle.Exclamation, "Error")
                End If
            End Using
        Catch ex As Exception
            MsgBox("Error updating member: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtSearchID.Clear()
        txtID.Clear()
        txtFullName.Clear()
        txtPhone.Clear()
        numWeight.Value = 0
        numHeight.Value = 0
        cmbPlan.SelectedIndex = -1
        dtpStartDate.Value = DateTime.Now
    End Sub
End Class