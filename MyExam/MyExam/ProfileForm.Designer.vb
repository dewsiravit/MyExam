<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileForm
    Inherits MyExam.BaseMainForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.ProfileTabPage = New System.Windows.Forms.TabPage()
        Me.TestListTabPage = New System.Windows.Forms.TabPage()
        Me.TestListTreeView = New System.Windows.Forms.TreeView()
        Me.TestScoreTabPage = New System.Windows.Forms.TabPage()
        Me.TestScoreTreeView = New System.Windows.Forms.TreeView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AnswerTextBox = New System.Windows.Forms.TextBox()
        Me.QuestionTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.QuestionLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.ProfileTabPage.SuspendLayout()
        Me.TestListTabPage.SuspendLayout()
        Me.TestScoreTabPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.ProfileTabPage)
        Me.TabControl.Controls.Add(Me.TestListTabPage)
        Me.TabControl.Controls.Add(Me.TestScoreTabPage)
        Me.TabControl.Location = New System.Drawing.Point(12, 49)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(660, 400)
        Me.TabControl.TabIndex = 7
        '
        'ProfileTabPage
        '
        Me.ProfileTabPage.Controls.Add(Me.Label12)
        Me.ProfileTabPage.Controls.Add(Me.Label11)
        Me.ProfileTabPage.Controls.Add(Me.Label10)
        Me.ProfileTabPage.Controls.Add(Me.Label8)
        Me.ProfileTabPage.Controls.Add(Me.Label7)
        Me.ProfileTabPage.Controls.Add(Me.AnswerTextBox)
        Me.ProfileTabPage.Controls.Add(Me.QuestionTextBox)
        Me.ProfileTabPage.Controls.Add(Me.EmailTextBox)
        Me.ProfileTabPage.Controls.Add(Me.PasswordTextBox)
        Me.ProfileTabPage.Controls.Add(Me.UsernameTextBox)
        Me.ProfileTabPage.Controls.Add(Me.AnswerLabel)
        Me.ProfileTabPage.Controls.Add(Me.QuestionLabel)
        Me.ProfileTabPage.Controls.Add(Me.EmailLabel)
        Me.ProfileTabPage.Controls.Add(Me.PasswordLabel)
        Me.ProfileTabPage.Controls.Add(Me.UsernameLabel)
        Me.ProfileTabPage.Location = New System.Drawing.Point(4, 29)
        Me.ProfileTabPage.Name = "ProfileTabPage"
        Me.ProfileTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.ProfileTabPage.Size = New System.Drawing.Size(652, 367)
        Me.ProfileTabPage.TabIndex = 0
        Me.ProfileTabPage.Text = "ข้อมูลส่วนตัว"
        Me.ProfileTabPage.UseVisualStyleBackColor = True
        '
        'TestListTabPage
        '
        Me.TestListTabPage.Controls.Add(Me.TestListTreeView)
        Me.TestListTabPage.Location = New System.Drawing.Point(4, 29)
        Me.TestListTabPage.Name = "TestListTabPage"
        Me.TestListTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TestListTabPage.Size = New System.Drawing.Size(652, 367)
        Me.TestListTabPage.TabIndex = 1
        Me.TestListTabPage.Text = "ข้อสอบที่สร้าง"
        Me.TestListTabPage.UseVisualStyleBackColor = True
        '
        'TestListTreeView
        '
        Me.TestListTreeView.Location = New System.Drawing.Point(6, 6)
        Me.TestListTreeView.Name = "TestListTreeView"
        Me.TestListTreeView.Size = New System.Drawing.Size(640, 355)
        Me.TestListTreeView.TabIndex = 0
        '
        'TestScoreTabPage
        '
        Me.TestScoreTabPage.Controls.Add(Me.TestScoreTreeView)
        Me.TestScoreTabPage.Location = New System.Drawing.Point(4, 29)
        Me.TestScoreTabPage.Name = "TestScoreTabPage"
        Me.TestScoreTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.TestScoreTabPage.Size = New System.Drawing.Size(652, 367)
        Me.TestScoreTabPage.TabIndex = 2
        Me.TestScoreTabPage.Text = "ข้อสอบที่เคยทำ"
        Me.TestScoreTabPage.UseVisualStyleBackColor = True
        '
        'TestScoreTreeView
        '
        Me.TestScoreTreeView.Location = New System.Drawing.Point(6, 6)
        Me.TestScoreTreeView.Name = "TestScoreTreeView"
        Me.TestScoreTreeView.Size = New System.Drawing.Size(640, 355)
        Me.TestScoreTreeView.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(480, 169)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 20)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(480, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(435, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(435, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(435, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "*"
        '
        'AnswerTextBox
        '
        Me.AnswerTextBox.Location = New System.Drawing.Point(287, 166)
        Me.AnswerTextBox.Name = "AnswerTextBox"
        Me.AnswerTextBox.Size = New System.Drawing.Size(187, 26)
        Me.AnswerTextBox.TabIndex = 31
        '
        'QuestionTextBox
        '
        Me.QuestionTextBox.Location = New System.Drawing.Point(287, 134)
        Me.QuestionTextBox.Name = "QuestionTextBox"
        Me.QuestionTextBox.Size = New System.Drawing.Size(187, 26)
        Me.QuestionTextBox.TabIndex = 30
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(287, 102)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(142, 26)
        Me.EmailTextBox.TabIndex = 29
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(287, 70)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(142, 26)
        Me.PasswordTextBox.TabIndex = 27
        Me.PasswordTextBox.UseSystemPasswordChar = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(287, 38)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(142, 26)
        Me.UsernameTextBox.TabIndex = 26
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Location = New System.Drawing.Point(85, 169)
        Me.AnswerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(150, 20)
        Me.AnswerLabel.TabIndex = 25
        Me.AnswerLabel.Text = "คำตอบ เมื่อลืมรหัสผ่าน:"
        '
        'QuestionLabel
        '
        Me.QuestionLabel.AutoSize = True
        Me.QuestionLabel.Location = New System.Drawing.Point(85, 137)
        Me.QuestionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.QuestionLabel.Name = "QuestionLabel"
        Me.QuestionLabel.Size = New System.Drawing.Size(150, 20)
        Me.QuestionLabel.TabIndex = 24
        Me.QuestionLabel.Text = "คำถาม เมื่อลืมรหัสผ่าน:"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(190, 105)
        Me.EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(45, 20)
        Me.EmailLabel.TabIndex = 23
        Me.EmailLabel.Text = "อีเมล์:"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(173, 73)
        Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(62, 20)
        Me.PasswordLabel.TabIndex = 21
        Me.PasswordLabel.Text = "รหัสผ่าน:"
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(180, 41)
        Me.UsernameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(55, 20)
        Me.UsernameLabel.TabIndex = 20
        Me.UsernameLabel.Text = "ชื่อผู้ใช้:"
        '
        'ProfileForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "ProfileForm"
        Me.Text = "ข้อมูลส่วนตัว - MyExam"
        Me.Controls.SetChildIndex(Me.TabControl, 0)
        Me.TabControl.ResumeLayout(False)
        Me.ProfileTabPage.ResumeLayout(False)
        Me.ProfileTabPage.PerformLayout()
        Me.TestListTabPage.ResumeLayout(False)
        Me.TestScoreTabPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents ProfileTabPage As TabPage
    Friend WithEvents TestListTabPage As TabPage
    Friend WithEvents TestScoreTabPage As TabPage
    Friend WithEvents TestListTreeView As TreeView
    Friend WithEvents TestScoreTreeView As TreeView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AnswerTextBox As TextBox
    Friend WithEvents QuestionTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents QuestionLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
End Class
