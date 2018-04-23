Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Xpf.Docking
Imports System.Windows.Media

Namespace WpfApplication
	Public Class PanelViewModel
        Implements IMVVMDockingProperties
		Private privateCaption As String
		Public Property Caption() As String
			Get
				Return privateCaption
			End Get
			Set(ByVal value As String)
				privateCaption = value
			End Set
		End Property
		Public Sub New(ByVal c As Color, ByVal caption As String)
			_Color = New SolidColorBrush(c)
			Caption = caption
		End Sub

		Private Property TargetName() As String Implements IMVVMDockingProperties.TargetName
			Get
				Return "DockPanels"
			End Get
			Set(ByVal value As String)
				Throw New NotImplementedException()
			End Set
		End Property

		' Fields...
		Private _Color As SolidColorBrush


		Public Property ColorBrush() As SolidColorBrush
			Get
				Return _Color
			End Get
			Set(ByVal value As SolidColorBrush)
				_Color = value
			End Set
		End Property
	End Class
End Namespace
