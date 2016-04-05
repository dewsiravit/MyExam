Imports MySql.Data.MySqlClient
Imports MyExam.ConnectDatabase
Public Class LoginForm
    Private member As New Member
    Private conn As New MySqlConnection(CONNECTSTRING)
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        member.Username = UsernameTextBox.Text
        member.Password = PasswordTextBox.Text
        If CheckUsername() Then
            ErrorUsernameLabel.ResetText()
        Else
            ErrorUsernameLabel.Text = "*ไม่พบชื่อผู้ใช้นี้ในระบบ"
            ErrorPasswordLabel.ResetText()
            PasswordTextBox.Clear()
            Exit Sub
        End If
        If CheckLogin() Then
            Dim main As New MainForm(member)
            main.Show()
            Close()
        Else
            ErrorPasswordLabel.Text = "*รหัสผ่านไม่ถูกต้อง"
            PasswordTextBox.Clear()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Close()
    End Sub

    Private Sub ErrorUsernameLabel_Click(sender As Object, e As EventArgs) Handles ErrorUsernameLabel.Click

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorUsernameLabel.ResetText()
        ErrorPasswordLabel.ResetText()
    End Sub

    Private Sub RegisterLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegisterLinkLabel.LinkClicked
        RegisterForm.Show()
        Close()
    End Sub

    Private Sub ForgotPasswordLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPasswordLinkLabel.LinkClicked
        ForgotPasswordForm.Show()
        Close()
    End Sub

    Private Function CheckLogin()
        Dim stm = "SELECT * FROM myexam_member WHERE username_member = @username AND password_member = @password"
        Dim cmd As New MySqlCommand(stm, conn)
        cmd.Parameters.AddWithValue("@username", member.Username)
        cmd.Parameters.AddWithValue("@password", member.SHA256(member.Password))
        Try
            If cmd.Connection.State = ConnectionState.Open Then
                cmd.Connection.Close()
            End If
            cmd.Connection.Open()
            Dim result As MySqlDataReader = cmd.ExecuteReader()
            If result.HasRows Then
                result.Read()
                member.ID = result.Item("id_member")
                member.Username = result("username_member")
                member.Email = result.Item("email_member")
                member.Password = result.Item("password_member")
                member.Question = result.Item("question_member")
                member.Answer = result.Item("answer_member")
                Return True
            Else
                Return False
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Error " & ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Function CheckUsername() As Boolean
        Dim stm As String = "SELECT username_member FROM myexam_member WHERE username_member = @username"
        Dim cmd As New MySqlCommand(stm, conn)
        cmd.Parameters.AddWithValue("@username", member.Username)
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
