Public Class Converter

    Dim Hectares As Decimal
    Dim Morgens As Decimal
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtLeft.Value = 0
        txtRight.Value = 0
    End Sub

    Private Sub txtLeft_Click(sender As Object, e As EventArgs) Handles txtLeft.Click
        Morgens = txtLeft.Value
        If Hectares <> Morgens * 1.167498704 Then
            Hectares = Morgens * 1.167498704
            txtRight.Value = Hectares
        ElseIf Hectares = Morgens * 1.167498704 Or Morgens = Hectares * 0.856532 Then
            Morgens = txtLeft.Value
            Hectares = txtRight.Value
        Else
            txtLeft.Value = 0
            txtRight.Value = 0
            MsgBox("Error!")
        End If
    End Sub

    Private Sub txtLeft_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLeft.KeyPress
        Morgens = txtLeft.Value
        If Hectares <> Morgens * 1.167498704 Then
            Hectares = Morgens * 1.167498704
            txtRight.Value = Hectares
        ElseIf Hectares = Morgens * 1.167498704 Or Morgens = Hectares * 0.856532 Then
            Morgens = txtLeft.Value
            Hectares = txtRight.Value
        Else
            txtLeft.Value = 0
            txtRight.Value = 0
            MsgBox("Error!")
        End If
    End Sub

    Private Sub txtRight_Click(sender As Object, e As EventArgs) Handles txtRight.Click
        Hectares = txtRight.Value
        If Morgens <> Hectares * 0.856532 Then
            Morgens = Hectares * 0.856532
            txtLeft.Value = Morgens
        ElseIf Hectares = Morgens * 1.167498704 Or Morgens = Hectares * 0.856532 Then
            Morgens = txtLeft.Value
            Hectares = txtRight.Value
        Else
            txtLeft.Value = 0
            txtRight.Value = 0
            MsgBox("Error!")
        End If
    End Sub

    Private Sub txtRight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRight.KeyPress
        Hectares = txtRight.Value
        If Morgens <> Hectares * 0.856532 Then
            Morgens = Hectares * 0.856532
            txtLeft.Value = Morgens
        ElseIf Hectares = Morgens * 1.167498704 Or Morgens = Hectares * 0.856532 Then
            Morgens = txtLeft.Value
            Hectares = txtRight.Value
        Else
            txtLeft.Value = 0
            txtRight.Value = 0
            MsgBox("Error!")
        End If
    End Sub

    Private Sub hsbScale_ValueChanged(sender As Object, e As EventArgs) Handles hsbScale.ValueChanged
        Morgens = hsbScale.Value
        Hectares = Morgens * 1.167498704
        txtLeft.Value = Morgens
        txtRight.Value = Hectares
    End Sub

    Private Sub txtWhatIs_Click(sender As Object, e As EventArgs) Handles txtWhatIs.Click
        MsgBox("What is a Morgen you ask?   A Morgen is a Dutch unit of measurement that is intended to describe the area 'a man behind an ox can till in the morning hours of the day'. This is where the name Morgen comes from, as it means morning in Dutch, German and Danish. This converter is very useful, as the Morgen was the official unit of measurement in South Arica until 1970, so many older documents use it.")
    End Sub
End Class
