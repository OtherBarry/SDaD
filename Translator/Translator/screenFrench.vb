Public Class screenFrench
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        screenClose.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        screenMain.Show()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cmbPhrase.Text = ""
    End Sub

    Private Sub screenFrench_Load(sender As Object, e As EventArgs) Handles Me.Load
        If usrLanguage = Language(2) Then
            btnClear.Text = "Claro"
            btnExit.Text = "Salida"
            btnHome.Text = "Casa"
            lblPhrase.Text = "Frase"
            lblTranslation.Text = "Traducción"
        ElseIf usrLanguage = Language(3) Then
            btnClear.Text = "Claro"
            btnExit.Text = "Saída"
            btnHome.Text = "Casa"
            lblPhrase.Text = "Frase"
            lblTranslation.Text = "Tradução"
        Else
            btnClear.Text = "Clear"
            btnExit.Text = "Exit"
            btnHome.Text = "Home"
            lblPhrase.Text = "Phrase"
            lblTranslation.Text = "Translation"
        End If
        For x As Integer = 0 To 9
            cmbPhrase.Items(x) = Phrases(x, 1)
        Next
    End Sub
End Class