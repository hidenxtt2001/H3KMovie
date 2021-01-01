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

        private void poster_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(100, Color.FromArgb(125, 124, 163));
        }

        private void poster_MouseLeave(object sender, EventArgs e)
        {
            if (!IsMouseHover(this))
            {
                this.BackColor = Color.Transparent;
            }
        }
        private bool IsMouseHover(Control c)
        {
            Point p = Control.MousePosition;
            Point p1 = c.PointToClient(p);
            if (c.DisplayRectangle.Contains(c.PointToClient(p)))
            {
                return true;
            }
            return false;
        }

        public delegate void EventClickAlbumControl(object sender, EventArgs e);
        public event EventClickAlbumControl ClickAlbumControl;


        private void AlbumControl_Click(object sender, EventArgs e)
        {
            if (this.ClickAlbumControl != null)
                this.ClickAlbumControl(this, e);
        }
    }
}
