Public Class Book
    ' deklaracja pól
    Public Text As String = ""
    Public PageLenght As Integer = 10

    ' konstruktor
    Private m_title As String

    ' właściwości
    Public Property Title() As String
        Get
            Return m_title
        End Get
        Set(value As String)
            m_title = value
        End Set
    End Property

    ' metoda
    Public Function GetPage(ByVal pageNumber As Integer) As String

        Dim start As Integer = (pageNumber - 1) * PageLenght

        If (start < Text.Length) And (start >= 0) Then
            If (start + PageLenght) < Text.Length Then
                Return Text.Substring(start, PageLenght)
            Else
                Return Text.Substring(start, Text.Length - start)
            End If
        Else
            Return ""
        End If

    End Function
End Class
