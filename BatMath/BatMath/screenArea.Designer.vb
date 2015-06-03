<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class screenArea
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.input1 = New System.Windows.Forms.NumericUpDown()
        Me.input2 = New System.Windows.Forms.NumericUpDown()
        Me.input3 = New System.Windows.Forms.NumericUpDown()
        Me.Output1 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.picShape = New System.Windows.Forms.PictureBox()
        CType(Me.input1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'input1
        '
        Me.input1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.input1.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.input1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.input1.Location = New System.Drawing.Point(832, 201)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(146, 41)
        Me.input1.TabIndex = 0
        Me.input1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'input2
        '
        Me.input2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.input2.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.input2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.input2.Location = New System.Drawing.Point(832, 241)
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(146, 41)
        Me.input2.TabIndex = 1
        Me.input2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'input3
        '
        Me.input3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.input3.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.input3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.input3.Location = New System.Drawing.Point(832, 281)
        Me.input3.Name = "input3"
        Me.input3.Size = New System.Drawing.Size(146, 41)
        Me.input3.TabIndex = 2
        Me.input3.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Output1
        '
        Me.Output1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Output1.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.Output1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Output1.Location = New System.Drawing.Point(490, 329)
        Me.Output1.Name = "Output1"
        Me.Output1.Size = New System.Drawing.Size(488, 35)
        Me.Output1.TabIndex = 3
        Me.Output1.Text = "X times y = z"
        Me.Output1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl3
        '
        Me.lbl3.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(488, 283)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(313, 31)
        Me.lbl3.TabIndex = 5
        Me.lbl3.Text = "Label3"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("BatmanForeverAlternate", 75.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(214, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(449, 93)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Shape"
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(445, 203)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(356, 31)
        Me.lbl1.TabIndex = 8
        Me.lbl1.Text = "lbl1"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(476, 243)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(325, 31)
        Me.lbl2.TabIndex = 9
        Me.lbl2.Text = "Label2"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.BatMath.My.Resources.Resources.atman
        Me.PictureBox4.Location = New System.Drawing.Point(0, 316)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(380, 260)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'picShape
        '
        Me.picShape.BackColor = System.Drawing.Color.Transparent
        Me.picShape.Image = Global.BatMath.My.Resources.Resources.circle
        Me.picShape.Location = New System.Drawing.Point(245, 201)
        Me.picShape.Name = "picShape"
        Me.picShape.Size = New System.Drawing.Size(250, 250)
        Me.picShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape.TabIndex = 14
        Me.picShape.TabStop = False
        '
        'screenArea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.picShape)
        Me.Controls.Add(Me.Output1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.input3)
        Me.Controls.Add(Me.input2)
        Me.Controls.Add(Me.input1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "screenArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "screenArea"
        CType(Me.input1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents input1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents input2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents input3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Output1 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents picShape As System.Windows.Forms.PictureBox
End Class
