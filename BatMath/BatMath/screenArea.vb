Public Class screenArea

    Private Sub screenArea_Load(sender As Object, e As EventArgs) Handles Me.Load
        screenSelect.Hide()
        Me.BackColor = ColorTranslator.FromHtml("#36454F")
        input1.BackColor = ColorTranslator.FromHtml("#FCE5C3")
        input2.BackColor = ColorTranslator.FromHtml("#FCE5C3")
        input3.BackColor = ColorTranslator.FromHtml("#FCE5C3")
        lbl2.Visible = False
        input2.Visible = False
        lbl3.Visible = False
        input3.Visible = False
        lblTitle.Text = Shapes2D(ShapeNum)
        If ShapeNum = 0 Then 'Circle
            picShape.Image = My.Resources.circle
            lbl1.Text = "Radius Length"
            AreaVal = (input1.Value ^ 2) * pi
            Output1.Text = input1.Value.ToString + "² × pi = " + Decimal.Round(AreaVal, 0, MidpointRounding.AwayFromZero).ToString + " cm²"
        ElseIf ShapeNum = 1 Then 'Square
            picShape.Image = My.Resources.square
            lbl1.Text = "Side Length"
            AreaVal = input1.Value ^ 2
            Output1.Text = input1.Value.ToString + "² = " + Decimal.Round(AreaVal, 0, MidpointRounding.AwayFromZero).ToString + " cm²"
        ElseIf ShapeNum = 3 Then 'Hexagon
            picShape.Image = My.Resources.hexagon
            lbl1.Text = "Side Length"
            AreaVal = ((3 * Math.Sqrt(3.0)) / 2) * (input1.Value ^ 2)
            Output1.Text = "2.6 × " + input1.Value.ToString + "² = " + Decimal.Round(AreaVal, 0, MidpointRounding.AwayFromZero).ToString + " cm²"
        ElseIf ShapeNum = 4 Then 'Pentagon
            picShape.Image = My.Resources.pentagon
            lbl1.Text = "Side Length"
            AreaVal = 1.72 * (input1.Value ^ 2)
            Output1.Text = "1.72 × " + input1.Value.ToString + "² = " + Decimal.Round(AreaVal, 0, MidpointRounding.AwayFromZero).ToString + " cm²"
        ElseIf ShapeNum = 2 Then 'Triangle
            picShape.Image = My.Resources.triangle
            lbl1.Text = "Base Length"
            lbl2.Text = "Height"
            lbl2.Visible = True
            input2.Visible = True
            AreaVal = 0.5 * input1.Value * input2.Value
            Output1.Text = input1.Value.ToString + " × " + input2.Value.ToString + " = " + Decimal.Round(AreaVal, 0, MidpointRounding.AwayFromZero).ToString + " cm²"
        ElseIf ShapeNum = 5 Then 'Rectangle
            picShape.Image = My.Resources.rectangle
            lbl2.Visible = True
            input2.Visible = True
            lbl1.Text = "Base Length"
            lbl2.Text = "Height"
            AreaVal = input1.Value * input2.Value
            Output1.Text = input1.Value.ToString + " × " + input2.Value.ToString + " = " + Decimal.Round(AreaVal, 0, MidpointRounding.AwayFromZero).ToString + " cm²"
        End If
        Me.lblTitle.Left = (Me.lblTitle.Width \ 2) - (Me.lblTitle.Width \ 2)
    End Sub

    Private Sub ValueChanged(sender As Object, e As EventArgs) Handles input1.ValueChanged, input2.ValueChanged, input3.ValueChanged
        If ShapeNum = 0 Then 'Circle
            AreaVal = (input1.Value ^ 2) * pi
            Output1.Text = input1.Value.ToString + "² × pi = " + Decimal.Round(AreaVal, 0, MidpointRounding.AwayFromZero).ToString + " cm²"
        ElseIf ShapeNum = 1 Then 'Square
            AreaVal = input1.Value ^ 2
            Output1.Text = input1.Value.ToString + "² = " + Decimal.Round(AreaVal, 0, MidpointRounding.AwayFromZero).ToString + " cm²"
        ElseIf ShapeNum = 2 Then 'Triangle
            AreaVal = 0.5 * input1.Value * input2.Value
            Output1.Text = input1.Value.ToString + " × " + input2.Value.ToString + " = " + Decimal.Round(AreaVal, 0, MidpointRounding.AwayFromZero).ToString + " cm²"
        ElseIf ShapeNum = 3 Then 'Hexagon
            AreaVal = ((3 * Math.Sqrt(3.0)) / 2) * (input1.Value ^ 2)
            Output1.Text = "2.6 × " + input1.Value.ToString + "² = " + Decimal.Round(AreaVal, 0, MidpointRounding.AwayFromZero).ToString + " cm²"
        ElseIf ShapeNum = 5 Then 'Rectangle
            AreaVal = input1.Value * input2.Value
            Output1.Text = input1.Value.ToString + " × " + input2.Value.ToString + " = " + Decimal.Round(AreaVal, 0, MidpointRounding.AwayFromZero).ToString + " cm²"
        ElseIf ShapeNum = 4 Then 'Pentagon
            AreaVal = 1.72 * (input1.Value ^ 2)
            Output1.Text = "1.72 × " + input1.Value.ToString + "² = " + Decimal.Round(AreaVal, 0, MidpointRounding.AwayFromZero).ToString + " cm²"
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        screenHome.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        screenQuiz.Show()
        Me.Hide()
    End Sub
End Class