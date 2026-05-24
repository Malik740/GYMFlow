Imports System.Data

Module DatabaseModule
    Public connString As String = "Data Source=.;Initial Catalog=GYMFLOW_DB;Integrated Security=SSPI;"
    Public conn As New SqlClient.SqlConnection(connString)

    Public Sub OpenConnection()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("خطأ في الاتصال بقاعدة البيانات: " & ex.Message, MsgBoxStyle.Critical, "GymFlow Error")
        End Try
    End Sub

    Public Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Module