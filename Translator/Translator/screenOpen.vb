Public Class screenOpen

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        screenClose.Show()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        screenMain.Show()
    End Sub

    Private Sub cmbLanguage_TextChanged(sender As Object, e As EventArgs) Handles cmbLanguage.TextChanged
        varStorage.usrLanguage = cmbLanguage.Text
        If usrLanguage = Language(1) Then
            btnExit.Text = "Sortie"
            btnNext.Text = "Suivant"
            If usrName = "" Then
                lblHello.Text = "Bonjour User!"
            Else
                lblHello.Text = "Bonjour " + usrName + "!"
            End If
            lblLanguage.Text = "Sélectionner une langue:"
            lblName.Text = "Quel est votre nom?"
        ElseIf usrLanguage = Language(2) Then
            btnExit.Text = "Salida"
            btnNext.Text = "Siguiente"
            If usrName = "" Then
                lblHello.Text = "Hola User!"
            Else
                lblHello.Text = "Hola " + usrName + "!"
            End If
            lblLanguage.Text = "Seleccione un idioma:"
            lblName.Text = "Cuál es tu nombre?"
        ElseIf usrLanguage = Language(3) Then
            btnExit.Text = "Saída"
            btnNext.Text = "Seguinte"
            If usrName = "" Then
                lblHello.Text = "Olá User!"
            Else
                lblHello.Text = "Olá " + usrName + "!"
            End If
            lblLanguage.Text = "Selecione o idioma:"
            lblName.Text = "Qual é o seu nome?"
        Else
            btnExit.Text = "Exit"
            btnNext.Text = "Next"
            If usrName = "" Then
                lblHello.Text = "Hello User!"
            Else
                lblHello.Text = "Hello " + usrName + "!"
            End If
            lblLanguage.Text = "Please select a language:"
            lblName.Text = "What is your name?"
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        varStorage.usrName = txtName.Text
        If usrLanguage = Language(1) Then
            lblHello.Text = "Bonjour " + usrName + "!"
        ElseIf usrLanguage = Language(2) Then
            lblHello.Text = "Hola " + usrName + "!"
        ElseIf usrLanguage = Language(3) Then
            lblHello.Text = "Olá " + usrName + "!"
        ElseIf usrName = "" Then
            If usrLanguage = Language(0) Then
                lblHello.Text = "Hello User!"
            ElseIf usrLanguage = Language(1) Then
                lblHello.Text = "Bonjour User!"
            ElseIf usrLanguage = Language(2) Then
                lblHello.Text = "Hola User!"
            ElseIf usrLanguage = Language(3) Then
                lblHello.Text = "Olá User!"
            End If
        Else
            lblHello.Text = "Hello " + usrName + "!"
        End If
    End Sub

End Class