Public Class screenVolume

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        screenHome.Show()
        Me.Close()
    End Sub

    Private Sub screenVolume_Load(sender As Object, e As EventArgs) Handles Me.Load
        screenSelectVolume.Hide()
        Label3.Text = "The formula for the area of a " + Shapes3D(ShapeNum) + " is " + AnswersVolume(0, ShapeNum)
        Me.BackColor = ColorTranslator.FromHtml("#36454F")
        input1.BackColor = ColorTranslator.FromHtml("#5e7889")
        input2.BackColor = ColorTranslator.FromHtml("#5e7889")
        input3.BackColor = ColorTranslator.FromHtml("#5e7889")
        lbl3.Visible = False
        input3.Visible = False
        lblTitle.Text = Shapes3D(ShapeNum)
        If ShapeNum = 0 Then 'Sphere
            lbl2.Visible = False
            input2.Visible = False
            picShape.Image = My.Resources.blue_sphere
            lbl1.Text = "Radius"
            Volume = (4 / 3) * pi * (input1.Value ^ 3)
            Output1.Text = "¾ × pi × " + input1.Value.ToString + "³ = " + Decimal.Round(Volume, 0, MidpointRounding.AwayFromZero).ToString + " cm³"
        ElseIf ShapeNum = 1 Then 'Cube
            lbl2.Visible = False
            input2.Visible = False
            picShape.Image = My.Resources.blue_cube
            lbl1.Text = "Side Length"
            Volume = input1.Value ^ 3
            Output1.Text = input1.Value.ToString + "³ = " + Decimal.Round(Volume, 0, MidpointRounding.AwayFromZero).ToString + " cm³"
        ElseIf ShapeNum = 2 Then 'Cone
            picShape.Image = My.Resources.blue_cone
            lbl1.Text = "Radius"
            lbl2.Text = "Height"
            Volume = pi * (input1.Value ^ 2) * (input2.Value / 3)
            Output1.Text = "pi × " + input1.Value.ToString + "² × (" + input2.Value.ToString + " ÷ 3) = " + Decimal.Round(Volume, 0, MidpointRounding.AwayFromZero).ToString + " cm³"
        ElseIf ShapeNum = 3 Then 'Pyramid
            lbl3.Visible = True
            input3.Visible = True
            picShape.Image = My.Resources.blue_square_pyramid
            lbl1.Text = "Radius"
            lbl2.Text = "Length"
            lbl3.Text = "Width"
            Volume = (input1.Value * input2.Value * input3.Value) / 3
            Output1.Text = "(" + input1.Value.ToString + " × " + input2.Value.ToString + " × " + input3.Value.ToString + ") ÷ 3  = " + Decimal.Round(Volume, 0, MidpointRounding.AwayFromZero).ToString + " cm³"
        ElseIf ShapeNum = 4 Then 'Rectangular Prism
            lbl3.Visible = True
            input3.Visible = True
            picShape.Image = My.Resources.blue_cuboid
            lbl1.Text = "Radius"
            lbl2.Text = "Length"
            lbl3.Text = "Width"
            Volume = input1.Value * input2.Value * input3.Value
            Output1.Text = input1.Value.ToString + " × " + input2.Value.ToString + " × " + input3.Value.ToString + " = " + Decimal.Round(Volume, 0, MidpointRounding.AwayFromZero).ToString + " cm³"
        ElseIf ShapeNum = 5 Then 'Cylinder
            picShape.Image = My.Resources.blue_cylinder
            lbl2.Visible = True
            input2.Visible = True
            lbl1.Text = "Radius"
            lbl2.Text = "Height"
            Volume = pi * (input1.Value ^ 2) * input2.Value
            Output1.Text = input1.Value.ToString + "² × " + input2.Value.ToString + " × pi = " + Decimal.Round(Volume, 0, MidpointRounding.AwayFromZero).ToString + " cm³"
        End If
        Me.lblTitle.Left = (Me.lblTitle.Width \ 2) - (Me.lblTitle.Width \ 2)
    End Sub

    Private Sub input1_ValueChanged(sender As Object, e As EventArgs) Handles input1.ValueChanged, input2.ValueChanged, input3.ValueChanged
        If ShapeNum = 0 Then 'Sphere
            lbl2.Visible = False
            input2.Visible = False
            picShape.Image = My.Resources.blue_sphere
            lbl1.Text = "Radius"
            Volume = (4 / 3) * pi * (input1.Value ^ 3)
            Output1.Text = "¾ × pi × " + input1.Value.ToString + "³ = " + Decimal.Round(Volume, 0, MidpointRounding.AwayFromZero).ToString + " cm³"
        ElseIf ShapeNum = 1 Then 'Cube
            lbl2.Visible = False
            input2.Visible = False
            picShape.Image = My.Resources.blue_cube
            lbl1.Text = "Side Length"
            Volume = input1.Value ^ 3
            Output1.Text = input1.Value.ToString + "³ = " + Decimal.Round(Volume, 0, MidpointRounding.AwayFromZero).ToString + " cm³"
        ElseIf ShapeNum = 2 Then 'Cone
            picShape.Image = My.Resources.blue_cone
            lbl1.Text = "Radius"
            lbl2.Text = "Height"
            Volume = pi * (input1.Value ^ 2) * (input2.Value / 3)
            Output1.Text = "pi × " + input1.Value.ToString + "² × (" + input2.Value.ToString + " ÷ 3) = " + Decimal.Round(Volume, 0, MidpointRounding.AwayFromZero).ToString + " cm³"
        ElseIf ShapeNum = 3 Then 'Pyramid
            lbl3.Visible = True
            input3.Visible = True
            picShape.Image = My.Resources.blue_square_pyramid
            lbl1.Text = "Radius"
            lbl2.Text = "Length"
            lbl3.Text = "Width"
            Volume = (input1.Value * input2.Value * input3.Value) / 3
            Output1.Text = "(" + input1.Value.ToString + " × " + input2.Value.ToString + " × " + input3.Value.ToString + ") ÷ 3  = " + Decimal.Round(Volume, 0, MidpointRounding.AwayFromZero).ToString + " cm³"
        ElseIf ShapeNum = 4 Then 'Rectangular Prism
            lbl3.Visible = True
            input3.Visible = True
            picShape.Image = My.Resources.blue_cuboid
            lbl1.Text = "Radius"
            lbl2.Text = "Length"
            lbl3.Text = "Width"
            Volume = input1.Value * input2.Value * input3.Value
            Output1.Text = input1.Value.ToString + " × " + input2.Value.ToString + " × " + input3.Value.ToString + " = " + Decimal.Round(Volume, 0, MidpointRounding.AwayFromZero).ToString + " cm³"
        ElseIf ShapeNum = 5 Then 'Cylinder
            picShape.Image = My.Resources.blue_cylinder
            lbl2.Visible = True
            input2.Visible = True
            lbl1.Text = "Radius"
            lbl2.Text = "Height"
            Volume = pi * (input1.Value ^ 2) * input2.Value
            Output1.Text = input1.Value.ToString + "² × " + input2.Value.ToString + " × pi = " + Decimal.Round(Volume, 0, MidpointRounding.AwayFromZero).ToString + " cm³"
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        screenQuizVolume.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        screenExit.Show()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles picCorner.MouseEnter
        picCorner.BackColor = ColorTranslator.FromHtml("#FFDE21")
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles picCorner.MouseLeave
        picCorner.BackColor = Nothing
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.BackColor = ColorTranslator.FromHtml("#FFDE21")
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.BackColor = Nothing
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = ColorTranslator.FromHtml("#FFDE21")
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.Black
    End Sub
End Class