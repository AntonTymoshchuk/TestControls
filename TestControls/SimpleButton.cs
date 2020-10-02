using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestControls
{
    public class SimpleButton
    {
        public NoFocusCuesButton UIButton;
        public EventHandler Call;

        public SimpleButton(AppSettings Settings)
        {
            UIButton = new NoFocusCuesButton();
            UIButton.FlatStyle = FlatStyle.Flat;
            UIButton.BackColor = Settings.ThemeColor;
            UIButton.FlatAppearance.MouseOverBackColor = Settings.ThemeColor;
            UIButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(Settings.ThemeColor.R - 15, Settings.ThemeColor.G - 15, Settings.ThemeColor.B - 15);
        }
    }
}
