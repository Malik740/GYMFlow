Imports System.Data.SqlClient

Public Class Attendance

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        If String.IsNullOrEmpty(txtPhone.Text.Trim()) Then
            MsgBox("Please enter the member's phone number.", MsgBoxStyle.Exclamation, "Validation Error")
            Exit Sub
        End If

        Dim memberQuery As String = "SELECT MemberID, FullName, SubscriptionStatus, ExpiryDate FROM Members WHERE Phone = @Phone"

        Dim memberID As Integer = 0
        Dim memberName As String = ""
        Dim status As String = ""
        Dim expiryDate As Date

        Try
            OpenConnection()

            Using cmdCheck As New SqlCommand(memberQuery, conn)
                cmdCheck.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim())

                Using reader As SqlDataReader = cmdCheck.ExecuteReader()
                    If reader.Read() Then
                        memberID = Convert.ToInt32(reader("MemberID"))
                        memberName = reader("FullName").ToString()
                        status = reader("SubscriptionStatus").ToString()
                        expiryDate = Convert.ToDateTime(reader("ExpiryDate"))

                        txtMemberName.Text = memberName
                        txtStatus.Text = status
                        txtExpiryDate.Text = expiryDate.ToString("yyyy-MM-dd")
                    Else
                        MsgBox("No member found with this phone number.", MsgBoxStyle.Critical, "Not Found")
                        ClearFields()
                        Exit Sub
                    End If
                End Using
            End Using

            If status.ToLower() = "frozen" Then
                MsgBox("This subscription is currently Frozen. Cannot record attendance.", MsgBoxStyle.Exclamation, "Access Denied")
                Exit Sub
            End If

            If expiryDate < DateTime.Now.Date OrElse status.ToLower() = "expired" Then
                MsgBox("This subscription has Expired! Please renew first.", MsgBoxStyle.Critical, "Access Denied")
                Dim updateStatusQuery As String = "UPDATE Members SET SubscriptionStatus = 'Expired' WHERE MemberID = @ID"
                Using cmdUpdate As New SqlCommand(updateStatusQuery, conn)
                    cmdUpdate.Parameters.AddWithValue("@ID", memberID)
                    cmdUpdate.ExecuteNonQuery()
                End Using
                txtStatus.Text = "Expired"
                Exit Sub
            End If


            Dim insertAttendanceQuery As String = "INSERT INTO Attendance (LogDateTime, MemberID) VALUES (@LogTime, @MemberID)"

            Using cmdInsert As New SqlCommand(insertAttendanceQuery, conn)
                cmdInsert.Parameters.AddWithValue("@LogTime", DateTime.Now)
                cmdInsert.Parameters.AddWithValue("@MemberID", memberID)

                Dim rows As Integer = cmdInsert.ExecuteNonQuery()
                If rows > 0 Then
                    MsgBox("Attendance recorded successfully for " & memberName & "!", MsgBoxStyle.Information, "Success")
                Else
                    MsgBox("Failed to record attendance.", MsgBoxStyle.Exclamation, "Error")
                End If
            End Using

        Catch ex As Exception
            MsgBox("Error recording attendance: " & ex.Message, MsgBoxStyle.Critical, "Database Error")
        Finally
            CloseConnection()
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearFields()
        txtPhone.Clear()
    End Sub

    Private Sub ClearFields()
        txtMemberName.Clear()
        txtStatus.Clear()
        txtExpiryDate.Clear()
    End Sub
End Class