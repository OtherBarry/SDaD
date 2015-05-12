<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class screenSelect
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
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.picCircle = New System.Windows.Forms.PictureBox()
        Me.picSquare = New System.Windows.Forms.PictureBox()
        Me.picTriangle = New System.Windows.Forms.PictureBox()
        Me.lblCircle = New System.Windows.Forms.Label()
        Me.lblSquare = New System.Windows.Forms.Label()
        Me.lblTriangle = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCircle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSquare, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTriangle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.BatMath.My.Resources.Resources.atman
        Me.PictureBox4.Location = New System.Drawing.Point(0, 316)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(380, 260)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'picCircle
        '
        Me.picCircle.Image = Global.BatMath.My.Resources.Resources.botmon
        Me.picCircle.Location = New System.Drawing.Point(100, 100)
        Me.picCircle.Name = "picCircle"
        Me.picCircle.Size = New System.Drawing.Size(150, 150)
        Me.picCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCircle.TabIndex = 2
        Me.picCircle.TabStop = False
        '
        'picSquare
        '
        Me.picSquare.BackColor = System.Drawing.Color.Gold
        Me.picSquare.Location = New System.Drawing.Point(437, 100)
        Me.picSquare.Name = "picSquare"
        Me.picSquare.Size = New System.Drawing.Size(150, 150)
        Me.picSquare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSquare.TabIndex = 1
        Me.picSquare.TabStop = False
        '
        'picTriangle
        '
        Me.picTriangle.Image = Global.BatMath.My.Resources.Resources.botmon
        Me.picTriangle.Location = New System.Drawing.Point(774, 100)
        Me.picTriangle.Name = "picTriangle"
        Me.picTriangle.Size = New System.Drawing.Size(150, 150)
        Me.picTriangle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTriangle.TabIndex = 0
        Me.picTriangle.TabStop = False
        '
        'lblCircle
        '
        Me.lblCircle.AutoSize = True
        Me.lblCircle.Font = New System.Drawing.Font("BatmanForeverAlternate", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCircle.Location = New System.Drawing.Point(102, 163)
        Me.lblCircle.Name = "lblCircle"
        Me.lblCircle.Size = New System.Drawing.Size(148, 30)
        Me.lblCircle.TabIndex = 4
        Me.lblCircle.Text = "Circle"
        '
        'lblSquare
        '
        Me.lblSquare.AutoSize = True
        Me.lblSquare.Font = New System.Drawing.Font("BatmanForeverAlternate", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSquare.Location = New System.Drawing.Point(422, 163)
        Me.lblSquare.Name = "lblSquare"
        Me.lblSquare.Size = New System.Drawing.Size(179, 30)
        Me.lblSquare.TabIndex = 5
        Me.lblSquare.Text = "Square"
        '
        'lblTriangle
        '
        Me.lblTriangle.AutoSize = True
        Me.lblTriangle.Font = New System.Drawing.Font("BatmanForeverAlternate", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTriangle.Location = New System.Drawing.Point(748, 163)
        Me.lblTriangle.Name = "lblTriangle"
        Me.lblTriangle.Size = New System.Drawing.Size(206, 30)
        Me.lblTriangle.TabIndex = 6
        Me.lblTriangle.Text = "Triangle"
        '
        'screenSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.lblTriangle)
        Me.Controls.Add(Me.lblSquare)
        Me.Controls.Add(Me.lblCircle)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.picSquare)
        Me.Controls.Add(Me.picTriangle)
        Me.Controls.Add(Me.picCircle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "screenSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "screenSelect"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCircle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSquare, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTriangle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTriangle As System.Windows.Forms.PictureBox
    Friend WithEvents picSquare As System.Windows.Forms.PictureBox
    Friend WithEvents picCircle As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCircle As System.Windows.Forms.Label
    Friend WithEvents lblSquare As System.Windows.Forms.Label
    Friend WithEvents lblTriangle As System.Windows.Forms.Label
End Class
