<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Converter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Converter))
        Me.lblRight = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.hsbScale = New System.Windows.Forms.HScrollBar()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtLeft = New System.Windows.Forms.NumericUpDown()
        Me.txtRight = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtWhatIs = New System.Windows.Forms.LinkLabel()
        CType(Me.txtLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRight
        '
        Me.lblRight.AutoSize = True
        Me.lblRight.Location = New System.Drawing.Point(302, 100)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(50, 13)
        Me.lblRight.TabIndex = 0
        Me.lblRight.Text = "Hectares"
        '
        'lblLeft
        '
        Me.lblLeft.AutoSize = True
        Me.lblLeft.Location = New System.Drawing.Point(99, 100)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(48, 13)
        Me.lblLeft.TabIndex = 1
        Me.lblLeft.Text = "Morgens"
        '
        'hsbScale
        '
        Me.hsbScale.Location = New System.Drawing.Point(12, 159)
        Me.hsbScale.Maximum = 500
        Me.hsbScale.Name = "hsbScale"
        Me.hsbScale.Size = New System.Drawing.Size(414, 17)
        Me.hsbScale.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(326, 203)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 203)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtLeft
        '
        Me.txtLeft.DecimalPlaces = 3
        Me.txtLeft.Location = New System.Drawing.Point(12, 116)
        Me.txtLeft.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.txtLeft.Minimum = New Decimal(New Integer() {-1486618625, 232830643, 0, -2147483648})
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.Size = New System.Drawing.Size(207, 20)
        Me.txtLeft.TabIndex = 9
        '
        'txtRight
        '
        Me.txtRight.DecimalPlaces = 3
        Me.txtRight.Location = New System.Drawing.Point(226, 116)
        Me.txtRight.Maximum = New Decimal(New Integer() {-1486618625, 232830643, 0, 0})
        Me.txtRight.Minimum = New Decimal(New Integer() {-1486618625, 232830643, 0, -2147483648})
        Me.txtRight.Name = "txtRight"
        Me.txtRight.Size = New System.Drawing.Size(200, 20)
        Me.txtRight.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(207, 85)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(226, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 85)
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'txtWhatIs
        '
        Me.txtWhatIs.AutoSize = True
        Me.txtWhatIs.Location = New System.Drawing.Point(144, 100)
        Me.txtWhatIs.Name = "txtWhatIs"
        Me.txtWhatIs.Size = New System.Drawing.Size(13, 13)
        Me.txtWhatIs.TabIndex = 13
        Me.txtWhatIs.TabStop = True
        Me.txtWhatIs.Text = "?"
        '
        'Converter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 238)
        Me.Controls.Add(Me.txtWhatIs)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtRight)
        Me.Controls.Add(Me.txtLeft)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.hsbScale)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblRight)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Converter"
        Me.Text = "Converter"
        CType(Me.txtLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRight As System.Windows.Forms.Label
    Friend WithEvents lblLeft As System.Windows.Forms.Label
    Friend WithEvents hsbScale As System.Windows.Forms.HScrollBar
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtLeft As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtRight As System.Windows.Forms.NumericUpDown
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtWhatIs As System.Windows.Forms.LinkLabel

End Class
