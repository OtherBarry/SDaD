Public Class screenSelect

    Private Sub screenSelect_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackColor = ColorTranslator.FromHtml("#36454F")
        screenHome.Hide()
        picSquare.BackColor = ColorTranslator.FromHtml("#F1C143")
        picCircle.Image = Nothing
    End Sub

    Private Sub CircleClick(sender As Object, e As EventArgs) Handles lblCircle.Click, picCircle.Click
        ShapeType = "Circle"
        screenArea.Show()
        Me.Hide()
    End Sub

    Private Sub picCircle_MouseEnter(sender As Object, e As EventArgs) Handles picCircle.MouseEnter, lblCircle.MouseEnter
        picCircle.Image = My.Resources.botmon
        lblCircle.Visible = False
    End Sub

    Private Sub picCircle_MouseLeave(sender As Object, e As EventArgs) Handles picCircle.MouseLeave, lblCircle.MouseLeave
        picCircle.Image = Nothing
        lblCircle.Visible = True
    End Sub
End Class