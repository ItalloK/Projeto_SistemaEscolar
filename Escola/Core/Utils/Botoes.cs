using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CustomControls.Botoes
{
    public class ButtonIG : Button
    {
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;
        private Color hoverBackgroundColor = Color.LightBlue;
        private Color originalBackgroundColor = Color.Transparent;

        [Category("Code Advance")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                if (value != borderSize)
                {
                    borderSize = value;
                    Invalidate(); // Repaint the control
                }
            }
        }

        [Category("Code Advance")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value != borderRadius)
                {
                    borderRadius = value;
                    Invalidate();
                }
            }
        }

        [Category("Code Advance")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                if (value != borderColor)
                {
                    borderColor = value;
                    Invalidate();
                }
            }
        }

        [Category("Code Advance")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackgroundColor
        {
            get => BackColor;
            set
            {
                if (value != BackColor)
                {
                    BackColor = value;
                    Invalidate();
                }
            }
        }

        [Category("Code Advance")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color TextColor
        {
            get => ForeColor;
            set
            {
                if (value != ForeColor)
                {
                    ForeColor = value;
                    Invalidate();
                }
            }
        }

        [Category("Code Advance")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverBackgroundColor
        {
            get => hoverBackgroundColor;
            set
            {
                if (value != hoverBackgroundColor)
                {
                    hoverBackgroundColor = value;
                }
            }
        }

        public ButtonIG()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Size = new Size(150, 40);
            BackColor = Color.MediumSlateBlue;
            ForeColor = Color.White;

            Resize += Button_Resize;
            MouseEnter += Button_MouseEnter;
            MouseLeave += Button_MouseLeave;
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize : 2;

            if (borderRadius > 2)
            {
                using GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius);
                using GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize);
                using Pen penSurface = new(Parent?.BackColor ?? Color.Transparent, smoothSize);
                using Pen penBorder = new(borderColor, borderSize);

                pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Region = new Region(pathSurface);
                pevent.Graphics.DrawPath(penSurface, pathSurface);

                if (borderSize >= 1)
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
            }
            else
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using Pen penBorder = new(borderColor, borderSize)
                    {
                        Alignment = PenAlignment.Inset
                    };
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (Parent != null)
                Parent.BackColorChanged += Container_BackColorChanged;
        }

        private void Container_BackColorChanged(object? sender, EventArgs e)
        {
            Invalidate();
        }

        private void Button_Resize(object? sender, EventArgs e)
        {
            if (borderRadius > Height)
                borderRadius = Height;
        }

        private void Button_MouseEnter(object? sender, EventArgs e)
        {
            originalBackgroundColor = BackColor;
            BackColor = hoverBackgroundColor;
        }

        private void Button_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = originalBackgroundColor;
        }
    }
}
