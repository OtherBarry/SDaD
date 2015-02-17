Public Class Form1

    Private Sub btnDisplay_Click(sender As Object, e As System.EventArgs) Handles btnDisplay.Click
        txtGreeting.Text = "How are you today?"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As System.EventArgs) Handles btnClear.Click
        txtGreeting.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As System.EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
