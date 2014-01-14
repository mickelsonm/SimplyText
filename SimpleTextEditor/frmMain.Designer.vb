<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuAll = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPrint = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuUndo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRedo = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTextToUpper = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTextToLower = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuInvertText = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBoldText = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuItalicText = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuConfigEd = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuInsertTags = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuFromTemp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHTML = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuPHP = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuManageTags = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuBrowserView = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog
        Me.sfdSaveFile = New System.Windows.Forms.SaveFileDialog
        Me.pdPrinting = New System.Drawing.Printing.PrintDocument
        Me.mnuRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRightUpper = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRightLower = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRightInverse = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRightCopy = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRightCut = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRightPaste = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRightBold = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRightItalic = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRightInsHTML = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuRightBrowser = New System.Windows.Forms.ToolStripMenuItem
        Me.tmrKillSplash = New System.Windows.Forms.Timer(Me.components)
        Me.txtDocument = New System.Windows.Forms.RichTextBox
        Me.mnuAll.SuspendLayout()
        Me.mnuRightClick.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuAll
        '
        Me.mnuAll.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuTools, Me.mnuHelp})
        Me.mnuAll.Location = New System.Drawing.Point(0, 0)
        Me.mnuAll.Name = "mnuAll"
        Me.mnuAll.Size = New System.Drawing.Size(792, 24)
        Me.mnuAll.TabIndex = 0
        Me.mnuAll.Text = "mnuAll"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuPrint, Me.mnuFileExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        Me.mnuFileNew.Size = New System.Drawing.Size(124, 22)
        Me.mnuFileNew.Text = "New"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(124, 22)
        Me.mnuFileOpen.Text = "Open"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(124, 22)
        Me.mnuFileSave.Text = "Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(124, 22)
        Me.mnuFileSaveAs.Text = "Save As"
        '
        'mnuPrint
        '
        Me.mnuPrint.Name = "mnuPrint"
        Me.mnuPrint.Size = New System.Drawing.Size(124, 22)
        Me.mnuPrint.Text = "Print"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(124, 22)
        Me.mnuFileExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuUndo, Me.mnuRedo, Me.mnuCopy, Me.mnuCut, Me.mnuPaste, Me.mnuTextToUpper, Me.mnuTextToLower, Me.mnuInvertText, Me.mnuBoldText, Me.mnuItalicText})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(37, 20)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuUndo
        '
        Me.mnuUndo.Name = "mnuUndo"
        Me.mnuUndo.Size = New System.Drawing.Size(181, 22)
        Me.mnuUndo.Text = "Undo"
        '
        'mnuRedo
        '
        Me.mnuRedo.Name = "mnuRedo"
        Me.mnuRedo.Size = New System.Drawing.Size(181, 22)
        Me.mnuRedo.Text = "Redo"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.Size = New System.Drawing.Size(181, 22)
        Me.mnuCopy.Text = "Copy"
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(181, 22)
        Me.mnuCut.Text = "Cut"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.Size = New System.Drawing.Size(181, 22)
        Me.mnuPaste.Text = "Paste"
        '
        'mnuTextToUpper
        '
        Me.mnuTextToUpper.Name = "mnuTextToUpper"
        Me.mnuTextToUpper.Size = New System.Drawing.Size(181, 22)
        Me.mnuTextToUpper.Text = "Text to UPPERCASE"
        '
        'mnuTextToLower
        '
        Me.mnuTextToLower.Name = "mnuTextToLower"
        Me.mnuTextToLower.Size = New System.Drawing.Size(181, 22)
        Me.mnuTextToLower.Text = "Text to lowercase"
        '
        'mnuInvertText
        '
        Me.mnuInvertText.Name = "mnuInvertText"
        Me.mnuInvertText.Size = New System.Drawing.Size(181, 22)
        Me.mnuInvertText.Text = "TeXt To InVeRsE"
        '
        'mnuBoldText
        '
        Me.mnuBoldText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBoldText.Name = "mnuBoldText"
        Me.mnuBoldText.Size = New System.Drawing.Size(181, 22)
        Me.mnuBoldText.Text = "Bold text"
        '
        'mnuItalicText
        '
        Me.mnuItalicText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuItalicText.Name = "mnuItalicText"
        Me.mnuItalicText.Size = New System.Drawing.Size(181, 22)
        Me.mnuItalicText.Text = "Italicize text"
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuConfigEd, Me.mnuInsertTags, Me.mnuFromTemp, Me.mnuManageTags, Me.mnuBrowserView})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(44, 20)
        Me.mnuTools.Text = "Tools"
        '
        'mnuConfigEd
        '
        Me.mnuConfigEd.Name = "mnuConfigEd"
        Me.mnuConfigEd.Size = New System.Drawing.Size(178, 22)
        Me.mnuConfigEd.Text = "Configure Editor"
        '
        'mnuInsertTags
        '
        Me.mnuInsertTags.Name = "mnuInsertTags"
        Me.mnuInsertTags.Size = New System.Drawing.Size(178, 22)
        Me.mnuInsertTags.Text = "Insert HTML Tags"
        '
        'mnuFromTemp
        '
        Me.mnuFromTemp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHTML, Me.mnuPHP})
        Me.mnuFromTemp.Name = "mnuFromTemp"
        Me.mnuFromTemp.Size = New System.Drawing.Size(178, 22)
        Me.mnuFromTemp.Text = "Insert Template"
        '
        'mnuHTML
        '
        Me.mnuHTML.Name = "mnuHTML"
        Me.mnuHTML.Size = New System.Drawing.Size(111, 22)
        Me.mnuHTML.Text = "HTML"
        '
        'mnuPHP
        '
        Me.mnuPHP.Name = "mnuPHP"
        Me.mnuPHP.Size = New System.Drawing.Size(111, 22)
        Me.mnuPHP.Text = "PHP"
        '
        'mnuManageTags
        '
        Me.mnuManageTags.Name = "mnuManageTags"
        Me.mnuManageTags.Size = New System.Drawing.Size(178, 22)
        Me.mnuManageTags.Text = "Manage HTML Tags"
        '
        'mnuBrowserView
        '
        Me.mnuBrowserView.Name = "mnuBrowserView"
        Me.mnuBrowserView.Size = New System.Drawing.Size(178, 22)
        Me.mnuBrowserView.Text = "View in Browser"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(40, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(114, 22)
        Me.mnuHelpAbout.Text = "About"
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.Filter = resources.GetString("ofdOpenFile.Filter")
        '
        'sfdSaveFile
        '
        Me.sfdSaveFile.Filter = resources.GetString("sfdSaveFile.Filter")
        '
        'pdPrinting
        '
        '
        'mnuRightClick
        '
        Me.mnuRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRightUpper, Me.mnuRightLower, Me.mnuRightInverse, Me.mnuRightCopy, Me.mnuRightCut, Me.mnuRightPaste, Me.mnuRightBold, Me.mnuRightItalic, Me.mnuRightInsHTML, Me.mnuRightBrowser})
        Me.mnuRightClick.Name = "mnuRightClick"
        Me.mnuRightClick.Size = New System.Drawing.Size(170, 224)
        '
        'mnuRightUpper
        '
        Me.mnuRightUpper.Name = "mnuRightUpper"
        Me.mnuRightUpper.Size = New System.Drawing.Size(169, 22)
        Me.mnuRightUpper.Text = "UPPERCASE"
        '
        'mnuRightLower
        '
        Me.mnuRightLower.Name = "mnuRightLower"
        Me.mnuRightLower.Size = New System.Drawing.Size(169, 22)
        Me.mnuRightLower.Text = "lowercase"
        '
        'mnuRightInverse
        '
        Me.mnuRightInverse.Name = "mnuRightInverse"
        Me.mnuRightInverse.Size = New System.Drawing.Size(169, 22)
        Me.mnuRightInverse.Text = "InVeRsE"
        '
        'mnuRightCopy
        '
        Me.mnuRightCopy.Name = "mnuRightCopy"
        Me.mnuRightCopy.Size = New System.Drawing.Size(169, 22)
        Me.mnuRightCopy.Text = "Copy"
        '
        'mnuRightCut
        '
        Me.mnuRightCut.Name = "mnuRightCut"
        Me.mnuRightCut.Size = New System.Drawing.Size(169, 22)
        Me.mnuRightCut.Text = "Cut"
        '
        'mnuRightPaste
        '
        Me.mnuRightPaste.Name = "mnuRightPaste"
        Me.mnuRightPaste.Size = New System.Drawing.Size(169, 22)
        Me.mnuRightPaste.Text = "Paste"
        '
        'mnuRightBold
        '
        Me.mnuRightBold.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuRightBold.Name = "mnuRightBold"
        Me.mnuRightBold.Size = New System.Drawing.Size(169, 22)
        Me.mnuRightBold.Text = "Bold Text"
        '
        'mnuRightItalic
        '
        Me.mnuRightItalic.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuRightItalic.Name = "mnuRightItalic"
        Me.mnuRightItalic.Size = New System.Drawing.Size(169, 22)
        Me.mnuRightItalic.Text = "Italicize Text"
        '
        'mnuRightInsHTML
        '
        Me.mnuRightInsHTML.Name = "mnuRightInsHTML"
        Me.mnuRightInsHTML.Size = New System.Drawing.Size(169, 22)
        Me.mnuRightInsHTML.Text = "Insert HTML Tags"
        '
        'mnuRightBrowser
        '
        Me.mnuRightBrowser.Name = "mnuRightBrowser"
        Me.mnuRightBrowser.Size = New System.Drawing.Size(169, 22)
        Me.mnuRightBrowser.Text = "View in Browser"
        '
        'tmrKillSplash
        '
        Me.tmrKillSplash.Interval = 5000
        '
        'txtDocument
        '
        Me.txtDocument.AcceptsTab = True
        Me.txtDocument.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDocument.ContextMenuStrip = Me.mnuRightClick
        Me.txtDocument.DetectUrls = False
        Me.txtDocument.Location = New System.Drawing.Point(0, 27)
        Me.txtDocument.Name = "txtDocument"
        Me.txtDocument.Size = New System.Drawing.Size(792, 547)
        Me.txtDocument.TabIndex = 1
        Me.txtDocument.Text = ""
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.txtDocument)
        Me.Controls.Add(Me.mnuAll)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuAll
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simply Text"
        Me.mnuAll.ResumeLayout(False)
        Me.mnuAll.PerformLayout()
        Me.mnuRightClick.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuAll As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileNew As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents mnuPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pdPrinting As System.Drawing.Printing.PrintDocument
    Friend WithEvents mnuTools As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConfigEd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowserView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFromTemp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHTML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPHP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTextToUpper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTextToLower As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInvertText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuRightUpper As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRightLower As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRightInverse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrKillSplash As System.Windows.Forms.Timer
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRightCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRightCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRightPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtDocument As System.Windows.Forms.RichTextBox
    Friend WithEvents mnuBoldText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuItalicText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRightBold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRightItalic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInsertTags As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRightInsHTML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuManageTags As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuRightBrowser As System.Windows.Forms.ToolStripMenuItem

End Class
