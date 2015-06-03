Public Class screenHome

    Private Sub screenHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        screenLoad.Hide()
        My.Computer.Audio.Play(My.Resources.BatmanMain, AudioPlayMode.Background)
    End Sub

    Private Sub lblArea_Click(sender As Object, e As EventArgs) Handles lblArea.Click
        Area = True
        screenSelect.Show()
    End Sub

    Private Sub lblVolume_Click(sender As Object, e As EventArgs) Handles lblVolume.Click
        Area = False
        screenSelectVolume.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        screenExit.Show()
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = ColorTranslator.FromHtml("#FFDE21")
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Nothing
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles lblArea.MouseEnter
        lblArea.ForeColor = ColorTranslator.FromHtml("#FFDE21")
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles lblArea.MouseLeave
        lblArea.ForeColor = Color.Black
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles lblVolume.MouseEnter
        lblVolume.ForeColor = ColorTranslator.FromHtml("#FFDE21")
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles lblVolume.MouseLeave
        lblVolume.ForeColor = Color.Black
    End Sub
End Class