Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class AddUser

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdbfemale.CheckedChanged

    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtfullname.Clear()
        MaskedTextBox.Clear()
        txtemail.Clear()
        txtlocation.Clear()
        cmbplan.SelectedIndex = -1
        txtsal.Clear()
        txtnote.Clear()
    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        smbplan.Items.Add("morning shift 8-3")
        smbplan.Items.Add("evening shift 3-10")
        smbplan.Items.Add("night shift 10-5")
        smbplan.SelectedIndex = 0
    End Sub

    Private Sub btnsavemember_Click(sender As Object, e As EventArgs) Handles btnsavemember.Click
        If String.IsNullOrEmpty null Or Empty(txtfullname.Text) Then
            MessageBox.Show("Please enter the full name.")
        End If
        If String.IsNullOrEmpty null Or Empty(mskphone.Text) Then
            MessageBox.Show("Please enter the phone number.")
        End If
        If String.IsNullOrEmpty null Or Empty(txtemail.Text) Then
            MessageBox.Show("Please enter the email address.")
        End If
        If String.IsNullOrEmpty null Or Empty(txtlocation.Text) Then
            MessageBox.Show("Please enter the location.")
        End If
        If String.IsNullOrEmpty null Or Empty(txtsal.Text) Then
            MessageBox.Show("Please enter the salary.")
        End If
        Dim quer As String = "Insert into users (FullName,Grnder,DOB,Phone,Email,Location,UserShefit,Salary,Notes)" & "Values(@FullName)"
        Try
            OpenConnection()
            dimcmd as New sqlcommand(quer, conn)
                cmd.paremeters.addwithvalue("@FullName", txtfullname.Text)
            cmd.paremeters.addwithvalue("@Grnder", rdbmale.Checked)
            cmd.paremeters.addwithvalue("@DOB", dtpBirthDate.Value.Date)
            cmd.paremeters.addwithvalue("@Phone", mskphone.Text)
            cmd.paremeters.addwithvalue("@Email", txtemail.Text)
            cmd.paremeters.addwithvalue("@Location", txtlocation.Text)
            cmd.paremeters.addwithvalue("@UserShefit", cmbplan.SelectedItem.ToString())
            Dim salary As Decimal = 0
            Decimal.TryParse(txtsal.Text, salary)
            cmd.paremeters.addwithvalue("@Salary", salary)
            dimroweffected as integer = cmd.executeNonQuery()
                If roweffected > 0 Then
                MessageBox.Show("User added successfully.")
                btnreset.PerformClick()
            Else
                MessageBox.Show("Failed to add user.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            CloseConnection()
        End Try


    End Sub
End Class