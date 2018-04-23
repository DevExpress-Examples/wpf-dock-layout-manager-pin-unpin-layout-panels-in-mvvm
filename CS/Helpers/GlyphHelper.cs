using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media.Imaging;

namespace WpfApplication
{
    static class GlyphHelper
    {
        public static BitmapImage GetGlyph(string path)
        {
            return new BitmapImage(DevExpress.Utils.AssemblyHelper.GetResourceUri(typeof(GlyphHelper).Assembly, path));
        }
    }
}
