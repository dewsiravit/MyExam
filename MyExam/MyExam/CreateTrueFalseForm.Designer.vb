<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateTrueFalseForm
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
        Me.QuestionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TrueRadioButton = New System.Windows.Forms.RadioButton()
        Me.PreviewLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.NumberComboBox = New System.Windows.Forms.ComboBox()
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.FalseRadioButton = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'QuestionRichTextBox
        '
        Me.QuestionRichTextBox.Location = New System.Drawing.Point(20, 138)
        Me.QuestionRichTextBox.Name = "QuestionRichTextBox"
        Me.QuestionRichTextBox.Size = New System.Drawing.Size(647, 75)
        Me.QuestionRichTextBox.TabIndex = 40
        Me.QuestionRichTextBox.Text = ""
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(190, 312)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(91, 39)
        Me.BackButton.TabIndex = 36
        Me.BackButton.Text = "ย้อนกลับ"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(287, 312)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(91, 39)
        Me.NextButton.TabIndex = 35
        Me.NextButton.Text = "ถัดไป"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(384, 312)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(91, 39)
        Me.SaveButton.TabIndex = 34
        Me.SaveButton.Text = "บันทึก"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TrueRadioButton
        '
        Me.TrueRadioButton.AutoSize = True
        Me.TrueRadioButton.Checked = True
        Me.TrueRadioButton.Location = New System.Drawing.Point(226, 232)
        Me.TrueRadioButton.Name = "TrueRadioButton"
        Me.TrueRadioButton.Size = New System.Drawing.Size(45, 24)
        Me.TrueRadioButton.TabIndex = 33
        Me.TrueRadioButton.TabStop = True
        Me.TrueRadioButton.Text = "ถูก"
        Me.TrueRadioButton.UseVisualStyleBackColor = True
        '
        'PreviewLinkLabel
        '
        Me.PreviewLinkLabel.AutoSize = True
        Me.PreviewLinkLabel.Location = New System.Drawing.Point(603, 107)
        Me.PreviewLinkLabel.Name = "PreviewLinkLabel"
        Me.PreviewLinkLabel.Size = New System.Drawing.Size(64, 20)
        Me.PreviewLinkLabel.TabIndex = 44
        Me.PreviewLinkLabel.TabStop = True
        Me.PreviewLinkLabel.Text = "ดูตัวอย่าง"
        '
        'NumberComboBox
        '
        Me.NumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NumberComboBox.FormattingEnabled = True
        Me.NumberComboBox.Location = New System.Drawing.Point(58, 104)
        Me.NumberComboBox.Name = "NumberComboBox"
        Me.NumberComboBox.Size = New System.Drawing.Size(58, 28)
        Me.NumberComboBox.TabIndex = 43
        '
        'DeleteLinkLabel
        '
        Me.DeleteLinkLabel.AutoSize = True
        Me.DeleteLinkLabel.Location = New System.Drawing.Point(122, 107)
        Me.DeleteLinkLabel.Name = "DeleteLinkLabel"
        Me.DeleteLinkLabel.Size = New System.Drawing.Size(26, 20)
        Me.DeleteLinkLabel.TabIndex = 42
        Me.DeleteLinkLabel.TabStop = True
        Me.DeleteLinkLabel.Text = "ลบ"
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Location = New System.Drawing.Point(16, 107)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(36, 20)
        Me.NumberLabel.TabIndex = 41
        Me.NumberLabel.Text = "ข้อที่"
        '
        'FalseRadioButton
        '
        Me.FalseRadioButton.AutoSize = True
        Me.FalseRadioButton.Location = New System.Drawing.Point(374, 232)
        Me.FalseRadioButton.Name = "FalseRadioButton"
        Me.FalseRadioButton.Size = New System.Drawing.Size(45, 24)
        Me.FalseRadioButton.TabIndex = 45
        Me.FalseRadioButton.Text = "ผิด"
        Me.FalseRadioButton.UseVisualStyleBackColor = True
        '
        'CreateTrueFalseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.FalseRadioButton)
        Me.Controls.Add(Me.PreviewLinkLabel)
        Me.Controls.Add(Me.NumberComboBox)
        Me.Controls.Add(Me.DeleteLinkLabel)
        Me.Controls.Add(Me.NumberLabel)
        Me.Controls.Add(Me.QuestionRichTextBox)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.TrueRadioButton)
        Me.Name = "CreateTrueFalseForm"
        Me.Text = "สร้างแบบทดสอบ ถูกผิด - MyExam"
        Me.Controls.SetChildIndex(Me.TrueRadioButton, 0)
        Me.Controls.SetChildIndex(Me.SaveButton, 0)
        Me.Controls.SetChildIndex(Me.NextButton, 0)
        Me.Controls.SetChildIndex(Me.BackButton, 0)
        Me.Controls.SetChildIndex(Me.QuestionRichTextBox, 0)
        Me.Controls.SetChildIndex(Me.NumberLabel, 0)
        Me.Controls.SetChildIndex(Me.DeleteLinkLabel, 0)
        Me.Controls.SetChildIndex(Me.NumberComboBox, 0)
        Me.Controls.SetChildIndex(Me.PreviewLinkLabel, 0)
        Me.Controls.SetChildIndex(Me.FalseRadioButton, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuestionRichTextBox As RichTextBox
    Friend WithEvents BackButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents TrueRadioButton As RadioButton
    Friend WithEvents PreviewLinkLabel As LinkLabel
    Friend WithEvents NumberComboBox As ComboBox
    Friend WithEvents DeleteLinkLabel As LinkLabel
    Friend WithEvents NumberLabel As Label
    Friend WithEvents FalseRadioButton As RadioButton
End Class
