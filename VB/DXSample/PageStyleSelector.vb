Imports System.Windows
Imports System.Windows.Controls

Namespace DXSample
    Public Class PageStyleSelector
        Inherits StyleSelector

        Public Property WelcomePageStyle() As Style
        Public Property CommonPageStyle() As Style
        Public Property CompletionPageStyle() As Style
        Public Overrides Function SelectStyle(ByVal item As Object, ByVal container As DependencyObject) As Style
            If Not(TypeOf item Is PageViewModel) Then
                Return Nothing
            End If
            Dim vm = TryCast(item, PageViewModel)
            Select Case vm.Type
                Case PageType.Welcome
                    Return WelcomePageStyle
                Case PageType.Common
                    Return CommonPageStyle
                Case PageType.Completion
                    Return CompletionPageStyle
            End Select
            Return MyBase.SelectStyle(item, container)
        End Function
    End Class
End Namespace
