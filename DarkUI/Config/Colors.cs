using System.Drawing;

namespace DarkUI.Config
{
    public static class Colors
    {
        public static Color ControlBackground { get; set; }
        public static Color ControlBackgroundOddIndex { get; set; }
        public static Color CaptionInactiveBackground { get; set; }
        public static Color CaptionActiveBackground { get; set; }
        public static Color DefaultButtonBackground { get; set; }
        public static Color ControlPressed { get; set; }
        public static Color MediumBackground { get; set; }
        public static Color LightBackground { get; set; }
        public static Color LighterBackground { get; set; }
        public static Color LightestBackground { get; set; }
        public static Color LightBorder { get; set; }
        public static Color DarkBorder { get; set; }
        public static Color LightText { get; set; }
        public static Color DisabledText { get; set; }
        public static Color BlueHighlight { get; set; }
        public static Color SelectionActive { get; set; }



        public static Color GreyHighlight { get; set; }
        public static Color Scroolbar { get; set; }

        public static Color CheckboxAmbivalentBackground { get; set; }

        public static Color ControlBorder { get; set; }

        public static Color SelectionInactive { get; set; }

        public static Color DarkGreySelection { get; set; }
        public static Color DarkBlueBorder { get; set; }
        public static Color LightBlueBorder { get; set; }
        public static Color ActiveControl { get; set; }

        static Colors()
        {
            Themes.Default.Colors.Use();
        }
    }
}
