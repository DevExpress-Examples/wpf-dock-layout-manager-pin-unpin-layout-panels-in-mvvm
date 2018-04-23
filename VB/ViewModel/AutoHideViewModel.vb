Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpf.Docking

Namespace WpfApplication
	Public Class AutoHideViewModel
		Implements IMVVMDockingProperties
		Public Sub New(ByVal caption As String)
			Caption = caption
			MyTargetName = "auotHideGroup"
		End Sub
		Private privateCaption As String
		Public Property Caption() As String
			Get
				Return privateCaption
			End Get
			Set(ByVal value As String)
				privateCaption = value
			End Set
		End Property
		Private privateMyTargetName As String
		Public Property MyTargetName() As String
			Get
				Return privateMyTargetName
			End Get
			Set(ByVal value As String)
				privateMyTargetName = value
			End Set
		End Property
        Private Property TargetName() As String Implements IMVVMDockingProperties.TargetName
            Get
                Return MyTargetName
            End Get
            Set(ByVal value As String)
                MyTargetName = value
            End Set
        End Property
	End Class
End Namespace
