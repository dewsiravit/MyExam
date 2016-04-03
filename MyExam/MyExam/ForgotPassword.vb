Imports MySql.Data.MySqlClient
Imports MyExam.ConnectDatabase
Public Class ForgotPassword
    Inherits Member
    Private cmd As MySqlCommand
    Public Function CheckUser(name As String) As Boolean
        Dim stm As String = "Select * From myexam_member Where username_member = @name OR email_member = @name"
        cmd = New MySqlCommand(stm, New MySqlConnection(CONNECTSTRING))
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
End Class
