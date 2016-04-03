Imports MySql.Data.MySqlClient
Imports MyExam.ConnectDatabase
Public Class ForgotPassword
    Inherits Member
    Private conn As New MySqlConnection(CONNECTSTRING)
    Public Function CheckUser(name As String) As Boolean
        Dim stm As String = "Select * From myexam_member Where username_member = @name OR email_member = @name"
        Dim cmd As New MySqlCommand(stm, conn)
        cmd.Parameters.AddWithValue("@name", name)
        Try
            cmd.Connection.Open()
            Dim result As MySqlDataReader
            result = cmd.ExecuteReader()
            If result.HasRows Then
                While result.Read
                    ID = result.Item("id_member")
                    Username = result.Item("username_member")
                    Password = result.Item("password_member")
                    Email = result.Item("email_member")
                    Question = result.Item("question_member")
                    Answer = result.Item("answer_member")
                End While
                cmd.Connection.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error " & ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function CheckAnsewr(answer As String) As Boolean
        If Me.Answer.Equals(SHA256(answer)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function ChangePassword(password As String) As Boolean
        Dim stm As String = "UPDATE myexam_member SET password_member = @password WHERE id_member = @id"
        Dim cmd As New MySqlCommand(stm, conn)
        cmd.Parameters.AddWithValue("@password", SHA256(password))
        cmd.Parameters.AddWithValue("@id", ID)
        Try
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            Return True
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error " & ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
