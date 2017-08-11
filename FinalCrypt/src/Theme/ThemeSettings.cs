using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace FinalCrypt.Theme
{
    /// <summary>
    /// Provides styling information for the theme
    /// </summary>
    class ThemeSettings
    {
        /* Colors */

        // General
        public static Color WindowHandleForegroundColor { get; set; } = Color.FromArgb(255, 30, 30, 30);
        public static Color WindowHandleBackgroundColor { get; set; } = Color.FromArgb(255, 255, 255, 255);
        public static Color PrimaryBackgroundColor { get; set; } = Color.FromArgb(255, 240, 240, 240);
        public static Color SecondaryBackgroundColor { get; set; } = Color.FromArgb(255, 220, 220, 220);
        public static Color AlternateBackgroundColor { get; set; } = Color.FromArgb(180, 220, 0, 0);
        public static Color TextColor { get; set; } = Color.FromArgb(255, 5, 5, 5);
        public static Font TextFontSmall { get; set; } = new Font("Segoe UI", 11);
        public static Font TextFontMedium { get; set; } = new Font("Segoe UI", 14);
        public static Font TextFontLarge { get; set; } = new Font("Segoe UI", 22);

        // Window Buttons
        public static Color WindowExitButtonForegroundColor { get; set; } = Color.FromArgb(255, 100, 100, 100);
        public static Color WindowExitButtonBackgroundColor { get; set; } = Color.FromArgb(255, 230, 230, 230);
        public static Color WindowExitButtonBackgroundHoveredColor { get; set; } = Color.FromArgb(255, 255, 50, 50);
        public static Color WindowMinimizeButtonForegroundColor { get; set; } = Color.FromArgb(255, 100, 100, 100);
        public static Color WindowMinimizeButtonBackgroundColor { get; set; } = Color.FromArgb(255, 230, 230, 230);
        public static Color WindowMinimizeButtonBackgroundHoveredColor { get; set; } = Color.FromArgb(255, 200, 200, 200);
        public static Color WindowMaximizeButtonForegroundColor { get; set; } = Color.FromArgb(255, 100, 100, 100);
        public static Color WindowMaximizeButtonBackgroundColor { get; set; } = Color.FromArgb(255, 230, 230, 230);
        public static Color WindowMaximizeButtonBackgroundHoveredColor { get; set; } = Color.FromArgb(255, 200, 200, 200);
        public static Color WindowButtonDisabledColor { get; set; } = Color.FromArgb(255, 210, 210, 210);

        // TextBoxes
        public static Color TextBoxBackgroundColor { get; set; } = Color.FromArgb(255, 250, 250, 250);
        public static Color TextBoxBackgroundHighlightedColor { get; set; } = Color.FromArgb(255, 240, 240, 240);
        public static Color TextBoxForegroundColor { get; set; } = Color.FromArgb(255, 20, 20, 20);
        public static Color TextBoxBorderColor { get; set; } = Color.FromArgb(255, 200, 200, 200);
        public static Color TextBoxBorderHighlightedColor { get; set; } = AlternateBackgroundColor;

        // Buttons
        public static Color ButtonForegroundColor { get; set; } = TextColor;
        public static Color ButtonBackgroundColor { get; set; } = Color.FromArgb(255, 255, 255, 255);
        public static Color ButtonBackgroundHoveredColor { get; set; } = Color.FromArgb(255, 255, 0, 0);
        public static Color ButtonBackgroundDarkColor { get; set; } = Color.FromArgb(255, 220, 220, 220);

        // Progress Bars
        public static Color ProgressBarForegroundColor { get; set; } = Color.FromArgb(255, 0, 255, 0);
        public static Color ProgressBarBackgroundColor { get; set; } = Color.FromArgb(255, 255, 255, 255);

        // Menu View
        public static Color MenuViewForegroundCoor { get; set; } = TextColor;
        public static Color MenuViewBackgroundcolor { get; set; } = Color.FromArgb(255, 240, 240, 240);

        






    }
}
