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
            Themes.Default.Colors.Use();
        }
    }
}
