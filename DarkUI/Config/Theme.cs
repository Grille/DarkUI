using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using DstColors = DarkUI.Config.Colors;
using DstConsts = DarkUI.Config.Consts;

namespace DarkUI.Config
{
    public class Theme
    {
        public class CColors
        {
            public Color ControlBackground { get; set; }
            public Color ControlBackgroundOddIndex { get; set; }
            public Color CaptionInactiveBackground { get; set; }
            public Color CaptionActiveBackground { get; set; }
            public Color X0 { get; set; }
            public Color ButtonDown { get; set; }
            public Color MediumBackground { get; set; }
            public Color ButtonBackground { get; set; }
            public Color ButtonHighlight { get; set; }
            public Color LightestBackground { get; set; }
            public Color BorderLight { get; set; }
            public Color BorderDark { get; set; }
            public Color Text { get; set; }
            public Color TextDisabled { get; set; }
            public Color BlueHighlight { get; set; }
            public Color SelectionActive { get; set; }
            public Color CheckboxDisabled { get; set; }
            public Color Scroolbar { get; set; }
            public Color ControlBorder { get; set; }
            public Color CheckboxAmbivalentBackground { get; set; }

            public Color SelectionInactive { get; set; }

            public Color ButtonDisabledBackground { get; set; }
            public Color ActiveCaptionBorderTop0 { get; set; }
            public Color ActiveCaptionBorderBottom { get; set; }
            public Color ActiveCaptionBorderTop1 { get; set; }

            public void Use()
            {
                DstColors.ControlBackground = ControlBackground;
                DstColors.ControlBackgroundOddIndex = ControlBackgroundOddIndex;
                DstColors.CaptionInactiveBackground = CaptionInactiveBackground;
                DstColors.CaptionActiveBackground = CaptionActiveBackground;

                DstColors.DefaultButtonBackground = X0;
                DstColors.ControlPressed = ButtonDown;
                DstColors.MediumBackground = MediumBackground;
                DstColors.LightBackground = ButtonBackground;
                DstColors.LighterBackground = ButtonHighlight;
                DstColors.LightestBackground = LightestBackground;
                DstColors.LightBorder = BorderLight;
                DstColors.DarkBorder = BorderDark;
                DstColors.LightText = Text;
                DstColors.DisabledText = TextDisabled;
                DstColors.BlueHighlight = BlueHighlight;
                DstColors.SelectionActive = SelectionActive;
                DstColors.GreyHighlight = CheckboxDisabled;
                DstColors.Scroolbar = Scroolbar;
                DstColors.ControlBorder = ControlBorder;
                DstColors.CheckboxAmbivalentBackground = CheckboxAmbivalentBackground;
                DstColors.SelectionInactive = SelectionInactive;

                DstColors.DarkGreySelection = ButtonDisabledBackground;
                DstColors.DarkBlueBorder = ActiveCaptionBorderTop0;
                DstColors.LightBlueBorder = ActiveCaptionBorderBottom;
                DstColors.ActiveControl = ActiveCaptionBorderTop1;
            }
        }

        public CColors Colors { get; set; }


        public class CConsts
        {
            public int Padding { get; set; }
            public int ScrollBarSize { get; set; }
            public int ArrowButtonSize { get; set; }
            public int MinimumThumbSize { get; set; }
            public int CheckBoxSize { get; set; }
            public int RadioButtonSize { get; set; }
            public int ToolWindowHeaderSize { get; set; }
            public int DocumentTabAreaSize { get; set; }
            public int ToolWindowTabAreaSize { get; set; }

            public void Use()
            {
                DstConsts.Padding = Padding;
                DstConsts.ScrollBarSize = ScrollBarSize;
                DstConsts.ArrowButtonSize = ArrowButtonSize;
                DstConsts.MinimumThumbSize = MinimumThumbSize;
                DstConsts.CheckBoxSize = CheckBoxSize;
                DstConsts.RadioButtonSize = RadioButtonSize;
                DstConsts.ToolWindowHeaderSize = ToolWindowHeaderSize;
                DstConsts.DocumentTabAreaSize = DocumentTabAreaSize;
                DstConsts.ToolWindowTabAreaSize = ToolWindowTabAreaSize;
            }
        }

        public CConsts Consts { get; set; }

        public Theme(CColors colors, CConsts consts)
        {
            Colors = colors;
            Consts = consts;
        }

        public void Use()
        {
            Colors.Use();
            Consts.Use();
        }
    }
}
