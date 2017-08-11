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


        private SolidBrush brush = new SolidBrush(Color.FromArgb(255, 10, 10, 10));
        private SolidBrush hoveredBrush = new SolidBrush(Color.FromArgb(255, 20, 20, 20));

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(6, 6, 10, 10);


            Pen pen = new Pen(Color.White, 2);

            if (!Clickable)
            {
                brush = new SolidBrush(Color.FromArgb(255, 20, 20, 20));
                hoveredBrush = new SolidBrush(Color.FromArgb(255, 50, 50, 50));

                if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
                    e.Graphics.FillRectangle(hoveredBrush, e.ClipRectangle);
                else
                    e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
            else
            {
                if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
                    e.Graphics.FillRectangle(hoveredBrush, e.ClipRectangle);
                else
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
