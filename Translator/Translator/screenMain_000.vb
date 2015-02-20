﻿<?xml version="1.0" encoding="UTF-8" standalone="yes"?>
<assembly xmlns="urn:schemas-microsoft-com:asm.v1" manifestVersion="1.0">
  <assemblyIdentity version="1.0.0.0" name="MyApplication.app"/>
  <trustInfo xmlns="urn:schemas-microsoft-com:asm.v2">
    <security>
      <requestedPrivileges xmlns="urn:schemas-microsoft-com:asm.v3">
        <requestedExecutionLevel level="asInvoker" uiAccess="false"/>
      </requestedPrivileges>
    </security>
  </trustInfo>
</assembly>
                      .Text = uirPortuguese(usrLangNumb)
        ElseIf usrLanguage = Language(2) Then
            rdoLeft.Text = uirEnglish(usrLangNumb)
            rdoCenter.Text = uirFrench(usrLangNumb)
            rdoRight.Text = uirPortuguese(usrLangNumb)
        ElseIf usrLanguage = Language(3) Then
            rdoLeft.Text = uirEnglish(usrLangNumb)
            rdoCenter.Text = uirFrench(usrLangNumb)
            rdoRight.Text = uirSpanish(usrLangNumb)
        Else
            rdoLeft.Text = uirFrench(usrLangNumb)
            rdoCenter.Text = uirSpanish(usrLangNumb)
            rdoRight.Text = uirPortuguese(usrLangNumb)
        End If
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        screenOpen.Show()
    End Sub

    Private Sub rdoLeft_Click(sender As Object, e As EventArgs) Handles rdoLeft.Click
        GlobalVariables.txtLeft = rdoLeft.Text
        If uirFrench.Contains(txtLeft) Then
            screenFrench.Show()
        ElseIf uirSpanish.Contains(rdoLeft.Text.ToString) Then
            screenSpanish.Show()
        ElseIf uirPortuguese.Contains(rdoLeft.Text.ToString) Then
            screenPortuguese.Show()
        Else
            screenEnglish.Show()
        End If
    End Sub

    Private Sub rdoCenter_Click(sender As Object, e As EventArgs) Handles rdoCenter.Click
        If uirFrench.Contains(rdoCenter.Text.ToString) Then
            screenFrench.Show()
        ElseIf uirSpanish.Contains(rdoCenter.Text.ToString) Then
            screenSpanish.Show()
        ElseIf uirPortuguese.Contains(rdoCenter.Text.ToString) Then
            screenPortuguese.Show()
        Else
            screenEnglish.Show()
        End If
    End Sub

    Private Sub rdoRight_Click(sender As Object, e As EventArgs) Handles rdoRight.Click
        If uirFrench.Contains(rdoRight.Text.ToString) Then
            screenFrench.Show()
        ElseIf uirSpanish.Contains(rdoRight.Text.ToString) Then
            screenSpanish.Show()
        ElseIf uirPortuguese.Contains(rdoRight.Text.ToString) Then
            screenPortuguese.Show()
        Else
            screenEnglish.Show()
        End If
    End Sub
End Class
