Public Class Product


    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashbord.Click
        DashBoard.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class