<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateForm
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
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.AccessLabel = New System.Windows.Forms.Label()
        Me.PublicRadioButton = New System.Windows.Forms.RadioButton()
        Me.OnlyPinRadioButton = New System.Windows.Forms.RadioButton()
        Me.PinTextBox = New System.Windows.Forms.TextBox()
        Me.LimitTimeLabel = New System.Windows.Forms.Label()
        Me.TimeTextBox = New System.Windows.Forms.TextBox()
        Me.MinuteLabel = New System.Windows.Forms.Label()
        Me.NoLimitRadioButton = New System.Windows.Forms.RadioButton()
        Me.LimitTimeRadioButton = New System.Windows.Forms.RadioButton()
        Me.InformationLabel = New System.Windows.Forms.Label()
        Me.InformationCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.AddInformationTextBox = New System.Windows.Forms.TextBox()
        Me.AddInformaionButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(30, 64)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(101, 20)
        Me.NameLabel.TabIndex = 6
        Me.NameLabel.Text = "ชื่อแบบทดสอบ:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(137, 61)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(323, 26)
        Me.NameTextBox.TabIndex = 7
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Location = New System.Drawing.Point(466, 64)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(57, 20)
        Me.TypeLabel.TabIndex = 8
        Me.TypeLabel.Text = "ประเภท"
        '
        'TypeComboBox
        '
        Me.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Items.AddRange(New Object() {"เลือกคำตอบ", "เติมคำตอบ", "เขียนคำตอบ", "จับคู่", "ถูกผิด"})
        Me.TypeComboBox.Location = New System.Drawing.Point(529, 61)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(121, 28)
        Me.TypeComboBox.TabIndex = 9
        '
        'AccessLabel
        '
        Me.AccessLabel.AutoSize = True
        Me.AccessLabel.Location = New System.Drawing.Point(30, 108)
        Me.AccessLabel.Name = "AccessLabel"
        Me.AccessLabel.Size = New System.Drawing.Size(145, 20)
        Me.AccessLabel.TabIndex = 10
        Me.AccessLabel.Text = "การเข้าถึงแบบทดสอบ:"
        '
        'PublicRadioButton
        '
        Me.PublicRadioButton.AutoSize = True
        Me.PublicRadioButton.Location = New System.Drawing.Point(181, 106)
        Me.PublicRadioButton.Name = "PublicRadioButton"
        Me.PublicRadioButton.Size = New System.Drawing.Size(83, 24)
        Me.PublicRadioButton.TabIndex = 11
        Me.PublicRadioButton.TabStop = True
        Me.PublicRadioButton.Text = "สาธารณะ"
        Me.PublicRadioButton.UseVisualStyleBackColor = True
        '
        'OnlyPinRadioButton
        '
        Me.OnlyPinRadioButton.AutoSize = True
        Me.OnlyPinRadioButton.Location = New System.Drawing.Point(270, 106)
        Me.OnlyPinRadioButton.Name = "OnlyPinRadioButton"
        Me.OnlyPinRadioButton.Size = New System.Drawing.Size(120, 24)
        Me.OnlyPinRadioButton.TabIndex = 12
        Me.OnlyPinRadioButton.TabStop = True
        Me.OnlyPinRadioButton.Text = "เฉพาะผู้ที่มีรหัส"
        Me.OnlyPinRadioButton.UseVisualStyleBackColor = True
        '
        'PinTextBox
        '
        Me.PinTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.PinTextBox.Location = New System.Drawing.Point(396, 105)
        Me.PinTextBox.Name = "PinTextBox"
        Me.PinTextBox.Size = New System.Drawing.Size(254, 26)
        Me.PinTextBox.TabIndex = 13
        Me.PinTextBox.Text = "กำหนดรหัสเพื่อเข้าถึงแบบทดสอบ"
        '
        'LimitTimeLabel
        '
        Me.LimitTimeLabel.AutoSize = True
        Me.LimitTimeLabel.Location = New System.Drawing.Point(30, 147)
        Me.LimitTimeLabel.Name = "LimitTimeLabel"
        Me.LimitTimeLabel.Size = New System.Drawing.Size(165, 20)
        Me.LimitTimeLabel.TabIndex = 14
        Me.LimitTimeLabel.Text = "เวลาที่ใช้ในการทำข้อสอบ:"
        '
        'TimeTextBox
        '
        Me.TimeTextBox.Location = New System.Drawing.Point(422, 144)
        Me.TimeTextBox.Name = "TimeTextBox"
        Me.TimeTextBox.Size = New System.Drawing.Size(43, 26)
        Me.TimeTextBox.TabIndex = 15
        '
        'MinuteLabel
        '
        Me.MinuteLabel.AutoSize = True
        Me.MinuteLabel.Location = New System.Drawing.Point(471, 147)
        Me.MinuteLabel.Name = "MinuteLabel"
        Me.MinuteLabel.Size = New System.Drawing.Size(35, 20)
        Me.MinuteLabel.TabIndex = 16
        Me.MinuteLabel.Text = "นาที"
        '
        'NoLimitRadioButton
        '
        Me.NoLimitRadioButton.AutoSize = True
        Me.NoLimitRadioButton.Location = New System.Drawing.Point(199, 145)
        Me.NoLimitRadioButton.Name = "NoLimitRadioButton"
        Me.NoLimitRadioButton.Size = New System.Drawing.Size(115, 24)
        Me.NoLimitRadioButton.TabIndex = 17
        Me.NoLimitRadioButton.TabStop = True
        Me.NoLimitRadioButton.Text = "ไม่กำหนดเวลา"
        Me.NoLimitRadioButton.UseVisualStyleBackColor = True
        '
        'LimitTimeRadioButton
        '
        Me.LimitTimeRadioButton.AutoSize = True
        Me.LimitTimeRadioButton.Location = New System.Drawing.Point(320, 145)
        Me.LimitTimeRadioButton.Name = "LimitTimeRadioButton"
        Me.LimitTimeRadioButton.Size = New System.Drawing.Size(98, 24)
        Me.LimitTimeRadioButton.TabIndex = 18
        Me.LimitTimeRadioButton.TabStop = True
        Me.LimitTimeRadioButton.Text = "กำหนดเวลา"
        Me.LimitTimeRadioButton.UseVisualStyleBackColor = True
        '
        'InformationLabel
        '
        Me.InformationLabel.AutoSize = True
        Me.InformationLabel.Location = New System.Drawing.Point(30, 190)
        Me.InformationLabel.Name = "InformationLabel"
        Me.InformationLabel.Size = New System.Drawing.Size(104, 20)
        Me.InformationLabel.TabIndex = 19
        Me.InformationLabel.Text = "ข้อมูลผู้เข้าสอบ:"
        '
        'InformationCheckedListBox
        '
        Me.InformationCheckedListBox.FormattingEnabled = True
        Me.InformationCheckedListBox.Items.AddRange(New Object() {"ชื่อผู้ใช้", "ชื่อ", "นามสกุล", "เลขประจำตัว"})
        Me.InformationCheckedListBox.Location = New System.Drawing.Point(137, 190)
        Me.InformationCheckedListBox.Name = "InformationCheckedListBox"
        Me.InformationCheckedListBox.Size = New System.Drawing.Size(513, 109)
        Me.InformationCheckedListBox.TabIndex = 20
        '
        'AddInformationTextBox
        '
        Me.AddInformationTextBox.Location = New System.Drawing.Point(137, 305)
        Me.AddInformationTextBox.Name = "AddInformationTextBox"
        Me.AddInformationTextBox.Size = New System.Drawing.Size(202, 26)
        Me.AddInformationTextBox.TabIndex = 21
        '
        'AddInformaionButton
        '
        Me.AddInformaionButton.AutoSize = True
        Me.AddInformaionButton.Location = New System.Drawing.Point(345, 303)
        Me.AddInformaionButton.Name = "AddInformaionButton"
        Me.AddInformaionButton.Size = New System.Drawing.Size(45, 30)
        Me.AddInformaionButton.TabIndex = 22
        Me.AddInformaionButton.Text = "เพิ่ม"
        Me.AddInformaionButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.AutoSize = True
        Me.NextButton.Location = New System.Drawing.Point(199, 403)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(112, 46)
        Me.NextButton.TabIndex = 23
        Me.NextButton.Text = "ถัดไป"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.AutoSize = True
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(317, 403)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(112, 46)
        Me.CancelButton.TabIndex = 24
        Me.CancelButton.Text = "ยกเลิก"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'CreateForm
        '
        Me.AcceptButton = Me.NextButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.AddInformaionButton)
        Me.Controls.Add(Me.AddInformationTextBox)
        Me.Controls.Add(Me.InformationCheckedListBox)
        Me.Controls.Add(Me.InformationLabel)
        Me.Controls.Add(Me.LimitTimeRadioButton)
        Me.Controls.Add(Me.NoLimitRadioButton)
        Me.Controls.Add(Me.MinuteLabel)
        Me.Controls.Add(Me.TimeTextBox)
        Me.Controls.Add(Me.LimitTimeLabel)
        Me.Controls.Add(Me.PinTextBox)
        Me.Controls.Add(Me.OnlyPinRadioButton)
        Me.Controls.Add(Me.PublicRadioButton)
        Me.Controls.Add(Me.AccessLabel)
        Me.Controls.Add(Me.TypeComboBox)
        Me.Controls.Add(Me.TypeLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Name = "CreateForm"
        Me.Text = "สร้างแบบทดสอบ - MyExam"
        Me.Controls.SetChildIndex(Me.NameLabel, 0)
        Me.Controls.SetChildIndex(Me.NameTextBox, 0)
        Me.Controls.SetChildIndex(Me.TypeLabel, 0)
        Me.Controls.SetChildIndex(Me.TypeComboBox, 0)
        Me.Controls.SetChildIndex(Me.AccessLabel, 0)
        Me.Controls.SetChildIndex(Me.PublicRadioButton, 0)
        Me.Controls.SetChildIndex(Me.OnlyPinRadioButton, 0)
        Me.Controls.SetChildIndex(Me.PinTextBox, 0)
        Me.Controls.SetChildIndex(Me.LimitTimeLabel, 0)
        Me.Controls.SetChildIndex(Me.TimeTextBox, 0)
        Me.Controls.SetChildIndex(Me.MinuteLabel, 0)
        Me.Controls.SetChildIndex(Me.NoLimitRadioButton, 0)
        Me.Controls.SetChildIndex(Me.LimitTimeRadioButton, 0)
        Me.Controls.SetChildIndex(Me.InformationLabel, 0)
        Me.Controls.SetChildIndex(Me.InformationCheckedListBox, 0)
        Me.Controls.SetChildIndex(Me.AddInformationTextBox, 0)
        Me.Controls.SetChildIndex(Me.AddInformaionButton, 0)
        Me.Controls.SetChildIndex(Me.NextButton, 0)
        Me.Controls.SetChildIndex(Me.CancelButton, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents TypeLabel As Label
    Friend WithEvents TypeComboBox As ComboBox
    Friend WithEvents AccessLabel As Label
    Friend WithEvents PublicRadioButton As RadioButton
    Friend WithEvents OnlyPinRadioButton As RadioButton
    Friend WithEvents PinTextBox As TextBox
    Friend WithEvents LimitTimeLabel As Label
    Friend WithEvents TimeTextBox As TextBox
    Friend WithEvents MinuteLabel As Label
    Friend WithEvents NoLimitRadioButton As RadioButton
    Friend WithEvents LimitTimeRadioButton As RadioButton
    Friend WithEvents InformationLabel As Label
    Friend WithEvents InformationCheckedListBox As CheckedListBox
    Friend WithEvents AddInformationTextBox As TextBox
    Friend WithEvents AddInformaionButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents CancelButton As Button
End Class
