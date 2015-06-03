<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class screenVolume
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Output1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.input3 = New System.Windows.Forms.NumericUpDown()
        Me.input2 = New System.Windows.Forms.NumericUpDown()
        Me.input1 = New System.Windows.Forms.NumericUpDown()
        Me.picShape = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picCorner = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.input3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picShape, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCorner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(609, 430)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 31)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Test yourself!"
        '
        'lbl3
        '
        Me.lbl3.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(503, 271)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(305, 31)
        Me.lbl3.TabIndex = 21
        Me.lbl3.Text = "Label3"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(501, 231)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(307, 31)
        Me.lbl2.TabIndex = 24
        Me.lbl2.Text = "Label2"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(503, 191)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(305, 31)
        Me.lbl1.TabIndex = 23
        Me.lbl1.Text = "lbl1"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Output1
        '
        Me.Output1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Output1.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.Output1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Output1.Location = New System.Drawing.Point(497, 317)
        Me.Output1.Name = "Output1"
        Me.Output1.Size = New System.Drawing.Size(488, 35)
        Me.Output1.TabIndex = 20
        Me.Output1.Text = "X times y = z"
        Me.Output1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("BatmanForeverAlternate", 75.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(221, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(449, 93)
        Me.lblTitle.TabIndex = 22
        Me.lblTitle.Text = "Shape"
        '
        'input3
        '
        Me.input3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.input3.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.input3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.input3.Location = New System.Drawing.Point(839, 269)
        Me.input3.Name = "input3"
        Me.input3.Size = New System.Drawing.Size(146, 41)
        Me.input3.TabIndex = 19
        Me.input3.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'input2
        '
        Me.input2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.input2.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.input2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.input2.Location = New System.Drawing.Point(839, 229)
        Me.input2.Name = "input2"
        Me.input2.Size = New System.Drawing.Size(146, 41)
        Me.input2.TabIndex = 18
        Me.input2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'input1
        '
        Me.input1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.input1.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.input1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.input1.Location = New System.Drawing.Point(839, 189)
        Me.input1.Name = "input1"
        Me.input1.Size = New System.Drawing.Size(146, 41)
        Me.input1.TabIndex = 17
        Me.input1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'picShape
        '
        Me.picShape.BackColor = System.Drawing.Color.Transparent
        Me.picShape.Image = Global.BatMath.My.Resources.Resources.circle
        Me.picShape.Location = New System.Drawing.Point(252, 189)
        Me.picShape.Name = "picShape"
        Me.picShape.Size = New System.Drawing.Size(250, 250)
        Me.picShape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picShape.TabIndex = 25
        Me.picShape.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.BatMath.My.Resources.Resources.HomeIcon
        Me.PictureBox2.Location = New System.Drawing.Point(949, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'picCorner
        '
        Me.picCorner.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picCorner.Image = Global.BatMath.My.Resources.Resources.atman
        Me.picCorner.Location = New System.Drawing.Point(0, 316)
        Me.picCorner.Name = "picCorner"
        Me.picCorner.Size = New System.Drawing.Size(380, 260)
        Me.picCorner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCorner.TabIndex = 2
        Me.picCorner.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.BatMath.My.Resources.Resources.iconsineed_cross_24_128
        Me.PictureBox3.Location = New System.Drawing.Point(880, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(63, 63)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'screenVolume
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.picShape)
        Me.Controls.Add(Me.Output1)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.input3)
        Me.Controls.Add(Me.input2)
        Me.Controls.Add(Me.input1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.picCorner)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "screenVolume"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.input3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picShape, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCorner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picCorner As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents picShape As System.Windows.Forms.PictureBox
    Friend WithEvents Output1 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents input3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents input2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents input1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
