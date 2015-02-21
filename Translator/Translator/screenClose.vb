Public Class screenClose

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        End
    End Sub

    Private Sub screenClose_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnNo.Text = uibNo(LN)
        btnYes.Text = uibYes(LN)
        lblQuestion.Text = uilQuit(LN)
        Me.Text = uibExit(LN)
    End Sub
End Class