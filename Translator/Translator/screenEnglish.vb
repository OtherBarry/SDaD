Public Class screenEnglish
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

    Private Sub screenEnglish_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = uiEnglish(LN) + " " + uilTrans(LN)
        btnClear.Text = uibClear(LN)
        btnExit.Text = uibExit(LN)
        btnHome.Text = uibHome(LN)
        lblPhrase.Text = uilPhrases(LN)
        lblTranslation.Text = uilTrans(LN)
        For x As Integer = 0 To 9
            cmbPhrase.Items(x) = Phrases(x, LN)
        Next
    End Sub
End Class