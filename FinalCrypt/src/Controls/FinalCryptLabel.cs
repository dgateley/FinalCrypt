using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalCrypt.Theme;

namespace FinalCrypt.Controls
{
    class FinalCryptLabel : Label
    {
        public FinalCryptLabel()
        {
            Font = ThemeSettings.TextFontSmall;
            ForeColor = ThemeSettings.TextColor;
            BackColor = ThemeSettings.PrimaryBackgroundColor;
        }
    }
}
