Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Media.Imaging

Namespace WpfApplication
	Friend NotInheritable Class GlyphHelper
		Private Sub New()
		End Sub
		Public Shared Function GetGlyph(ByVal path As String) As BitmapImage
			Return New BitmapImage(DevExpress.Utils.AssemblyHelper.GetResourceUri(GetType(GlyphHelper).Assembly, path))
		End Function
	End Class
End Namespace
