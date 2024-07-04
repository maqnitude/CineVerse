using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineVerse.Views.CustomControls
{
    public partial class CustomScrollablePanel : Panel
    {
        private Color scrollThumbColor = Color.Red;
        private Color scrollTrackColor = Color.Green;
        private Color scrollArrowColor = Color.Blue;

        public Color ScrollThumbColor
        {
            get { return scrollThumbColor; }
            set { scrollThumbColor = value; Invalidate(); }
        }

        public Color ScrollTrackColor
        {
            get { return scrollTrackColor; }
            set { scrollTrackColor = value; Invalidate(); }
        }

        public Color ScrollArrowColor
        {
            get { return scrollArrowColor; }
            set { scrollArrowColor = value; Invalidate(); }
        }

        public CustomScrollablePanel()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;
            this.AutoScroll = true;
            this.Scroll += CustomScrollablePanel_Scroll;
        }

        private void CustomScrollablePanel_Scroll(object sender, ScrollEventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (this.VerticalScroll.Visible)
            {
                DrawVerticalScrollBar(e.Graphics);
            }

            if (this.HorizontalScroll.Visible)
            {
                DrawHorizontalScrollBar(e.Graphics);
            }
        }

        private void DrawVerticalScrollBar(Graphics g)
        {
            Rectangle trackRect = new Rectangle(this.Width - SystemInformation.VerticalScrollBarWidth, 0, SystemInformation.VerticalScrollBarWidth, this.Height);
            using (Brush trackBrush = new SolidBrush(scrollTrackColor))
            {
                g.FillRectangle(trackBrush, trackRect);
            }

            int thumbHeight = Math.Max(this.Height * this.Height / this.DisplayRectangle.Height, 10);
            int thumbTop = this.VerticalScroll.Value * (this.Height - thumbHeight) / (this.DisplayRectangle.Height - this.Height);
            Rectangle thumbRect = new Rectangle(this.Width - SystemInformation.VerticalScrollBarWidth, thumbTop, SystemInformation.VerticalScrollBarWidth, thumbHeight);
            using (Brush thumbBrush = new SolidBrush(scrollThumbColor))
            {
                g.FillRectangle(thumbBrush, thumbRect);
            }
        }

        private void DrawHorizontalScrollBar(Graphics g)
        {
            Rectangle trackRect = new Rectangle(0, this.Height - SystemInformation.HorizontalScrollBarHeight, this.Width, SystemInformation.HorizontalScrollBarHeight);
            using (Brush trackBrush = new SolidBrush(scrollTrackColor))
            {
                g.FillRectangle(trackBrush, trackRect);
            }

            int thumbWidth = Math.Max(this.Width * this.Width / this.DisplayRectangle.Width, 10);
            int thumbLeft = this.HorizontalScroll.Value * (this.Width - thumbWidth) / (this.DisplayRectangle.Width - this.Width);
            Rectangle thumbRect = new Rectangle(thumbLeft, this.Height - SystemInformation.HorizontalScrollBarHeight, thumbWidth, SystemInformation.HorizontalScrollBarHeight);
            using (Brush thumbBrush = new SolidBrush(scrollThumbColor))
            {
                g.FillRectangle(thumbBrush, thumbRect);
            }
        }
    }
}
