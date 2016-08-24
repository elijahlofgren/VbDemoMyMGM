Imports System.Data.Entity

Public Class LocalEvent
    Public Property ID() As Integer
    Public Property Title() As String
    Public Property StartDate() As Date
    Public Property Description() As String
    Public Property Url() As String
End Class

Public Class LocalEventDBContext
    Inherits DbContext
    Public Property LocalEvents() As DbSet(Of LocalEvent)
End Class