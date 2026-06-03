Imports System.Data.SqlClient

Public Class AddUser

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtfullname.Clear()
        mskphone.Clear()
        txtemail.Clear()
        txtlocation.Clear()
        cmbplan.SelectedIndex = 0
        txtsal.Clear()
        txtnote.Clear()
        rdbmale.Checked = True
    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbplan.Items.Clear()
        cmbplan.Items.Add("Morning Shift 8-3")
        cmbplan.Items.Add("Evening Shift 3-10")
        cmbplan.Items.Add("Night Shift 10-5")
        cmbplan.SelectedIndex = 0
    End Sub

    Private Sub btnsavemember_Click(sender As Object, e As EventArgs) Handles btnsavemember.Click
        If String.IsNullOrEmpty(txtfullname.Text.Trim()) Then
            MessageBox.Show("Please enter the full name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtsal.Text.Trim()) Then
            MessageBox.Show("Please enter the salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim quer As String = "INSERT INTO Trainers (TrainerName, Specialty, Salary) VALUES (@TrainerName, @Specialty, @Salary)"

        Try
            OpenConnection()
            Using cmd As New SqlCommand(quer, conn)
                cmd.Parameters.AddWithValue("@TrainerName", txtfullname.Text.Trim())

                Dim specialtyText As String = cmbplan.SelectedItem.ToString()
                If Not String.IsNullOrEmpty(txtnote.Text.Trim()) Then
                    specialtyText &= " - " & txtnote.Text.Trim()
                End If
                cmd.Parameters.AddWithValue("@Specialty", specialtyText)

                Dim salary As Decimal = 0
                Decimal.TryParse(txtsal.Text.Trim(), salary)
                cmd.Parameters.AddWithValue("@Salary", salary)

                Dim roweffected As Integer = cmd.ExecuteNonQuery()
                If roweffected > 0 Then
                    MessageBox.Show("Staff / Trainer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btnreset.PerformClick()
                Else
                    MessageBox.Show("Failed to add staff.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            CloseConnection()
        End Try
    End Sub
End Class