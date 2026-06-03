Public Class DeleteUser
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim input As String = txtusername.Text
        If String.IsNullOrEmpty(input) Then
            MessageBox.Show("Please enter a username to delete.")
            Return
        End If
        Dim confermation As DialogResult = MessageBox.Show("Are you sure you want to delete the user '" & input & "'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If confermation = DialogResult.Yes Then
            ' Add code to delete the user from the database here
            MessageBox.Show("User deleted successfully.")
        End If
        Dim deleteQuery As String = "DELETE FROM users WHERE Fullname = @Fullname"
        Try
            OpenConnection()
            Dim cmd As New SqlCommand(deleteQuery, conn)
            cmd.Parameters.AddWithValue("@Fullname", input)
            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            If rowsAffected > 0 Then
                MessageBox.Show("User deleted successfully.")
                txtusername.Clear()
            Else
                MessageBox.Show("No user found with the specified username.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the user: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtusername.Clear()
        Me.Close()
    End Sub
End Class