Imports MySql.Data.MySqlClient
Imports MyExam.ConnectDatabase
Public Class RegisterForm
    Private member As New Member()
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        LoginForm.Show()
        Close()
    End Sub

    Private Sub UsernameLabel_Click(sender As Object, e As EventArgs) Handles UsernameLabel.Click
        UsernameTextBox.Focus()
    End Sub

    Private Sub PasswordLabel_Click(sender As Object, e As EventArgs) Handles PasswordLabel.Click
        PasswordTextBox.Focus()
    End Sub

    Private Sub PasswordComfirmLabel_Click(sender As Object, e As EventArgs) Handles PasswordComfirmLabel.Click
        PasswordComfirmTextBox.Focus()
    End Sub

    Private Sub EmailLabel_Click(sender As Object, e As EventArgs) Handles EmailLabel.Click
        EmailTextBox.Focus()
    End Sub

    Private Sub QuestionLabel_Click(sender As Object, e As EventArgs) Handles QuestionLabel.Click
        QuestionTextBox.Focus()
    End Sub

    Private Sub AnswerLabel_Click(sender As Object, e As EventArgs) Handles AnswerLabel.Click
        AnswerTextBox.Focus()
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Member.Username = UsernameTextBox.Text
        Member.Password = PasswordComfirmTextBox.Text
        Member.Email = EmailTextBox.Text
        Member.Question = QuestionTextBox.Text
        member.Answer = AnswerTextBox.Text

        For Each i As Char In member.Username.ToUpper
            If Not (i >= "A"c And i <= "Z"c) And Not (i >= "0"c And i <= "9"c) And Not (i = "_"c Or i = "-"c Or i = "."c) Then
                MsgBox("ชื่อผู้ใช้ต้องเป็นภาษาอังกฤษ a-z, A-Z, ตัวเลข 0-9, และเครื่องหมาย (_), (-) ,(.) เท่านั้น")
                Exit Sub
            End If
        Next


        If AddMember() Then
            MessageBox.Show("สมัครสมาชิกเรียบร้อยแล้ว", "MyExam", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function AddMember() As Boolean
        Dim stm = "INSERT INTO myexam_member(username_member, email_member, password_member, question_member, answer_member) VALUE(@username, @email, @password, @question, @answer)"
        Dim cmd As New MySqlCommand(stm, New MySqlConnection(CONNECTSTRING))
        cmd.Parameters.AddWithValue("@username", member.Username)
        cmd.Parameters.AddWithValue("@email", member.Email)
        cmd.Parameters.AddWithValue("@password", member.SHA256(member.Password))
        cmd.Parameters.AddWithValue("@question", member.Question)
        cmd.Parameters.AddWithValue("@answer", member.SHA256(member.Answer))
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
