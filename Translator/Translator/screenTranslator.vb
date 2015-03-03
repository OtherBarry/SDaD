Public Class screenTranslator
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        screenClose.Show()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        screenMain.Show()
    End Sub

    Private Sub screenFrench_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = uiLanguages(TN, LN) + " " + uilTrans(LN)
        btnExit.Text = uibExit(LN)
        btnHome.Text = uibHome(LN)
        lblPhrase.Text = uilPhrases(LN)
        lblTranslation.Text = uilTrans(LN)
        For x As Integer = 0 To 9
            cmbPhrase.Items(x) = Phrases(x, LN) + "?"
        Next
        If TN = 1 Then
            txtDescription.Text = DescriptionsFrench(LN, CN)
            Flag.BackgroundImage = FlagsFrench(CN)
        ElseIf TN = 2 Then
            txtDescription.Text = DescriptionsSpanish(LN, CN)
            Flag.BackgroundImage = FlagsSpanish(CN)
        ElseIf TN = 3 Then
            txtDescription.Text = DescriptionsPortuguese(LN, CN)
            Flag.BackgroundImage = FlagsPortugal(CN)
        Else
            txtDescription.Text = DescriptionsEnglish(LN, CN)
            Flag.BackgroundImage = FlagsEnglish(CN)
        End If
    End Sub

    Private Sub cmbPhrase_TextChanged(sender As Object, e As EventArgs) Handles cmbPhrase.TextChanged
        cmbOption.Visible = False
        txtOption.Visible = False
        Dim a() As String = (From item As String In cmbOption.Items Select item).ToArray
        Dim b As Integer = Array.IndexOf(a, cmbOption.SelectedItem)
        Dim x() As String = (From item As String In cmbPhrase.Items Select item).ToArray
        Dim y As Integer = Array.IndexOf(x, cmbPhrase.SelectedItem)
        If cmbPhrase.SelectedItem = Phrases(2, LN) + "?" Then
            cmbOption.Visible = True
            For c As Integer = 4 To 9
                cmbOption.Items(c) = " "
            Next
            For z As Integer = 0 To 3
                cmbOption.Items(z) = Transport(z, LN) + "?"
            Next
        ElseIf cmbPhrase.SelectedItem = Phrases(4, LN) + "?" Then
            cmbOption.Visible = True
            For z As Integer = 0 To 9
                cmbOption.Items(z) = Numbers(z, LN) + "..."
            Next
        ElseIf cmbPhrase.SelectedItem = Phrases(8, LN) + "?" Then
            txtOption.Visible = True
            txtOption.Text = uiLanguages(LN, LN) + "?"
        ElseIf cmbPhrase.SelectedItem = Phrases(9, LN) + "?" Then
            txtOption.Visible = True
            txtOption.Text = uiLanguages(TN, LN) + "."
        Else
            txtOption.Visible = False
            txtTranslation.Text = Phrases(y, TN) + "?"
            cmbOption.Visible = False
        End If
        If cmbOption.Visible Then
            If cmbOption.Text = "" Then
                txtTranslation.Text = Phrases(y, TN) + "?"
            ElseIf cmbOption.Text = " " Then
                txtTranslation.Text = Phrases(y, TN) + "?"
            ElseIf cmbPhrase.SelectedItem = Phrases(2, LN) Then
                txtTranslation.Text = Phrases(y, TN) + " " + Transport(b, TN) + "?"
            ElseIf cmbPhrase.SelectedItem = Phrases(4, LN) Then
                txtTranslation.Text = Phrases(y, TN) + " " + Numbers(b, TN) + "..."
            End If
        ElseIf txtOption.Visible Then
            If cmbPhrase.SelectedItem = Phrases(8, LN) + "?" Then
                txtTranslation.Text = Phrases(y, TN) + " " + uiLanguages(LN, TN) + "?"
            ElseIf cmbPhrase.SelectedItem = Phrases(9, LN) + "?" Then
                txtTranslation.Text = Phrases(y, TN) + " " + uiLanguages(TN, TN) + "."
            End If
        Else
            txtTranslation.Text = Phrases(y, TN) + "?"
        End If
    End Sub

    Private Sub cmbOption_TextChanged(sender As Object, e As EventArgs) Handles cmbOption.TextChanged
        Dim a() As String = (From item As String In cmbOption.Items Select item).ToArray
        Dim b As Integer = Array.IndexOf(a, cmbOption.SelectedItem)
        Dim x() As String = (From item As String In cmbPhrase.Items Select item).ToArray
        Dim y As Integer = Array.IndexOf(x, cmbPhrase.SelectedItem)
        If cmbOption.Visible Then
            If cmbOption.Text = "" Then
                txtTranslation.Text = Phrases(y, TN) + "?"
            ElseIf cmbOption.Text = " " Then
                txtTranslation.Text = Phrases(y, TN) + "?"
            ElseIf cmbPhrase.SelectedItem = Phrases(2, LN) + "?" Then
                For z As Integer = 0 To 3
                    cmbOption.Items(z) = Transport(z, LN) + "?"
                Next
                txtTranslation.Text = Phrases(y, TN) + " " + Transport(b, TN) + "?"
            ElseIf cmbPhrase.SelectedItem = Phrases(4, LN) + "?" Then
                For z As Integer = 0 To 9
                    cmbOption.Items(z) = Numbers(z, LN) + "..."
                Next
                txtTranslation.Text = Phrases(y, TN) + " " + Numbers(b, TN) + "..."
            End If
        End If
    End Sub
End Class