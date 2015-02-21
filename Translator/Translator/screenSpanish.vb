Public Class screenSpanish
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

    Private Sub screenSpanish_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = uiLanguages(TN, LN) + " " + uilTrans(LN)
        btnClear.Text = uibClear(LN)
        btnExit.Text = uibExit(LN)
        btnHome.Text = uibHome(LN)
        lblPhrase.Text = uilPhrases(LN)
        lblTranslation.Text = uilTrans(LN)
        For x As Integer = 0 To 9
            cmbPhrase.Items(x) = Phrases(x, LN)
        Next
    End Sub

    Private Sub cmbPhrase_TextChanged(sender As Object, e As EventArgs) Handles cmbPhrase.TextChanged
        txtOption.Visible = False
        cmbOption.Visible = False
        For x As Integer = 0 To 9
            cmbOption.Items(x) = " "
        Next
        If cmbPhrase.SelectedItem = Phrases(2, LN) Then
            cmbOption.Visible = True
            For x As Integer = 0 To 3
                cmbOption.Items(x) = Transport(x, LN) + "?"
            Next
        ElseIf cmbPhrase.SelectedItem = Phrases(4, LN) Then
            cmbOption.Visible = True
            For x As Integer = 0 To 9
                cmbOption.Items(x) = Numbers(x, LN) + "..."
            Next
        ElseIf cmbPhrase.SelectedItem = Phrases(8, LN) Then
            txtOption.Visible = True
            txtOption.Text = uiLanguages(LN, LN) + "?"
        ElseIf cmbPhrase.SelectedItem = Phrases(9, LN) Then
            txtOption.Visible = True
            txtOption.Text = uiLanguages(TN, LN) + "."
        End If
    End Sub
End Class