Public Class ForgetPassword
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Dim ds As New DataSet("sysUsers")
        Dim strconn As String
        Dim username, newPassword, confirmPassword As String


        If String.IsNullOrEmpty(txtusername.Text) Or String.IsNullOrEmpty(txtnewpass.Text) Or String.IsNullOrEmpty(txtconfnew.Text) Then
            MsgBox("Please fill in all fields!", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If


        username = txtusername.Text.Trim()
        newPassword = txtnewpass.Text.Trim()
        confirmPassword = txtconfnew.Text.Trim()


        If newPassword <> confirmPassword Then
            MsgBox("New Password and Confirm New Password do not match!", MsgBoxStyle.Critical, "Password Mismatch")
            Exit Sub
        End If


        Try

            strconn = "SELECT * FROM Users WHERE Username = '" & username & "'"
            Dim dataadapter As New Data.SqlClient.SqlDataAdapter(strconn, conn)


            Dim cmdBuilder As New Data.SqlClient.SqlCommandBuilder(dataadapter)


            OpenConnection()
            dataadapter.Fill(ds, "sysUsers")

            '
            If ds.Tables("sysUsers").Rows.Count > 0 Then


                ds.Tables("sysUsers").Rows(0).Item("UserPassword") = newPassword

                dataadapter.Update(ds, "sysUsers")

                CloseConnection()

                MsgBox("Password updated successfully! You can now login with your new password.", MsgBoxStyle.Information, "Success")

                Me.Close()
            Else
                CloseConnection()
                MsgBox("Username not found in the system! Cannot change password.", MsgBoxStyle.Critical, "Error")
            End If

        Catch ex As Exception
            MsgBox("Error while updating password: " & ex.Message, MsgBoxStyle.Critical, "System Error")
        Finally
            CloseConnection()
        End Try
    End Sub
End Class