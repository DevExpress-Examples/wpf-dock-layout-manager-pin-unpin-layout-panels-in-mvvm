Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports System.Collections.ObjectModel
Imports System.Windows.Media

Namespace WpfApplication

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Sub New()
            ChildViews.Add(New DocumentViewModel("Document1", "/Images/change.png"))
            ChildViews.Add(New DocumentViewModel("Document2", "/Images/create.png"))
            ChildViews.Add(New DocumentViewModel("Document2", "/Images/new-16x16.png"))
            ChildViews.Add(New PanelViewModel(Colors.Red, "1"))
            ChildViews.Add(New PanelViewModel(Colors.Blue, "2"))
            ChildViews.Add(New PanelViewModel(Colors.Green, "3"))
            ChildViews.Add(New AutoHideViewModel("Properties"))
            MessagesViewModel = New AutoHideViewModel("Messages")
            ChildViews.Add(MessagesViewModel)
        End Sub

        Private Property MessagesViewModel As AutoHideViewModel

        Private _Children As ObservableCollection(Of Object) = New ObservableCollection(Of Object)()

        Public Property ChildViews As ObservableCollection(Of Object)
            Get
                Return _Children
            End Get

            Set(ByVal value As ObservableCollection(Of Object))
                _Children = value
            End Set
        End Property

        Private Sub MoveMessagesViewModel(ByVal targetGroupName As String)
            ChildViews.Remove(MessagesViewModel)
            MessagesViewModel.MyTargetName = targetGroupName
            ChildViews.Add(MessagesViewModel)
        End Sub

        <Command(CanExecuteMethodName:="CanMoveMessages")>
        Public Sub PinMessages()
            MoveMessagesViewModel("DockPanels")
        End Sub

        Public Function CanMoveMessages() As Boolean
            Return ChildViews.Contains(MessagesViewModel)
        End Function

        <Command(CanExecuteMethodName:="CanMoveMessages")>
        Public Sub UnpinMessages()
            MoveMessagesViewModel("auotHideGroup")
        End Sub
    End Class
End Namespace
