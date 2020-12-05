using H3K.InterFace.Movie_Mange;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace.WatchMovie
{
    public partial class MovieShowInfor : Form
    {
        private MovieItem movieItem { get; set; }

        private ConnectData data { get; set; }

        public MovieShowInfor(MovieItem movieItem , ConnectData data)
        {
            InitializeComponent();
            this.movieItem = movieItem;
            this.data = data;
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
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
                ReleaseCapture();
                
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Form Load
        private void MovieShowInfor_Load(object sender, EventArgs e)
        {
            // Waitting Backgroundload
            Thread t = new Thread(() => { 
                while (movieItem.ImageBackgournd == null)
                {
                    continue;
                }
                this.Invoke(new Action(() => { poster.BackgroundImage = movieItem.ImageBackgournd; }));
                Console.WriteLine("Set up xong hinh");
            });
            t.IsBackground = true;
            t.Start();

            // Set information
            rating.Point = movieItem.Rating;
            point.Text = movieItem.Rating + "/100";
            director.Text = movieItem.Director;
            title.Text = movieItem.Title;
            content.Text = movieItem.Content;
            content.SelectAll();
            content.SelectionAlignment = HorizontalAlignment.Center;

            // set Flag favorite 
            setFlagLoad();
        }

        private void setFlagLoad()
        {
            if (data.checkFavorite(data.Account.Rows[0]["username"].ToString(), movieItem.Movie_id))
            {
                mark_flag.Image = Mark.Images[1];
                mark_flag.Tag = 1;
            }
            else
            {
                mark_flag.Image = Mark.Images[0];
                mark_flag.Tag = 0;
            }
        }
        #endregion

        #region Favorite Action
        private void mark_flag_Click(object sender, EventArgs e)
        {
            setFlag();
        }
        private void setFlag()
        {

            if (Convert.ToInt32(mark_flag.Tag) == 0)
            {
                data.setFavorite(data.Account.Rows[0]["username"].ToString(), movieItem.Movie_id);
                mark_flag.Image = Mark.Images[1];
                mark_flag.Tag = 1;
            }
            else
            {
                data.delFavorite(data.Account.Rows[0]["username"].ToString(), movieItem.Movie_id);
                mark_flag.Image = Mark.Images[0];
                mark_flag.Tag = 0;
            }

        }
        #endregion

        #region Watch Movie
        private void watch_movie_Click(object sender, EventArgs e)
        {
            MovieShow form = new MovieShow(movieItem.Movie_id,movieItem.Title);
            if (!data.checkHistory(data.Account.Rows[0]["username"].ToString(), movieItem.Movie_id))
                data.setHistory(data.Account.Rows[0]["username"].ToString(), movieItem.Movie_id);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        #endregion
        

        
    }
}
