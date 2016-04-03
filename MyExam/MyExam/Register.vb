Imports MySql.Data.MySqlClient
Imports MyExam.ConnectDatabase
Public Class Register
    Inherits Member
    Public Function AddtoDatabase(member As Member) As Boolean
        Dim str = "INSERT INTO myexam_member (username_member, email_member, password_member, question_member, answer_member) VALUE(@username, @email, @password, @question, @answer)"
        Dim cmd As New MySqlCommand(str, New MySqlConnection(CONNECTSTRING))
        cmd.Parameters.AddWithValue("@username", member.Username)
        cmd.Parameters.AddWithValue("@email", member.Email)
        cmd.Parameters.AddWithValue("@password", member.Password)
        cmd.Parameters.AddWithValue("@question", member.Question)
        cmd.Parameters.AddWithValue("@answer", member.Answer)
        Try
            cmd.Connection.Open()
            cmd.ExecuteNonQuery()
            cmd.Connection.Close()
            Return True
        Catch ex As MySqlException
            MessageBox.Show("ไม่สารถสมัครสมาชิกได้ โปรตรวจสอบการเชื่อมต่อ Database" & vbNewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Class
