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

        private SolidBrush brush = new SolidBrush(Color.FromArgb(255, 20, 20, 20));
        private SolidBrush hoveredBrush = new SolidBrush(Color.FromArgb(255, 50, 50, 50));

        protected override void OnPaint(PaintEventArgs e)
        {

            Point bottomLeft = new Point(6, 16);
            Point bottomRight = new Point(16, 16);


            Pen pen = new Pen(Color.White, 2);


            if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
                e.Graphics.FillRectangle(hoveredBrush, e.ClipRectangle);
            else
                e.Graphics.FillRectangle(brush, e.ClipRectangle);

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
