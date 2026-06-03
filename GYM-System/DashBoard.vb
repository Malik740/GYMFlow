Imports System.Data.SqlClient

Public Class DashBoard
    Private Sub addnewusertool_Click(sender As Object, e As EventArgs) Handles addnewusertool.Click
        Dim frm As New AddUser()
        frm.ShowDialog()
    End Sub

    Private Sub changeuserinfotool_Click(sender As Object, e As EventArgs) Handles changeuserinfotool.Click
        Dim frm As New ChangeUser()
        frm.ShowDialog()
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteUserToolStripMenuItem.Click
        Dim frm As New DeleteUser()
        frm.ShowDialog()
    End Sub

    Private Sub ViewMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewMemberToolStripMenuItem.Click
        Dim frm As New ViewMember()
        frm.ShowDialog()
    End Sub

    Private Sub AddMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMemberToolStripMenuItem.Click
        Dim frm As New AddMember()
        frm.ShowDialog()
    End Sub

    Private Sub EditMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditMemberToolStripMenuItem.Click
        Dim frm As New EditMember()
        frm.ShowDialog()
    End Sub

    Private Sub FreezSubscriptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FreezSubscriptionToolStripMenuItem.Click
        Dim frm As New FreezSub()
        frm.ShowDialog()
    End Sub

    Private Sub ViewProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProductsToolStripMenuItem.Click
        Dim frm As New Product()
        frm.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frm As New About()
        frm.ShowDialog()
    End Sub

    Private Sub TakeAttendanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TakeAttendanceToolStripMenuItem.Click
        Dim frm As New Attendance()
        frm.ShowDialog()
    End Sub

    Private Sub PlansToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlansToolStripMenuItem1.Click
        Dim frm As New MembershipPlans()
        frm.ShowDialog()
    End Sub

    Private Sub ViewTrainersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTrainersToolStripMenuItem.Click
        Dim frm As New Trainers()
        frm.ShowDialog()
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
            Me.DoubleBuffered = True
            Dim dgvType As Type = dgvLatestMembers.[GetType]()
            Dim pi As System.Reflection.PropertyInfo = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
            pi.SetValue(dgvLatestMembers, True, Nothing)

            Dim dsActive As New DataSet()
            Dim daActive As New SqlDataAdapter("SELECT COUNT(*) FROM Members", conn)
            OpenConnection()
            daActive.Fill(dsActive, "ActiveCount")
            CloseConnection()
            lblActiveCount.Text = dsActive.Tables("ActiveCount").Rows(0).Item(0).ToString()

            Dim dsTrainers As New DataSet()
            Dim daTrainers As New SqlDataAdapter("SELECT COUNT(*) FROM Trainers", conn)
            OpenConnection()
            daTrainers.Fill(dsTrainers, "TrainersCount")
            CloseConnection()
            lblTrainersCount.Text = dsTrainers.Tables("TrainersCount").Rows(0).Item(0).ToString()

            Dim dsExpired As New DataSet()
            Dim daExpired As New SqlDataAdapter("SELECT COUNT(*) FROM MembershipPlans", conn)
            OpenConnection()
            daExpired.Fill(dsExpired, "ExpiredCount")
            CloseConnection()
            lblExpiredCount.Text = dsExpired.Tables("ExpiredCount").Rows(0).Item(0).ToString()

            Dim dsGrid As New DataSet()
            Dim strGrid As String = "SELECT MemberID, FullName, Phone, Weight, Height, JoinDate, ExpiryDate, SubscriptionStatus FROM Members"
            Dim daGrid As New SqlDataAdapter(strGrid, conn)
            OpenConnection()
            daGrid.Fill(dsGrid, "GridData")
            CloseConnection()
            dgvLatestMembers.DataSource = dsGrid.Tables("GridData")

        Catch ex As Exception
            MsgBox("Error loading dashboard data: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub
End Class