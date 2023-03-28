Imports System.Windows
Imports DevExpress.Xpf.Core

Namespace DXSample

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

        Private Sub OnAppStartup_UpdateThemeName(ByVal sender As Object, ByVal e As StartupEventArgs)
            ApplicationThemeHelper.UpdateApplicationThemeName()
        End Sub
    End Class
End Namespace
