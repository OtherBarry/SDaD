Public Class screenMain

    Private Sub screenMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = uilTrans(LN)
        btnExit.Text = uibExit(LN)
        btnOption.Text = uibOptions(LN)
        GroupLanguage.Text = uilSelectLang(LN)
        GroupCountry.Text = uilSelectCountry(LN)
        chkLanguage.Text = uilFlags(LN) + " " + uilOn(LN)
        chkNation.Text = uilFlags(LN) + " " + uilOn(LN)
        If usrName = "" Then
            lblWelcome.Text = uilWelcome(LN) + ", User!"
        Else
            lblWelcome.Text = uilWelcome(LN) + ", " + usrName + "!"
        End If

        If LN = 1 Then
            rdoLeft.Text = uiLanguages(0, LN)
            rdoCente.Text = uiLanguages(2, LN)
            rdoRight.Text = uiLanguages(3, LN)
            flagLeft.BackgroundImage = FlagsEnglish(4)
            flagCenter.BackgroundImage = FlagsSpanish(4)
            flagRight.BackgroundImage = FlagsPortugal(5)
            txtLeft.Text = CountiresSpoken(LN, 0)
            txtCenter.Text = CountiresSpoken(LN, 2)
            txtRight.Text = CountiresSpoken(LN, 3)
        ElseIf LN = 2 Then
            rdoLeft.Text = uiLanguages(0, LN)
            rdoCente.Text = uiLanguages(1, LN)
            rdoRight.Text = uiLanguages(3, LN)
            flagLeft.BackgroundImage = FlagsEnglish(4)
            flagCenter.BackgroundImage = FlagsFrench(2)
            flagRight.BackgroundImage = FlagsPortugal(5)
            txtLeft.Text = CountiresSpoken(LN, 0)
            txtCenter.Text = CountiresSpoken(LN, 1)
            txtRight.Text = CountiresSpoken(LN, 3)
        ElseIf LN = 3 Then
            rdoLeft.Text = uiLanguages(0, LN)
            rdoCente.Text = uiLanguages(1, LN)
            rdoRight.Text = uiLanguages(2, LN)
            flagLeft.BackgroundImage = FlagsEnglish(4)
            flagCenter.BackgroundImage = FlagsFrench(2)
            flagRight.BackgroundImage = FlagsSpanish(4)
            txtLeft.Text = CountiresSpoken(LN, 0)
            txtCenter.Text = CountiresSpoken(LN, 1)
            txtRight.Text = CountiresSpoken(LN, 2)
        Else
            rdoLeft.Text = uiLanguages(1, LN)
            rdoCente.Text = uiLanguages(2, LN)
            rdoRight.Text = uiLanguages(3, LN)
            flagLeft.BackgroundImage = FlagsFrench(2)
            flagCenter.BackgroundImage = FlagsSpanish(4)
            flagRight.BackgroundImage = FlagsPortugal(5)
            txtLeft.Text = CountiresSpoken(LN, 1)
            txtCenter.Text = CountiresSpoken(LN, 2)
            txtRight.Text = CountiresSpoken(LN, 3)
        End If
    End Sub

    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        screenOptions.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        screenClose.Show()
    End Sub

    Private Sub rdoLeft_Click(sender As Object, e As EventArgs) Handles rdoLeft.Click
        lblCountry1.Visible = True
        lblCountry2.Visible = True
        lblCountry3.Visible = True
        lblCountry4.Visible = True
        lblCountry5.Visible = True
        lblCountry6.Visible = True
        btnCountry1.Visible = True
        btnCountry2.Visible = True
        btnCountry3.Visible = True
        btnCountry4.Visible = True
        btnCountry5.Visible = True
        btnCountry6.Visible = True
        If rdoRight.Checked Then
            If LN < 3 Then
                GlobalVariables.TN = 3
            Else
                GlobalVariables.TN = 0
            End If
        ElseIf rdoCente.Checked Then
            If LN > 1 Then
                GlobalVariables.TN = 1
            Else
                GlobalVariables.TN = 2
            End If
        ElseIf rdoLeft.Checked Then
            If LN > 0 Then
                GlobalVariables.TN = 0
            Else
                GlobalVariables.TN = 1
            End If
        Else
            GlobalVariables.TN = 0
        End If
        chkBox()
    End Sub

    Private Sub rdoCente_Click(sender As Object, e As EventArgs) Handles rdoCente.Click
        lblCountry1.Visible = True
        lblCountry2.Visible = True
        lblCountry3.Visible = True
        lblCountry4.Visible = True
        lblCountry5.Visible = True
        lblCountry6.Visible = True
        btnCountry1.Visible = True
        btnCountry2.Visible = True
        btnCountry3.Visible = True
        btnCountry4.Visible = True
        btnCountry5.Visible = True
        btnCountry6.Visible = True
        If rdoRight.Checked Then
            If LN < 3 Then
                GlobalVariables.TN = 3
            Else
                GlobalVariables.TN = 0
            End If
        ElseIf rdoCente.Checked Then
            If LN > 1 Then
                GlobalVariables.TN = 1
            Else
                GlobalVariables.TN = 2
            End If
        ElseIf rdoLeft.Checked Then
            If LN > 0 Then
                GlobalVariables.TN = 0
            Else
                GlobalVariables.TN = 1
            End If
        Else
            GlobalVariables.TN = 0
        End If
        chkBox()
    End Sub

    Private Sub rdoRight_Click(sender As Object, e As EventArgs) Handles rdoRight.Click
        lblCountry1.Visible = True
        lblCountry2.Visible = True
        lblCountry3.Visible = True
        lblCountry4.Visible = True
        lblCountry5.Visible = True
        lblCountry6.Visible = True
        btnCountry1.Visible = True
        btnCountry2.Visible = True
        btnCountry3.Visible = True
        btnCountry4.Visible = True
        btnCountry5.Visible = True
        btnCountry6.Visible = True
        If rdoRight.Checked Then
            If LN < 3 Then
                GlobalVariables.TN = 3
            Else
                GlobalVariables.TN = 0
            End If
        ElseIf rdoCente.Checked Then
            If LN > 1 Then
                GlobalVariables.TN = 1
            Else
                GlobalVariables.TN = 2
            End If
        ElseIf rdoLeft.Checked Then
            If LN > 0 Then
                GlobalVariables.TN = 0
            Else
                GlobalVariables.TN = 1
            End If
        Else
            GlobalVariables.TN = 0
        End If
        chkBox()
    End Sub

    Private Sub chkLanguage_CheckedChanged(sender As Object, e As EventArgs) Handles chkLanguage.CheckedChanged
        If chkLanguage.Checked Then
            flagLeft.Visible = True
            flagCenter.Visible = True
            flagRight.Visible = True
            chkLanguage.Text = uilFlags(LN) + " " + uilOn(LN)
        ElseIf chkLanguage.Checked = False Then
            flagLeft.Visible = False
            flagCenter.Visible = False
            flagRight.Visible = False
            chkLanguage.Text = uilFlags(LN) + " " + uilOff(LN)
        End If
    End Sub

    Private Sub chkNation_CheckedChanged(sender As Object, e As EventArgs) Handles chkNation.CheckedChanged
        If chkNation.Checked Then
            chkNation.Text = uilFlags(LN) + " " + uilOn(LN)
            If rdoLeft.Checked Or rdoCente.Checked Or rdoRight.Checked Then
                lblCountry1.Visible = True
                lblCountry2.Visible = True
                lblCountry3.Visible = True
                lblCountry4.Visible = True
                lblCountry5.Visible = True
                lblCountry6.Visible = True
            Else
                lblCountry1.Visible = False
                lblCountry2.Visible = False
                lblCountry3.Visible = False
                lblCountry4.Visible = False
                lblCountry5.Visible = False
                lblCountry6.Visible = False
            End If
            btnCountry1.Text = ""
            btnCountry2.Text = ""
            btnCountry3.Text = ""
            btnCountry4.Text = ""
            btnCountry5.Text = ""
            btnCountry6.Text = ""
            If TN = 1 Then
                lblCountry1.Text = NationsFrench(LN, 0)
                lblCountry2.Text = NationsFrench(LN, 1)
                lblCountry3.Text = NationsFrench(LN, 2)
                lblCountry4.Text = NationsFrench(LN, 3)
                lblCountry5.Text = NationsFrench(LN, 4)
                lblCountry6.Text = NationsFrench(LN, 5)
                btnCountry1.BackgroundImage = FlagsFrench(0)
                btnCountry2.BackgroundImage = FlagsFrench(1)
                btnCountry3.BackgroundImage = FlagsFrench(2)
                btnCountry4.BackgroundImage = FlagsFrench(3)
                btnCountry5.BackgroundImage = FlagsFrench(4)
                btnCountry6.BackgroundImage = FlagsFrench(5)
            ElseIf TN = 2 Then
                lblCountry1.Text = NationsSpanish(LN, 0)
                lblCountry2.Text = NationsSpanish(LN, 1)
                lblCountry3.Text = NationsSpanish(LN, 2)
                lblCountry4.Text = NationsSpanish(LN, 3)
                lblCountry5.Text = NationsSpanish(LN, 4)
                lblCountry6.Text = NationsSpanish(LN, 5)
                btnCountry1.BackgroundImage = FlagsSpanish(0)
                btnCountry2.BackgroundImage = FlagsSpanish(1)
                btnCountry3.BackgroundImage = FlagsSpanish(2)
                btnCountry4.BackgroundImage = FlagsSpanish(3)
                btnCountry5.BackgroundImage = FlagsSpanish(4)
                btnCountry6.BackgroundImage = FlagsSpanish(5)
            ElseIf TN = 3 Then
                lblCountry1.Text = NationsPortuguese(LN, 0)
                lblCountry2.Text = NationsPortuguese(LN, 1)
                lblCountry3.Text = NationsPortuguese(LN, 2)
                lblCountry4.Text = NationsPortuguese(LN, 3)
                lblCountry5.Text = NationsPortuguese(LN, 4)
                lblCountry6.Text = NationsPortuguese(LN, 5)
                btnCountry1.BackgroundImage = FlagsPortugal(0)
                btnCountry2.BackgroundImage = FlagsPortugal(1)
                btnCountry3.BackgroundImage = FlagsPortugal(2)
                btnCountry4.BackgroundImage = FlagsPortugal(3)
                btnCountry5.BackgroundImage = FlagsPortugal(4)
                btnCountry6.BackgroundImage = FlagsPortugal(5)
            Else
                lblCountry1.Text = NationsEnglish(LN, 0)
                lblCountry2.Text = NationsEnglish(LN, 1)
                lblCountry3.Text = NationsEnglish(LN, 2)
                lblCountry4.Text = NationsEnglish(LN, 3)
                lblCountry5.Text = NationsEnglish(LN, 4)
                lblCountry6.Text = NationsEnglish(LN, 5)
                btnCountry1.BackgroundImage = FlagsEnglish(0)
                btnCountry2.BackgroundImage = FlagsEnglish(1)
                btnCountry3.BackgroundImage = FlagsEnglish(2)
                btnCountry4.BackgroundImage = FlagsEnglish(3)
                btnCountry5.BackgroundImage = FlagsEnglish(4)
                btnCountry6.BackgroundImage = FlagsEnglish(5)
            End If
        ElseIf chkNation.Checked = False Then
            chkNation.Text = uilFlags(LN) + " " + uilOff(LN)
            lblCountry1.Visible = False
            lblCountry2.Visible = False
            lblCountry3.Visible = False
            lblCountry4.Visible = False
            lblCountry5.Visible = False
            lblCountry6.Visible = False
            btnCountry1.BackgroundImage = Nothing
            btnCountry2.BackgroundImage = Nothing
            btnCountry3.BackgroundImage = Nothing
            btnCountry4.BackgroundImage = Nothing
            btnCountry5.BackgroundImage = Nothing
            btnCountry6.BackgroundImage = Nothing
            If TN = 1 Then
                btnCountry1.Text = NationsFrench(LN, 0)
                btnCountry2.Text = NationsFrench(LN, 1)
                btnCountry3.Text = NationsFrench(LN, 2)
                btnCountry4.Text = NationsFrench(LN, 3)
                btnCountry5.Text = NationsFrench(LN, 4)
                btnCountry6.Text = NationsFrench(LN, 5)
            ElseIf TN = 2 Then
                btnCountry1.Text = NationsSpanish(LN, 0)
                btnCountry2.Text = NationsSpanish(LN, 1)
                btnCountry3.Text = NationsSpanish(LN, 2)
                btnCountry4.Text = NationsSpanish(LN, 3)
                btnCountry5.Text = NationsSpanish(LN, 4)
                btnCountry6.Text = NationsSpanish(LN, 5)
            ElseIf TN = 3 Then
                btnCountry1.Text = NationsPortuguese(LN, 0)
                btnCountry2.Text = NationsPortuguese(LN, 1)
                btnCountry3.Text = NationsPortuguese(LN, 2)
                btnCountry4.Text = NationsPortuguese(LN, 3)
                btnCountry5.Text = NationsPortuguese(LN, 4)
                btnCountry6.Text = NationsPortuguese(LN, 5)
            Else
                btnCountry1.Text = NationsEnglish(LN, 0)
                btnCountry2.Text = NationsEnglish(LN, 1)
                btnCountry3.Text = NationsEnglish(LN, 2)
                btnCountry4.Text = NationsEnglish(LN, 3)
                btnCountry5.Text = NationsEnglish(LN, 4)
                btnCountry6.Text = NationsEnglish(LN, 5)
            End If
        End If
    End Sub

    Private Sub btnCountry1_Click(sender As Object, e As EventArgs) Handles btnCountry1.Click
        GlobalVariables.CN = 0
        screenTranslator.Show()
        Me.Hide()
    End Sub

    Private Sub btnCountry2_Click(sender As Object, e As EventArgs) Handles btnCountry2.Click
        GlobalVariables.CN = 1
        screenTranslator.Show()
        Me.Hide()
    End Sub

    Private Sub btnCountry3_Click(sender As Object, e As EventArgs) Handles btnCountry3.Click
        GlobalVariables.CN = 2
        screenTranslator.Show()
        Me.Hide()
    End Sub

    Private Sub btnCountry4_Click(sender As Object, e As EventArgs) Handles btnCountry4.Click
        GlobalVariables.CN = 3
        screenTranslator.Show()
        Me.Hide()
    End Sub

    Private Sub btnCountry5_Click(sender As Object, e As EventArgs) Handles btnCountry5.Click
        GlobalVariables.CN = 4
        screenTranslator.Show()
        Me.Hide()
    End Sub

    Private Sub btnCountry6_Click(sender As Object, e As EventArgs) Handles btnCountry6.Click
        GlobalVariables.CN = 5
        screenTranslator.Show()
        Me.Hide()
    End Sub
End Class
