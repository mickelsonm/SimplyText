'Author: Matt Mickelson
'Purpose: This form allows the user to add or remove tags from the database.

Option Strict On
Option Explicit On

Imports System.Data.OleDb

Public Class frmModifyTags

    'Database that will be connected to
    Dim database As String = "simplytext.mdb"

    'Table that the tags will be retrieved from
    Dim table As String = "html_tbl"

    'Database connection string
    Dim mstrCN As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & database.ToString & ";"
    'Dim mstrCN As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=simplytext.mdb;"

    Private Sub frmModifyTags_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UpdateTags("start")
    End Sub

    Private Sub btnAddTag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTag.Click
        Dim strID As String
        Dim strStartTag As String
        Dim strEndTag As String
        Dim blnIsRdy As Boolean

        'Get the reference id
        strID = InputBox("What will the reference name be for this tag?", "Tag Reference")

        'Get the starting tag
        strStartTag = InputBox("What will the starting tag be for this tag?", "Starting Tag Name")

        'Get he ending tag
        strEndTag = InputBox("What will the ending tag be for this tag?", "Ending Tag Name")

        If (strID.Length > 0 And strStartTag.Length > 0 And strEndTag.Length > 0) Then
            blnIsRdy = True
        End If

        'Insert these into the database
        If (blnIsRdy) Then
            UpdateTags("insert into " & table & " values( '" & strID & "', '" & strStartTag & "', '" & strEndTag & "')")

            MessageBox.Show(strID & " was added to the database!", "Tag Added")

            UpdateTags("update")
        Else
            MessageBox.Show("Failed to add the tag to the database!", "Error")
        End If
      

    End Sub

    Private Sub UpdateTags(Byref sql As String)
        Dim strSQL As String
        Dim objConnection As New OleDbConnection(mstrCN)
        Dim blnConnected As Boolean = False

        'Atempt to open the database. If it cant open the database, then throw an error.
        ' if( blnConnected) //success, anything else...failed
        Try
            objConnection.Open()
            blnConnected = True
        Catch ex As Exception
            MessageBox.Show("Could not connect to the Database", "Error")
            blnConnected = False
        End Try

        If (sql = "start" Or sql = "update") Then
            sql = "Select strTagID, startTagName & ' ' & endTagName as htmlTags from " & table.ToString
        End If

        'SQL query
        strSQL = sql

        'Create the Data Adapter
        Dim objDataAdapter As New OleDbDataAdapter(strSQL, objConnection)

        'Create the dataset
        Dim objDataSet As New DataSet

        'Populate the dataset with the fill method.
        objDataAdapter.Fill(objDataSet, "strTagID")
        lstAllTags.DataSource = objDataSet.Tables("strTagID")
        'Gets the Alias from the SQL command named FullName
        'Sets the drop down values to those of the Full_Names from the Database.
        lstAllTags.DisplayMember = "htmlTags"


        'Close the database and destroy the various objects used
        If blnConnected = True Then
            objConnection.Close()
            objDataAdapter.Dispose()
            objDataSet.Tables.Clear()
            objConnection.Dispose()
            blnConnected = False
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        UpdateTags("update")
    End Sub

    'This will handle the removal of the tags
    Private Sub btnRemoveTag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveTag.Click
        Dim strID As String
        Dim strTemp As String = ""
        Dim intStart As Integer = 0
        Dim intEnd As Integer = 0

        'As long as there is an item to remove, lets account for it
        'if there isn't then give them an error message
        If (lstAllTags.Items.Count > 0) Then
            strID = lstAllTags.Text

            'This gets the first tag of the pair Example: ' <em> '</em>

            For Each letter As Char In strID

                If (intEnd = 0) Then

                    'step through the letters of the selected tag
                    strTemp += letter

                    'Start of the tag
                    If (letter = "<" And intStart = 0) Then
                        intStart = 1
                    End If

                    'End of the tag
                    If (letter = ">" And intEnd = 0) Then
                        intEnd = 1
                    End If

                End If

            Next

            'Delete the tag from the database
            UpdateTags("Delete from " & table & " where startTagName= '" & strTemp & "'")

            'Tell them that the entry was removed
            MessageBox.Show(strTemp & " was removed!", "Tag Removed")

            'Call the update
            UpdateTags("update")

        Else
            'No entries available
            MessageBox.Show("There are no tags available for removal!", "No tags available")
        End If


    End Sub
End Class