Imports DevExpress.Mvvm
Imports System
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace DXSample
    Public Class MainViewModel
        Public Property Pages() As ObservableCollection(Of PageViewModel)
        Public Sub New()
            Pages = New ObservableCollection(Of PageViewModel)() From { _
                New PageViewModel() With {.Text = "Welcome Page", .Type = PageType.Welcome}, _
                New PageViewModel() With {.Text = "Common Page", .Type = PageType.Common}, _
                New PageViewModel() With {.Text = "Completion Page", .Type = PageType.Completion} _
            }
        End Sub
    End Class

    Public Enum PageType
        Welcome
        Common
        Completion
    End Enum
    Public Class PageViewModel
        Public Property Text() As String
        Public Property Type() As PageType
    End Class
End Namespace
