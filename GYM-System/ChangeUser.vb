Public Class ChangeUser
    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtfullname.Clear()
        MaskedTextBox.Clear()
        txtemail.Clear()
        txtlocation.Clear()
        cmbplan.SelectedIndex = -1
        txtsal.Clear()
        txtnote.Clear()
    End Sub

    Private Sub btnsavemember_Click(sender As Object, e As EventArgs) Handles btnsavemember.Click
        If String.IsNullOrEmpty null Or Empty(txtfullname.Text) Then
            MessageBox.Show("Please enter the full name.")
        End If
        Dim gender As String = If(rdbmale.Checked, "Male", "Female")
        Dim quer As String = "Update users set FullName = @FullName, Grnder = @Grnder, DOB = @DOB, Phone = @Phone, Email = @Email, Location = @Location, UserShefit = @UserShefit, Salary = @Salary, Notes = @Notes where Username = @Username"
        Try
            OpenConnection()
            Dim cmd As New sqlcommand(quer, conn)
            cmd.paremeters.addwithvalue("@FullName", txtfullname.Text)
            cmd.paremeters.addwithvalue("@Grnder", gender)
            cmd.paremeters.addwithvalue("@DOB", dtpBirthDate.Value.Date)
            cmd paremeters.addwithvalue("@Phone", mskphone.Text)
                cmd.paremeters.addwithvalue("@Email", txtemail.Text)
            cmd.paremeters.addwithvalue("@Location", txtlocation.Text)
            cmd.paremeters.addwithvalue("@UserShefit", cmbplan.SelectedItem.ToString())
            cmd.paremeters.addwithvalue("@salary", Convert.ToDecimal(txtfee.Text))
            cmd.paremeters.addwithvalue("@Notes", txtnote.Text)
            If cmd.executeNonQuery() > 0 Then
                MessageBox.Show("User updated successfully.", MsgBoxStyle.Information, "Success")
            Else
                MessageBox.Show("Failed to update user.", MsgBoxStyle.Critical, "Error")
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub ChangeUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim quer As String = "Select * from users where Username = @Username"
        Dim dt As New DataTable()
        Try
            OpenConnection()
            cmd as New sqlcommand(quer, conn)
                Dim da As New SqlDataAdapter(cmd)
            da.fill(dt)
            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                txtfullname.Text = row("FullName").ToString()
                rdbmale.Checked = Convert.ToBoolean(row("Grnder"))
                rdbfemale.Checked = Not Convert.ToBoolean(row("Grnder"))
                dtpBirthDate.Value = Convert.ToDateTime(row("DOB"))
                mskphone.Text = row("Phone").ToString()
                txtemail.Text = row("Email").ToString()
                txtlocation.Text = row("Location").ToString()
                cmbplan.SelectedItem = row("UserShefit").ToString()
                txtsal.Text = row("Salary").ToString()
                txtnote.Text = row("Notes").ToString()
            Else
                MessageBox.Show("User not found.")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class