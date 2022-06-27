Imports System
Imports DevExpress.Xpf.Docking

Namespace WpfApplication

    Public Class DocumentViewModel
        Implements IMVVMDockingProperties

        Public Sub New(ByVal caption As String, ByVal imagePath As String)
            Me.Caption = caption
            Glyph = GetGlyph(imagePath)
            Text = String.Format("Document text ({0})", caption)
        End Sub

        Private Property TargetName As String Implements IMVVMDockingProperties.TargetName
            Get
                Return "DocumentsGroup"
            End Get

            Set(ByVal value As String)
                Throw New NotImplementedException()
            End Set
        End Property

        Public Property Caption As String

        Public Property Glyph As Object

        Public Property Text As String
    End Class
End Namespace
