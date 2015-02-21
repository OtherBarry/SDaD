Public Class screenMain

    Private Sub screenMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = uilTrans(LN)
        btnExit.Text = uibExit(LN)
        btnOption.Text = uibOptions(LN)
        If LN = 1 Then
            rdoLeft.Text = uiLanguages(0, LN)
            rdoCente.Text = uiLanguages(2, LN)
            rdoRight.Text = uiLanguages(3, LN)
        ElseIf LN = 2 Then
            rdoLeft.Text = uiLanguages(0, LN)
            rdoCente.Text = uiLanguages(1, LN)
            rdoRight.Text = uiLanguages(3, LN)
        ElseIf LN = 3 Then
            rdoLeft.Text = uiLanguages(0, LN)
            rdoCente.Text = uiLanguages(1, LN)
            rdoRight.Text = uiLanguages(2, LN)
        Else
            rdoLeft.Text = uiLanguages(1, LN)
            rdoCente.Text = uiLanguages(2, LN)
            rdoRight.Text = uiLanguages(3, LN)
        End If
    End Sub

    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        screenOpen.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        screenClose.Show()
    End Sub

    Private Sub rdoLeft_Click(sender As Object, e As EventArgs) Handles rdoLeft.Click
        If rdoLeft.Enabled Then
            If LN > 0 Then
                screenEnglish.Show()
                GlobalVariables.TN = 0
            Else
                screenFrench.Show()
                GlobalVariables.TN = 1
            End If
        End If
    End Sub

    Private Sub rdoCente_Click(sender As Object, e As EventArgs) Handles rdoCente.Click
        If rdoCente.Enabled Then
            If LN > 1 Then
                screenFrench.Show()
                GlobalVariables.TN = 1
            Else
                screenSpanish.Show()
                GlobalVariables.TN = 2
            End If
        End If
    End Sub

    Private Sub rdoRight_Click(sender As Object, e As EventArgs) Handles rdoRight.Click
        If rdoRight.Enabled Then
            If LN < 3 Then
                screenPortuguese.Show()
                GlobalVariables.TN = 3
            Else
                screenSpanish.Show()
                GlobalVariables.TN = 2
            End If
        End If
    End Sub
End Class
