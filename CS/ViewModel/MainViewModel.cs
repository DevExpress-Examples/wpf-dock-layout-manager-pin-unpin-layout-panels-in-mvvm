using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Docking;
using System.Windows.Media;

namespace WpfApplication
{
    public class MainViewModel 
    {

        public MainViewModel()
        {
            ChildViews.Add(new DocumentViewModel("Document1", "/Images/change.png"));
            ChildViews.Add(new DocumentViewModel("Document2", "/Images/create.png"));
            ChildViews.Add(new DocumentViewModel("Document2", "/Images/new-16x16.png"));
            ChildViews.Add(new PanelViewModel(Colors.Red,"1"));
            ChildViews.Add(new PanelViewModel(Colors.Blue, "2"));
            ChildViews.Add(new PanelViewModel(Colors.Green, "3"));
            ChildViews.Add(new AutoHideViewModel("Properties"));
            ChildViews.Add(new AutoHideViewModel("Messages"));
        }

        private ObservableCollection<object> _Children = new ObservableCollection<object>();


        public ObservableCollection<object> ChildViews
        {
            get { return _Children; }
            set
            {
                _Children = value;

            }
        }



        

    }
}