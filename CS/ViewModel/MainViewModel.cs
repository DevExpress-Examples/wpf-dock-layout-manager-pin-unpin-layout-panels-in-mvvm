using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using System.Collections.ObjectModel;
using System.Windows.Media;

namespace WpfApplication {
    public class MainViewModel : ViewModelBase {

        public MainViewModel() {
            ChildViews.Add(new DocumentViewModel("Document1", "/Images/change.png"));
            ChildViews.Add(new DocumentViewModel("Document2", "/Images/create.png"));
            ChildViews.Add(new DocumentViewModel("Document2", "/Images/new-16x16.png"));
            ChildViews.Add(new PanelViewModel(Colors.Red, "1"));
            ChildViews.Add(new PanelViewModel(Colors.Blue, "2"));
            ChildViews.Add(new PanelViewModel(Colors.Green, "3"));
            ChildViews.Add(new AutoHideViewModel("Properties"));
            this.MessagesViewModel = new AutoHideViewModel("Messages");
            ChildViews.Add(this.MessagesViewModel);
        }

        private AutoHideViewModel MessagesViewModel { get; set; }

        private ObservableCollection<object> _Children = new ObservableCollection<object>();


        public ObservableCollection<object> ChildViews {
            get { return _Children; }
            set {
                _Children = value;

            }
        }

        private void MoveMessagesViewModel(string targetGroupName) {
            this.ChildViews.Remove(this.MessagesViewModel);
            this.MessagesViewModel.MyTargetName = targetGroupName;
            ChildViews.Add(this.MessagesViewModel);
        }


        [Command(CanExecuteMethodName = "CanMoveMessages")]
        public void PinMessages() {
            this.MoveMessagesViewModel("DockPanels");
        }

        public bool CanMoveMessages() {
            return this.ChildViews.Contains(this.MessagesViewModel);
        }

        [Command(CanExecuteMethodName = "CanMoveMessages")]
        public void UnpinMessages() {
            this.MoveMessagesViewModel("auotHideGroup");
        }
    }
}