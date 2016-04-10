Imports MySql.Data.MySqlClient
Imports MyExam.ConnectDatabase
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
        If MessageBox.Show("แบบทดสอบยังไม่ถูกบันทึก คุณต้องการย้อนกลับใช่หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        Dim creat As New CreateForm(member, myTest)
        creat.Show()
        Close()
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        AddData()
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

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        If MessageBox.Show("บันทึกและเสร็จสิ้นการสร้างแบบทดสอบ", "บันทึก", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            AddData()
            Try
                Dim stm As String = "INSERT INTO myexam_test(id_member, name_test, type_test, access_test, time_test, createdate_test) VALUES(@id, @name, @type, @access, @time, @date)"
                Dim conn As New MySqlConnection(CONNECTSTRING)
                Dim cmd As New MySqlCommand(stm, conn)
                cmd.Parameters.AddWithValue("@id", member.ID)
                cmd.Parameters.AddWithValue("@name", myTest.Name)
                cmd.Parameters.AddWithValue("@type", myTest.Type.ToString)
                cmd.Parameters.AddWithValue("@access", myTest.Access)
                cmd.Parameters.AddWithValue("@time", myTest.Time)
                cmd.Parameters.AddWithValue("@date", Date.Now)
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()
                cmd.Connection.Close()
                stm = "SELECT id_test FROM myexam_test WHERE id_member = @id ORDER BY id_test DESC LIMIT 1"
                cmd.CommandText = stm
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@id", member.ID)
                cmd.Connection.Open()
                Dim result As MySqlDataReader = cmd.ExecuteReader()
                result.Read()
                myTest.ID = result.Item("id_test")
                cmd.Connection.Close()
                stm = "INSERT INTO myexam_test_information(id_test, name_information) VALUES(@id, @name)"
                cmd.CommandText = stm
                cmd.Parameters.Clear()
                For Each i As String In myTest.Information
                    cmd.Parameters.AddWithValue("@id", myTest.ID)
                    cmd.Parameters.AddWithValue("@name", i)
                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Connection.Close()
                    cmd.Parameters.Clear()
                Next
                stm = "INSERT INTO myexam_test_choice(id_test, question_choice, answer_choice, a_choice, b_choice, c_choice, d_choice) VALUES(@id, @question, @answer, @a, @b, @c, @d)"
                cmd.CommandText = stm
                cmd.Parameters.Clear()
                For Each i As TestChoice In data
                    cmd.Parameters.AddWithValue("@id", myTest.ID)
                    cmd.Parameters.AddWithValue("@question", i.Question)
                    cmd.Parameters.AddWithValue("@answer", i.Answer.ToString)
                    cmd.Parameters.AddWithValue("@a", i.ChoiceA.ToString)
                    cmd.Parameters.AddWithValue("@b", i.ChoiceB.ToString)
                    cmd.Parameters.AddWithValue("@c", i.ChoiceC.ToString)
                    cmd.Parameters.AddWithValue("@d", i.CHoiceD.ToString)
                    cmd.Connection.Open()
                    cmd.ExecuteNonQuery()
                    cmd.Connection.Close()
                    cmd.Parameters.Clear()
                Next
                cmd.Connection.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Error " & ex.Number, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Dim main As New MainForm(member)
            main.Show()
            Close()
        End If
    End Sub

    Private Sub AddData()
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
    End Sub
End Class
