'Author: Matt Mickelson
'Date: 12/3/09
'Purpose: This is the class object for all templates available.

Option Strict On
Option Explicit On

Imports System.IO

Public Class clsTemplates

    Const HTML_TEMPLATE_FILE As String = "Templates\html_template.html"
    Const PHP_TEMPLATE_FILE As String = "Templates\php_template.php"

    Public Function get_html_template() As String

        Dim strHTML As String = ""
        Dim fileReader As StreamReader

        'use the file reader to open the file
        fileReader = File.OpenText(HTML_TEMPLATE_FILE)
        strHTML = fileReader.ReadToEnd()

        'close the file reader
        fileReader.Close()

        Return strHTML

    End Function

    Public Function get_php_template() As String

        Dim strPHP As String = ""
        Dim fileReader As StreamReader

        'use the file reader to open the file
        fileReader = File.OpenText(PHP_TEMPLATE_FILE)

        strPHP = fileReader.ReadToEnd()

        'close the file reader
        fileReader.Close()

        Return strPHP

    End Function

End Class
