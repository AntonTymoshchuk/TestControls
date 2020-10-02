using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestControls
{
    public class AppSettings
    {
        private Color xThemeColor;
        private Color xDependentColor;

        public Color ThemeColor
        {
            get { return xThemeColor; }
        }

        public Color DependentColor
        {
            get { return xDependentColor; }
        }

        public AppSettings()
        {
            // Simulating of serialization
            xThemeColor = Color.FromArgb(115, 255, 215);
            xDependentColor = Color.Black;
        }
    }
}
