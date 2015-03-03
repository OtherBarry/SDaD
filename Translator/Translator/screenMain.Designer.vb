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
        Me.chkLanguage = New System.Windows.Forms.CheckBox()
        Me.chkNation = New System.Windows.Forms.CheckBox()
        Me.flagLeft = New System.Windows.Forms.PictureBox()
        Me.flagCenter = New System.Windows.Forms.PictureBox()
        Me.flagRight = New System.Windows.Forms.PictureBox()
        Me.txtLeft = New System.Windows.Forms.TextBox()
        Me.txtCenter = New System.Windows.Forms.TextBox()
        Me.txtRight = New System.Windows.Forms.TextBox()
        Me.GroupCountry = New System.Windows.Forms.GroupBox()
        Me.lblCountry5 = New System.Windows.Forms.Label()
        Me.lblCountry4 = New System.Windows.Forms.Label()
        Me.lblCountry3 = New System.Windows.Forms.Label()
        Me.lblCountry6 = New System.Windows.Forms.Label()
        Me.lblCountry1 = New System.Windows.Forms.Label()
        Me.btnCountry3 = New System.Windows.Forms.Button()
        Me.btnCountry2 = New System.Windows.Forms.Button()
        Me.lblCountry2 = New System.Windows.Forms.Label()
        Me.btnCountry6 = New System.Windows.Forms.Button()
        Me.btnCountry5 = New System.Windows.Forms.Button()
        Me.btnCountry4 = New System.Windows.Forms.Button()
        Me.btnCountry1 = New System.Windows.Forms.Button()
        Me.GroupLanguage = New System.Windows.Forms.GroupBox()
        CType(Me.flagLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flagCenter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flagRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupCountry.SuspendLayout()
        Me.GroupLanguage.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(857, 12)
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
        Me.rdoLeft.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.rdoLeft.AutoSize = True
        Me.rdoLeft.Location = New System.Drawing.Point(164, 104)
        Me.rdoLeft.Name = "rdoLeft"
        Me.rdoLeft.Size = New System.Drawing.Size(79, 17)
        Me.rdoLeft.TabIndex = 16
        Me.rdoLeft.TabStop = True
        Me.rdoLeft.Text = "Portuguese"
        Me.rdoLeft.UseVisualStyleBackColor = True
        '
        'rdoCente
        '
        Me.rdoCente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.rdoCente.AutoSize = True
        Me.rdoCente.Location = New System.Drawing.Point(419, 102)
        Me.rdoCente.Name = "rdoCente"
        Me.rdoCente.Size = New System.Drawing.Size(79, 17)
        Me.rdoCente.TabIndex = 17
        Me.rdoCente.TabStop = True
        Me.rdoCente.Text = "Portuguese"
        Me.rdoCente.UseVisualStyleBackColor = True
        '
        'rdoRight
        '
        Me.rdoRight.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.rdoRight.AutoSize = True
        Me.rdoRight.Location = New System.Drawing.Point(680, 104)
        Me.rdoRight.Name = "rdoRight"
        Me.rdoRight.Size = New System.Drawing.Size(79, 17)
        Me.rdoRight.TabIndex = 18
        Me.rdoRight.TabStop = True
        Me.rdoRight.Text = "Portuguese"
        Me.rdoRight.UseVisualStyleBackColor = True
        '
        'chkLanguage
        '
        Me.chkLanguage.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chkLanguage.AutoSize = True
        Me.chkLanguage.Checked = True
        Me.chkLanguage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkLanguage.Location = New System.Drawing.Point(409, 159)
        Me.chkLanguage.Name = "chkLanguage"
        Me.chkLanguage.Size = New System.Drawing.Size(68, 17)
        Me.chkLanguage.TabIndex = 20
        Me.chkLanguage.Text = "Flags On"
        Me.chkLanguage.UseVisualStyleBackColor = True
        '
        'chkNation
        '
        Me.chkNation.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chkNation.AutoSize = True
        Me.chkNation.Checked = True
        Me.chkNation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkNation.Location = New System.Drawing.Point(418, 114)
        Me.chkNation.Name = "chkNation"
        Me.chkNation.Size = New System.Drawing.Size(68, 17)
        Me.chkNation.TabIndex = 22
        Me.chkNation.Text = "Flags On"
        Me.chkNation.UseVisualStyleBackColor = True
        '
        'flagLeft
        '
        Me.flagLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flagLeft.Location = New System.Drawing.Point(154, 19)
        Me.flagLeft.Name = "flagLeft"
        Me.flagLeft.Size = New System.Drawing.Size(100, 50)
        Me.flagLeft.TabIndex = 23
        Me.flagLeft.TabStop = False
        '
        'flagCenter
        '
        Me.flagCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flagCenter.Location = New System.Drawing.Point(409, 19)
        Me.flagCenter.Name = "flagCenter"
        Me.flagCenter.Size = New System.Drawing.Size(100, 50)
        Me.flagCenter.TabIndex = 24
        Me.flagCenter.TabStop = False
        '
        'flagRight
        '
        Me.flagRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.flagRight.Location = New System.Drawing.Point(669, 19)
        Me.flagRight.Name = "flagRight"
        Me.flagRight.Size = New System.Drawing.Size(100, 50)
        Me.flagRight.TabIndex = 25
        Me.flagRight.TabStop = False
        '
        'txtLeft
        '
        Me.txtLeft.BackColor = System.Drawing.SystemColors.Info
        Me.txtLeft.Location = New System.Drawing.Point(145, 78)
        Me.txtLeft.Name = "txtLeft"
        Me.txtLeft.ReadOnly = True
        Me.txtLeft.Size = New System.Drawing.Size(118, 20)
        Me.txtLeft.TabIndex = 26
        Me.txtLeft.Text = "Spoken in 22 countries"
        '
        'txtCenter
        '
        Me.txtCenter.BackColor = System.Drawing.SystemColors.Info
        Me.txtCenter.Location = New System.Drawing.Point(402, 76)
        Me.txtCenter.Name = "txtCenter"
        Me.txtCenter.ReadOnly = True
        Me.txtCenter.Size = New System.Drawing.Size(116, 20)
        Me.txtCenter.TabIndex = 27
        Me.txtCenter.Text = "Spoken in 22 countries"
        '
        'txtRight
        '
        Me.txtRight.BackColor = System.Drawing.SystemColors.Info
        Me.txtRight.Location = New System.Drawing.Point(661, 75)
        Me.txtRight.Name = "txtRight"
        Me.txtRight.ReadOnly = True
        Me.txtRight.Size = New System.Drawing.Size(116, 20)
        Me.txtRight.TabIndex = 28
        Me.txtRight.Text = "Spoken in 22 countries"
        '
        'GroupCountry
        '
        Me.GroupCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupCountry.Controls.Add(Me.lblCountry5)
        Me.GroupCountry.Controls.Add(Me.chkNation)
        Me.GroupCountry.Controls.Add(Me.lblCountry4)
        Me.GroupCountry.Controls.Add(Me.lblCountry3)
        Me.GroupCountry.Controls.Add(Me.lblCountry6)
        Me.GroupCountry.Controls.Add(Me.lblCountry1)
        Me.GroupCountry.Controls.Add(Me.btnCountry3)
        Me.GroupCountry.Controls.Add(Me.btnCountry2)
        Me.GroupCountry.Controls.Add(Me.lblCountry2)
        Me.GroupCountry.Controls.Add(Me.btnCountry6)
        Me.GroupCountry.Controls.Add(Me.btnCountry5)
        Me.GroupCountry.Controls.Add(Me.btnCountry4)
        Me.GroupCountry.Controls.Add(Me.btnCountry1)
        Me.GroupCountry.Location = New System.Drawing.Point(13, 286)
        Me.GroupCountry.Name = "GroupCountry"
        Me.GroupCountry.Size = New System.Drawing.Size(919, 162)
        Me.GroupCountry.TabIndex = 29
        Me.GroupCountry.TabStop = False
        Me.GroupCountry.Text = "Please select a country"
        '
        'lblCountry5
        '
        Me.lblCountry5.AutoSize = True
        Me.lblCountry5.Location = New System.Drawing.Point(632, 71)
        Me.lblCountry5.Name = "lblCountry5"
        Me.lblCountry5.Size = New System.Drawing.Size(13, 13)
        Me.lblCountry5.TabIndex = 11
        Me.lblCountry5.Text = "5"
        Me.lblCountry5.Visible = False
        '
        'lblCountry4
        '
        Me.lblCountry4.AutoSize = True
        Me.lblCountry4.Location = New System.Drawing.Point(490, 72)
        Me.lblCountry4.Name = "lblCountry4"
        Me.lblCountry4.Size = New System.Drawing.Size(13, 13)
        Me.lblCountry4.TabIndex = 10
        Me.lblCountry4.Text = "4"
        Me.lblCountry4.Visible = False
        '
        'lblCountry3
        '
        Me.lblCountry3.AutoSize = True
        Me.lblCountry3.Location = New System.Drawing.Point(348, 71)
        Me.lblCountry3.Name = "lblCountry3"
        Me.lblCountry3.Size = New System.Drawing.Size(13, 13)
        Me.lblCountry3.TabIndex = 9
        Me.lblCountry3.Text = "3"
        Me.lblCountry3.Visible = False
        '
        'lblCountry6
        '
        Me.lblCountry6.AutoSize = True
        Me.lblCountry6.Location = New System.Drawing.Point(774, 71)
        Me.lblCountry6.Name = "lblCountry6"
        Me.lblCountry6.Size = New System.Drawing.Size(13, 13)
        Me.lblCountry6.TabIndex = 8
        Me.lblCountry6.Text = "6"
        Me.lblCountry6.Visible = False
        '
        'lblCountry1
        '
        Me.lblCountry1.AutoSize = True
        Me.lblCountry1.Location = New System.Drawing.Point(64, 71)
        Me.lblCountry1.Name = "lblCountry1"
        Me.lblCountry1.Size = New System.Drawing.Size(13, 13)
        Me.lblCountry1.TabIndex = 6
        Me.lblCountry1.Text = "1"
        Me.lblCountry1.Visible = False
        '
        'btnCountry3
        '
        Me.btnCountry3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCountry3.Location = New System.Drawing.Point(351, 19)
        Me.btnCountry3.Name = "btnCountry3"
        Me.btnCountry3.Size = New System.Drawing.Size(75, 50)
        Me.btnCountry3.TabIndex = 2
        Me.btnCountry3.UseVisualStyleBackColor = True
        Me.btnCountry3.Visible = False
        '
        'btnCountry2
        '
        Me.btnCountry2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCountry2.Location = New System.Drawing.Point(209, 19)
        Me.btnCountry2.Name = "btnCountry2"
        Me.btnCountry2.Size = New System.Drawing.Size(75, 50)
        Me.btnCountry2.TabIndex = 3
        Me.btnCountry2.UseVisualStyleBackColor = True
        Me.btnCountry2.Visible = False
        '
        'lblCountry2
        '
        Me.lblCountry2.AutoSize = True
        Me.lblCountry2.Location = New System.Drawing.Point(206, 72)
        Me.lblCountry2.Name = "lblCountry2"
        Me.lblCountry2.Size = New System.Drawing.Size(13, 13)
        Me.lblCountry2.TabIndex = 7
        Me.lblCountry2.Text = "2"
        Me.lblCountry2.Visible = False
        '
        'btnCountry6
        '
        Me.btnCountry6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCountry6.Location = New System.Drawing.Point(777, 19)
        Me.btnCountry6.Name = "btnCountry6"
        Me.btnCountry6.Size = New System.Drawing.Size(75, 50)
        Me.btnCountry6.TabIndex = 5
        Me.btnCountry6.UseVisualStyleBackColor = True
        Me.btnCountry6.Visible = False
        '
        'btnCountry5
        '
        Me.btnCountry5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCountry5.Location = New System.Drawing.Point(635, 18)
        Me.btnCountry5.Name = "btnCountry5"
        Me.btnCountry5.Size = New System.Drawing.Size(75, 50)
        Me.btnCountry5.TabIndex = 4
        Me.btnCountry5.UseVisualStyleBackColor = True
        Me.btnCountry5.Visible = False
        '
        'btnCountry4
        '
        Me.btnCountry4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCountry4.Location = New System.Drawing.Point(493, 19)
        Me.btnCountry4.Name = "btnCountry4"
        Me.btnCountry4.Size = New System.Drawing.Size(75, 50)
        Me.btnCountry4.TabIndex = 1
        Me.btnCountry4.UseVisualStyleBackColor = True
        Me.btnCountry4.Visible = False
        '
        'btnCountry1
        '
        Me.btnCountry1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCountry1.Location = New System.Drawing.Point(67, 18)
        Me.btnCountry1.Name = "btnCountry1"
        Me.btnCountry1.Size = New System.Drawing.Size(75, 50)
        Me.btnCountry1.TabIndex = 0
        Me.btnCountry1.UseVisualStyleBackColor = True
        Me.btnCountry1.Visible = False
        '
        'GroupLanguage
        '
        Me.GroupLanguage.Controls.Add(Me.txtRight)
        Me.GroupLanguage.Controls.Add(Me.chkLanguage)
        Me.GroupLanguage.Controls.Add(Me.txtLeft)
        Me.GroupLanguage.Controls.Add(Me.txtCenter)
        Me.GroupLanguage.Controls.Add(Me.rdoRight)
        Me.GroupLanguage.Controls.Add(Me.flagRight)
        Me.GroupLanguage.Controls.Add(Me.rdoCente)
        Me.GroupLanguage.Controls.Add(Me.flagCenter)
        Me.GroupLanguage.Controls.Add(Me.rdoLeft)
        Me.GroupLanguage.Controls.Add(Me.flagLeft)
        Me.GroupLanguage.Location = New System.Drawing.Point(12, 69)
        Me.GroupLanguage.Name = "GroupLanguage"
        Me.GroupLanguage.Size = New System.Drawing.Size(901, 191)
        Me.GroupLanguage.TabIndex = 30
        Me.GroupLanguage.TabStop = False
        Me.GroupLanguage.Text = "Please select a language"
        '
        'screenMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 501)
        Me.Controls.Add(Me.GroupCountry)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOption)
        Me.Controls.Add(Me.GroupLanguage)
        Me.MaximumSize = New System.Drawing.Size(960, 540)
        Me.MinimumSize = New System.Drawing.Size(960, 540)
        Me.Name = "screenMain"
        Me.Text = "Translator"
        CType(Me.flagLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flagCenter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flagRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupCountry.ResumeLayout(False)
        Me.GroupCountry.PerformLayout()
        Me.GroupLanguage.ResumeLayout(False)
        Me.GroupLanguage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnOption As System.Windows.Forms.Button
    Friend WithEvents rdoLeft As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCente As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRight As System.Windows.Forms.RadioButton
    Friend WithEvents chkLanguage As System.Windows.Forms.CheckBox
    Friend WithEvents chkNation As System.Windows.Forms.CheckBox
    Friend WithEvents flagLeft As System.Windows.Forms.PictureBox
    Friend WithEvents flagCenter As System.Windows.Forms.PictureBox
    Friend WithEvents flagRight As System.Windows.Forms.PictureBox
    Friend WithEvents txtLeft As System.Windows.Forms.TextBox
    Friend WithEvents txtCenter As System.Windows.Forms.TextBox
    Friend WithEvents txtRight As System.Windows.Forms.TextBox
    Friend WithEvents GroupCountry As System.Windows.Forms.GroupBox
    Friend WithEvents GroupLanguage As System.Windows.Forms.GroupBox
    Friend WithEvents lblCountry5 As System.Windows.Forms.Label
    Friend WithEvents lblCountry4 As System.Windows.Forms.Label
    Friend WithEvents lblCountry3 As System.Windows.Forms.Label
    Friend WithEvents lblCountry6 As System.Windows.Forms.Label
    Friend WithEvents lblCountry2 As System.Windows.Forms.Label
    Friend WithEvents lblCountry1 As System.Windows.Forms.Label
    Friend WithEvents btnCountry6 As System.Windows.Forms.Button
    Friend WithEvents btnCountry5 As System.Windows.Forms.Button
    Friend WithEvents btnCountry2 As System.Windows.Forms.Button
    Friend WithEvents btnCountry3 As System.Windows.Forms.Button
    Friend WithEvents btnCountry4 As System.Windows.Forms.Button
    Friend WithEvents btnCountry1 As System.Windows.Forms.Button

End Class
