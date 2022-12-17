Imports System.Collections.ObjectModel

Namespace DockingInWebBrowserInspiredApps

    Public Partial Class MainWindow

        Public Sub New()
            Me.InitializeComponent()
            Dim p As System.Windows.Style
        End Sub
    End Class

    Public Class ItemVM

        Public Property Header As String

        Public Property Body As String

        Public Sub New()
            Header = String.Format("New Document{0}", i)
            Body = String.Format("Document{0} Body", i)
            i += 1
        End Sub

        Private Shared i As Integer = 1
    End Class

    Public Class VM

        Public Property Source As ObservableCollection(Of ItemVM)

        Public Sub New()
            Source = New ObservableCollection(Of ItemVM)()
            Source.Add(New ItemVM())
            Source.Add(New ItemVM())
        End Sub
    End Class
End Namespace
