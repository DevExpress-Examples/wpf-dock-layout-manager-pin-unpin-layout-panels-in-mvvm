using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpf.Docking;

namespace WpfApplication {
    public class AutoHideViewModel : IMVVMDockingProperties {
        public AutoHideViewModel(string caption) {
            Caption = caption;
            MyTargetName = "auotHideGroup";
        }
        public string Caption { get; set; }
        public string MyTargetName { get; set; }
        string IMVVMDockingProperties.TargetName {
            get {
                return MyTargetName;
            }
            set {
                MyTargetName = value;
            }
        }
    }
}
