Public Class screenHome

    Private Sub screenHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        screenLoad.Hide()
    End Sub

    Private Sub lblArea_Click(sender As Object, e As EventArgs) Handles lblArea.Click
        Area = True
        screenSelect.Show()
    End Sub

    Private Sub lblVolume_Click(sender As Object, e As EventArgs) Handles lblVolume.Click
        Area = False
        screenSelect.Show()
    End Sub
End Class