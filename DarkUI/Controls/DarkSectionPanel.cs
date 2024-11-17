using DarkUI.Config;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DarkUI.Controls
{
    public class DarkSectionPanel : Panel
    {
        #region Field Region

        private string _sectionHeader;

        #endregion

        #region Property Region

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Padding Padding
        {
            get { return base.Padding; }
        }

        [Category("Appearance")]
        [Description("The section header text associated with this control.")]
        public string SectionHeader
        {
            get { return _sectionHeader; }
            set
            {
                _sectionHeader = value;
                Invalidate();
            }
        }

        #endregion

        #region Constructor Region

        public DarkSectionPanel()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);

            base.Padding = new Padding(1, 25, 1, 1);
        }

        #endregion

        #region Event Handler Region

        protected override void OnEnter(System.EventArgs e)
        {
            base.OnEnter(e);

            Invalidate();
        }

        protected override void OnLeave(System.EventArgs e)
        {
            base.OnLeave(e);

            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (Controls.Count > 0)
                Controls[0].Focus();
        }

        #endregion

        #region Paint Region

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var rect = ClientRectangle;

            // Fill body
            { var b = GdiCache.Brush(Colors.ControlBackground);
            
                g.FillRectangle(b, rect);
            }

            // Draw header
            var bgColor = ContainsFocus ? Colors.CaptionActiveBackground : Colors.CaptionInactiveBackground;
            var darkColor = ContainsFocus ? Colors.DarkBlueBorder : Colors.DarkBorder;
            var lightColor = ContainsFocus ? Colors.LightBlueBorder : Colors.LightBorder;

            { var b = GdiCache.Brush(bgColor);
            
                var bgRect = new Rectangle(0, 0, rect.Width, 25);
                g.FillRectangle(b, bgRect);
            }

            { var p = GdiCache.Pen(darkColor);
            
                g.DrawLine(p, rect.Left, 0, rect.Right, 0);
                g.DrawLine(p, rect.Left, 25 - 1, rect.Right, 25 - 1);
            }

            { var p = GdiCache.Pen(lightColor);
            
                g.DrawLine(p, rect.Left, 1, rect.Right, 1);
            }

            var xOffset = 3;

            { var b = GdiCache.Brush(Colors.LightText);
            
                var textRect = new Rectangle(xOffset, 0, rect.Width - 4 - xOffset, 25);

                var format = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center,
                    FormatFlags = StringFormatFlags.NoWrap,
                    Trimming = StringTrimming.EllipsisCharacter
                };

                g.DrawString(SectionHeader, Font, b, textRect, format);
            }

            // Draw border
            var borderPen = GdiCache.Pen(Colors.DarkBorder, 1);
            {
                var modRect = new Rectangle(rect.Left, rect.Top, rect.Width - 1, rect.Height - 1);

                g.DrawRectangle(borderPen, modRect);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Absorb event
        }

        #endregion
    }
}
