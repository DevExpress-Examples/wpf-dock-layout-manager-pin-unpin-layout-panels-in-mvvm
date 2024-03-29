using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Xpf.Docking;

namespace WpfApplication {
    public class DocumentViewModel : IMVVMDockingProperties {


        public DocumentViewModel(string caption, string imagePath) {
            Caption = caption;
            Glyph = GlyphHelper.GetGlyph(imagePath);
            Text = String.Format("Document text ({0})", caption);
        }

        string IMVVMDockingProperties.TargetName {
            get {
                return "DocumentsGroup";
            }
            set {
                throw new NotImplementedException();
            }

        }



        public string Caption { get; set; }


        public object Glyph { get; set; }

        public string Text { get; set; }


    }
}
