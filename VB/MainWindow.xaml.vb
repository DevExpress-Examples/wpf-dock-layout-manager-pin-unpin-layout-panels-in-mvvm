Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Docking
Imports System.Collections.ObjectModel

Namespace WpfApplication
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			vm = TryCast(mainGrid.Resources("viewModel"), MainViewModel)
			ahvm = TryCast(vm.ChildViews(7), AutoHideViewModel)
		End Sub
		Private vm As MainViewModel
		Private ahvm As AutoHideViewModel

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			vm.ChildViews.Remove(ahvm)
			(ahvm).MyTargetName = "DockPanels"
			vm.ChildViews.Add(ahvm)
		End Sub

		Private Sub Button_Click_1(ByVal sender As Object, ByVal e As RoutedEventArgs)
			vm.ChildViews.Remove(ahvm)
			(ahvm).MyTargetName = "auotHideGroup"
			vm.ChildViews.Add(ahvm)

		End Sub

	End Class
End Namespace