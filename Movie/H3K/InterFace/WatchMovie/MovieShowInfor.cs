using H3K.InterFace.Movie_Mange;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace.WatchMovie
{
    public partial class MovieShowInfor : Form
    {
        private MovieItem movieItem { get; set; }


        public MovieShowInfor(MovieItem movieItem)
        {
            InitializeComponent();
            this.movieItem = movieItem;
            this.content.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.content.MouseWheel += richTextBox1_MouseWheel;
        }
        void richTextBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                //Handle mouse move upwards
                if (content.SelectionStart > 10)
                {
                    content.SelectionStart -= 10;
                    content.ScrollToCaret();
                }
            }
            else
            {
                //Mouse move downwards.
                content.SelectionStart += 10;
                content.ScrollToCaret();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_CLIPCHILDREN
                return cp;
            }
        }
        

        #region Mouse Drag Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MovieShowInfor_Load(object sender, EventArgs e)
        {
            poster.BackgroundImage = movieItem.ImageBackgournd;
            rating.Point = movieItem.Rating;
            director.Text = movieItem.Director;
            title.Text = movieItem.Title;
            content.Text = movieItem.Content;
            content.SelectAll();
            content.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void watch_movie_Click(object sender, EventArgs e)
        {
            MovieShow form = new MovieShow(movieItem.Movie_id,movieItem.Title);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
