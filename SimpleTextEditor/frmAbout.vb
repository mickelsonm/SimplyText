'Author: Matt Mickelson
'Purpose: This is the about form.

Public Class frmAbout

    Dim strProgEmail As String = "mickelmr@gmail.com"
    Dim strGraphicsEmail As String = "davidvaini@gmail.com"

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub


    'Address selections

    Private Sub lblProgName_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblProgName.LinkClicked

        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Process.Start("mailto: " & strProgEmail)
        End If

    End Sub

    Private Sub lblGraphDesigner_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblGraphName.LinkClicked
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Process.Start("mailto: " & strGraphicsEmail)
        End If

    End Sub

    'Copy the e-mail address from the about screen to the clipboard
    Private Sub mnuCopyEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopyEmail.Click
        If Me.lblProgName.Focused Then
            'Copy the programmer's email to clipboard
            Clipboard.SetText(strProgEmail.ToString)
        Else
            'copy the graphic designer's email to clipboard
            Clipboard.SetText(strGraphicsEmail.ToString)
        End If

    End Sub

End Class