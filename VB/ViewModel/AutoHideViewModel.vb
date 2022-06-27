Imports DevExpress.Xpf.Docking

Namespace WpfApplication

    Public Class AutoHideViewModel
        Implements IMVVMDockingProperties

        Public Sub New(ByVal caption As String)
            Me.Caption = caption
            MyTargetName = "auotHideGroup"
        End Sub

        Public Property Caption As String

        Public Property MyTargetName As String

        Private Property TargetName As String Implements IMVVMDockingProperties.TargetName
            Get
                Return MyTargetName
            End Get

            Set(ByVal value As String)
                MyTargetName = value
            End Set
        End Property
    End Class
End Namespace
