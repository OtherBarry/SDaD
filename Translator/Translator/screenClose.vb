Public Class screenClose

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Hide()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        End
    End Sub

    Private Sub screenClose_Load(sender As Object, e As EventArgs) Handles Me.Load
        If usrLanguage = Language(1) Then
            btnNo.Text = "Non"
            btnYes.Text = "Oui"
            lblQuestion.Text = "Êtes-vous sûr de vouloir quitter?"
        ElseIf usrLanguage = Language(2) Then
            btnNo.Text = "No"
            btnYes.Text = "Sí"
            lblQuestion.Text = "¿Seguro que quieres salir?"
        ElseIf usrLanguage = Language(3) Then
            btnNo.Text = "Não"
            btnYes.Text = "Sim"
            lblQuestion.Text = "Tem certeza de que deseja sair?"
        Else
            btnNo.Text = "No"
            btnYes.Text = "Yes"
            lblQuestion.Text = "Are you sure you want to exit?"
        End If
    End Sub
End Class