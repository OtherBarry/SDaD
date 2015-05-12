Public Class screenSelect

    Private Sub screenSelect_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackColor = ColorTranslator.FromHtml("#36454F")
        screenHome.Hide()
        picSquare.BackColor = Color.Transparent
        picCircle.Image = Nothing
        picTriangle.Image = Nothing
        If Area = True Then

        End If
    End Sub

    Private Sub CircleClick(sender As Object, e As EventArgs) Handles lblCircle.Click, picCircle.Click
        If Area = True Then
            Shape = "Circle"
            screenArea.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub SquareClick(sender As Object, e As EventArgs) Handles lblSquare.Click, picSquare.Click
        If Area = True Then
            Shape = "Square"
            screenArea.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TriangleClick(sender As Object, e As EventArgs) Handles lblTriangle.Click, picTriangle.Click
        If Area = True Then
            Shape = "Triangle"
            screenArea.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub picCircle_MouseEnter(sender As Object, e As EventArgs) Handles picCircle.MouseEnter, lblCircle.MouseEnter
        If Area = True Then
            picCircle.Image = My.Resources.botmon
            lblCircle.Text = ""
        End If
    End Sub

    Private Sub picCircle_MouseLeave(sender As Object, e As EventArgs) Handles picCircle.MouseLeave, lblCircle.MouseLeave
        If Area = True Then
            picCircle.Image = Nothing
            lblCircle.Text = "Circle"
        End If
    End Sub

    Private Sub picSquare_MouseEnter(sender As Object, e As EventArgs) Handles picSquare.MouseEnter, lblSquare.MouseEnter
        If Area = True Then
            picSquare.BackColor = ColorTranslator.FromHtml("#F1C143")
            lblSquare.Text = ""
        End If
    End Sub

    Private Sub picSquare_MouseLeave(sender As Object, e As EventArgs) Handles picSquare.MouseLeave, lblSquare.MouseLeave
        If Area = True Then
            picSquare.BackColor = Color.Transparent
            lblSquare.Text = "Square"
        End If
    End Sub

    Private Sub picTriangle_MouseEnter(sender As Object, e As EventArgs) Handles picTriangle.MouseEnter, lblTriangle.MouseEnter
        If Area = True Then
            picTriangle.Image = My.Resources.botmon
            lblTriangle.Text = ""
        End If
    End Sub

    Private Sub picTriangle_MouseLeave(sender As Object, e As EventArgs) Handles picTriangle.MouseLeave, lblTriangle.MouseLeave
        If Area = True Then
            picTriangle.Image = Nothing
            lblTriangle.Text = "Traingle"
        End If
    End Sub
End Class