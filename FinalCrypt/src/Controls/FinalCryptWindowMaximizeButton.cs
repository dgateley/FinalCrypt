using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using FinalCrypt.Theme;

namespace FinalCrypt.Controls
{
    class FinalCryptWindowMaximizeButton : Button
    { 
        public bool Clickable { get; set; } = true;


        private SolidBrush brush = new SolidBrush(ThemeSettings.WindowMaximizeButtonBackgroundColor);
        private SolidBrush hoveredBrush = new SolidBrush(ThemeSettings.WindowMaximizeButtonBackgroundHoveredColor);

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(9, 9, 12, 12);
            Pen pen = new Pen(ThemeSettings.WindowMaximizeButtonForegroundColor, 2);

            if (Clickable)
            {
                if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
                    e.Graphics.FillRectangle(hoveredBrush, e.ClipRectangle);
                else
                    e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
            else
            {
                brush = new SolidBrush(ThemeSettings.WindowButtonDisabledColor);
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }

            e.Graphics.DrawRectangle(pen, rect);

            pen.Dispose();
        }

        protected override void OnClick(EventArgs e)
        {
            if (Clickable)
                FindForm().WindowState = FormWindowState.Maximized;
        }
    }
}
