using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace.Movie_Mange
{
    public partial class MovieItem : UserControl
    {
        public MovieItem()
        {
            InitializeComponent();
        }

        private string _title;
        private Image _background;
        private string _movieLink;
        private string _content;
        private string _director;
        private int _rating;
        [Category("Custom")]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        [Category("Custom")]
        public Image ImageBackgournd
        {
            get { return _background; }
            set { _background = value;}
        }
        [Category("Custom")]
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        [Category("Custom")]
        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }
        [Category("Custom")]
        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }
        [Category("Custom")]
        public string MovieLink
        {
            get { return _movieLink; }
            set { _movieLink = value; }
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
    }
}
