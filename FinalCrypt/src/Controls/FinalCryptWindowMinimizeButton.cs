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
    class FinalCryptWindowMinimizeButton : Button
    {
        public bool Clickable { get; set; } = true;

        private SolidBrush brush = new SolidBrush(ThemeSettings.WindowMinimizeButtonBackgroundColor);
        private SolidBrush hoveredBrush = new SolidBrush(ThemeSettings.WindowMinimizeButtonBackgroundHoveredColor);

        protected override void OnPaint(PaintEventArgs e)
        {
            Point bottomLeft = new Point(6, 20);
            Point bottomRight = new Point(20, 20);
            Pen pen = new Pen(ThemeSettings.WindowMinimizeButtonForegroundColor, 2);

            if (Clickable)
            {
                if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
                    e.Graphics.FillRectangle(hoveredBrush, e.ClipRectangle);
                else
                    e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }

            e.Graphics.DrawLine(pen, bottomLeft, bottomRight);
  
            pen.Dispose();
        }

        protected override void OnClick(EventArgs e)
        {
            if (Clickable)
                FindForm().WindowState = FormWindowState.Minimized;
        }
    }
}
