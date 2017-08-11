﻿using System;
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


        private SolidBrush brush = new SolidBrush(Color.FromArgb(255, 20, 20, 20));
        private SolidBrush hoveredBrush = new SolidBrush(Color.FromArgb(255, 180, 0, 50));

        protected override void OnPaint(PaintEventArgs e)
        {
            Point topLeft = new Point(6, 6);
            Point bottomRight = new Point(16, 16);
            Point topRight = new Point(16, 6);
            Point bottomLeft = new Point(6, 16);

            Pen pen = new Pen(Color.White, 2);

            if (Clickable)
            {
                if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
                    e.Graphics.FillRectangle(hoveredBrush, e.ClipRectangle);
                else
                    e.Graphics.FillRectangle(brush, e.ClipRectangle);
            }
            else
            {
                brush = new SolidBrush(Color.FromArgb(255, 10, 10, 10));
                hoveredBrush = new SolidBrush(Color.FromArgb(255, 20, 20, 20));

                if (ClientRectangle.Contains(PointToClient(Cursor.Position)))
                    e.Graphics.FillRectangle(hoveredBrush, e.ClipRectangle);
                else
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