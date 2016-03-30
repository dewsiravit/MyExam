Public Class CreateForm
    Private Const PINSUGGEST = "กำหนดรหัส"
    Private Sub CreateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TypeComboBox.SelectedIndex = 0
        PublicRadioButton.Checked = True
        NoLimitRadioButton.Checked = True
        TimeTextBox.Enabled = False
        PinTextBox.Enabled = False
        PinTextBox.Text = PINSUGGEST
        VisiblePinLinkLabel.Enabled = False
        ErrorNameLabel.ResetText()
        ErrorAddInformationLabel.ResetText()
        InformationCheckedListBox.SetItemChecked(0, True)
        ActiveControl = NameTextBox
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
        MainForm.Show()
        Close()
    End Sub

    Private Sub LimitTimeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles LimitTimeRadioButton.CheckedChanged
        If LimitTimeRadioButton.Checked Then
            TimeTextBox.Enabled = True
        Else
            TimeTextBox.Enabled = False
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
        CreateChoiceForm.Show()
        Close()
    End Sub
End Class
