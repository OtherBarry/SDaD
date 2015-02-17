Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLeft.Text = ""
        txtRight.Text = ""
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Farenheit As Decimal
        Dim Celsius As Decimal
        If rdoSwitch.Text = "Celsius To Farenheit" Then
            If txtLeft.Text = "" Or txtLeft.Text = "Requires Input!" Then
                txtLeft.Text = "Requires Input!"
            ElseIf Decimal.Parse(txtLeft.Text) > -2147483648 Then
                Celsius = Decimal.Parse(txtLeft.Text)
                Farenheit = (1.8 * Celsius) + 32
                txtRight.Text = Farenheit
            ElseIf txtLeft.Text = "Input must be a number" Then
                txtLeft.Text = "Input must be a number"
            Else
                txtLeft.Text = "Input must be a number"
            End If
        ElseIf rdoSwitch.Text = "Farenheit To Celsius" Then
            If txtLeft.Text = "" Or txtLeft.Text = "Requires Input!" Then
                txtLeft.Text = "Requires Input!"
            ElseIf Decimal.Parse(txtLeft.Text) > -2147483648 Then
                Farenheit = Decimal.Parse(txtLeft.Text)
                Celsius = (Farenheit - 32) / 1.8
                txtRight.Text = Celsius
            ElseIf txtLeft.Text = "Input must be a number" Then
                txtLeft.Text = "Input must be a number"
            Else
                txtLeft.Text = "Input must be a number"
            End If
        Else
            txtLeft.Text = "Something Broke"
            txtRight.Text = "Something Broke"
        End If
    End Sub

    Private Sub rdoSwitch_Click(sender As Object, e As EventArgs) Handles rdoSwitch.Click
        If rdoSwitch.Text = "Celsius To Farenheit" Then
            rdoSwitch.Text = "Farenheit To Celsius"
            lblLeft.Text = "Farenheit"
            lblRight.Text = "Celsius"
        ElseIf rdoSwitch.Text = "Farenheit To Celsius" Then
            rdoSwitch.Text = "Celsius To Farenheit"
            lblLeft.Text = "Celsius"
            lblRight.Text = "Farenheit"
        Else
            rdoSwitch.Text = "Celsius To Farenheit"
            lblLeft.Text = "Celsius"
            lblRight.Text = "Farenheit"
            txtLeft.Text = "Something Broke"
            txtRight.Text = "Something Broke"
        End If
    End Sub
End Class
