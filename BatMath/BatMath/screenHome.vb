Public Class screenHome

    Private Sub screenHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackColor = ColorTranslator.FromHtml("#36454F")
        screenLoad.Hide()
    End Sub

    Private Sub lblArea_Click(sender As Object, e As EventArgs) Handles lblArea.Click
        ShapeType = "Area"
        screenSelect.Show()
    End Sub

    Private Sub lblVolume_Click(sender As Object, e As EventArgs) Handles lblVolume.Click
        ShapeType = "Volume"
        screenSelect.Show()
    End Sub
End Class