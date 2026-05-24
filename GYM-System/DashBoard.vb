Imports System.Data.SqlClient

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

    Private Sub ViewProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductsToolStripMenuItem.Click
        Product.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub TakeAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TakeAttendanceToolStripMenuItem.Click
        Attendance.Show()
    End Sub

    Private Sub PlansToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlansToolStripMenuItem1.Click
        MembershipPlans.Show()
    End Sub

    Private Sub ViewTrainersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTrainersToolStripMenuItem.Click
        Trainers.Show()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Try
            Dim result As DialogResult = MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Logout Confirmation")
            If result = DialogResult.Yes Then
                Login.Show()
                Me.Close()

            End If
        Catch ex As Exception
            MsgBox("Error during logout: " & ex.Message, MsgBoxStyle.Critical, "System Error")
        End Try
    End Sub

    Private Sub DashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim dsActive As New DataSet()
            Dim strActive As String = "SELECT COUNT(*) FROM Members"
            Dim daActive As New SqlDataAdapter(strActive, conn)

            OpenConnection()
            daActive.Fill(dsActive, "ActiveCount")
            CloseConnection()

            lblActiveCount.Text = dsActive.Tables("ActiveCount").Rows(0).Item(0).ToString()


            Dim dsTrainers As New DataSet()
            Dim strTrainers As String = "SELECT COUNT(*) FROM Trainers"
            Dim daTrainers As New SqlDataAdapter(strTrainers, conn)

            OpenConnection()
            daTrainers.Fill(dsTrainers, "TrainersCount")
            CloseConnection()

            lblTrainersCount.Text = dsTrainers.Tables("TrainersCount").Rows(0).Item(0).ToString()


            Dim dsExpired As New DataSet()
            Dim strExpired As String = "SELECT COUNT(*) FROM MembershipPlans"
            Dim daExpired As New SqlDataAdapter(strExpired, conn)

            OpenConnection()
            daExpired.Fill(dsExpired, "ExpiredCount")
            CloseConnection()

            lblExpiredCount.Text = dsExpired.Tables("ExpiredCount").Rows(0).Item(0).ToString()

        Catch ex As Exception
            MsgBox("Error loading dashboard statistics: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub

End Class