Imports MySql.Data.MySqlClient
Imports MyExam.ConnectDatabase
Public Class Register
    Inherits Member

    Public Function AddMember(member As Member) As Boolean
        Dim stm = "INSERT INTO myexam_member (username_member, email_member, password_member, question_member, answer_member) VALUE(@username, @email, @password, @question, @answer)"
        Dim cmd As New MySqlCommand(stm, New MySqlConnection(CONNECTSTRING))
        cmd.Parameters.AddWithValue("@username", member.Username)
        cmd.Parameters.AddWithValue("@email", member.Email)
        cmd.Parameters.AddWithValue("@password", SHA256(member.Password))
        cmd.Parameters.AddWithValue("@question", member.Question)
        cmd.Parameters.AddWithValue("@answer", SHA256(member.Answer))
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
