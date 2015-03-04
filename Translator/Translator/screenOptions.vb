Public Class screenOptions

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        screenClose.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        screenMain.Close()
        screenMain.Show()
        Me.Hide()
    End Sub

    Private Sub cmbLanguage_TextChanged(sender As Object, e As EventArgs) Handles cmbLanguage.TextChanged
        GlobalVariables.usrLanguage = cmbLanguage.Text
        GlobalVariables.LN = Array.IndexOf(Language, cmbLanguage.Text)
        btnExit.Text = uibExit(LN)
        btnNext.Text = uibNext(LN)
        lblLanguage.Text = uilSelectLang(LN)
        lblName.Text = uilName(LN)
        Me.Text = uilTrans(LN)
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        GlobalVariables.usrName = txtName.Text
    End Sub

    Private Sub screenOptions_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnExit.Text = uibExit(LN)
        btnNext.Text = uibHome(LN)
        lblLanguage.Text = uilSelectLang(LN)
        lblName.Text = uilName(LN)
        Me.Text = uilTrans(LN)
    End Sub
End Class