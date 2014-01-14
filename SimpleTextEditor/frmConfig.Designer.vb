<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblBackColor = New System.Windows.Forms.Label
        Me.lblFontColor = New System.Windows.Forms.Label
        Me.lblFontSize = New System.Windows.Forms.Label
        Me.lblCurrentFont = New System.Windows.Forms.Label
        Me.btnFont = New System.Windows.Forms.Button
        Me.btnFontColor = New System.Windows.Forms.Button
        Me.btnBackColor = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.fontSelect = New System.Windows.Forms.FontDialog
        Me.fontColorSelect = New System.Windows.Forms.ColorDialog
        Me.backColorSelect = New System.Windows.Forms.ColorDialog
        Me.chkWordWrap = New System.Windows.Forms.CheckBox
        Me.chkFullScreen = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Background Color:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Font Color:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Font Size:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 237)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Font:"
        '
        'lblBackColor
        '
        Me.lblBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBackColor.Location = New System.Drawing.Point(35, 68)
        Me.lblBackColor.Name = "lblBackColor"
        Me.lblBackColor.Size = New System.Drawing.Size(228, 23)
        Me.lblBackColor.TabIndex = 31
        '
        'lblFontColor
        '
        Me.lblFontColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFontColor.Location = New System.Drawing.Point(35, 169)
        Me.lblFontColor.Name = "lblFontColor"
        Me.lblFontColor.Size = New System.Drawing.Size(228, 23)
        Me.lblFontColor.TabIndex = 30
        '
        'lblFontSize
        '
        Me.lblFontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFontSize.Location = New System.Drawing.Point(288, 266)
        Me.lblFontSize.Name = "lblFontSize"
        Me.lblFontSize.Size = New System.Drawing.Size(111, 23)
        Me.lblFontSize.TabIndex = 29
        '
        'lblCurrentFont
        '
        Me.lblCurrentFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentFont.Location = New System.Drawing.Point(35, 266)
        Me.lblCurrentFont.Name = "lblCurrentFont"
        Me.lblCurrentFont.Size = New System.Drawing.Size(224, 23)
        Me.lblCurrentFont.TabIndex = 28
        '
        'btnFont
        '
        Me.btnFont.Location = New System.Drawing.Point(430, 237)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(133, 52)
        Me.btnFont.TabIndex = 3
        Me.btnFont.Text = "Change Font"
        Me.btnFont.UseVisualStyleBackColor = True
        '
        'btnFontColor
        '
        Me.btnFontColor.Location = New System.Drawing.Point(430, 150)
        Me.btnFontColor.Name = "btnFontColor"
        Me.btnFontColor.Size = New System.Drawing.Size(133, 52)
        Me.btnFontColor.TabIndex = 2
        Me.btnFontColor.Text = "Change Font Color"
        Me.btnFontColor.UseVisualStyleBackColor = True
        '
        'btnBackColor
        '
        Me.btnBackColor.Location = New System.Drawing.Point(430, 39)
        Me.btnBackColor.Name = "btnBackColor"
        Me.btnBackColor.Size = New System.Drawing.Size(133, 52)
        Me.btnBackColor.TabIndex = 1
        Me.btnBackColor.Text = "Change Back Color"
        Me.btnBackColor.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(35, 399)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(133, 52)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkWordWrap
        '
        Me.chkWordWrap.AutoSize = True
        Me.chkWordWrap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWordWrap.Location = New System.Drawing.Point(35, 325)
        Me.chkWordWrap.Name = "chkWordWrap"
        Me.chkWordWrap.Size = New System.Drawing.Size(178, 24)
        Me.chkWordWrap.TabIndex = 4
        Me.chkWordWrap.Text = "Enable Word Wrap"
        Me.chkWordWrap.UseVisualStyleBackColor = True
        '
        'chkFullScreen
        '
        Me.chkFullScreen.AutoSize = True
        Me.chkFullScreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFullScreen.Location = New System.Drawing.Point(246, 325)
        Me.chkFullScreen.Name = "chkFullScreen"
        Me.chkFullScreen.Size = New System.Drawing.Size(232, 24)
        Me.chkFullScreen.TabIndex = 36
        Me.chkFullScreen.Text = "Full Screen Browser View"
        Me.chkFullScreen.UseVisualStyleBackColor = True
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 463)
        Me.Controls.Add(Me.chkFullScreen)
        Me.Controls.Add(Me.chkWordWrap)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblBackColor)
        Me.Controls.Add(Me.lblFontColor)
        Me.Controls.Add(Me.lblFontSize)
        Me.Controls.Add(Me.lblCurrentFont)
        Me.Controls.Add(Me.btnFont)
        Me.Controls.Add(Me.btnFontColor)
        Me.Controls.Add(Me.btnBackColor)
        Me.Name = "frmConfig"
        Me.Text = "Configure Text Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBackColor As System.Windows.Forms.Label
    Friend WithEvents lblFontColor As System.Windows.Forms.Label
    Friend WithEvents lblFontSize As System.Windows.Forms.Label
    Friend WithEvents lblCurrentFont As System.Windows.Forms.Label
    Friend WithEvents btnFont As System.Windows.Forms.Button
    Friend WithEvents btnFontColor As System.Windows.Forms.Button
    Friend WithEvents btnBackColor As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents fontSelect As System.Windows.Forms.FontDialog
    Friend WithEvents fontColorSelect As System.Windows.Forms.ColorDialog
    Friend WithEvents backColorSelect As System.Windows.Forms.ColorDialog
    Friend WithEvents chkWordWrap As System.Windows.Forms.CheckBox
    Friend WithEvents chkFullScreen As System.Windows.Forms.CheckBox
End Class
