using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DarkUI.Config
{
    public static class Themes
    {
        public static Theme.CConsts DefaultConsts { get; }

        public static Theme Default { get; }

        public static Theme Dark { get; }

        static Themes()
        {
            DefaultConsts = new Theme.CConsts()
            {
                Padding = 10,
                ScrollBarSize = 15,
                ArrowButtonSize = 15,
                MinimumThumbSize = 11,
                CheckBoxSize = 12,
                RadioButtonSize = 12,
                ToolWindowHeaderSize = 25,
                DocumentTabAreaSize = 24,
                ToolWindowTabAreaSize = 21,
            };

            var darkColors = new Theme.CColors()
            {
                GreyBackground = Color.FromArgb(60, 63, 65),
                HeaderBackground = Color.FromArgb(57, 60, 62),
                BlueBackground = Color.FromArgb(66, 77, 95),
                DarkBlueBackground = Color.FromArgb(52, 57, 66),
                DarkBackground = Color.FromArgb(43, 43, 43),
                MediumBackground = Color.FromArgb(49, 51, 53),
                LightBackground = Color.FromArgb(69, 73, 74),
                LighterBackground = Color.FromArgb(95, 101, 102),
                LightestBackground = Color.FromArgb(178, 178, 178),
                LightBorder = Color.FromArgb(81, 81, 81),
                DarkBorder = Color.FromArgb(51, 51, 51),
                LightText = Color.FromArgb(220, 220, 220),
                DisabledText = Color.FromArgb(153, 153, 153),
                BlueHighlight = Color.FromArgb(104, 151, 187),
                BlueSelection = Color.FromArgb(75, 110, 175),
                GreyHighlight = Color.FromArgb(122, 128, 132),
                GreySelection = Color.FromArgb(92, 92, 92),
                DarkGreySelection = Color.FromArgb(82, 82, 82),
                DarkBlueBorder = Color.FromArgb(51, 61, 78),
                LightBlueBorder = Color.FromArgb(86, 97, 114),
                ActiveControl = Color.FromArgb(159, 178, 196),
            };

            Dark = new Theme(darkColors, DefaultConsts);

            Default = Dark;
        }
    }
}
