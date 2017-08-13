using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalCrypt.Theme;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FinalCrypt.Controls
{
    class FInalCryptPanelButton : FinalCryptButton
    {
        public FInalCryptPanelButton()
        {
            Font = ThemeSettings.TextFontMedium;
            BackColor = ThemeSettings.ButtonBackgroundColor;
            ForeColor = ThemeSettings.ButtonForegroundColor;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            RectangleF Rect = new RectangleF(0, 0, Width, Height);
            GraphicsPath GraphPath = new GraphicsPath();
            Pen pen = new Pen(ThemeSettings.ButtonBackgroundColor);
            SolidBrush brush = new SolidBrush(BackColor);
            int radius = 10;
            float r2 = radius / 2f;

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

            GraphPath.CloseFigure();
            Region = new Region(GraphPath);
            pen.Alignment = PenAlignment.Inset;

            e.Graphics.DrawPath(pen, GraphPath);
            e.Graphics.FillPath(brush, GraphPath);

            pen.Dispose();
            brush.Dispose();
            GraphPath.Dispose();

            base.OnPaint(e);
        }
    }
}
