Imports System.Windows
Imports System.Windows.Controls

Namespace WpfApplication

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            vm = TryCast(Me.mainGrid.Resources("viewModel"), MainViewModel)
            ahvm = TryCast(vm.ChildViews(7), AutoHideViewModel)
        End Sub

        Private vm As MainViewModel

        Private ahvm As AutoHideViewModel

        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            vm.ChildViews.Remove(ahvm)
            ahvm.MyTargetName = "DockPanels"
            vm.ChildViews.Add(ahvm)
        End Sub

        Private Sub Button_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
            vm.ChildViews.Remove(ahvm)
            ahvm.MyTargetName = "auotHideGroup"
            vm.ChildViews.Add(ahvm)
        End Sub
    End Class
End Namespace
