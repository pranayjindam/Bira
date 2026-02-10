using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bira.UI
{
    public static class ColorHelper
    {
        public static Color FromHex(string hex)
        {
            return ColorTranslator.FromHtml(hex);
        }
    }

}
