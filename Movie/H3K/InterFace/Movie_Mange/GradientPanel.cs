using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace.Movie_Mange
{
    class GradientPanel : Panel
    {
        public Color ColorTop { get; set; }
        public Color ColorBotton { get; set; }

        private int _opacity = 255;
        public int Opacity
        {
            get { return _opacity; }
            set
            {
                if (value > 255) _opacity = 255;
                else if (value < 0) _opacity = 0;
                else
                    _opacity = value;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(0, this.ColorTop), Color.FromArgb(_opacity, this.ColorBotton), 90F);
            Graphics g = e.Graphics;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
