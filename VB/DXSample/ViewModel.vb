Imports System.Collections.ObjectModel

Namespace DXSample

    Public Class MainViewModel

        Public Property Pages As ObservableCollection(Of PageViewModel)

        Public Sub New()
            Pages = New ObservableCollection(Of PageViewModel)() From {New PageViewModel() With {.Text = "Welcome Page", .Type = PageType.Welcome}, New PageViewModel() With {.Text = "Common Page", .Type = PageType.Common}, New PageViewModel() With {.Text = "Completion Page", .Type = PageType.Completion}}
        End Sub
    End Class

    Public Enum PageType
        Welcome
        Common
        Completion
    End Enum

    Public Class PageViewModel

        Public Property Text As String

        Public Property Type As PageType
    End Class
End Namespace
