using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    private int _borderRadius = 10;
    private Color _buttonColor = Color.LightGray;
    private Color _hoverColor = Color.Gray; // Warna saat mouse hover

    public int BorderRadius
    {
        get { return _borderRadius; }
        set
        {
            _borderRadius = value;
            Invalidate();
        }
    }

    public Color ButtonColor
    {
        get { return _buttonColor; }
        set
        {
            _buttonColor = value;
            Invalidate();
        }
    }

    public Color HoverColor
    {
        get { return _hoverColor; }
        set
        {
            _hoverColor = value;
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

            Color currentColor = (this.ClientRectangle.Contains(this.PointToClient(Cursor.Position))) ? HoverColor : ButtonColor;

            using (SolidBrush brush = new SolidBrush(currentColor))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.FillPath(brush, path);
                e.Graphics.SmoothingMode = SmoothingMode.Default;
            }

            // Draw text
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(this.Text, this.Font, textBrush, ClientRectangle, sf);
            }
        }
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        Invalidate();
    }
}
