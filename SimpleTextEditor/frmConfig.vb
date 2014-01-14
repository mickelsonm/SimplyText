'Author: Matt Mickelson
'Date: 12/3/09
'Purpose: This form configures the background color, font family, font color, and font size on
'         the output shown on the frmMain.vb page.

Option Strict On
Option Explicit On

Public Class frmConfig

    Dim objGeneric As New clsGeneric

    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Get the background color already being used.
        lblBackColor.Text = frmMain.txtDocument.BackColor.ToString

        'Get the font color already being used.
        lblFontColor.Text = frmMain.txtDocument.ForeColor.ToString

        'Get the current font already being used.
        lblCurrentFont.Text = frmMain.txtDocument.Font.Name

        'Get the font size already being used
        lblFontSize.Text = frmMain.txtDocument.Font.Size.ToString

        'Get the status of wordwrap from txtDocument on frmMain.vb
        chkWordWrap.Checked = frmMain.txtDocument.WordWrap

    End Sub

    'This sub handles the font family, style, and size changes.
    Private Sub FontChange()

        If fontSelect.ShowDialog = Windows.Forms.DialogResult.OK Then

            'update the output shown on the main form ( frmMain.vb )
            frmMain.txtDocument.Font = fontSelect.Font

            'update the font size label on this form
            lblFontSize.Text = fontSelect.Font.ToString

        End If
    End Sub

    'This sub handles the font color change
    Private Sub FontColorChange()

        If fontColorSelect.ShowDialog = Windows.Forms.DialogResult.OK Then

            'update the font color over on frmMain.vb
            frmMain.txtDocument.ForeColor = fontColorSelect.Color

            'update the font color label on this form
            lblFontColor.Text = fontColorSelect.Color.ToString

        End If

    End Sub

    'This sub handles the background color change
    Private Sub BackgroundColorChange()

        If backColorSelect.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Update the background color on frmMain.vb
            frmMain.txtDocument.BackColor = backColorSelect.Color

            'update the background color label on this form
            lblBackColor.Text = backColorSelect.Color.ToString

        End If

    End Sub

    'Change the background color click event
    Private Sub btnBackColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackColor.Click
        BackgroundColorChange()
    End Sub


    'Change the font color click event
    Private Sub btnFontColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFontColor.Click
        FontColorChange()
    End Sub

    'Change the font family & size click event
    Private Sub btnChangeFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        FontChange()
    End Sub

    'Exit the form when they click this button
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub chkWordWrap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWordWrap.CheckedChanged

        If (chkWordWrap.Checked = True) Then
            frmMain.txtDocument.WordWrap = True
        Else
            frmMain.txtDocument.WordWrap = False
        End If

    End Sub

    Private Sub chkFullScreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFullScreen.CheckedChanged
        If (chkFullScreen.Checked = True) Then
            objGeneric.FullScreen = True
        Else
            objGeneric.FullScreen = False
        End If

    End Sub

End Class