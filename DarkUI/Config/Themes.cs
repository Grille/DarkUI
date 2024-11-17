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
                ControlBackground = Color.FromArgb(60, 63, 65),
                ControlBackgroundOddIndex = Color.FromArgb(60, 63, 65),
                CaptionInactiveBackground = Color.FromArgb(57, 60, 62),
                CaptionActiveBackground = Color.FromArgb(66, 77, 95),
                X0 = Color.FromArgb(52, 57, 66),
                ButtonDown = Color.FromArgb(43, 43, 43),
                MediumBackground = Color.FromArgb(49, 51, 53),
                ButtonBackground = Color.FromArgb(69, 73, 74),
                ButtonHighlight = Color.FromArgb(95, 101, 102),
                LightestBackground = Color.FromArgb(178, 178, 178),
                BorderLight = Color.FromArgb(81, 81, 81),
                BorderDark = Color.FromArgb(51, 51, 51),
                Text = Color.FromArgb(220, 220, 220),
                TextDisabled = Color.FromArgb(153, 153, 153),
                BlueHighlight = Color.FromArgb(104, 151, 187),
                SelectionActive = Color.FromArgb(75, 110, 175),
                CheckboxDisabled = Color.FromArgb(122, 128, 132),
                Scroolbar = Color.FromArgb(92, 92, 92),
                ControlBorder = Color.FromArgb(92, 92, 92),
                CheckboxAmbivalentBackground = Color.FromArgb(92, 92, 92),
                SelectionInactive = Color.FromArgb(92, 92, 92),
                ButtonDisabledBackground = Color.FromArgb(82, 82, 82),
                ActiveCaptionBorderTop0 = Color.FromArgb(51, 61, 78),
                ActiveCaptionBorderBottom = Color.FromArgb(86, 97, 114),
                ActiveCaptionBorderTop1 = Color.FromArgb(159, 178, 196),
            };

            var systemColors = new Theme.CColors()
            {
                ControlBackground = SystemColors.Control,
                ControlBackgroundOddIndex = SystemColors.Control,
                CaptionInactiveBackground = SystemColors.InactiveCaption,
                CaptionActiveBackground = SystemColors.ActiveCaption,
                X0 = SystemColors.Control,
                ButtonDown = SystemColors.Control,
                MediumBackground = SystemColors.Control,
                ButtonBackground = SystemColors.Control,
                ButtonHighlight = SystemColors.Control,
                LightestBackground = SystemColors.Control,
                BorderLight = SystemColors.ActiveBorder,
                BorderDark = SystemColors.ActiveBorder,
                Text = SystemColors.ControlText,
                TextDisabled = SystemColors.GrayText,
                BlueHighlight = SystemColors.Highlight,
                SelectionActive = SystemColors.Highlight,
                CheckboxDisabled = SystemColors.Control,
                Scroolbar = SystemColors.WindowFrame,
                ControlBorder = SystemColors.ActiveBorder,
                CheckboxAmbivalentBackground = SystemColors.Control,
                SelectionInactive = SystemColors.Highlight,
                ButtonDisabledBackground = SystemColors.Control,
                ActiveCaptionBorderTop0 = SystemColors.ActiveBorder,
                ActiveCaptionBorderBottom = SystemColors.ActiveBorder,
                ActiveCaptionBorderTop1 = SystemColors.ActiveBorder,
            };


            darkColors = new Theme.CColors()
            {
                ControlBackground = Color.FromArgb(60, 63, 65),
                ControlBackgroundOddIndex = Color.FromArgb(60, 63, 65),
                CaptionInactiveBackground = Color.FromArgb(57, 62, 60),
                CaptionActiveBackground = Color.FromArgb(66, 95, 77),
                X0 = Color.FromArgb(0, 0, 66),
                ButtonDown = Color.FromArgb(43, 43, 43),
                MediumBackground = Color.FromArgb(49, 51, 53),
                ButtonBackground = Color.FromArgb(69, 73, 74),
                ButtonHighlight = Color.FromArgb(95, 0, 102),
                LightestBackground = Color.FromArgb(178, 178, 178),
                BorderLight = Color.FromArgb(81, 81, 81),
                BorderDark = Color.FromArgb(51, 51, 51),
                Text = Color.FromArgb(220, 220, 220),
                TextDisabled = Color.FromArgb(153, 153, 153),
                BlueHighlight = Color.FromArgb(104, 151, 187),
                SelectionActive = Color.FromArgb(0, 110, 0),
                CheckboxDisabled = Color.FromArgb(122, 128, 132),
                Scroolbar = Color.FromArgb(92, 92, 92),
                ControlBorder = Color.FromArgb(92, 92, 92),
                CheckboxAmbivalentBackground = Color.FromArgb(92, 92, 92),
                SelectionInactive = Color.FromArgb(0, 92, 0),
                ButtonDisabledBackground = Color.FromArgb(82, 82, 82),
                ActiveCaptionBorderTop0 = Color.FromArgb(51, 61, 78),
                ActiveCaptionBorderBottom = Color.FromArgb(86, 97, 114),
                ActiveCaptionBorderTop1 = Color.FromArgb(159, 178, 196),
            };
            

            Dark = new Theme(systemColors, DefaultConsts);

            Default = Dark;
        }
    }
}
