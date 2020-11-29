using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace.WatchMovie
{
    class GradientPanel:Panel
    {
        public Color ColorBotton { get; set; }
        public Color ColorTop { get; set; }
        

        private int _opacity = 255;
        public int Opacity { get { return _opacity; } set { _opacity = value; } }

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
