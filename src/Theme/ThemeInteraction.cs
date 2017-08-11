using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCrypt.Theme
{
    /// <summary>
    /// Handles user interaction on the window handle
    /// </summary>
    class ThemeInteraction
    {
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        public static void Drag(Form form, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(form.Handle, 0xA1, 0x2, 0);
            }
        }
    }
}
