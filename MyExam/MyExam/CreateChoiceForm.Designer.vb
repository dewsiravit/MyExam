<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateChoiceForm
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
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.ChoiceARadioButton = New System.Windows.Forms.RadioButton()
        Me.ChoiceBRadioButton = New System.Windows.Forms.RadioButton()
        Me.ChoiceCRadioButton = New System.Windows.Forms.RadioButton()
        Me.ChoiceDRadioButton = New System.Windows.Forms.RadioButton()
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.NumberComboBox = New System.Windows.Forms.ComboBox()
        Me.PreviewLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.QurstionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ChoiceARichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ChoiceBRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ChoiceCRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ChoiceDRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Location = New System.Drawing.Point(21, 47)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(36, 20)
        Me.NumberLabel.TabIndex = 7
        Me.NumberLabel.Text = "ข้อที่"
        '
        'ChoiceARadioButton
        '
        Me.ChoiceARadioButton.AutoSize = True
        Me.ChoiceARadioButton.Checked = True
        Me.ChoiceARadioButton.Location = New System.Drawing.Point(23, 174)
        Me.ChoiceARadioButton.Name = "ChoiceARadioButton"
        Me.ChoiceARadioButton.Size = New System.Drawing.Size(14, 13)
        Me.ChoiceARadioButton.TabIndex = 15
        Me.ChoiceARadioButton.TabStop = True
        Me.ChoiceARadioButton.UseVisualStyleBackColor = True
        '
        'ChoiceBRadioButton
        '
        Me.ChoiceBRadioButton.AutoSize = True
        Me.ChoiceBRadioButton.Location = New System.Drawing.Point(23, 233)
        Me.ChoiceBRadioButton.Name = "ChoiceBRadioButton"
        Me.ChoiceBRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.ChoiceBRadioButton.TabIndex = 16
        Me.ChoiceBRadioButton.UseVisualStyleBackColor = True
        '
        'ChoiceCRadioButton
        '
        Me.ChoiceCRadioButton.AutoSize = True
        Me.ChoiceCRadioButton.Location = New System.Drawing.Point(23, 288)
        Me.ChoiceCRadioButton.Name = "ChoiceCRadioButton"
        Me.ChoiceCRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.ChoiceCRadioButton.TabIndex = 17
        Me.ChoiceCRadioButton.UseVisualStyleBackColor = True
        '
        'ChoiceDRadioButton
        '
        Me.ChoiceDRadioButton.AutoSize = True
        Me.ChoiceDRadioButton.Location = New System.Drawing.Point(23, 345)
        Me.ChoiceDRadioButton.Name = "ChoiceDRadioButton"
        Me.ChoiceDRadioButton.Size = New System.Drawing.Size(14, 13)
        Me.ChoiceDRadioButton.TabIndex = 18
        Me.ChoiceDRadioButton.UseVisualStyleBackColor = True
        '
        'DeleteLinkLabel
        '
        Me.DeleteLinkLabel.AutoSize = True
        Me.DeleteLinkLabel.Location = New System.Drawing.Point(127, 47)
        Me.DeleteLinkLabel.Name = "DeleteLinkLabel"
        Me.DeleteLinkLabel.Size = New System.Drawing.Size(26, 20)
        Me.DeleteLinkLabel.TabIndex = 19
        Me.DeleteLinkLabel.TabStop = True
        Me.DeleteLinkLabel.Text = "ลบ"
        '
        'NumberComboBox
        '
        Me.NumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NumberComboBox.FormattingEnabled = True
        Me.NumberComboBox.Location = New System.Drawing.Point(63, 44)
        Me.NumberComboBox.Name = "NumberComboBox"
        Me.NumberComboBox.Size = New System.Drawing.Size(58, 28)
        Me.NumberComboBox.TabIndex = 20
        '
        'PreviewLinkLabel
        '
        Me.PreviewLinkLabel.AutoSize = True
        Me.PreviewLinkLabel.Location = New System.Drawing.Point(608, 47)
        Me.PreviewLinkLabel.Name = "PreviewLinkLabel"
        Me.PreviewLinkLabel.Size = New System.Drawing.Size(64, 20)
        Me.PreviewLinkLabel.TabIndex = 21
        Me.PreviewLinkLabel.TabStop = True
        Me.PreviewLinkLabel.Text = "ดูตัวอย่าง"
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(190, 396)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(91, 39)
        Me.SaveButton.TabIndex = 22
        Me.SaveButton.Text = "บันทึก"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(287, 396)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(91, 39)
        Me.NextButton.TabIndex = 23
        Me.NextButton.Text = "ถัดไป"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(384, 396)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(91, 39)
        Me.BackButton.TabIndex = 24
        Me.BackButton.Text = "ย้อนกลับ"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'QurstionRichTextBox
        '
        Me.QurstionRichTextBox.Location = New System.Drawing.Point(25, 78)
        Me.QurstionRichTextBox.Name = "QurstionRichTextBox"
        Me.QurstionRichTextBox.Size = New System.Drawing.Size(646, 65)
        Me.QurstionRichTextBox.TabIndex = 25
        Me.QurstionRichTextBox.Text = ""
        '
        'ChoiceARichTextBox
        '
        Me.ChoiceARichTextBox.Location = New System.Drawing.Point(43, 154)
        Me.ChoiceARichTextBox.Name = "ChoiceARichTextBox"
        Me.ChoiceARichTextBox.Size = New System.Drawing.Size(628, 51)
        Me.ChoiceARichTextBox.TabIndex = 26
        Me.ChoiceARichTextBox.Text = ""
        '
        'ChoiceBRichTextBox
        '
        Me.ChoiceBRichTextBox.Location = New System.Drawing.Point(43, 211)
        Me.ChoiceBRichTextBox.Name = "ChoiceBRichTextBox"
        Me.ChoiceBRichTextBox.Size = New System.Drawing.Size(628, 51)
        Me.ChoiceBRichTextBox.TabIndex = 27
        Me.ChoiceBRichTextBox.Text = ""
        '
        'ChoiceCRichTextBox
        '
        Me.ChoiceCRichTextBox.Location = New System.Drawing.Point(43, 268)
        Me.ChoiceCRichTextBox.Name = "ChoiceCRichTextBox"
        Me.ChoiceCRichTextBox.Size = New System.Drawing.Size(628, 51)
        Me.ChoiceCRichTextBox.TabIndex = 28
        Me.ChoiceCRichTextBox.Text = ""
        '
        'ChoiceDRichTextBox
        '
        Me.ChoiceDRichTextBox.Location = New System.Drawing.Point(43, 325)
        Me.ChoiceDRichTextBox.Name = "ChoiceDRichTextBox"
        Me.ChoiceDRichTextBox.Size = New System.Drawing.Size(628, 51)
        Me.ChoiceDRichTextBox.TabIndex = 29
        Me.ChoiceDRichTextBox.Text = ""
        '
        'CreateChoiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.ChoiceDRichTextBox)
        Me.Controls.Add(Me.ChoiceCRichTextBox)
        Me.Controls.Add(Me.ChoiceBRichTextBox)
        Me.Controls.Add(Me.ChoiceARichTextBox)
        Me.Controls.Add(Me.QurstionRichTextBox)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.PreviewLinkLabel)
        Me.Controls.Add(Me.NumberComboBox)
        Me.Controls.Add(Me.DeleteLinkLabel)
        Me.Controls.Add(Me.ChoiceDRadioButton)
        Me.Controls.Add(Me.ChoiceCRadioButton)
        Me.Controls.Add(Me.ChoiceBRadioButton)
        Me.Controls.Add(Me.ChoiceARadioButton)
        Me.Controls.Add(Me.NumberLabel)
        Me.Name = "CreateChoiceForm"
        Me.Text = "แบบทดสอบ เลือกตอบ - MyExam"
        Me.Controls.SetChildIndex(Me.NumberLabel, 0)
        Me.Controls.SetChildIndex(Me.ChoiceARadioButton, 0)
        Me.Controls.SetChildIndex(Me.ChoiceBRadioButton, 0)
        Me.Controls.SetChildIndex(Me.ChoiceCRadioButton, 0)
        Me.Controls.SetChildIndex(Me.ChoiceDRadioButton, 0)
        Me.Controls.SetChildIndex(Me.DeleteLinkLabel, 0)
        Me.Controls.SetChildIndex(Me.NumberComboBox, 0)
        Me.Controls.SetChildIndex(Me.PreviewLinkLabel, 0)
        Me.Controls.SetChildIndex(Me.SaveButton, 0)
        Me.Controls.SetChildIndex(Me.NextButton, 0)
        Me.Controls.SetChildIndex(Me.BackButton, 0)
        Me.Controls.SetChildIndex(Me.QurstionRichTextBox, 0)
        Me.Controls.SetChildIndex(Me.ChoiceARichTextBox, 0)
        Me.Controls.SetChildIndex(Me.ChoiceBRichTextBox, 0)
        Me.Controls.SetChildIndex(Me.ChoiceCRichTextBox, 0)
        Me.Controls.SetChildIndex(Me.ChoiceDRichTextBox, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumberLabel As Label
    Friend WithEvents ChoiceARadioButton As RadioButton
    Friend WithEvents ChoiceBRadioButton As RadioButton
    Friend WithEvents ChoiceCRadioButton As RadioButton
    Friend WithEvents ChoiceDRadioButton As RadioButton
    Friend WithEvents DeleteLinkLabel As LinkLabel
    Friend WithEvents NumberComboBox As ComboBox
    Friend WithEvents PreviewLinkLabel As LinkLabel
    Friend WithEvents SaveButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents QurstionRichTextBox As RichTextBox
    Friend WithEvents ChoiceARichTextBox As RichTextBox
    Friend WithEvents ChoiceBRichTextBox As RichTextBox
    Friend WithEvents ChoiceCRichTextBox As RichTextBox
    Friend WithEvents ChoiceDRichTextBox As RichTextBox
End Class
