Option Strict On
Option Explicit On

Public Class clsGeneric

    Private strTempText As String
    Private blnFullScreen As Boolean

    Public Property TempText() As String
        Get
            Return strTempText
        End Get
        Set(ByVal value As String)
            strTempText = value
        End Set
    End Property

    Public Property FullScreen() As Boolean
        Get
            Return blnFullScreen
        End Get
        Set(ByVal value As Boolean)
            blnFullScreen = value
        End Set
    End Property

    Public Function newLine() As String
        Return ControlChars.NewLine
    End Function

End Class
