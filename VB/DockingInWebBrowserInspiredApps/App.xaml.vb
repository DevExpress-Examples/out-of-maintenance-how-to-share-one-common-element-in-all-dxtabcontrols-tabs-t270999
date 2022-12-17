Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace DockingInWebBrowserInspiredApps

    ''' <summary>
    ''' Interaction logic for App.xaml
    ''' </summary>
    Public Partial Class App
        Inherits Application

        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            MyBase.OnStartup(e)
            ThemeManager.ApplicationThemeName = "Office2013"
        End Sub
    End Class
End Namespace
