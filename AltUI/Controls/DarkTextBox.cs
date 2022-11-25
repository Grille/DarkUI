﻿using System.Windows.Forms;
using AltUI.Config;

namespace AltUI.Controls
{
    public class DarkTextBox : TextBox
    {
        #region Constructor Region

        public DarkTextBox()
        {
            BackColor = ThemeProvider.Theme.Colors.LightBackground;
            ForeColor = ThemeProvider.Theme.Colors.LightText;
            Padding = new Padding(2, 2, 2, 2);
            BorderStyle = BorderStyle.FixedSingle;
        }
        #endregion
    }
}
