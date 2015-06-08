Public Class screenStart

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        screenGame.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
        Me.BackColor = Black
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblStart.Visible = False Then
            lblStart.Visible = True
        Else
            lblStart.Visible = False
        End If
    End Sub
End Class
