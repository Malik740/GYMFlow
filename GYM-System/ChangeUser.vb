Imports System.Data.SqlClient

Public Class ChangeUser
    Private targetTrainerID As Integer = 0

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtfullname.Clear()
        mskphone.Clear()
        txtemail.Clear()
        txtlocation.Clear()
        If cmbplan.Items.Count > 0 Then cmbplan.SelectedIndex = 0
        txtfee.Clear()
        txtnote.Clear()
        targetTrainerID = 0
    End Sub

    Private Sub btnsavemember_Click(sender As Object, e As EventArgs) Handles btnsavemember.Click
        If targetTrainerID = 0 Then
            MessageBox.Show("Please search and load a staff member first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtfullname.Text.Trim()) Then
            MessageBox.Show("Please enter the full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtfee.Text.Trim()) Then
            MessageBox.Show("Please enter the salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim specialtyText As String = cmbplan.SelectedItem.ToString()
        If Not String.IsNullOrEmpty(txtnote.Text.Trim()) Then
            specialtyText &= " - " & txtnote.Text.Trim()
        End If

        Dim salary As Decimal = 0
        Decimal.TryParse(txtfee.Text.Trim(), salary)

        Dim quer As String = "UPDATE Trainers SET TrainerName = @TrainerName, Specialty = @Specialty, Salary = @Salary WHERE TrainerID = @TrainerID"
        Try
            OpenConnection()
            Using cmd As New SqlCommand(quer, conn)
                cmd.Parameters.AddWithValue("@TrainerName", txtfullname.Text.Trim())
                cmd.Parameters.AddWithValue("@Specialty", specialtyText)
                cmd.Parameters.AddWithValue("@Salary", salary)
                cmd.Parameters.AddWithValue("@TrainerID", targetTrainerID)

                If cmd.ExecuteNonQuery() > 0 Then
                    MsgBox("Staff member updated successfully.", MsgBoxStyle.Information, "Success")
                    btnreset.PerformClick()
                Else
                    MsgBox("Failed to update staff member.", MsgBoxStyle.Critical, "Error")
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub ChangeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbplan.Items.Clear()
        cmbplan.Items.Add("Morning Shift 8-3")
        cmbplan.Items.Add("Evening Shift 3-10")
        cmbplan.Items.Add("Night Shift 10-5")
        cmbplan.SelectedIndex = 0
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrEmpty(txtfullname.Text.Trim()) Then
            MessageBox.Show("Please enter a name to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim quer As String = "SELECT TrainerID, TrainerName, Specialty, Salary FROM Trainers WHERE TrainerName = @TrainerName"
        Dim dt As New DataTable()
        Try
            OpenConnection()
            Using cmd As New SqlCommand(quer, conn)
                cmd.Parameters.AddWithValue("@TrainerName", txtfullname.Text.Trim())
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                targetTrainerID = Convert.ToInt32(row("TrainerID"))
                txtfullname.Text = row("TrainerName").ToString()
                txtfee.Text = row("Salary").ToString()

                Dim specialty As String = row("Specialty").ToString()
                If specialty.Contains("Morning Shift 8-3") Then
                    cmbplan.SelectedIndex = 0
                ElseIf specialty.Contains("Evening Shift 3-10") Then
                    cmbplan.SelectedIndex = 1
                ElseIf specialty.Contains("Night Shift 10-5") Then
                    cmbplan.SelectedIndex = 2
                End If

                If specialty.Contains(" - ") Then
                    Dim parts As String() = specialty.Split(New String() {" - "}, StringSplitOptions.None)
                    If parts.Length > 1 Then
                        txtnote.Text = parts(1)
                    End If
                Else
                    txtnote.Text = ""
                End If
                MsgBox("Staff data loaded successfully.", MsgBoxStyle.Information, "Success")
            Else
                MessageBox.Show("Staff member not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
                targetTrainerID = 0
            End If
        Catch ex As Exception
            MsgBox("An error occurred during search: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CloseConnection()
        End Try
    End Sub
End Class