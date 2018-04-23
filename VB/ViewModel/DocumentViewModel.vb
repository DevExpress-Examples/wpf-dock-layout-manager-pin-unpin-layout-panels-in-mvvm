Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Xpf.Docking

Namespace WpfApplication
	Public Class DocumentViewModel
		Implements IMVVMDockingProperties


		Public Sub New(ByVal caption As String, ByVal imagePath As String)
			Caption = caption
			Glyph = GlyphHelper.GetGlyph(imagePath)
			Text = String.Format("Document text ({0})", caption)
		End Sub

		Private Property TargetName() As String Implements IMVVMDockingProperties.TargetName
			Get
				Return "DocumentsGroup"
			End Get
			Set(ByVal value As String)
				Throw New NotImplementedException()
			End Set

		End Property



		Private privateCaption As String
		Public Property Caption() As String
			Get
				Return privateCaption
			End Get
			Set(ByVal value As String)
				privateCaption = value
			End Set
		End Property


		Private privateGlyph As Object
		Public Property Glyph() As Object
			Get
				Return privateGlyph
			End Get
			Set(ByVal value As Object)
				privateGlyph = value
			End Set
		End Property

		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property


	End Class
End Namespace
