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


        /// <summary>
        /// Draws the header on the main form
        /// </summary>
        /// <param name="form"></param>
        public static void DrawMainHeader(Form form)
        {
            SolidBrush brush = new SolidBrush(ThemeSettings.AlternateBackgroundColor);
            Graphics graphics = form.CreateGraphics();

            graphics.FillRectangle(brush, new Rectangle(0, 28, form.Width, 42));

            graphics.Dispose();
            brush.Dispose();
        }

        /// <summary>
        /// Draws the surroundings of the panel view
        /// </summary>
        /// <param name="form"></param>
        public static void DrawMainTreeBorder(Form form)
        {
            SolidBrush brush = new SolidBrush(ThemeSettings.MenuViewBackgroundColor);
            Graphics graphics = form.CreateGraphics();

            graphics.FillRectangle(brush, new Rectangle(0, 28 + 42, 172, 500));

            graphics.Dispose();
            brush.Dispose();
        }
    }
}
