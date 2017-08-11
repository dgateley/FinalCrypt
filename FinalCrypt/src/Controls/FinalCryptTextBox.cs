using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalCrypt.Theme;
using System.Drawing;
using System.Runtime.InteropServices;

namespace FinalCrypt.Controls
{ 
    class FinalCryptTextBox : Panel
    {
        TextBox textBox;

        public FinalCryptTextBox()
        {
            DoubleBuffered = true;
            Padding = new Padding(2);

            textBox = new TextBox()
            {
                AutoSize = false,
                BorderStyle = BorderStyle.None,
                TextAlign = HorizontalAlignment.Center,
                Dock = DockStyle.Fill,
                Font = ThemeSettings.TextFontSmall,
                BackColor = ThemeSettings.TextBoxBackgroundColor,
                ForeColor = ThemeSettings.TextBoxForegroundColor,
            };

            textBox.Enter += Refresh;
            textBox.Leave += Refresh;

            Controls.Add(textBox);

            BackColor = ThemeSettings.TextBoxBorderColor;
            Padding = new Padding(1);
            Size = textBox.Size;

        }

        /// <summary>
        /// Force the control to be repainted
        /// </summary>
        private void Refresh(object sender, EventArgs e)
        {
            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            Pen borderPen = new Pen(textBox.Focused ? ThemeSettings.TextBoxBorderHighlightedColor : ThemeSettings.TextBoxBorderColor);

            e.Graphics.Clear(ThemeSettings.TextBoxBackgroundColor);
            e.Graphics.DrawRectangle(borderPen, new Rectangle(0, 0, ClientSize.Width - 1, ClientSize.Height - 1));

            borderPen.Dispose();

            base.OnPaint(e);
        }
    }
}
