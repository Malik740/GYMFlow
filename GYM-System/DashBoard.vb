Public Class DashBoard
    Private Sub addnewusertool_Click(sender As Object, e As EventArgs) Handles addnewusertool.Click
        AddUser.Show()

    End Sub

    Private Sub changeuserinfotool_Click(sender As Object, e As EventArgs) Handles changeuserinfotool.Click
        ChangeUser.Show()

    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click
        DeleteUser.Show()

    End Sub

    Private Sub ViewMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMemberToolStripMenuItem.Click
        ViewMember.Show()

    End Sub

    Private Sub AddMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMemberToolStripMenuItem.Click
        AddMember.Show()

    End Sub

    Private Sub EditMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditMemberToolStripMenuItem.Click
        EditMember.Show()

    End Sub

    Private Sub FreezSubscriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FreezSubscriptionToolStripMenuItem.Click
        FreezSub.Show()

    End Sub
End Class