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
        Me.TestScoreTabPage = New System.Windows.Forms.TabPage()
        Me.TestListTreeView = New System.Windows.Forms.TreeView()
        Me.TestScoreTreeView = New System.Windows.Forms.TreeView()
        Me.TabControl.SuspendLayout()
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
        'TestListTreeView
        '
        Me.TestListTreeView.Location = New System.Drawing.Point(6, 6)
        Me.TestListTreeView.Name = "TestListTreeView"
        Me.TestListTreeView.Size = New System.Drawing.Size(640, 355)
        Me.TestListTreeView.TabIndex = 0
        '
        'TestScoreTreeView
        '
        Me.TestScoreTreeView.Location = New System.Drawing.Point(6, 6)
        Me.TestScoreTreeView.Name = "TestScoreTreeView"
        Me.TestScoreTreeView.Size = New System.Drawing.Size(640, 355)
        Me.TestScoreTreeView.TabIndex = 1
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
End Class
