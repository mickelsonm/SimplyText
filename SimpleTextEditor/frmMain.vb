'Author: Matt Mickelson
'Date: 12/3/09
'Purpose: This form is the first to be shown and the gateway to some of the other
'         features that exist within this browser.

'Compiler options
Option Strict On
Option Explicit On

'Imports
Imports System.IO

Public Class frmMain

    'class level variables
    Dim strDocumentName As String = String.Empty
    Dim blnIsChanged As Boolean = False
    Dim strFontName As String
    Dim intFontSize As Integer
    Dim intTimerCounter As Integer = 0

    'Get access to the template-related items
    Dim objTemplate As New clsTemplates


    '-------------------------------------------------------------------------------------------
    ' Form Load
    '-------------------------------------------------------------------------------------------
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'show the splash screen
        showSplashScreen()

        'At the start, get the default font and size
        strFontName = txtDocument.Font.Name
        intFontSize = Convert.ToInt32(txtDocument.Font.Size)

    End Sub

    'This sub will close the splash screen, once it reaches this point
    Private Sub tmrKillSplash_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrKillSplash.Tick

        intTimerCounter += 1

        If (intTimerCounter = 1) Then
            splashSimplyText.Close()
            tmrKillSplash.Stop()
            Me.Show()

        End If

    End Sub

    'When something on the document has changed
    'flag blnIsChanged as true
    Private Sub txtDocument_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'document has changed
        blnIsChanged = True

    End Sub

    '-------------------------------------------------------------------------------------------
    '                                   Menu-Click Events
    '-------------------------------------------------------------------------------------------

    'Handle the click event for creating new files
    Private Sub mnuFileNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileNew.Click

        'Start a new document
        If blnIsChanged = True Then

            'document has changed and isn't saved
            If MessageBox.Show("The current document has not been saved!" _
                               & " Are you sure?", "Confirm", _
                               MessageBoxButtons.YesNo) = _
                               Windows.Forms.DialogResult.Yes Then
                ClearContent()
            End If

        Else
            'This document has not changed
            ClearContent()
        End If

    End Sub

    'Handle the click event for opening files
    Private Sub mnuFileOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click

        If blnIsChanged = True Then

            If MessageBox.Show("The current document has not been saved!" _
                               & " Do you wish to discard your changes?", "Confirm", _
                               MessageBoxButtons.YesNo) = _
                               Windows.Forms.DialogResult.Yes Then
                ClearContent()
                OpenFile()

            End If

        Else
            ClearContent()
            OpenFile()

        End If

    End Sub

    'Handle the click event for saving files
    Private Sub mnuFileSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSave.Click

        'If there is no document name, then we can move on, if there is
        'already a document, then lets save it already!
        If strDocumentName = String.Empty Then

            If sfdSaveFile.ShowDialog = _
            Windows.Forms.DialogResult.OK Then
                strDocumentName = sfdSaveFile.FileName
                SaveContent()
            End If
        Else
            SaveContent()
        End If

    End Sub

    'Handle the file save as click event
    Private Sub mnuFileSaveAs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileSaveAs.Click

        'Save the current document under a new file name
        If sfdSaveFile.ShowDialog = _
        Windows.Forms.DialogResult.OK Then
            strDocumentName = sfdSaveFile.FileName
            SaveContent()
        End If

    End Sub

    'Close the application, when they click exit
    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    'About this program
    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        frmAbout.ShowDialog()
    End Sub

    'As the form is closing & the document has changed
    'Ask them if they are sure if this is what they want to do...
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'Only ask if something has changed, otherwise let them exit
        If blnIsChanged = True Then

            If MessageBox.Show("The current document is not saved. " _
                & " Are you sure you want to exit?", "Confirm", _
                MessageBoxButtons.YesNo) = _
                Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If

        End If

    End Sub

    'Handle the printing setup, etc
    Private Sub pdPrint_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdPrinting.PrintPage

        'Print the contents of the document
        e.Graphics.DrawString(txtDocument.Text, _
                              New Font(strFontName, intFontSize, _
                                       FontStyle.Regular), Brushes.Black, 10, 10)
    End Sub

    'Handle the click event for printing
    Private Sub mnuPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPrint.Click
        pdPrinting.Print()
    End Sub

    'Show the configuration of the page
    'Eventually, all this will be moved to a complete XML config format
    Private Sub mnuConfigEd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuConfigEd.Click

        frmConfig.ShowDialog()

    End Sub

    'Get the HTML template selected from clsTemplates
    Private Sub mnuHTML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHTML.Click
        Dim strCode As String
        strCode = objTemplate.get_html_template()

        txtDocument.Clear()
        txtDocument.Text = strCode

        blnIsChanged = True
    End Sub

    'Get the PHP template selected from clsTemplates
    Private Sub mnuPHP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPHP.Click
        Dim strCode As String

        strCode = objTemplate.get_php_template()

        txtDocument.Clear()
        txtDocument.Text = strCode

        blnIsChanged = True
    End Sub

    'Display the contentss inside of a dynamic web browser
    Private Sub mnuBrowserView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBrowserView.Click
        ViewCodeInBrowser()
    End Sub

    'Convert text to all uppercase letters
    Private Sub mnuTextToUpper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTextToUpper.Click
        txtDocument.SelectedText = textToUpperCase(txtDocument.SelectedText)
    End Sub

    'Convert text to all lowercase letters
    Private Sub mnuTextToLower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTextToLower.Click
        txtDocument.SelectedText = textToLowerCase(txtDocument.SelectedText)
    End Sub

    'Convert text to the inverse of the origional...Example MaTt -> mAtT
    Private Sub mnuInvertText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInvertText.Click
        txtDocument.SelectedText = invertText(txtDocument.SelectedText)
    End Sub

    'Redo the last operation that happened inside of txtDocument
    Private Sub mnuRedo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRedo.Click
        Redo()
    End Sub

    'Undo the last operation that happened inside of txtDocument
    Private Sub mnuUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUndo.Click
        Undo()
    End Sub

    'Copy whatever is selected inside of txtDocument
    Private Sub mnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopy.Click
        Copy()
    End Sub

    'Cut whatever is selected inside of txtDocument into clipboard
    Private Sub mnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCut.Click
        Cut()
    End Sub

    'Paste whatever is in the clipboard into txtDocument
    Private Sub mnuPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPaste.Click
        Paste()
    End Sub

    'Turn text into bold text
    Private Sub mnuBoldText_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBoldText.Click
        boldSelectedText(txtDocument.SelectedText)
    End Sub

    'turn text into italic text
    Private Sub mnuItalics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItalicText.Click
        italicSelectedText(txtDocument.SelectedText)
    End Sub

    'Manage the html tags
    Private Sub mnuManageTags_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuManageTags.Click
        frmModifyTags.ShowDialog()
    End Sub

    'Insert the html tags
    Private Sub mnuInsertTags_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInsertTags.Click
        insertHTML()
    End Sub

    '-------------------------------------------------------------------------------------------
    '                               Right-Click Events
    '-------------------------------------------------------------------------------------------

    'UPPERCASE TEXT
    Private Sub mnuRightUpper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRightUpper.Click
        txtDocument.SelectedText = textToUpperCase(txtDocument.SelectedText)
    End Sub

    'lowercase text
    Private Sub mnuRightLower_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRightLower.Click
        txtDocument.SelectedText = textToLowerCase(txtDocument.SelectedText)
    End Sub

    'Inverse text
    Private Sub mnuRightInverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRightInverse.Click
        txtDocument.SelectedText = invertText(txtDocument.SelectedText)
    End Sub

    'Copy
    Private Sub mnuRightCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRightCopy.Click
        Copy()
    End Sub

    'Cut
    Private Sub mnuRightCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRightCut.Click
        Cut()
    End Sub

    'Paste
    Private Sub mnuRightPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRightPaste.Click
        Paste()
    End Sub

    'Browser preview
    Private Sub mnuRightBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRightBrowser.Click
        ViewCodeInBrowser()
    End Sub

    'Bold
    Private Sub mnuRightBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRightBold.Click
        boldSelectedText(txtDocument.SelectedText)
    End Sub

    'Italicize
    Private Sub mnuRightItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRightItalic.Click
        italicSelectedText(txtDocument.SelectedText)
    End Sub

    'Display the insert html form
    Private Sub mnuRightInsHTML_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRightInsHTML.Click
        insertHTML()
    End Sub

    '-------------------------------------------------------------------------------------------
    '                                   Subs & Functions
    '-------------------------------------------------------------------------------------------

    '
    ' Display the splash screen
    '
    Private Sub showSplashScreen()
        tmrKillSplash.Start()
        splashSimplyText.ShowDialog()
    End Sub

    '
    ' Clear the contents of the current document
    '
    Private Sub ClearContent()

        'Clear the contents of the document
        txtDocument.Clear()

        'Clear the document name
        strDocumentName = String.Empty

        'set blnIsChanged to false
        blnIsChanged = False

    End Sub

    '
    ' Handle the opening of documents
    '
    Private Sub OpenFile()

        'Create a new file reader
        Dim fileReader As StreamReader

        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then

            'update the document name, which we are viewing
            strDocumentName = ofdOpenFile.FileName

            If (strDocumentName.Contains(".rtf")) Then
                txtDocument.LoadFile(strDocumentName)
            Else
                'use the file reader to open the file
                fileReader = File.OpenText(strDocumentName)

                'get the text from the file reader and assign it to txtDocument.text
                txtDocument.Text = fileReader.ReadToEnd()

                'close the file reader
                fileReader.Close()
            End If

        End If

    End Sub

    '
    ' Handle the saving of documents
    '
    Private Sub SaveContent()

        'Create a new file writer
        Dim fileWriter As StreamWriter

        If (strDocumentName.Contains(".rtf")) Then
            txtDocument.SaveFile(strDocumentName)
        Else
            'Assign the file writer the name of our new file
            fileWriter = File.CreateText(strDocumentName)

            'Write out the file and close the filewriter when we are done using it
            fileWriter.Write(txtDocument.Text)

            fileWriter.Close()
        End If

        'update the blnIsChanged variable.
        blnIsChanged = False

    End Sub

    '
    ' Handle the save as of documents
    '
    Private Sub SaveAs()

        'If we have specified a new file name and location, lets reset the 
        'current file name and save it already!
        If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strDocumentName = sfdSaveFile.FileName
            SaveContent()
        End If

    End Sub

    '
    ' Display the contents of our file inside of a dynamic browser
    '
    Private Sub ViewCodeInBrowser()

        Dim objNewWindow As New Form
        Dim newBrowser As New WebBrowser
        Dim blnIsFullScreen As Boolean

        'There needs to be some content to 
        If (txtDocument.Text.Length > 0) Then

            'Setup the various properties for the new window
            objNewWindow.Text = "Browser Preview"
            objNewWindow.Icon = Me.Icon

            objNewWindow.Width = 800
            objNewWindow.Height = 600

            objNewWindow.StartPosition = FormStartPosition.CenterScreen
            objNewWindow.Controls.Add(newBrowser)

            'Setup various properties for the new browser
            newBrowser.Dock = DockStyle.Fill
            newBrowser.DocumentText = txtDocument.Text

            'Check to see if the new window needs to be full-screen or not
            blnIsFullScreen = frmConfig.chkFullScreen.Checked

            If (blnIsFullScreen = True) Then
                objNewWindow.WindowState = FormWindowState.Maximized
            Else
                objNewWindow.WindowState = FormWindowState.Normal
            End If

            'Display output
            objNewWindow.ShowDialog()
        Else
            'There was no content!
            MessageBox.Show("There needs to be some content to display!", "Content Needed")
        End If

    End Sub


    '
    ' Convert text to uppercase
    '
    Private Function textToUpperCase(ByVal text As String) As String
        'Declare variables
        Dim strTempText As String
        Dim strNewText As String

        'assign the text to be manipulated
        strTempText = text

        'convert the selected text to upper case
        strNewText = strTempText.ToUpper

        'return the newly setup text
        Return strNewText

    End Function

    '
    ' Convert text to UPPERCASE
    '
    Private Function textToLowerCase(ByVal text As String) As String
        'Declare variables
        Dim strTempText As String
        Dim strNewText As String

        'assign the text to be manipulated
        strTempText = text

        'convert the selected text to lower case
        strNewText = strTempText.ToLower

        'Return the newly setup text
        Return strNewText

    End Function

    '
    ' Convert text to InVeRsE
    '
    Private Function invertText(ByVal text As String) As String
        Dim strTempText As String
        Dim strNewText As String = ""

        'assign the text to be manipulated
        strTempText = text

        'step through each letter of the selected text
        For Each letter As Char In text

            If (Char.IsLower(letter) = True) Then
                strNewText += Char.ToUpper(letter)
            Else
                strNewText += Char.ToLower(letter)
            End If

        Next

        'Return the newly setup text
        Return strNewText

    End Function

    '
    ' Copy whatever is selected in txtDocument
    '
    Private Sub Copy()
        txtDocument.Copy()
        blnIsChanged = True
    End Sub

    '
    ' Cut whatever is selected in txtDocument
    '
    Private Sub Cut()
        txtDocument.Cut()
        blnIsChanged = True
    End Sub

    '
    ' Paste whatever is in clipboard into txtDocument
    '
    Private Sub Paste()
        txtDocument.Paste()
        blnIsChanged = True
    End Sub

    '
    ' Redo the last action that was performed inside of txtDocument
    '
    Private Sub Redo()
        txtDocument.Redo()
        blnIsChanged = True
    End Sub

    '
    ' Under the action performed inside of txtDocument
    '
    Private Sub Undo()
        txtDocument.Undo()
        blnIsChanged = True
    End Sub

    '
    ' Bold the selected text
    '
    Private Sub boldSelectedText(ByVal text As String)
        Try
            txtDocument.SelectionStart = txtDocument.Find(text)
            Dim ifont As New Font(txtDocument.SelectionFont, FontStyle.Bold)
            txtDocument.SelectionFont = ifont
        Catch ex As Exception
            MessageBox.Show("You need to have text selected, before you can bold!", "No text selected")
        End Try
    End Sub


    '
    ' Italicize the selected text
    '
    Private Sub italicSelectedText(ByVal text As String)
        Try

            txtDocument.SelectionStart = txtDocument.Find(text)
            Dim ifont As New Font(txtDocument.SelectionFont, FontStyle.Italic)
            txtDocument.SelectionFont = ifont

        Catch ex As Exception
            MessageBox.Show("You need to have text selected, before you can italicize!", "No text selected")
        End Try
    End Sub

  
    '
    ' Insert HTML tags
    '
    Public Sub insertHTML()

        'If they have something selected, then we need to modify this text
        'over on the frmInsertCode form.
        If (txtDocument.SelectedText.Length > 0) Then
            frmInsertCode.txtCollected.Text = txtDocument.SelectedText.ToString
            frmInsertCode.Show()
        Else
            'We will just add
            frmInsertCode.txtCollected.Enabled = False
            frmInsertCode.txtCollected.Visible = False
            frmInsertCode.lblModified.Enabled = False
            frmInsertCode.lblModified.Visible = False

            'Resize the form
            frmInsertCode.Width = 386
            frmInsertCode.Height = 124

            frmInsertCode.Show()
        End If

    End Sub

    '
    ' Add the html code to txtDocument
    '
    Public Sub addHTMLCode(ByVal code As String)
        'Replaces the selected, with the new one
        txtDocument.SelectedText = code.ToString
        blnIsChanged = True
    End Sub

End Class
