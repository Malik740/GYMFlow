Imports System.Data.SqlClient

Public Class ViewMember
    Private Sub ViewMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Dim dgvType As Type = dgvMembers.[GetType]()
        Dim pi As System.Reflection.PropertyInfo = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
        pi.SetValue(dgvMembers, True, Nothing)

        Dim query As String = "SELECT M.MemberID, M.FullName, M.Phone, P.PlanName, M.ExpiryDate, M.SubscriptionStatus " &
                             "FROM Members M " &
                             "INNER JOIN MembershipPlans P ON M.PlanID = P.PlanID"
        Dim dt As New DataTable()

        Try
            OpenConnection()
            Dim cmd As New SqlCommand(query, conn)
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            dgvMembers.DataSource = dt
            dgvMembers.Columns("MemberID").HeaderText = "ID"
            dgvMembers.Columns("FullName").HeaderText = "Full Name"
            dgvMembers.Columns("Phone").HeaderText = "Phone"
            dgvMembers.Columns("PlanName").HeaderText = "Plan Name"
            dgvMembers.Columns("ExpiryDate").HeaderText = "EndDate"
            dgvMembers.Columns("SubscriptionStatus").HeaderText = "Status"

        Catch ex As Exception
            MsgBox("Error loading members: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text.Trim() = "" Then
            MsgBox("Please enter a name to search.", MsgBoxStyle.Exclamation, "Input Required")
            Return
        End If
        Dim query As String = "SELECT M.MemberID, M.FullName, M.Phone, P.PlanName, M.ExpiryDate, M.SubscriptionStatus " &
                             "FROM Members M " &
                             "INNER JOIN MembershipPlans P ON M.PlanID = P.PlanID " &
                             "WHERE M.FullName LIKE @Search OR M.Phone LIKE @Search"
        Dim dt As New DataTable()
        Try
            OpenConnection()
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Search", "%" & txtSearch.Text.Trim() & "%")

                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvMembers.DataSource = dt
        Catch ex As Exception
            MsgBox("Error searching members: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub
End Class