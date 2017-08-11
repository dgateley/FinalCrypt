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
    class FinalCryptWindowExitButton : Button
    {
        public bool Clickable { get; set; } = true;

        public ThemeWindowCommands.CloseTypes Type { get; set; } = ThemeWindowCommands.CloseTypes.Exit;


        SolidBrush brush = new SolidBrush(ThemeSettings.WindowExitButtonBackgroundColor);
        SolidBrush hoveredBrush = new SolidBrush(ThemeSettings.WindowExitButtonBackgroundHoveredColor);

        protected override void OnPaint(PaintEventArgs e)
        {
            Point topLeft = new Point(7, 7);
            Point bottomRight = new Point(20, 20);
            Point topRight = new Point(20, 7);
            Point bottomLeft = new Point(7, 20);
            Pen pen = new Pen(ThemeSettings.WindowExitButtonForegroundColor, 2);

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

            e.Graphics.DrawLine(pen, topLeft, bottomRight);
            e.Graphics.DrawLine(pen, topRight, bottomLeft);

            pen.Dispose();
        }

        protected override void OnClick(EventArgs e)
        {
            if (Clickable)
            {
                if (Type == ThemeWindowCommands.CloseTypes.Close)
                    FindForm().Close();
                else if (Type == ThemeWindowCommands.CloseTypes.Exit)
                    Application.Exit();
            }
        }
    }
}
