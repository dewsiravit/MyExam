Imports MySql.Data.MySqlClient
Imports MyExam.ConnectDatabase
Public Class Login
    Inherits Member
    Private conn As New MySqlConnection(CONNECTSTRING)
    Public Function CheckLogin()
        Dim stm = "SELECT * FROM myexam_member WHERE username_member = @username AND password_member = @password"
        Dim cmd As New MySqlCommand(stm, conn)
        cmd.Parameters.AddWithValue("@username", Username)
        cmd.Parameters.AddWithValue("@password", SHA256(Password))
        Try
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
            cmd.Connection.Open()
            Dim result As MySqlDataReader = cmd.ExecuteReader()
            If result.HasRows Then
                result.Read()
                ID = result.Item("id_member")
                Username = result("username_member")
                Email = result.Item("email_member")
                Password = result.Item("password_member")
                Question = result.Item("question_member")
                Answer = result.Item("answer_member")
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error " & ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function CheckUsername() As Boolean
        Dim stm As String = "SELECT username_member FROM myexam_member WHERE username_member = @username"
        Dim cmd As New MySqlCommand(stm, conn)
        cmd.Parameters.AddWithValue("@username", Username)
        Try
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
            cmd.Connection.Open()
            If cmd.ExecuteReader.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error " & ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
