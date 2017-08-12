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
        public TextBox textBox;
        public Button button;

        private bool passwordHidden;

        public bool PasswordHidden
        {
            get { return passwordHidden; }
            set
            {
                passwordHidden = value;
                textBox.UseSystemPasswordChar = value;
            }
        }


        public FinalCryptTextBox()
        {
            DoubleBuffered = true;
            Padding = new Padding(2);

            textBox = new TextBox()
            {
                AutoSize = false,
                BorderStyle = BorderStyle.None,
                Dock = DockStyle.Fill,
                Font = ThemeSettings.TextFontSmall,
                BackColor = ThemeSettings.TextBoxBackgroundColor,
                ForeColor = ThemeSettings.TextBoxForegroundColor
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

        public void AddButton()
        {
            button = new Button();
            button.Height = Height;
            button.Width = 35;
            button.FlatStyle = FlatStyle.Flat;
            button.Image = Image.FromFile("..\\..\\resources\\IconEyeOpen.png");
            PasswordHidden = true;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = ThemeSettings.ButtonBackgroundDarkColor;
            button.Click += (s, e) => { ToggleVisibility(); }; 
            Controls.Add(button);
            Width += button.Width;
            textBox.Dock = DockStyle.Left;
            button.Dock = DockStyle.Right;
            textBox.Location = new Point(0, 0);
            textBox.Size = new Size(Width - button.Width, Height);
        }

        private void ToggleVisibility()
        {
            if (PasswordHidden)
            {
                button.Image = Image.FromFile("..\\..\\resources\\IconEyeClosed.png");
                PasswordHidden = false;
            }
            else
            {
                button.Image = Image.FromFile("..\\..\\resources\\IconEyeOpen.png");
                PasswordHidden = true;
            }
        }
    }
}
