Imports System.Data.SqlClient

Public Class Trainers
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Trainers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DoubleBuffered = True
        Dim dgvType As Type = dgvTrainers.[GetType]()
        Dim pi As System.Reflection.PropertyInfo = dgvType.GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.NonPublic)
        pi.SetValue(dgvTrainers, True, Nothing)
        dgvTrainers.Columns.Clear()

        Dim query As String = "SELECT TrainerID, TrainerName, Specialty, Salary FROM Trainers"
        Dim dt As New DataTable()
        Try
            OpenConnection()
            Using cmd As New SqlCommand(query, conn)
                Using da As New SqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using

            dgvTrainers.DataSource = dt

            dgvTrainers.Columns("TrainerID").HeaderText = "Trainer ID"
            dgvTrainers.Columns("TrainerName").HeaderText = "Trainer Name"
            dgvTrainers.Columns("Specialty").HeaderText = "Specialty"
            dgvTrainers.Columns("Salary").HeaderText = "Salary"

        Catch ex As Exception
            MsgBox("Error loading trainers data: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub
End Class