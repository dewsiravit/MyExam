Imports MySql.Data.MySqlClient
Imports MyExam.ConnectDatabase
Public Class ForgotPasswordForm
    Private member As New Member
    Private conn As New MySqlConnection(CONNECTSTRING)
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        LoginForm.Show()
        Close()
    End Sub

    Private Sub NameLabel_Click(sender As Object, e As EventArgs) Handles NameLabel.Click
        NameTextBox.Focus()
    End Sub

    Private Sub NewPasswordComfirmLabel_Click(sender As Object, e As EventArgs) Handles NewPasswordComfirmLabel.Click
        NewPasswordConfirmTextBox.Focus()
    End Sub

    Private Sub NewPasswordLabel_Click(sender As Object, e As EventArgs) Handles NewPasswordLabel.Click
        NewPasswordTextBox.Focus()
    End Sub

    Private Sub ForgotPasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorNameLabel.ResetText()
        ErrorAnswerLabel.ResetText()
        ErrorNewPasswordLabel.ResetText()
        ErrorNewPasswordConfirmLabel.ResetText()
        ChangePasswordGroupBox.Visible = False
    End Sub

    Private Sub QuestionLabel_Click(sender As Object, e As EventArgs) Handles QuestionLabel.Click
        AnswerTextBox.Focus()
    End Sub

    Private Sub CheckNameLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CheckNameLinkLabel.LinkClicked
        If CheckUser(NameTextBox.Text) Then
            QuestionLabel.Text = member.Question
            ErrorNameLabel.ResetText()
            NameTextBox.Enabled = False
            CheckNameLinkLabel.Enabled = False
            QuestionLabel.Enabled = True
            AnswerTextBox.Enabled = True
            SendAnswerButton.Enabled = True
        Else
            NameTextBox.Clear()
            NameTextBox.Focus()
            ErrorNameLabel.Text = "*ไม่พบชื่อผู้ใช้ หรืออีเมลนี้ในระบบ"
        End If
    End Sub

    Private Sub SendAnswerButton_Click(sender As Object, e As EventArgs) Handles SendAnswerButton.Click
        If CheckAnsewr(AnswerTextBox.Text) Then
            ErrorAnswerLabel.ResetText()
            VerifyGroupBox.Enabled = False
            ChangePasswordGroupBox.Visible = True
        Else
            ErrorAnswerLabel.Text = "*คำตอบไม่ถูกต้อง"
            AnswerTextBox.Clear()
            AnswerTextBox.Focus()
        End If
    End Sub

    Private Sub ChangePasswordButton_Click(sender As Object, e As EventArgs) Handles ChangePasswordButton.Click
        If ChangePassword(NewPasswordConfirmTextBox.Text) Then
            MessageBox.Show("เปลี่ยนรหัสผ่านเรียบร้อยแล้ว", "MyExam", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Function CheckUser(name As String) As Boolean
        Dim stm As String = "Select * From myexam_member Where username_member = @name OR email_member = @name"
        Dim cmd As New MySqlCommand(stm, conn)
        cmd.Parameters.AddWithValue("@name", name)
        Try
            cmd.Connection.Open()
            Dim result As MySqlDataReader
            result = cmd.ExecuteReader()
            If result.HasRows Then
                While result.Read
                    member.ID = result.Item("id_member")
                    member.Username = result.Item("username_member")
                    member.Password = result.Item("password_member")
                    member.Email = result.Item("email_member")
                    member.Question = result.Item("question_member")
                    member.Answer = result.Item("answer_member")
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

    Private Function CheckAnsewr(answer As String) As Boolean
        If member.Answer.Equals(member.SHA256(answer)) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function ChangePassword(password As String) As Boolean
        Dim stm As String = "UPDATE myexam_member SET password_member = @password WHERE id_member = @id"
        Dim cmd As New MySqlCommand(stm, conn)
        cmd.Parameters.AddWithValue("@password", member.SHA256(password))
        cmd.Parameters.AddWithValue("@id", member.ID)
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
