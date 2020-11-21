using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO;

namespace H3K.InterFace.Movie_Mange
{
    public partial class MovieInfor : UserControl
    {
        public MovieInfor()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(125, Color.White);
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
            set { _title = value; label1.Text = value; }
        }
        [Category("Custom")]
        public Image ImageBackgournd
        {
            get { return _background; }
            set { _background = value; this.BackgroundImage = _background; }
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
        #region Action
        private void MovieInfor_MouseHover(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {
            using (var form = new WatchMovieForm(this))
            {
                form.ShowDialog();
                form.Dispose();
            }
        }
    }
}
