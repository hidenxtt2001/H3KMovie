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
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Media.Imaging;
using System.Net;
using System.IO;

namespace H3K.InterFace.Movie_Mange
{
    public partial class MovieItem : UserControl
    {
        public MovieItem()
        {
            InitializeComponent();
            this.Disposed += OnDispose;
        }

        private void OnDispose(object sender, EventArgs e)
        {
            _background = null;
            poster.BackgroundImage = null;
        }
        private string _movie_id;
        private string _title;
        private string _content;
        private int _rating;
        private string _director;
        private string _movieLink;
        private Image _background =null;
        private string _background_link;
        private string _year;
        private string _nation;


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
        [Category("Custom")]
        public string Movie_id { get => _movie_id; set => _movie_id = value; }
        [Category("Custom")]
        public string Year { get => _year; set => _year = value; }
        [Category("Custom")]
        public string Nation { get => _nation; set => _nation = value; }
        public string Background_link { get => _background_link; set => _background_link = value; }


        #region Action on Hover
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
        #endregion

        private void MovieItem_Load(object sender, EventArgs e)
        {
            title.Text = _title;
            Thread t = new Thread(() => {
                try
                {
                    _background = Image.FromStream(DownloadData(Background_link));
                    this.Invoke(new Action(() => {
                        poster.BackgroundImage = _background;
                    }));
                    Console.WriteLine("Load Xong Hinh");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            });
            t.IsBackground = true;
            t.Start();
        }

        private Stream DownloadData(string url)
        {
            HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
            webRequest.AllowWriteStreamBuffering = true;
            webRequest.UseDefaultCredentials = true;
            webRequest.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            webRequest.Timeout = 30000;

            try
            {
                System.Net.WebResponse webResponse = webRequest.GetResponse();

                return webResponse.GetResponseStream();
            }
            catch(WebException ex)
            {
                return null;
            }
            
        }
        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        private void watch_click(object sender, EventArgs e)
        {
            WatchMovie.MovieShowInfor form = new WatchMovie.MovieShowInfor(this, MainMenu.data);
            (this.ParentForm as Form).Hide();
            form.ShowDialog();
            (this.ParentForm as Form).Show();
        }

    }
}
