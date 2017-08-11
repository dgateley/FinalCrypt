using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCrypt.Theme
{
    /// <summary>
    /// Used to edit the behavior of the Minimize/Maximize/Close buttons
    /// </summary>
    class ThemeWindowCommands
    {
        /// <summary>
        /// Provides alternate behavior for the exit button
        /// </summary>
        public enum CloseTypes
        {
            Exit,
            Close
        }

        public class WindowSettings
        {
            public CloseTypes CloseType { get; set; } = CloseTypes.Exit;

            public bool Closable { get; set; } = true;

            public bool Minimizable { get; set; } = true;

            public bool Maximizable { get; set; } = true;
        }
    }
}
