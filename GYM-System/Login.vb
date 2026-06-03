Imports System.Data.SqlClient

Public Class Login
    Dim loginAttempts As Integer = 0

    Private Sub btnforgetpass_Click(sender As Object, e As EventArgs) Handles btnforgetpass.Click
        ForgetPassword.Show()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim ds As New DataSet("sysUsers")
        Dim strconn As String
        Dim username, password As String

        If loginAttempts >= 3 Then
            MsgBox("Your account has been locked due to 3 failed login attempts!", MsgBoxStyle.Critical, "Security Lock")
            btnlogin.Enabled = False
            Exit Sub
        End If

        If String.IsNullOrEmpty(txtusername.Text) Then
            MsgBox("Please enter username", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        ElseIf String.IsNullOrEmpty(txtpassword.Text) Then
            MsgBox("Please enter password", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        Else
            username = txtusername.Text.Trim()
            password = txtpassword.Text.Trim()
        End If

        Try
            strconn = "SELECT * FROM Users WHERE Username = '" & username & "' AND UserPassword = '" & password & "'"
            Dim dataadapter As New Data.SqlClient.SqlDataAdapter(strconn, conn)

            OpenConnection()
            dataadapter.Fill(ds, "sysUsers")
            CloseConnection()

            If ds.Tables("sysUsers").Rows.Count > 0 Then


                loginAttempts = 0

                Me.Hide()
                DashBoard.Show()
            Else
                loginAttempts += 1

                Dim remainingAttempts As Integer = 3 - loginAttempts

                If remainingAttempts > 0 Then
                    MsgBox("Invalid username or password. You have " & remainingAttempts & " attempts left.", MsgBoxStyle.Critical, "Login Failed")
                Else
                    MsgBox("Invalid username or password. This was your last attempt! Access Blocked.", MsgBoxStyle.Critical, "Security Lock")
                    btnlogin.Enabled = False
                End If
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "System Error")
        Finally
            CloseConnection()
        End Try

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class