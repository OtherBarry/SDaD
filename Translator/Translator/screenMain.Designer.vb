<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class screenMain
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOption = New System.Windows.Forms.Button()
        Me.rdoLeft = New System.Windows.Forms.RadioButton()
        Me.rdoCente = New System.Windows.Forms.RadioButton()
        Me.rdoRight = New System.Windows.Forms.RadioButton()
        Me.chkLeft = New System.Windows.Forms.CheckBox()
        Me.chkRight = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(397, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOption
        '
        Me.btnOption.Location = New System.Drawing.Point(12, 12)
        Me.btnOption.Name = "btnOption"
        Me.btnOption.Size = New System.Drawing.Size(75, 23)
        Me.btnOption.TabIndex = 14
        Me.btnOption.Text = "Options"
        Me.btnOption.UseVisualStyleBackColor = True
        '
        'rdoLeft
        '
        Me.rdoLeft.AutoSize = True
        Me.rdoLeft.Location = New System.Drawing.Point(13, 112)
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Size = New System.Drawing.Size(79, 17)
        Me.rdoLeft.TabIndex = 16
        Me.rdoLeft.TabStop = True
        Me.rdoLeft.Text = "Portuguese"
        Me.rdoLeft.UseVisualStyleBackColor = True
        '
        'rdoCente
        '
        Me.rdoCente.AutoSize = True
        Me.rdoCente.Location = New System.Drawing.Point(201, 112)
        Me.rdoCente.Name = "rdoCente"
        Me.rdoCente.Size = New System.Drawing.Size(79, 17)
        Me.rdoCente.TabIndex = 17
        Me.rdoCente.TabStop = True
        Me.rdoCente.Text = "Portuguese"
        Me.rdoCente.UseVisualStyleBackColor = True
        '
        'rdoRight
        '
        Me.rdoRight.AutoSize = True
        Me.rdoRight.Location = New System.Drawing.Point(393, 112)
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Size = New System.Drawing.Size(79, 17)
        Me.rdoRight.TabIndex = 18
        Me.rdoRight.TabStop = True
        Me.rdoRight.Text = "Portuguese"
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'chkLeft
        '
        Me.chkLeft.AutoSize = True
        Me.chkLeft.Location = New System.Drawing.Point(98, 172)
        Me.chkLeft.Name = "chkLeft"
        Me.chkLeft.Size = New System.Drawing.Size(81, 17)
        Me.chkLeft.TabIndex = 20
        Me.chkLeft.Text = "CheckBox2"
        Me.chkLeft.UseVisualStyleBackColor = True
        '
        'chkRight
        '
        Me.chkRight.AutoSize = True
        Me.chkRight.Location = New System.Drawing.Point(306, 172)
        Me.chkRight.Name = "chkRight"
        Me.chkRight.Size = New System.Drawing.Size(81, 17)
        Me.chkRight.TabIndex = 22
        Me.chkRight.Text = "CheckBox4"
        Me.chkRight.UseVisualStyleBackColor = True
        '
        'screenMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 243)
        Me.Controls.Add(Me.chkRight)
        Me.Controls.Add(Me.chkLeft)
        Me.Controls.Add(Me.rdoRight)
        Me.Controls.Add(Me.rdoCente)
        Me.Controls.Add(Me.rdoLeft)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOption)
        Me.Name = "screenMain"
        Me.Text = "Translator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnOption As System.Windows.Forms.Button
    Friend WithEvents rdoLeft As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCente As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRight As System.Windows.Forms.RadioButton
    Friend WithEvents chkLeft As System.Windows.Forms.CheckBox
    Friend WithEvents chkRight As System.Windows.Forms.CheckBox

End Class
