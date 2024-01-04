using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Mini_Attendance
{
    public class RoundedPanel : Panel
    {
        private int _borderRadius = 100;
        private Color _colorPanel = ColorTranslator.FromHtml("#A0C1C7");
     
        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                Invalidate();
            }
        }

        public Color ColorPanel
        {
            get { return _colorPanel; }
            set
            {
                _colorPanel = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(ClientRectangle.X, ClientRectangle.Y, BorderRadius, BorderRadius, 180, 90);
                path.AddArc(ClientRectangle.X + Width - BorderRadius, ClientRectangle.Y, BorderRadius, BorderRadius, 270, 90);
                path.AddArc(ClientRectangle.X + Width - BorderRadius, ClientRectangle.Y + Height - BorderRadius, BorderRadius, BorderRadius, 0, 90);
                path.AddArc(ClientRectangle.X, ClientRectangle.Y + Height - BorderRadius, BorderRadius, BorderRadius, 90, 90);

                using (SolidBrush brush = new SolidBrush(ColorPanel))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.FillPath(brush, path);
                    e.Graphics.SmoothingMode = SmoothingMode.Default;
                }
            }
        }
    }
}
