using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpf.Docking;
using System.Windows.Media;

namespace WpfApplication
{
    public class PanelViewModel : IMVVMDockingProperties
    {
        public string Caption { get; set; }
        public PanelViewModel(Color c, string caption)
        {
            _Color = new SolidColorBrush(c);
            Caption = caption;
        }

        string IMVVMDockingProperties.TargetName
        {
            get
            {
                return "DockPanels";
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        // Fields...
        private SolidColorBrush _Color;


        public SolidColorBrush ColorBrush
        {
            get { return _Color; }
            set
            {
                _Color = value;
            }
        }
    }
}
