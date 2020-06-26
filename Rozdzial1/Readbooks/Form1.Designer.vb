<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.listOfBooks = New System.Windows.Forms.ListBox()
        Me.pageLenght = New System.Windows.Forms.NumericUpDown()
        Me.pageToDisplay = New System.Windows.Forms.NumericUpDown()
        Me.page = New System.Windows.Forms.RichTextBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.lblListOfBooks = New System.Windows.Forms.Label()
        Me.lblPageLenght = New System.Windows.Forms.Label()
        Me.lblPageToDisplay = New System.Windows.Forms.Label()
        CType(Me.pageLenght, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pageToDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listOfBooks
        '
        Me.listOfBooks.FormattingEnabled = True
        Me.listOfBooks.Location = New System.Drawing.Point(12, 27)
        Me.listOfBooks.Name = "listOfBooks"
        Me.listOfBooks.Size = New System.Drawing.Size(120, 95)
        Me.listOfBooks.TabIndex = 0
        '
        'pageLenght
        '
        Me.pageLenght.Location = New System.Drawing.Point(12, 142)
        Me.pageLenght.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.pageLenght.Name = "pageLenght"
        Me.pageLenght.Size = New System.Drawing.Size(120, 20)
        Me.pageLenght.TabIndex = 1
        Me.pageLenght.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pageToDisplay
        '
        Me.pageToDisplay.Location = New System.Drawing.Point(154, 142)
        Me.pageToDisplay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.pageToDisplay.Name = "pageToDisplay"
        Me.pageToDisplay.Size = New System.Drawing.Size(120, 20)
        Me.pageToDisplay.TabIndex = 2
        Me.pageToDisplay.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'page
        '
        Me.page.Location = New System.Drawing.Point(154, 27)
        Me.page.Name = "page"
        Me.page.Size = New System.Drawing.Size(120, 95)
        Me.page.TabIndex = 3
        Me.page.Text = ""
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Location = New System.Drawing.Point(151, 11)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(0, 13)
        Me.titleLabel.TabIndex = 4
        '
        'lblListOfBooks
        '
        Me.lblListOfBooks.AutoSize = True
        Me.lblListOfBooks.Location = New System.Drawing.Point(9, 11)
        Me.lblListOfBooks.Name = "lblListOfBooks"
        Me.lblListOfBooks.Size = New System.Drawing.Size(68, 13)
        Me.lblListOfBooks.TabIndex = 5
        Me.lblListOfBooks.Text = "List of Books"
        '
        'lblPageLenght
        '
        Me.lblPageLenght.AutoSize = True
        Me.lblPageLenght.Location = New System.Drawing.Point(9, 126)
        Me.lblPageLenght.Name = "lblPageLenght"
        Me.lblPageLenght.Size = New System.Drawing.Size(64, 13)
        Me.lblPageLenght.TabIndex = 6
        Me.lblPageLenght.Text = "Page lenght"
        '
        'lblPageToDisplay
        '
        Me.lblPageToDisplay.AutoSize = True
        Me.lblPageToDisplay.Location = New System.Drawing.Point(151, 126)
        Me.lblPageToDisplay.Name = "lblPageToDisplay"
        Me.lblPageToDisplay.Size = New System.Drawing.Size(79, 13)
        Me.lblPageToDisplay.TabIndex = 7
        Me.lblPageToDisplay.Text = "Page to display"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 174)
        Me.Controls.Add(Me.lblPageToDisplay)
        Me.Controls.Add(Me.lblPageLenght)
        Me.Controls.Add(Me.lblListOfBooks)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.page)
        Me.Controls.Add(Me.pageToDisplay)
        Me.Controls.Add(Me.pageLenght)
        Me.Controls.Add(Me.listOfBooks)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pageLenght, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pageToDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listOfBooks As ListBox
    Friend WithEvents pageLenght As NumericUpDown
    Friend WithEvents pageToDisplay As NumericUpDown
    Friend WithEvents page As RichTextBox
    Friend WithEvents titleLabel As Label
    Friend WithEvents lblListOfBooks As Label
    Friend WithEvents lblPageLenght As Label
    Friend WithEvents lblPageToDisplay As Label
End Class
