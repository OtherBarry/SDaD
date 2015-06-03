Public Class screenQuiz
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        screenHome.Show()
        Me.Hide()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If questionNumber > 5 Then
            screenArea.Show()
            Me.Hide()
            Exit Sub
        End If
        questionNumber += 1
        txtQuestion.Text = QuestionsArea(questionNumber)
        lblComplete.Text = "Completed: " + questionNumber.ToString
        If RadioButtons(random).Checked = True Then
            correctNumber += 1
            lblCorrect.Text = "Correct: " + correctNumber.ToString
        End If
        Randomize()
        random = Rnd() * 3
        RadioButtons(random).Text = AnswersArea(0, questionNumber)
        If RadioButton1.Text = AnswersArea(0, questionNumber) Then
            RadioButton2.Text = AnswersArea(1, questionNumber)
            RadioButton3.Text = AnswersArea(2, questionNumber)
            RadioButton4.Text = AnswersArea(3, questionNumber)
        ElseIf RadioButton2.Text = AnswersArea(0, questionNumber) Then
            RadioButton1.Text = AnswersArea(1, questionNumber)
            RadioButton3.Text = AnswersArea(2, questionNumber)
            RadioButton4.Text = AnswersArea(3, questionNumber)
        ElseIf RadioButton3.Text = AnswersArea(0, questionNumber) Then
            RadioButton1.Text = AnswersArea(1, questionNumber)
            RadioButton2.Text = AnswersArea(2, questionNumber)
            RadioButton4.Text = AnswersArea(3, questionNumber)
        ElseIf RadioButton4.Text = AnswersArea(0, questionNumber) Then
            RadioButton1.Text = AnswersArea(1, questionNumber)
            RadioButton2.Text = AnswersArea(2, questionNumber)
            RadioButton3.Text = AnswersArea(3, questionNumber)
        End If
    End Sub

    Private Sub screenQuiz_Load(sender As Object, e As EventArgs) Handles Me.Load
        Randomize()
        random = Rnd() * 3
        txtQuestion.Text = QuestionsArea(0)
        RadioButtons(random).Text = AnswersArea(0, 0)
        If RadioButton1.Text = AnswersArea(0, 0) Then
            RadioButton2.Text = AnswersArea(1, 0)
            RadioButton3.Text = AnswersArea(2, 0)
            RadioButton4.Text = AnswersArea(3, 0)
        ElseIf RadioButton2.Text = AnswersArea(0, 0) Then
            RadioButton1.Text = AnswersArea(1, 0)
            RadioButton3.Text = AnswersArea(2, 0)
            RadioButton4.Text = AnswersArea(3, 0)
        ElseIf RadioButton3.Text = AnswersArea(0, 0) Then
            RadioButton1.Text = AnswersArea(1, 0)
            RadioButton2.Text = AnswersArea(2, 0)
            RadioButton4.Text = AnswersArea(3, 0)
        ElseIf RadioButton4.Text = AnswersArea(0, 0) Then
            RadioButton1.Text = AnswersArea(1, 0)
            RadioButton2.Text = AnswersArea(2, 0)
            RadioButton3.Text = AnswersArea(3, 0)
        End If
    End Sub
End Class