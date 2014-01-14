<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifyTags
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModifyTags))
        Me.lstAllTags = New System.Windows.Forms.ListBox
        Me.btnAddTag = New System.Windows.Forms.Button
        Me.btnRemoveTag = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstAllTags
        '
        Me.lstAllTags.FormattingEnabled = True
        Me.lstAllTags.Location = New System.Drawing.Point(34, 24)
        Me.lstAllTags.Name = "lstAllTags"
        Me.lstAllTags.Size = New System.Drawing.Size(192, 108)
        Me.lstAllTags.TabIndex = 0
        '
        'btnAddTag
        '
        Me.btnAddTag.Location = New System.Drawing.Point(263, 24)
        Me.btnAddTag.Name = "btnAddTag"
        Me.btnAddTag.Size = New System.Drawing.Size(91, 23)
        Me.btnAddTag.TabIndex = 1
        Me.btnAddTag.Text = "Add Tag"
        Me.btnAddTag.UseVisualStyleBackColor = True
        '
        'btnRemoveTag
        '
        Me.btnRemoveTag.Location = New System.Drawing.Point(263, 65)
        Me.btnRemoveTag.Name = "btnRemoveTag"
        Me.btnRemoveTag.Size = New System.Drawing.Size(91, 23)
        Me.btnRemoveTag.TabIndex = 2
        Me.btnRemoveTag.Text = "Remove Tag"
        Me.btnRemoveTag.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(263, 109)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(91, 23)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'frmModifyTags
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 173)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRemoveTag)
        Me.Controls.Add(Me.btnAddTag)
        Me.Controls.Add(Me.lstAllTags)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(400, 200)
        Me.MinimumSize = New System.Drawing.Size(400, 200)
        Me.Name = "frmModifyTags"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage HTML Tags"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstAllTags As System.Windows.Forms.ListBox
    Friend WithEvents btnAddTag As System.Windows.Forms.Button
    Friend WithEvents btnRemoveTag As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
End Class
