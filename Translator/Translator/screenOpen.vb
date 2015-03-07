Public Class screenOpen

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        screenClose.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If usrName = "" Then
            GlobalVariables.usrName = "User"
        End If
        screenMain.Close()
        screenMain.Show()
        Me.Hide()
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        GlobalVariables.usrName = txtName.Text
            If usrName = "" Then
                lblHello.Text = uilHello(LN) + " User!"
            Else
                lblHello.Text = uilHello(LN) + " " + usrName + "!"
            End If
    End Sub

    Private Sub cmbLanguage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLanguage.SelectedIndexChanged
        GlobalVariables.usrLanguage = cmbLanguage.Text
        GlobalVariables.LN = Array.IndexOf(Language, cmbLanguage.Text)
        btnExit.Text = uibExit(LN)
        btnNext.Text = uibNext(LN)
        If usrName = "" Then
            lblHello.Text = uilHello(LN) + " User!"
        Else
            lblHello.Text = uilHello(LN) + " " + usrName + "!"
        End If
        lblLanguage.Text = uilSelectLang(LN)
        lblName.Text = uilName(LN)
        Me.Text = uilTrans(LN)
    End Sub
End Class