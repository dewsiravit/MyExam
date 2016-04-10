Public Class CreateChoiceForm
    Private myTest As Test
    Private data As New ArrayList
    Sub New(member As Member, myTest As Test)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.member = member
        Me.myTest = myTest
    End Sub
    Private Sub CreateChoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumberComboBox.Items.Add(data.Count + 1)
        NumberComboBox.SelectedIndex = data.Count
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Dim creat As New CreateForm(member, myTest)
        creat.Show()
        Close()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        Dim myChoice As New TestChoice
        myChoice.Question = QuestionRichTextBox.Text
        myChoice.ChoiceA = ChoiceARichTextBox.Text
        myChoice.ChoiceB = ChoiceBRichTextBox.Text
        myChoice.ChoiceC = ChoiceCRichTextBox.Text
        myChoice.CHoiceD = ChoiceDRichTextBox.Text
        If ChoiceARadioButton.Checked Then
            myChoice.Answer = 0
        ElseIf ChoiceBRadioButton.Checked Then
            myChoice.Answer = 1
        ElseIf ChoiceCRadioButton.Checked Then
            myChoice.Answer = 2
        ElseIf ChoiceDRadioButton.Checked Then
            myChoice.Answer = 3
        End If
        data.Add(myChoice)
        NumberComboBox.Items.Add(data.Count + 1)
        NumberComboBox.SelectedIndex = data.Count
        QuestionRichTextBox.Clear()
        ChoiceARichTextBox.Clear()
        ChoiceBRichTextBox.Clear()
        ChoiceCRichTextBox.Clear()
        ChoiceDRichTextBox.Clear()
        ChoiceARadioButton.Checked = True
    End Sub

    Private Sub NumberComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NumberComboBox.SelectedIndexChanged
        Dim choice As TestChoice
        Try
            choice = data.Item(NumberComboBox.SelectedIndex)
            QuestionRichTextBox.Text = choice.Question
            ChoiceARichTextBox.Text = choice.ChoiceA
            ChoiceBRichTextBox.Text = choice.ChoiceB
            ChoiceCRichTextBox.Text = choice.ChoiceC
            ChoiceDRichTextBox.Text = choice.CHoiceD
            Select Case choice.Answer
                Case 0 : ChoiceARadioButton.Checked = True
                Case 1 : ChoiceBRadioButton.Checked = True
                Case 2 : ChoiceCRadioButton.Checked = True
                Case 3 : ChoiceDRadioButton.Checked = True
            End Select
        Catch ex As Exception
            QuestionRichTextBox.Clear()
            ChoiceARichTextBox.Clear()
            ChoiceBRichTextBox.Clear()
            ChoiceCRichTextBox.Clear()
            ChoiceDRichTextBox.Clear()
            ChoiceARadioButton.Checked = True
        End Try
    End Sub

    Private Sub DeleteLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DeleteLinkLabel.LinkClicked
        If NumberComboBox.SelectedIndex > data.Count - 1 Then
            MessageBox.Show("ไม่สามารถลบได้", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        ElseIf MessageBox.Show("ต้องการที่จะลบข้อ " & NumberComboBox.SelectedIndex + 1 & " ใช่หรือไม่", "ยืนยันการลบ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        data.RemoveAt(NumberComboBox.SelectedIndex)
        Dim numTemp As Integer = NumberComboBox.SelectedIndex
        NumberComboBox.Items.Clear()
        For i As Integer = 0 To data.Count
            NumberComboBox.Items.Add(i + 1)
        Next
        NumberComboBox.SelectedIndex = numTemp
    End Sub
End Class
