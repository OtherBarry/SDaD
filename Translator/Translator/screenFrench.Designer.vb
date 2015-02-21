<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class screenFrench
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtOption = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbPhrase
        '
        Me.cmbPhrase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPhrase.FormattingEnabled = True
        Me.cmbPhrase.Items.AddRange(New Object() {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"})
        Me.cmbPhrase.Location = New System.Drawing.Point(12, 109)
        Me.cmbPhrase.MaxDropDownItems = 10
        Me.cmbPhrase.Name = "cmbPhrase"
        Me.cmbPhrase.Size = New System.Drawing.Size(174, 21)
        Me.cmbPhrase.TabIndex = 0
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.Location = New System.Drawing.Point(69, 94)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(40, 13)
        Me.lblPhrase.TabIndex = 1
        Me.lblPhrase.Text = "Phrase"
        '
        'txtTranslation
        '
        Me.txtTranslation.Location = New System.Drawing.Point(298, 110)
        Me.txtTranslation.Name = "txtTranslation"
        Me.txtTranslation.Size = New System.Drawing.Size(174, 20)
        Me.txtTranslation.TabIndex = 2
        '
        'cmbOption
        '
        Me.cmbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOption.FormattingEnabled = True
        Me.cmbOption.Items.AddRange(New Object() {" ", " ", " ", " ", " ", " ", " ", " ", " ", " "})
        Me.cmbOption.Location = New System.Drawing.Point(192, 110)
        Me.cmbOption.MaxDropDownItems = 10
        Me.cmbOption.Name = "cmbOption"
        Me.cmbOption.Size = New System.Drawing.Size(100, 21)
        Me.cmbOption.Sorted = True
        Me.cmbOption.TabIndex = 3
        Me.cmbOption.Visible = False
        '
        'lblTranslation
        '
        Me.lblTranslation.AutoSize = True
        Me.lblTranslation.Location = New System.Drawing.Point(355, 94)
        Me.lblTranslation.Name = "lblTranslation"
        Me.lblTranslation.Size = New System.Drawing.Size(59, 13)
        Me.lblTranslation.TabIndex = 4
        Me.lblTranslation.Text = "Translation"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 208)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(12, 12)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(75, 23)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(397, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtOption
        '
        Me.txtOption.AutoSize = True
        Me.txtOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOption.Location = New System.Drawing.Point(192, 111)
        Me.txtOption.Name = "txtOption"
        Me.txtOption.Size = New System.Drawing.Size(49, 16)
        Me.txtOption.TabIndex = 8
        Me.txtOption.Text = "French"
        Me.txtOption.Visible = False
        '
        'screenFrench
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 243)
        Me.Controls.Add(Me.txtOption)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTranslation)
        Me.Controls.Add(Me.cmbOption)
        Me.Controls.Add(Me.txtTranslation)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.cmbPhrase)
        Me.Name = "screenFrench"
        Me.Text = "French Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPhrase As System.Windows.Forms.ComboBox
    Friend WithEvents lblPhrase As System.Windows.Forms.Label
    Friend WithEvents txtTranslation As System.Windows.Forms.TextBox
    Friend WithEvents cmbOption As System.Windows.Forms.ComboBox
    Friend WithEvents lblTranslation As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtOption As System.Windows.Forms.Label
End Class
