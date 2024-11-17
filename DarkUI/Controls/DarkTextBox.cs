using DarkUI.Config;

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DarkUI.Controls
{
    public class DarkTextBox : TextBox
    {
        #region Constructor Region

        public DarkTextBox()
        {
            Padding = new Padding(2, 2, 2, 2);
            BorderStyle = BorderStyle.FixedSingle;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            BackColor = Colors.LightBackground;
            ForeColor = Colors.LightText;

            base.OnHandleCreated(e);
        }

        #endregion
    }
}
