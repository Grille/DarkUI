using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DarkUI.Config
{
    public class Theme
    {
        public class CColors
        {
            public Color GreyBackground { get; set; }
            public Color HeaderBackground { get; set; }
            public Color BlueBackground { get; set; }
            public Color DarkBlueBackground { get; set; }
            public Color DarkBackground { get; set; }
            public Color MediumBackground { get; set; }
            public Color LightBackground { get; set; }
            public Color LighterBackground { get; set; }
            public Color LightestBackground { get; set; }
            public Color LightBorder { get; set; }
            public Color DarkBorder { get; set; }
            public Color LightText { get; set; }
            public Color DisabledText { get; set; }
            public Color BlueHighlight { get; set; }
            public Color BlueSelection { get; set; }
            public Color GreyHighlight { get; set; }
            public Color GreySelection { get; set; }
            public Color DarkGreySelection { get; set; }
            public Color DarkBlueBorder { get; set; }
            public Color LightBlueBorder { get; set; }
            public Color ActiveControl { get; set; }

            public void Use()
            {
                Config.Colors.GreyBackground = GreyBackground;
                Config.Colors.HeaderBackground = HeaderBackground;
                Config.Colors.BlueBackground = BlueBackground;
                Config.Colors.DarkBlueBackground = DarkBlueBackground;
                Config.Colors.DarkBackground = DarkBackground;
                Config.Colors.MediumBackground = MediumBackground;
                Config.Colors.LightBackground = LightBackground;
                Config.Colors.LighterBackground = LighterBackground;
                Config.Colors.LightestBackground = LightestBackground;
                Config.Colors.LightBorder = LightBorder;
                Config.Colors.DarkBorder = DarkBorder;
                Config.Colors.LightText = LightText;
                Config.Colors.DisabledText = DisabledText;
                Config.Colors.BlueHighlight = BlueHighlight;
                Config.Colors.BlueSelection = BlueSelection;
                Config.Colors.GreyHighlight = GreyHighlight;
                Config.Colors.GreySelection = GreySelection;
                Config.Colors.DarkGreySelection = DarkGreySelection;
                Config.Colors.DarkBlueBorder = DarkBlueBorder;
                Config.Colors.LightBlueBorder = LightBlueBorder;
                Config.Colors.ActiveControl = ActiveControl;
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
                Config.Consts.Padding = Padding;
                Config.Consts.ScrollBarSize = ScrollBarSize;
                Config.Consts.ArrowButtonSize = ArrowButtonSize;
                Config.Consts.MinimumThumbSize = MinimumThumbSize;
                Config.Consts.CheckBoxSize = CheckBoxSize;
                Config.Consts.RadioButtonSize = RadioButtonSize;
                Config.Consts.ToolWindowHeaderSize = ToolWindowHeaderSize;
                Config.Consts.DocumentTabAreaSize = DocumentTabAreaSize;
                Config.Consts.ToolWindowTabAreaSize = ToolWindowTabAreaSize;
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
