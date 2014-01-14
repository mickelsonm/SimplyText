'Author: Matt Mickelson
'Purpose: This form will allow the user to add html tags inside txtDocument
'         located inside of frmMain

Option Strict On
Option Explicit On

Imports System.Data.OleDb

Public Class frmInsertCode

    'Database that will be connected to
    Dim database As String = "simplytext.mdb"

    'Table that the tags will be retrieved from
    Dim table As String = "html_tbl"

    'Database connection string
    Dim mstrCN As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & database.ToString & ";"

    Dim objGeneric As New clsGeneric


    'Populate the tags available
    Private Sub frmInsertCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strSQL As String
        Dim objConnection As New OleDbConnection(mstrCN)
        Dim blnConnected As Boolean = False

        'Atempt to open the database. If it cant open the database, then throw an error.
        ' if( blnConnected) //success, anything else...failed
        Try
            objConnection.Open()
            blnConnected = True
        Catch ex As Exception
            MessageBox.Show("Could not connect to the Database")
            blnConnected = False
        End Try

        'SQL query
        strSQL = "Select strTagID, startTagName & ' ' & endTagName as htmlTags from " & table.ToString

        'Create the Data Adapter
        Dim objDataAdapter As New OleDbDataAdapter(strSQL, objConnection)

        'Create the dataset
        Dim objDataSet As New DataSet

        'Populate the dataset with the fill method.
        objDataAdapter.Fill(objDataSet, "strTagID")
        Me.cboAllTags.DataSource = objDataSet.Tables("strTagID")
        'Gets the Alias from the SQL command named FullName
        'Sets the drop down values to those of the Full_Names from the Database.
        Me.cboAllTags.DisplayMember = "htmlTags"

        'Close the database and destroy the various objects used
        If blnConnected = True Then
            objConnection.Close()
            objDataAdapter.Dispose()
            objDataSet.Tables.Clear()
            objConnection.Dispose()
            blnConnected = False
        End If

    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click

        Dim strText As String
        Dim strTemp As String = ""
        Dim intCount As Integer = 0
        Dim blnIsDone As Boolean = False
        Dim blnRanFirst As Boolean = False

        strText = cboAllTags.Text.ToString

        If (txtCollected.Text.Length > 0) Then

            'Loop through each character of the tags they selected
            For Each letter As Char In strText

                'Add each letter to strTemp
                strTemp += letter.ToString

                'Look for the ending of the first tag
                If (letter = ">" And blnIsDone = False) Then
                    blnRanFirst = True
                End If

                'After the starting tag, apply the text that was passed in, then
                'flag it, so we are done with this
                If (letter = ">" And blnRanFirst = True And blnIsDone = False) Then
                    strTemp += txtCollected.Text
                    blnIsDone = True
                End If

            Next

            'Add the tags before and after the selected
            frmMain.addHTMLCode(strTemp & objGeneric.newLine)

        Else
            'Add just the tags
            frmMain.addHTMLCode(strText & objGeneric.newLine)

        End If

    End Sub
End Class