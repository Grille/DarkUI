namespace DarkUI.Config
{
    public static class Consts
    {
        public static int Padding;

        public static int ScrollBarSize;
        public static int ArrowButtonSize;
        public static int MinimumThumbSize;

        public static int CheckBoxSize;
        public static int RadioButtonSize;

        public static int ToolWindowHeaderSize;
        public static int DocumentTabAreaSize;
        public static int ToolWindowTabAreaSize;

        static Consts()
        {
            Themes.Default.Consts.Use();
        }
    }
}
