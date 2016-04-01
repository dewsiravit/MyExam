<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateWriteForm
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
        Me.PreviewLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.NumberComboBox = New System.Windows.Forms.ComboBox()
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.QuestionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.AnswerLabel = New System.Windows.Forms.Label()
        Me.AnswerRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'PreviewLinkLabel
        '
        Me.PreviewLinkLabel.AutoSize = True
        Me.PreviewLinkLabel.Location = New System.Drawing.Point(604, 67)
        Me.PreviewLinkLabel.Name = "PreviewLinkLabel"
        Me.PreviewLinkLabel.Size = New System.Drawing.Size(64, 20)
        Me.PreviewLinkLabel.TabIndex = 54
        Me.PreviewLinkLabel.TabStop = True
        Me.PreviewLinkLabel.Text = "ดูตัวอย่าง"
        '
        'NumberComboBox
        '
        Me.NumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NumberComboBox.FormattingEnabled = True
        Me.NumberComboBox.Location = New System.Drawing.Point(59, 64)
        Me.NumberComboBox.Name = "NumberComboBox"
        Me.NumberComboBox.Size = New System.Drawing.Size(58, 28)
        Me.NumberComboBox.TabIndex = 53
        '
        'DeleteLinkLabel
        '
        Me.DeleteLinkLabel.AutoSize = True
        Me.DeleteLinkLabel.Location = New System.Drawing.Point(123, 67)
        Me.DeleteLinkLabel.Name = "DeleteLinkLabel"
        Me.DeleteLinkLabel.Size = New System.Drawing.Size(26, 20)
        Me.DeleteLinkLabel.TabIndex = 52
        Me.DeleteLinkLabel.TabStop = True
        Me.DeleteLinkLabel.Text = "ลบ"
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Location = New System.Drawing.Point(17, 67)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(36, 20)
        Me.NumberLabel.TabIndex = 51
        Me.NumberLabel.Text = "ข้อที่"
        '
        'QuestionRichTextBox
        '
        Me.QuestionRichTextBox.Location = New System.Drawing.Point(21, 98)
        Me.QuestionRichTextBox.Name = "QuestionRichTextBox"
        Me.QuestionRichTextBox.Size = New System.Drawing.Size(647, 100)
        Me.QuestionRichTextBox.TabIndex = 50
        Me.QuestionRichTextBox.Text = ""
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(201, 367)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(91, 39)
        Me.BackButton.TabIndex = 49
        Me.BackButton.Text = "ย้อนกลับ"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(298, 367)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(91, 39)
        Me.NextButton.TabIndex = 48
        Me.NextButton.Text = "ถัดไป"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(395, 367)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(91, 39)
        Me.SaveButton.TabIndex = 47
        Me.SaveButton.Text = "บันทึก"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'AnswerLabel
        '
        Me.AnswerLabel.AutoSize = True
        Me.AnswerLabel.Location = New System.Drawing.Point(17, 214)
        Me.AnswerLabel.Name = "AnswerLabel"
        Me.AnswerLabel.Size = New System.Drawing.Size(51, 20)
        Me.AnswerLabel.TabIndex = 55
        Me.AnswerLabel.Text = "คำตอบ"
        '
        'AnswerRichTextBox
        '
        Me.AnswerRichTextBox.Location = New System.Drawing.Point(21, 237)
        Me.AnswerRichTextBox.Name = "AnswerRichTextBox"
        Me.AnswerRichTextBox.Size = New System.Drawing.Size(647, 72)
        Me.AnswerRichTextBox.TabIndex = 56
        Me.AnswerRichTextBox.Text = ""
        '
        'CreateWriteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.AnswerRichTextBox)
        Me.Controls.Add(Me.AnswerLabel)
        Me.Controls.Add(Me.PreviewLinkLabel)
        Me.Controls.Add(Me.NumberComboBox)
        Me.Controls.Add(Me.DeleteLinkLabel)
        Me.Controls.Add(Me.NumberLabel)
        Me.Controls.Add(Me.QuestionRichTextBox)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Name = "CreateWriteForm"
        Me.Text = "สร้างแบบทดสอบ เติมคำตอบ - MyExam"
        Me.Controls.SetChildIndex(Me.SaveButton, 0)
        Me.Controls.SetChildIndex(Me.NextButton, 0)
        Me.Controls.SetChildIndex(Me.BackButton, 0)
        Me.Controls.SetChildIndex(Me.QuestionRichTextBox, 0)
        Me.Controls.SetChildIndex(Me.NumberLabel, 0)
        Me.Controls.SetChildIndex(Me.DeleteLinkLabel, 0)
        Me.Controls.SetChildIndex(Me.NumberComboBox, 0)
        Me.Controls.SetChildIndex(Me.PreviewLinkLabel, 0)
        Me.Controls.SetChildIndex(Me.AnswerLabel, 0)
        Me.Controls.SetChildIndex(Me.AnswerRichTextBox, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PreviewLinkLabel As LinkLabel
    Friend WithEvents NumberComboBox As ComboBox
    Friend WithEvents DeleteLinkLabel As LinkLabel
    Friend WithEvents NumberLabel As Label
    Friend WithEvents QuestionRichTextBox As RichTextBox
    Friend WithEvents BackButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents AnswerLabel As Label
    Friend WithEvents AnswerRichTextBox As RichTextBox
End Class
