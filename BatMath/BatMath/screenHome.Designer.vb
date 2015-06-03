<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class screenHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(screenHome))
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.picCorner = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCorner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("BatmanForeverAlternate", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(87, 87)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(850, 124)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "BatMath"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.BackColor = System.Drawing.Color.Transparent
        Me.lblArea.Font = New System.Drawing.Font("BatmanForeverAlternate", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.ForeColor = System.Drawing.Color.Black
        Me.lblArea.Location = New System.Drawing.Point(192, 317)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(245, 63)
        Me.lblArea.TabIndex = 2
        Me.lblArea.Text = "Area"
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Font = New System.Drawing.Font("BatmanForeverAlternate", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVolume.ForeColor = System.Drawing.Color.Black
        Me.lblVolume.Location = New System.Drawing.Point(506, 317)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(363, 63)
        Me.lblVolume.TabIndex = 3
        Me.lblVolume.Text = "Volume"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(949, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'picCorner
        '
        Me.picCorner.Image = CType(resources.GetObject("picCorner.Image"), System.Drawing.Image)
        Me.picCorner.Location = New System.Drawing.Point(0, 317)
        Me.picCorner.Name = "picCorner"
        Me.picCorner.Size = New System.Drawing.Size(380, 260)
        Me.picCorner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCorner.TabIndex = 1
        Me.picCorner.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("BatmanForeverAlternate", 25.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(360, 415)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 31)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "What is pi?"
        '
        'screenHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 576)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblArea)
        Me.Controls.Add(Me.picCorner)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "screenHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "screenHome"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCorner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents picCorner As System.Windows.Forms.PictureBox
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents lblVolume As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
