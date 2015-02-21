Public Class screenMain

    Private Sub screenMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = uilTrans(LN)
        btnExit.Text = uibExit(LN)
        btnOption.Text = uibOptions(LN)
        If LN = 1 Then
            rdoLeft.Text = uiEnglish(LN)
            rdoCente.Text = uiSpanish(LN)
            rdoRight.Text = uiPortuguese(LN)
        ElseIf LN = 2 Then
            rdoLeft.Text = uiEnglish(LN)
            rdoCente.Text = uiFrench(LN)
            rdoRight.Text = uiPortuguese(LN)
        ElseIf LN = 3 Then
            rdoLeft.Text = uiEnglish(LN)
            rdoCente.Text = uiFrench(LN)
            rdoRight.Text = uiSpanish(LN)
        Else
            rdoLeft.Text = uiFrench(LN)
            rdoCente.Text = uiSpanish(LN)
            rdoRight.Text = uiPortuguese(LN)
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
            Else
                screenFrench.Show()
            End If
        End If
    End Sub

    Private Sub rdoCente_Click(sender As Object, e As EventArgs) Handles rdoCente.Click
        If rdoCente.Enabled Then
            If LN > 1 Then
                screenFrench.Show()
            Else
                screenSpanish.Show()
            End If
        End If
    End Sub

    Private Sub rdoRight_Click(sender As Object, e As EventArgs) Handles rdoRight.Click
        If rdoRight.Enabled Then
            If LN < 3 Then
                screenPortuguese.Show()
            Else
                screenSpanish.Show()
            End If
        End If
    End Sub
End Class
