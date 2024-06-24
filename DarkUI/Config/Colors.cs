using System.Drawing;

namespace DarkUI.Config
{
    public static class Colors
    {
        public static Color GreyBackground { get; set; }
        public static Color HeaderBackground { get; set; }
        public static Color BlueBackground { get; set; }
        public static Color DarkBlueBackground { get; set; }
        public static Color DarkBackground { get; set; }
        public static Color MediumBackground { get; set; }
        public static Color LightBackground { get; set; }
        public static Color LighterBackground { get; set; }
        public static Color LightestBackground { get; set; }
        public static Color LightBorder { get; set; }
        public static Color DarkBorder { get; set; }
        public static Color LightText { get; set; }
        public static Color DisabledText { get; set; }
        public static Color BlueHighlight { get; set; }
        public static Color BlueSelection { get; set; }
        public static Color GreyHighlight { get; set; }
        public static Color GreySelection { get; set; }
        public static Color DarkGreySelection { get; set; }
        public static Color DarkBlueBorder { get; set; }
        public static Color LightBlueBorder { get; set; }
        public static Color ActiveControl { get; set; }

        static Colors()
        {
            GreyBackground = Color.FromArgb(60, 63, 65);
            HeaderBackground = Color.FromArgb(57, 60, 62);
            BlueBackground = Color.FromArgb(66, 77, 95);
            DarkBlueBackground = Color.FromArgb(52, 57, 66);
            DarkBackground = Color.FromArgb(43, 43, 43);
            MediumBackground = Color.FromArgb(49, 51, 53);
            LightBackground = Color.FromArgb(69, 73, 74);
            LighterBackground = Color.FromArgb(95, 101, 102);
            LightestBackground = Color.FromArgb(178, 178, 178);
            LightBorder = Color.FromArgb(81, 81, 81);
            DarkBorder = Color.FromArgb(51, 51, 51);
            LightText = Color.FromArgb(220, 220, 220);
            DisabledText = Color.FromArgb(153, 153, 153);
            BlueHighlight = Color.FromArgb(104, 151, 187);
            BlueSelection = Color.FromArgb(75, 110, 175);
            GreyHighlight = Color.FromArgb(122, 128, 132);
            GreySelection = Color.FromArgb(92, 92, 92);
            DarkGreySelection = Color.FromArgb(82, 82, 82);
            DarkBlueBorder = Color.FromArgb(51, 61, 78);
            LightBlueBorder = Color.FromArgb(86, 97, 114);
            ActiveControl = Color.FromArgb(159, 178, 196);
        }
    }
}
