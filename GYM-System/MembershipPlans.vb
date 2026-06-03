Imports System.Data.SqlClient

Public Class MembershipPlans

    Private Sub MembershipPlans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Dim dgvType As Type = dgvPlans.[GetType]()
        Dim pi As System.Reflection.PropertyInfo = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
        pi.SetValue(dgvPlans, True, Nothing)

        dgvPlans.Columns.Clear()

        Dim query As String = "SELECT PlanID, PlanName, Price FROM MembershipPlans"
        Dim dt As New DataTable()

        Try
            OpenConnection()
            Using cmd As New SqlCommand(query, conn)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvPlans.DataSource = dt

            dgvPlans.Columns("PlanID").HeaderText = "Plan ID"
            dgvPlans.Columns("PlanName").HeaderText = "Plan Name"
            dgvPlans.Columns("Price").HeaderText = "Price (JD)"

            Dim durationColumn As New DataGridViewTextBoxColumn()
            durationColumn.Name = "Duration"
            durationColumn.HeaderText = "Duration"
            dgvPlans.Columns.Insert(2, durationColumn)

            Dim actionColumn As New DataGridViewTextBoxColumn()
            actionColumn.Name = "Action"
            actionColumn.HeaderText = "Action"
            dgvPlans.Columns.Add(actionColumn)

            For Each row As DataGridViewRow In dgvPlans.Rows
                If Not row.IsNewRow Then
                    Dim planName As String = row.Cells("PlanName").Value.ToString()


                    If planName.Contains("3-Month") Then
                        row.Cells("Duration").Value = "3 Months"
                    ElseIf planName.Contains("6-Month") Then
                        row.Cells("Duration").Value = "6 Months"
                    ElseIf planName.Contains("1-Year") OrElse planName.Contains("Platinum") Then
                        row.Cells("Duration").Value = "1 Year"
                    Else
                        row.Cells("Duration").Value = "1 Month"
                    End If

                    row.Cells("Action").Value = "Manage"
                End If
            Next

        Catch ex As Exception
            MsgBox("Error loading membership plans: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class