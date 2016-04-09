Public Class CreateForm
    Private Const PINSUGGEST = "กำหนดรหัส"
    Private myTest As New Test
    Sub New(member As Member)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.member = member
    End Sub

    Sub New(member As Member, myTest As Test)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.member = member
        Me.myTest = myTest
    End Sub

    Private Sub CreateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameTextBox.Text = myTest.Name
        TypeComboBox.SelectedIndex = myTest.Type
        If myTest.Access IsNot Nothing Then
            OnlyPinRadioButton.Checked = True
            PinTextBox.Text = myTest.Access
        Else
            PublicRadioButton.Checked = True
            TimeTextBox.Enabled = False
            PinTextBox.Enabled = False
            PinTextBox.Text = PINSUGGEST
            VisiblePinLinkLabel.Enabled = False
        End If
        If Not (myTest.Time = 0) Then
            LimitTimeRadioButton.Checked = True
            TimeTextBox.Text = myTest.Time
        Else
            NoLimitRadioButton.Checked = True
        End If
        If myTest.Information.Count > 0 Then
            For Each i As String In myTest.Information
                InformationCheckedListBox.Items.Add(i, True)
            Next
        Else
            Dim item() As String = {"ชื่อผู้ใช้", "ชื่อ", "นามสกุล", "เลขประจำตัว"}
            For Each i As String In item
                InformationCheckedListBox.Items.Add(i)
            Next
            InformationCheckedListBox.SetItemChecked(0, True)
        End If
        ErrorNameLabel.ResetText()
        ErrorAddInformationLabel.ResetText()
    End Sub

    Private Sub PinTextBox_TextClick(sender As Object, e As EventArgs) Handles PinTextBox.Click
        If PinTextBox.Text.Equals(PINSUGGEST) Then
            PinTextBox.Clear()
            PinTextBox.ForeColor = SystemColors.WindowText
        End If
    End Sub

    Private Sub PinTextBox_Leave(sender As Object, e As EventArgs) Handles PinTextBox.Leave
        If PinTextBox.Text = "" Then
            PinTextBox.Text = PINSUGGEST
            PinTextBox.ForeColor = SystemColors.WindowFrame
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim main As New MainForm(member)
        main.show()
        Close()
    End Sub

    Private Sub LimitTimeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles LimitTimeRadioButton.CheckedChanged
        If LimitTimeRadioButton.Checked Then
            TimeTextBox.Enabled = True
            MinuteLabel.Enabled = True
            TimeTextBox.Focus()
        Else
            TimeTextBox.Enabled = False
            MinuteLabel.Enabled = False
        End If
    End Sub

    Private Sub OnlyPinRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles OnlyPinRadioButton.CheckedChanged
        If OnlyPinRadioButton.Checked Then
            PinTextBox.Enabled = True
            VisiblePinLinkLabel.Enabled = True
        Else
            PinTextBox.Enabled = False
            VisiblePinLinkLabel.Enabled = False
        End If
    End Sub

    Private Sub VisiblePinLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles VisiblePinLinkLabel.LinkClicked
        If VisiblePinLinkLabel.Text.Equals("ซ่อน") Then
            PinTextBox.UseSystemPasswordChar = True
            VisiblePinLinkLabel.Text = "แสดง"
        Else
            PinTextBox.UseSystemPasswordChar = False
            VisiblePinLinkLabel.Text = "ซ่อน"
        End If
    End Sub

    Private Sub AddInformaionButton_Click(sender As Object, e As EventArgs) Handles AddInformaionButton.Click
        Dim str As String = AddInformationTextBox.Text
        Try
            If str = Nothing Then
                AddInformationTextBox.Focus()
                Throw New Exception("*กรุณาใส่ข้อความ")
            End If
            ErrorAddInformationLabel.ResetText()
            AddInformationTextBox.Clear()
            AddInformationTextBox.Focus()
            For i As Integer = 0 To InformationCheckedListBox.Items.Count - 1
                If InformationCheckedListBox.Items(i).Equals(str) Then
                    InformationCheckedListBox.SetItemChecked(i, True)
                    Exit Sub
                End If
            Next
            InformationCheckedListBox.Items.Add(str)
            InformationCheckedListBox.SetItemChecked(InformationCheckedListBox.Items.Count - 1, True)
        Catch ex As Exception
            ErrorAddInformationLabel.Text = ex.Message
        End Try
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If PinTextBox.Enabled Then
            myTest.Access = PinTextBox.Text
        End If
        Try
            If myTest.Name = "" Then
                Throw New Exception("กรุณาใส่ชื่อแบบทดสอบ")
            ElseIf myTest.Access = PINSUGGEST And PinTextBox.Enabled Then
                Throw New Exception("กรุณาใส่รหัสเพื่อเข้าถึงแบบทดสอบ")
            ElseIf InformationCheckedListBox.CheckedItems.Count = 0 Then
                Throw New Exception("กรุณาเลือกข้อมูลผู้เข้าสอบอย่างน้อย 1 รายการ")
            ElseIf myTest.Time = 0 And LimitTimeRadioButton.Enabled Then
                Throw New Exception("กรุณาใส่เวลาในการทำแบบทดสอบ")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        myTest.Information.Clear()
        For Each i As String In InformationCheckedListBox.CheckedItems
            myTest.Information.Add(i)
        Next

        Select Case TypeComboBox.SelectedIndex
            Case 0
                Dim choice As New CreateChoiceForm(member, myTest)
                choice.Show()
            Case 1
                Dim write As New CreateWriteForm(member)
                write.Show()
            Case 3
                Dim match As New CreateMatchForm(member)
                match.Show()
            Case 2
                Dim blank As New CreateBlankForm(member)
                blank.Show()
            Case 4
                Dim truefalse As New CreateTrueFalseForm(member)
                truefalse.Show()
        End Select
        Close()
    End Sub

    Private Sub TypeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TypeComboBox.SelectedIndexChanged
        Select Case TypeComboBox.SelectedIndex
            Case 0 : myTest.Type = 0
            Case 1 : myTest.Type = 1
            Case 2 : myTest.Type = 2
            Case 3 : myTest.Type = 3
            Case 4 : myTest.Type = 4
        End Select
    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        myTest.Name = NameTextBox.Text
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles PublicRadioButton.CheckedChanged, OnlyPinRadioButton.CheckedChanged, NoLimitRadioButton.CheckedChanged, LimitTimeRadioButton.CheckedChanged
        If PublicRadioButton.Checked Then
            myTest.Access = Nothing
        End If

        If NoLimitRadioButton.Checked Then
            myTest.Time = Nothing
        End If
    End Sub

    Private Sub TimeTextBox_Validated(sender As Object, e As EventArgs) Handles TimeTextBox.Validated
        If Not (Double.TryParse(TimeTextBox.Text, myTest.Time)) And TimeTextBox.Text IsNot "" Then
            MessageBox.Show("กรุณาใส่ข้อมูลให้ถูกต้อง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TimeTextBox.Clear()
            TimeTextBox.Focus()
        End If
    End Sub
End Class
