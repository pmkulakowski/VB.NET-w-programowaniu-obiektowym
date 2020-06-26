Imports System.Collections
Public Class Library

    ' konstruktor
    Private m_shelf As New SortedList()

    ' metody
    Public Sub CheckIn(ByVal newBook As Book)
        m_shelf.Add(newBook.Title, newBook)
    End Sub

    Public Function CheckOut(ByVal title As String) As Book
        Dim theBook As Book
        theBook = CType(m_shelf(title), Book)
        m_shelf.Remove(title)
        Return theBook

    End Function
End Class
