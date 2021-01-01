using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace H3K.InterFace.Movie_Mange
{
    public partial class AlbumMovies : UserControl
    {
        public AlbumMovies()
        {
            InitializeComponent();
        }
        private Color colorTop;
        private Color colorBottom;
        private String labelBottom;
        private String labelTop;
        public Color ColorTop { get => colorTop; set { colorTop = value; } }
        public Color ColorBottom { get => colorBottom; set { colorBottom = value; } }
        public string LabelBottom { get => labelBottom; set { labelBottom = value; this.label2.Text = value; } }
        public string LabelTop { get => labelTop; set { labelTop = value; this.label1.Text = value; } }

        private void poster_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle, Color.FromArgb(255, this.colorTop), Color.FromArgb(255, this.colorBottom), 90F);
            Graphics g = e.Graphics;
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            g.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
