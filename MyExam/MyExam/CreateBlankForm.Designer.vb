<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateBlankForm
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
        Me.QurstionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.PreviewLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.NumberComboBox = New System.Windows.Forms.ComboBox()
        Me.DeleteLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SuggestLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'QurstionRichTextBox
        '
        Me.QurstionRichTextBox.Location = New System.Drawing.Point(17, 150)
        Me.QurstionRichTextBox.Name = "QurstionRichTextBox"
        Me.QurstionRichTextBox.Size = New System.Drawing.Size(646, 125)
        Me.QurstionRichTextBox.TabIndex = 30
        Me.QurstionRichTextBox.Text = ""
        '
        'PreviewLinkLabel
        '
        Me.PreviewLinkLabel.AutoSize = True
        Me.PreviewLinkLabel.Location = New System.Drawing.Point(599, 71)
        Me.PreviewLinkLabel.Name = "PreviewLinkLabel"
        Me.PreviewLinkLabel.Size = New System.Drawing.Size(64, 20)
        Me.PreviewLinkLabel.TabIndex = 29
        Me.PreviewLinkLabel.TabStop = True
        Me.PreviewLinkLabel.Text = "ดูตัวอย่าง"
        '
        'NumberComboBox
        '
        Me.NumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NumberComboBox.FormattingEnabled = True
        Me.NumberComboBox.Location = New System.Drawing.Point(54, 68)
        Me.NumberComboBox.Name = "NumberComboBox"
        Me.NumberComboBox.Size = New System.Drawing.Size(58, 28)
        Me.NumberComboBox.TabIndex = 28
        '
        'DeleteLinkLabel
        '
        Me.DeleteLinkLabel.AutoSize = True
        Me.DeleteLinkLabel.Location = New System.Drawing.Point(118, 71)
        Me.DeleteLinkLabel.Name = "DeleteLinkLabel"
        Me.DeleteLinkLabel.Size = New System.Drawing.Size(26, 20)
        Me.DeleteLinkLabel.TabIndex = 27
        Me.DeleteLinkLabel.TabStop = True
        Me.DeleteLinkLabel.Text = "ลบ"
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Location = New System.Drawing.Point(12, 71)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(36, 20)
        Me.NumberLabel.TabIndex = 26
        Me.NumberLabel.Text = "ข้อที่"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(181, 331)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(91, 39)
        Me.BackButton.TabIndex = 52
        Me.BackButton.Text = "ย้อนกลับ"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(278, 331)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(91, 39)
        Me.NextButton.TabIndex = 51
        Me.NextButton.Text = "ถัดไป"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(375, 331)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(91, 39)
        Me.SaveButton.TabIndex = 50
        Me.SaveButton.Text = "บันทึก"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'SuggestLabel
        '
        Me.SuggestLabel.AutoSize = True
        Me.SuggestLabel.Location = New System.Drawing.Point(165, 84)
        Me.SuggestLabel.Name = "SuggestLabel"
        Me.SuggestLabel.Size = New System.Drawing.Size(411, 40)
        Me.SuggestLabel.TabIndex = 53
        Me.SuggestLabel.Text = "ใช้สัญลักษณ์ '(*' และ '*)' ในการปิดคำตอบจากโจทย์" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "เช่น ดวงอาทิตย์ขึ้นทาง (*ทิศตะว" &
    "ันออก*) -> ดวงอาทิตย์ขึ้นทาง____"
        '
        'CreateBlankForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.SuggestLabel)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.QurstionRichTextBox)
        Me.Controls.Add(Me.PreviewLinkLabel)
        Me.Controls.Add(Me.NumberComboBox)
        Me.Controls.Add(Me.DeleteLinkLabel)
        Me.Controls.Add(Me.NumberLabel)
        Me.Name = "CreateBlankForm"
        Me.Controls.SetChildIndex(Me.NumberLabel, 0)
        Me.Controls.SetChildIndex(Me.DeleteLinkLabel, 0)
        Me.Controls.SetChildIndex(Me.NumberComboBox, 0)
        Me.Controls.SetChildIndex(Me.PreviewLinkLabel, 0)
        Me.Controls.SetChildIndex(Me.QurstionRichTextBox, 0)
        Me.Controls.SetChildIndex(Me.SaveButton, 0)
        Me.Controls.SetChildIndex(Me.NextButton, 0)
        Me.Controls.SetChildIndex(Me.BackButton, 0)
        Me.Controls.SetChildIndex(Me.SuggestLabel, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QurstionRichTextBox As RichTextBox
    Friend WithEvents PreviewLinkLabel As LinkLabel
    Friend WithEvents NumberComboBox As ComboBox
    Friend WithEvents DeleteLinkLabel As LinkLabel
    Friend WithEvents NumberLabel As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents SuggestLabel As Label
End Class
