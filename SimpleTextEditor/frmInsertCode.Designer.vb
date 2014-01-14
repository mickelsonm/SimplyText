<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsertCode
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
        Me.cboAllTags = New System.Windows.Forms.ComboBox
        Me.btnInsert = New System.Windows.Forms.Button
        Me.txtCollected = New System.Windows.Forms.TextBox
        Me.lblModified = New System.Windows.Forms.Label
        Me.lblTagSelect = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cboAllTags
        '
        Me.cboAllTags.FormattingEnabled = True
        Me.cboAllTags.Location = New System.Drawing.Point(44, 54)
        Me.cboAllTags.Name = "cboAllTags"
        Me.cboAllTags.Size = New System.Drawing.Size(190, 21)
        Me.cboAllTags.TabIndex = 1
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(266, 52)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 2
        Me.btnInsert.Text = "Insert Code"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'txtCollected
        '
        Me.txtCollected.Location = New System.Drawing.Point(44, 129)
        Me.txtCollected.Multiline = True
        Me.txtCollected.Name = "txtCollected"
        Me.txtCollected.Size = New System.Drawing.Size(297, 67)
        Me.txtCollected.TabIndex = 3
        '
        'lblModified
        '
        Me.lblModified.AutoSize = True
        Me.lblModified.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModified.Location = New System.Drawing.Point(40, 97)
        Me.lblModified.Name = "lblModified"
        Me.lblModified.Size = New System.Drawing.Size(167, 20)
        Me.lblModified.TabIndex = 4
        Me.lblModified.Text = "Text to be modified:"
        '
        'lblTagSelect
        '
        Me.lblTagSelect.AutoSize = True
        Me.lblTagSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagSelect.Location = New System.Drawing.Point(40, 22)
        Me.lblTagSelect.Name = "lblTagSelect"
        Me.lblTagSelect.Size = New System.Drawing.Size(148, 20)
        Me.lblTagSelect.TabIndex = 5
        Me.lblTagSelect.Text = "Select HTML tag:"
        '
        'frmInsertCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 212)
        Me.Controls.Add(Me.lblTagSelect)
        Me.Controls.Add(Me.lblModified)
        Me.Controls.Add(Me.txtCollected)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.cboAllTags)
        Me.MaximizeBox = False
        Me.Name = "frmInsertCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert HTML Tags"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboAllTags As System.Windows.Forms.ComboBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents txtCollected As System.Windows.Forms.TextBox
    Friend WithEvents lblModified As System.Windows.Forms.Label
    Friend WithEvents lblTagSelect As System.Windows.Forms.Label
End Class
