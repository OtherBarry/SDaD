<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class screenTranslator
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
        Me.cmbPhrase = New System.Windows.Forms.ComboBox()
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.txtTranslation = New System.Windows.Forms.TextBox()
        Me.cmbOption = New System.Windows.Forms.ComboBox()
        Me.lblTranslation = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtOption = New System.Windows.Forms.Label()
        Me.Flag = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtDescription = New System.Windows.Forms.RichTextBox()
        CType(Me.Flag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbPhrase
        '
        Me.cmbPhrase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPhrase.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.cmbPhrase.FormattingEnabled = True
        Me.cmbPhrase.Items.AddRange(New Object() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"})
        Me.cmbPhrase.Location = New System.Drawing.Point(12, 230)
        Me.cmbPhrase.MaxDropDownItems = 10
        Me.cmbPhrase.Name = "cmbPhrase"
        Me.cmbPhrase.Size = New System.Drawing.Size(300, 31)
        Me.cmbPhrase.TabIndex = 0
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.lblPhrase.Location = New System.Drawing.Point(134, 204)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(65, 23)
        Me.lblPhrase.TabIndex = 1
        Me.lblPhrase.Text = "Phrase"
        '
        'txtTranslation
        '
        Me.txtTranslation.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txtTranslation.Location = New System.Drawing.Point(12, 154)
        Me.txtTranslation.Name = "txtTranslation"
        Me.txtTranslation.Size = New System.Drawing.Size(446, 32)
        Me.txtTranslation.TabIndex = 2
        '
        'cmbOption
        '
        Me.cmbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOption.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.cmbOption.FormattingEnabled = True
        Me.cmbOption.Items.AddRange(New Object() {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "})
        Me.cmbOption.Location = New System.Drawing.Point(318, 230)
        Me.cmbOption.MaxDropDownItems = 10
        Me.cmbOption.Name = "cmbOption"
        Me.cmbOption.Size = New System.Drawing.Size(140, 31)
        Me.cmbOption.Sorted = True
        Me.cmbOption.TabIndex = 3
        Me.cmbOption.Visible = False
        '
        'lblTranslation
        '
        Me.lblTranslation.AutoSize = True
        Me.lblTranslation.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.lblTranslation.Location = New System.Drawing.Point(192, 128)
        Me.lblTranslation.Name = "lblTranslation"
        Me.lblTranslation.Size = New System.Drawing.Size(103, 23)
        Me.lblTranslation.TabIndex = 4
        Me.lblTranslation.Text = "Translation"
        '
        'btnHome
        '
        Me.btnHome.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(12, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(80, 45)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.btnExit.Location = New System.Drawing.Point(852, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 45)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtOption
        '
        Me.txtOption.AutoSize = True
        Me.txtOption.Font = New System.Drawing.Font("Times New Roman", 15.75!)
        Me.txtOption.Location = New System.Drawing.Point(318, 233)
        Me.txtOption.Name = "txtOption"
        Me.txtOption.Size = New System.Drawing.Size(67, 23)
        Me.txtOption.TabIndex = 8
        Me.txtOption.Text = "French"
        Me.txtOption.Visible = False
        '
        'Flag
        '
        Me.Flag.BackgroundImage = Global.Translator.My.Resources.Resources.flagAlgeria
        Me.Flag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Flag.Location = New System.Drawing.Point(532, 70)
        Me.Flag.Name = "Flag"
        Me.Flag.Size = New System.Drawing.Size(250, 170)
        Me.Flag.TabIndex = 9
        Me.Flag.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(788, 70)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 171)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'txtDescription
        '
        Me.txtDescription.AcceptsTab = True
        Me.txtDescription.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtDescription.Location = New System.Drawing.Point(532, 260)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(400, 170)
        Me.txtDescription.TabIndex = 11
        Me.txtDescription.Text = ""
        '
        'screenTranslator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Flag)
        Me.Controls.Add(Me.txtOption)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.lblTranslation)
        Me.Controls.Add(Me.cmbOption)
        Me.Controls.Add(Me.txtTranslation)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.cmbPhrase)
        Me.MaximumSize = New System.Drawing.Size(960, 540)
        Me.MinimumSize = New System.Drawing.Size(960, 540)
        Me.Name = "screenTranslator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "French Translator"
        CType(Me.Flag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPhrase As System.Windows.Forms.ComboBox
    Friend WithEvents lblPhrase As System.Windows.Forms.Label
    Friend WithEvents txtTranslation As System.Windows.Forms.TextBox
    Friend WithEvents cmbOption As System.Windows.Forms.ComboBox
    Friend WithEvents lblTranslation As System.Windows.Forms.Label
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtOption As System.Windows.Forms.Label
    Friend WithEvents Flag As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDescription As System.Windows.Forms.RichTextBox
End Class
