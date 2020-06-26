Public Class Form1

    Private m_library As Library

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        m_library = New Library()

        Dim cookies As New Book()
        cookies.Text = "Chocolate chip cookies are the most delicious cookies."
        cookies.PageLenght = 8
        cookies.Title = "Cookies Recipes"

        Dim fairtyTales As New Book()
        fairtyTales.Text = "Once upon a time there was a bear."
        fairtyTales.PageLenght = 8
        fairtyTales.Title = "Fairty Talse"

        m_library.CheckIn(cookies)
        m_library.CheckIn(fairtyTales)

        listOfBooks.Items.Add(cookies.Title)
        listOfBooks.Items.Add(fairtyTales.Title)
    End Sub

    Private Sub listOfBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listOfBooks.SelectedIndexChanged
        Dim title As String = listOfBooks.SelectedItem.ToString()
        Dim theBook As Book = m_library.CheckOut(title)
        theBook.PageLenght = pageLenght.Value
        titleLabel.Text = theBook.Title
        page.Text = theBook.GetPage(pageToDisplay.Value)
        m_library.CheckIn(theBook)
    End Sub



    'Private Sub ShowPage_Click(sender As Object, e As EventArgs)

    '    Dim fairtyTales As New Book()
    '    fairtyTales.Text = "Once upon a time there was a bear."
    '    fairtyTales.PageLenght = 8
    '    fairtyTales.Title = "Fairty Talse"

    '    Dim cookies As Book = New Book()
    '    cookies.Text = "Chocolate chip cookies are the most delicious cookies."
    '    cookies.PageLenght = 8
    '    cookies.Title = "Cookies Recipes"

    '    Dim page As Integer = 3
    '    Dim report As String
    '    report = "Page: " & page.ToString() & ControlChars.CrLf _
    '        & fairtyTales.Title & ": " & fairtyTales.GetPage(page) _
    '        & ControlChars.CrLf _
    '        & "Cookies: " & cookies.GetPage(page)
    '    MessageBox.Show(report)
    '    report = "Titles: " + fairtyTales.Title & " and " & cookies.Title
    '    MessageBox.Show(report)
    'End Sub


End Class
