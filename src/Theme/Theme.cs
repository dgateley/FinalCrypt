using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace FinalCrypt.Theme
{
    class Theme
    {
        /* Colors */

        // General
        public static Color WindowHandleForegroundColor { get; set; } = Color.FromArgb(255, 30, 30, 30);
        public static Color WindowHandleBackgroundColor { get; set; } = Color.FromArgb(255, 255, 255, 255);
        public static Color PrimaryBackgroundColor { get; set; } = Color.FromArgb(255, 250, 250, 250);
        public static Color SecondaryBackgroundColor { get; set; } = Color.FromArgb(255, 220, 220, 220);
        public static Color AlternateBackgroundColor { get; set; } = Color.FromArgb(255, 255, 0, 0);
        public static Color TextColor { get; set; } = Color.FromArgb(255, 5, 5, 5);
        public static Font TextFontSmall { get; set; } = new Font("Segoe UI", 9);
        public static Font TextFontMedium { get; set; } = new Font("Segoe UI", 14);
        public static Font TextFontLarge { get; set; } = new Font("Segoe UI", 22);

        // Window Buttons
        public static Color WindowExitButtonForegroundColor { get; set; } = Color.FromArgb(255, 255, 255, 255);
        public static Color WindowExitButtonBackgroundColor { get; set; } = Color.FromArgb(255, 20, 20, 20);
        public static Color WindowExitButtonBackgroundHoveredColor { get; set; } = Color.FromArgb(255, 180, 0, 50);
        public static Color WindowMinimizeButtonForegroundColor { get; set; } = Color.FromArgb(255, 255, 255, 255);
        public static Color WindowMinimizeButtonBackgroundColor { get; set; } = Color.FromArgb(255, 20, 20, 20);
        public static Color WindowMinimizeButtonBackgroundHoveredColor { get; set; } = Color.FromArgb(255, 50, 50, 50);
        public static Color WindowMaximizeButtonForegroundColor { get; set; } = Color.FromArgb(255, 255, 255, 255);
        public static Color WindowMaximizeButtonBackgroundColor { get; set; } = Color.FromArgb(255, 20, 20, 20);
        public static Color WindowMaximizeButtonBackgroundHoveredColor { get; set; } = Color.FromArgb(255, 50, 50, 50);

        // TextBoxes
        public static Color TextBoxBackgroundColor { get; set; } = Color.FromArgb(255, 230, 230, 230);
        public static Color TextBoxBackgroundHighlightedColor { get; set; } = Color.FromArgb(255, 240, 240, 240);
        public static Color TextBoxForegroundColor { get; set; } = Color.FromArgb(255, 20, 20, 20);

        // Buttons
        public static Color ButtonForegroundColor { get; set; } = TextColor;
        public static Color ButtonBackgroundColor { get; set; } = Color.FromArgb(255, 240, 240, 240);
        public static Color ButtonBackgroundHoveredColor { get; set; } = Color.FromArgb(255, 255, 0, 0);
        
        // Progress Bars
        public static Color ProgressBarForegroundColor { get; set; } = Color.FromArgb(255, 0, 255, 0);
        public static Color ProgressBarBackgroundColor { get; set; } = Color.FromArgb(255, 255, 255, 255);

        // Menu View
        public static Color MenuViewForegroundCoor { get; set; } = TextColor;
        public static Color MenuViewBackgroundcolor { get; set; } = Color.FromArgb(255, 240, 240, 240);




        /// <summary>
        /// Called in the constructor to style a form
        /// </summary>
        /// <param name="form">The form to style</param>
        public static void Style(Form form)
        {
            foreach (var control in form.Controls)
            {
                if (control is TextBox)
                {

                }
            }
        }



        /* Drawing */

        /// <summary>
        /// Draws the window handle background, title text, and adds window controls
        /// </summary>
        /// <param name="form"></param>
        public static void DrawWindowHandle(Form form)
        {
            SolidBrush backgroundBrush = new SolidBrush(WindowHandleBackgroundColor);
            SolidBrush foregroundBrush = new SolidBrush(WindowHandleForegroundColor);
            Graphics graphics = form.CreateGraphics();

            graphics.FillRectangle(backgroundBrush, new Rectangle(0, 0, form.Width, 22));
            graphics.DrawString(form.Text, TextFontSmall, foregroundBrush, 2, 2);

            foregroundBrush.Dispose();
            backgroundBrush.Dispose();
            graphics.Dispose();
        }
        
    }
}
