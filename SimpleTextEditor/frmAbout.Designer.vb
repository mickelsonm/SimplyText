<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.btnOK = New System.Windows.Forms.Button
        Me.picLogo = New System.Windows.Forms.PictureBox
        Me.lblVersion = New System.Windows.Forms.Label
        Me.lblProgrammer = New System.Windows.Forms.Label
        Me.lblProgName = New System.Windows.Forms.LinkLabel
        Me.mnuAboutRight = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuCopyEmail = New System.Windows.Forms.ToolStripMenuItem
        Me.lblGraphName = New System.Windows.Forms.LinkLabel
        Me.lblGDesigner = New System.Windows.Forms.Label
        Me.lblVer = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuAboutRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(194, 242)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(292, 109)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(9, 121)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(67, 20)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Version:"
        '
        'lblProgrammer
        '
        Me.lblProgrammer.AutoSize = True
        Me.lblProgrammer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgrammer.Location = New System.Drawing.Point(8, 153)
        Me.lblProgrammer.Name = "lblProgrammer"
        Me.lblProgrammer.Size = New System.Drawing.Size(153, 20)
        Me.lblProgrammer.TabIndex = 3
        Me.lblProgrammer.Text = "Software Developer:"
        '
        'lblProgName
        '
        Me.lblProgName.AutoSize = True
        Me.lblProgName.ContextMenuStrip = Me.mnuAboutRight
        Me.lblProgName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProgName.Location = New System.Drawing.Point(167, 153)
        Me.lblProgName.Name = "lblProgName"
        Me.lblProgName.Size = New System.Drawing.Size(115, 20)
        Me.lblProgName.TabIndex = 5
        Me.lblProgName.TabStop = True
        Me.lblProgName.Tag = ""
        Me.lblProgName.Text = "Matt Mickelson"
        '
        'mnuAboutRight
        '
        Me.mnuAboutRight.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopyEmail})
        Me.mnuAboutRight.Name = "mnuAboutRight"
        Me.mnuAboutRight.Size = New System.Drawing.Size(254, 26)
        '
        'mnuCopyEmail
        '
        Me.mnuCopyEmail.Name = "mnuCopyEmail"
        Me.mnuCopyEmail.Size = New System.Drawing.Size(253, 22)
        Me.mnuCopyEmail.Text = "Copy E-mail Address to Clipboard"
        '
        'lblGraphName
        '
        Me.lblGraphName.AutoSize = True
        Me.lblGraphName.ContextMenuStrip = Me.mnuAboutRight
        Me.lblGraphName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphName.Location = New System.Drawing.Point(167, 189)
        Me.lblGraphName.Name = "lblGraphName"
        Me.lblGraphName.Size = New System.Drawing.Size(88, 20)
        Me.lblGraphName.TabIndex = 7
        Me.lblGraphName.TabStop = True
        Me.lblGraphName.Tag = ""
        Me.lblGraphName.Text = "David Vaini"
        '
        'lblGDesigner
        '
        Me.lblGDesigner.AutoSize = True
        Me.lblGDesigner.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGDesigner.Location = New System.Drawing.Point(8, 189)
        Me.lblGDesigner.Name = "lblGDesigner"
        Me.lblGDesigner.Size = New System.Drawing.Size(145, 20)
        Me.lblGDesigner.TabIndex = 6
        Me.lblGDesigner.Text = "Graphics Designer:"
        '
        'lblVer
        '
        Me.lblVer.AutoSize = True
        Me.lblVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVer.Location = New System.Drawing.Point(167, 121)
        Me.lblVer.Name = "lblVer"
        Me.lblVer.Size = New System.Drawing.Size(31, 20)
        Me.lblVer.TabIndex = 8
        Me.lblVer.Text = "1.0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Right click for more options."
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 276)
        Me.Controls.Add(Me.lblVer)
        Me.Controls.Add(Me.lblGraphName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGDesigner)
        Me.Controls.Add(Me.lblProgName)
        Me.Controls.Add(Me.lblProgrammer)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "frmAbout"
        Me.Text = "About Simply Text"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuAboutRight.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents picLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents lblProgrammer As System.Windows.Forms.Label
    Friend WithEvents lblProgName As System.Windows.Forms.LinkLabel
    Friend WithEvents lblGraphName As System.Windows.Forms.LinkLabel
    Friend WithEvents lblGDesigner As System.Windows.Forms.Label
    Friend WithEvents lblVer As System.Windows.Forms.Label
    Friend WithEvents mnuAboutRight As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuCopyEmail As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
