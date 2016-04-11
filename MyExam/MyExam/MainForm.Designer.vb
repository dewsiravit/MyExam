<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.SearchGroupBox = New System.Windows.Forms.GroupBox()
        Me.AdvanceSearchLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.SearchTypeLabel = New System.Windows.Forms.Label()
        Me.CreatorRadioButton = New System.Windows.Forms.RadioButton()
        Me.NameRadioButton = New System.Windows.Forms.RadioButton()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.NoColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NameColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TypeColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TimeColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AccessColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CreatorColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DateColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EditColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SearchGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchGroupBox
        '
        Me.SearchGroupBox.Controls.Add(Me.AdvanceSearchLinkLabel)
        Me.SearchGroupBox.Controls.Add(Me.SearchTypeLabel)
        Me.SearchGroupBox.Controls.Add(Me.CreatorRadioButton)
        Me.SearchGroupBox.Controls.Add(Me.NameRadioButton)
        Me.SearchGroupBox.Controls.Add(Me.SearchButton)
        Me.SearchGroupBox.Controls.Add(Me.SearchTextBox)
        Me.SearchGroupBox.Location = New System.Drawing.Point(14, 50)
        Me.SearchGroupBox.Name = "SearchGroupBox"
        Me.SearchGroupBox.Size = New System.Drawing.Size(654, 99)
        Me.SearchGroupBox.TabIndex = 7
        Me.SearchGroupBox.TabStop = False
        Me.SearchGroupBox.Text = "ค้นหา"
        '
        'AdvanceSearchLinkLabel
        '
        Me.AdvanceSearchLinkLabel.AutoSize = True
        Me.AdvanceSearchLinkLabel.Location = New System.Drawing.Point(478, 64)
        Me.AdvanceSearchLinkLabel.Name = "AdvanceSearchLinkLabel"
        Me.AdvanceSearchLinkLabel.Size = New System.Drawing.Size(116, 20)
        Me.AdvanceSearchLinkLabel.TabIndex = 5
        Me.AdvanceSearchLinkLabel.TabStop = True
        Me.AdvanceSearchLinkLabel.Text = "ค้นหาแบบละเอียด"
        '
        'SearchTypeLabel
        '
        Me.SearchTypeLabel.AutoSize = True
        Me.SearchTypeLabel.Location = New System.Drawing.Point(38, 64)
        Me.SearchTypeLabel.Name = "SearchTypeLabel"
        Me.SearchTypeLabel.Size = New System.Drawing.Size(103, 20)
        Me.SearchTypeLabel.TabIndex = 4
        Me.SearchTypeLabel.Text = "สิ่งที่กำลังค้นหา:"
        '
        'CreatorRadioButton
        '
        Me.CreatorRadioButton.AutoSize = True
        Me.CreatorRadioButton.Location = New System.Drawing.Point(268, 62)
        Me.CreatorRadioButton.Name = "CreatorRadioButton"
        Me.CreatorRadioButton.Size = New System.Drawing.Size(136, 24)
        Me.CreatorRadioButton.TabIndex = 3
        Me.CreatorRadioButton.TabStop = True
        Me.CreatorRadioButton.Text = "ผู้สร้างแบบทดสอบ"
        Me.CreatorRadioButton.UseVisualStyleBackColor = True
        '
        'NameRadioButton
        '
        Me.NameRadioButton.AutoSize = True
        Me.NameRadioButton.Checked = True
        Me.NameRadioButton.Location = New System.Drawing.Point(147, 62)
        Me.NameRadioButton.Name = "NameRadioButton"
        Me.NameRadioButton.Size = New System.Drawing.Size(115, 24)
        Me.NameRadioButton.TabIndex = 2
        Me.NameRadioButton.TabStop = True
        Me.NameRadioButton.Text = "ชื่อแบบทดสอบ"
        Me.NameRadioButton.UseVisualStyleBackColor = True
        '
        'SearchButton
        '
        Me.SearchButton.AutoSize = True
        Me.SearchButton.Location = New System.Drawing.Point(537, 23)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 30)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "ค้นหา"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(42, 25)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(489, 26)
        Me.SearchTextBox.TabIndex = 0
        '
        'CreateButton
        '
        Me.CreateButton.AutoSize = True
        Me.CreateButton.Location = New System.Drawing.Point(259, 9)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(119, 30)
        Me.CreateButton.TabIndex = 6
        Me.CreateButton.Text = "สร้างแบบทดสอบ"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NoColumnHeader, Me.NameColumnHeader, Me.TypeColumnHeader, Me.TimeColumnHeader, Me.AccessColumnHeader, Me.CreatorColumnHeader, Me.DateColumnHeader, Me.EditColumnHeader})
        Me.ListView.FullRowSelect = True
        Me.ListView.Location = New System.Drawing.Point(16, 159)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(652, 290)
        Me.ListView.TabIndex = 8
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'NoColumnHeader
        '
        Me.NoColumnHeader.Text = "No."
        '
        'NameColumnHeader
        '
        Me.NameColumnHeader.Text = "ชื่อ"
        Me.NameColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NameColumnHeader.Width = 201
        '
        'TypeColumnHeader
        '
        Me.TypeColumnHeader.Text = "ประเภท"
        Me.TypeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TypeColumnHeader.Width = 76
        '
        'TimeColumnHeader
        '
        Me.TimeColumnHeader.Text = "เวลา (นาที)"
        Me.TimeColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TimeColumnHeader.Width = 89
        '
        'AccessColumnHeader
        '
        Me.AccessColumnHeader.Text = "การเข้าถึง"
        Me.AccessColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.AccessColumnHeader.Width = 76
        '
        'CreatorColumnHeader
        '
        Me.CreatorColumnHeader.Text = "ผู้สร้าง"
        Me.CreatorColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CreatorColumnHeader.Width = 84
        '
        'DateColumnHeader
        '
        Me.DateColumnHeader.Text = "วันที่สร้าง"
        Me.DateColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.DateColumnHeader.Width = 98
        '
        'EditColumnHeader
        '
        Me.EditColumnHeader.Text = "แก้ไขล่าสุด"
        Me.EditColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.EditColumnHeader.Width = 86
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.SearchGroupBox)
        Me.Controls.Add(Me.CreateButton)
        Me.Name = "MainForm"
        Me.Text = "MyExam"
        Me.Controls.SetChildIndex(Me.CreateButton, 0)
        Me.Controls.SetChildIndex(Me.SearchGroupBox, 0)
        Me.Controls.SetChildIndex(Me.ListView, 0)
        Me.SearchGroupBox.ResumeLayout(False)
        Me.SearchGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchGroupBox As GroupBox
    Friend WithEvents SearchTypeLabel As Label
    Friend WithEvents CreatorRadioButton As RadioButton
    Friend WithEvents NameRadioButton As RadioButton
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents CreateButton As Button
    Friend WithEvents ListView As ListView
    Friend WithEvents NameColumnHeader As ColumnHeader
    Friend WithEvents TypeColumnHeader As ColumnHeader
    Friend WithEvents CreatorColumnHeader As ColumnHeader
    Friend WithEvents AdvanceSearchLinkLabel As LinkLabel
    Friend WithEvents DateColumnHeader As ColumnHeader
    Friend WithEvents TimeColumnHeader As ColumnHeader
    Friend WithEvents AccessColumnHeader As ColumnHeader
    Friend WithEvents EditColumnHeader As ColumnHeader
    Friend WithEvents NoColumnHeader As ColumnHeader
End Class
