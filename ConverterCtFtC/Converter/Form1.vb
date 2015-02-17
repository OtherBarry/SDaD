Public Class Converter

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLeft.Text = ""
        txtRight.Text = ""
    End Sub

    Private Sub rdoSwitch_Click(sender As Object, e As EventArgs) Handles rdoSwitch.Click
        If rdoSwitch.Text = "Celcius To Farenheit" Then
            rdoSwitch.Text = "Farenheit To Celcius"
            txtLeft.Text = "Farenheit"
            txtRight.Text = "Celcius"
        ElseIf rdoSwitch.Text = "Farenheit to Celcius" Then
            rdoSwitch.Text = "Celcius To Farenheit"
            txtLeft.Text = "Celcius"
            txtRight.Text = "Farenheit"
        Else
            rdoSwitch.Text = "Celcius To Farenheit"
            txtRight.Text = "Something Broke"
            txtLeft.Text = "Something Broke"
        End If
    End Sub
End Class
