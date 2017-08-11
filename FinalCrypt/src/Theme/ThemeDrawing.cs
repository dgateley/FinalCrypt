using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace FinalCrypt.Theme
{
    class ThemeDrawing
    {
        /* Drawing */

        /// <summary>
        /// Draws the window handle background, title text, and adds window controls
        /// </summary>
        /// <param name="form"></param>
        public static void DrawWindowHandle(Form form)
        {
            SolidBrush backgroundBrush = new SolidBrush(ThemeSettings.WindowHandleBackgroundColor);
            SolidBrush foregroundBrush = new SolidBrush(ThemeSettings.WindowHandleForegroundColor);
            Graphics graphics = form.CreateGraphics();

            graphics.FillRectangle(backgroundBrush, new Rectangle(0, 0, form.Width, 28));
            graphics.DrawString(form.Text, ThemeSettings.TextFontSmall, foregroundBrush, 4, 4);

            foregroundBrush.Dispose();
            backgroundBrush.Dispose();
            graphics.Dispose();
        }
    }
}
