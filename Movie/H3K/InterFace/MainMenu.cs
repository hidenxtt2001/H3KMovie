﻿using H3K.InterFace.Sign_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace
{
    public partial class MainMenu : Form
    {
        public static ConnectData data { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            // Disable Horizontal Scroll Bar
            category_scroll.HorizontalScroll.Maximum = 0;
            category_scroll.AutoScrollPosition = new Point(0, 0);
            category_scroll.AutoScroll = true;


            list_item_movie.VerticalScroll.Maximum = 0;
            list_item_movie.AutoScrollPosition = new Point(0, 0);
            list_item_movie.AutoScroll = true;

            // Enable Double Buffered
            EnableDoubleBuferring(this);

            // Set normal button main choose
            selectPanel = movie_show;

            manage_year.Maximum = DateTime.Now.Year;

            // Data
            data = new ConnectData();
        }

        private static List<Thread> workLoad { get; set; }

        public static void EnableDoubleBuferring(Control control)
        {
            foreach (Control item in control.Controls)
            {
                EnableDoubleBuferring(item);
            }
            var property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            property.SetValue(control, true, null);
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            workLoad = new List<Thread>();
            if (!LoginCheck())
            {
                this.Close();
            }
            else
            {
                if (!(bool)data.Account.Rows[0]["manage"])
                {
                    manage_show.Enabled = false;
                    manage_show.Visible = false;
                }
            }
        }
        private void MainMenu_Shown(object sender, EventArgs e)
        {
            GenreChooseLoad(genre1, e);
        }
        #region Check Login

        private bool LoginCheck()
        {
            Sign_Form.Login loginform = new Sign_Form.Login(data);
            loginform.ShowDialog();
            return loginform.loginSubmit;
        }

        #endregion

        #region Mouse Drag Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }

        #endregion

        #region Control Action
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Search Action
        private void search_input_Leave(object sender, EventArgs e)
        {
            if (search_input.Text.Replace(" ", string.Empty) == string.Empty)
            {
                search_input.Text = "Search";
            }
        }
        private void search_input_Enter(object sender, EventArgs e)
        {
            search_input.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            loadSearch(search_input.Text);
        }
        private void search_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loadSearch(search_input.Text);
            }
        }


        #endregion

        #region Category Movie
        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Tag = 0;
            timer1.Enabled = true;
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Tag = 1;
            timer1.Enabled = true;
        }
        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
        }
        private void button5_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        private const int WM_SCROLL = 276; // Horizontal scroll 

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (!category_scroll.Focused) category_scroll.Focus();
            for (int i = 0; i < 5; i++)
            {
                SendMessage(this.category_scroll.Handle, WM_SCROLL, (IntPtr)Convert.ToInt32(timer1.Tag), IntPtr.Zero);
            }
        }

        #endregion

        #region Button Main Show Panel

        private Control selectPanel { get; set; }
        private void mainbutton_show(object sender, EventArgs e)
        {
            if (selectPanel != null)
            {
                selectPanel.BackColor = Color.FromArgb(23, 27, 41);
                switch (selectPanel.Name)
                {
                    case "movie_show":
                        ClearControl(list_item_movie);
                        break;
                    case "favorite_show":
                        ClearControl(movies_list_favorite);
                        break;
                    case "history_show":
                        ClearControl(movies_list_history);
                        break;
                }
            }
            switch (((Button)sender).Name)
            {
                case "movie_show":
                    movie_show_panel.BringToFront();
                    GenreChooseLoad(genre1, e);
                    break;
                case "account_infor":
                    account_infor_panel.BringToFront();
                    break;
                case "favorite_show":
                    favorite_show_panel.BringToFront();
                    Thread t = new Thread(() =>
                    {
                        loadfavorite();
                    });
                    t.IsBackground = true;
                    workLoad.Add(t);
                    t.Start();
                    break;
                case "history_show":
                    history_show_panel.BringToFront();
                    Thread k = new Thread(() =>
                    {
                        loadHistory();
                    });
                    k.IsBackground = true;
                    workLoad.Add(k);
                    k.Start();
                    break;
                case "manage_show":
                    manage_show_panel.BringToFront();
                    break;
            }
            selectPanel = (Button)sender;
            ((Button)sender).BackColor = Color.FromArgb(125, 124, 163);

        }


        #endregion

        #region Load Data

        public Image byteArrayToImage(byte[] bytesArr) // Convert byte to Array
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private void ClearControl(Control control) // Clear UserControl
        {
            foreach (Control k in control.Controls)
            {
                control.BeginInvoke(new Action(() =>
                {
                    control.Controls.Remove(k);
                    k.Dispose();
                }));

            }

            control.Invoke(new Action(() => { control.Controls.Clear(); }));
        }

        private void loadDataAccount() // Update information about account
        {
            data.UpdateAccount();
        }
        private void loadHistory()// Load Movie History 
        {
            try
            {
                ClearControl(movies_list_history);
                loading_label.Invoke(new Action(() => { loading_label.Visible = true; }));
                DataTable result = data.dataHistory(data.Account.Rows[0]["username"].ToString()).Tables[0];
                if (!workLoad.Contains(Thread.CurrentThread)) return;
                loading_label.Invoke(new Action(() => { loading_label.Visible = false; }));
                foreach (DataRow item in result.Rows)
                {
                    if (workLoad.Contains(Thread.CurrentThread))
                        movies_list_history.Invoke(new Action(() =>
                        {
                            movies_list_history.Controls.Add(new Movie_Mange.MovieItem()
                            {
                                Movie_id = item["movie_id"].ToString(),
                                Title = item["title"].ToString(),
                                Content = item["plot"].ToString(),
                                Rating = Convert.ToInt32(item["rating"]),
                                Director = item["director"].ToString(),
                                MovieLink = item["movie_link"].ToString(),
                                Background_link = item["poster"].ToString(),
                                Year = item["year_create"].ToString(),
                                Nation = item["nation"].ToString()
                            });
                        }));
                    else return;
                }
            }
            catch (Exception) { }

        }

        private void loadfavorite()// Load Movie Favorite 
        {
            try
            {
                ClearControl(movies_list_favorite);
                loading_label.Invoke(new Action(() => { loading_label.Visible = true; }));
                DataTable result = data.dataFavorite(data.Account.Rows[0]["username"].ToString()).Tables[0];
                if (!workLoad.Contains(Thread.CurrentThread)) return;
                loading_label.Invoke(new Action(() => { loading_label.Visible = false; }));
                foreach (DataRow item in result.Rows)
                {
                    if (workLoad.Contains(Thread.CurrentThread))
                        movies_list_favorite.Invoke(new Action(() =>
                        {
                            movies_list_favorite.Controls.Add(new Movie_Mange.MovieItem()
                            {
                                Movie_id = item["movie_id"].ToString(),
                                Title = item["title"].ToString(),
                                Content = item["plot"].ToString(),
                                Rating = Convert.ToInt32(item["rating"]),
                                Director = item["director"].ToString(),
                                MovieLink = item["movie_link"].ToString(),
                                Background_link = item["poster"].ToString(),
                                Year = item["year_create"].ToString(),
                                Nation = item["nation"].ToString()
                            });
                        }));
                    else return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void loadMovie(int genre)// Load Movie by Genre 
        {

            ClearControl(list_item_movie);
            loading_label.Invoke(new Action(() => { loading_label.Visible = true; }));
            try
            {
                DataTable result = data.dataMovie(genre).Tables[0];
                if (!workLoad.Contains(Thread.CurrentThread)) return;
                loading_label.Invoke(new Action(() => { loading_label.Visible = false; }));
                foreach (DataRow item in result.Rows)
                {
                    if (workLoad.Contains(Thread.CurrentThread))
                        list_item_movie.Invoke(new Action(() =>
                        {
                            list_item_movie.Controls.Add(new Movie_Mange.MovieItem()
                            {
                                Movie_id = item["movie_id"].ToString(),
                                Title = item["title"].ToString(),
                                Content = item["plot"].ToString(),
                                Rating = Convert.ToInt32(item["rating"]),
                                Director = item["director"].ToString(),
                                MovieLink = item["movie_link"].ToString(),
                                Background_link = item["poster"].ToString(),
                                Year = item["year_create"].ToString(),
                                Nation = item["nation"].ToString()
                            });
                        }));
                    else return;
                }
            }
            catch (Exception)
            {

            }


        }

        private void loadSearch(string keyword) // Search Movie
        {
            if (workLoad.Count != 0)
            {
                foreach (Thread k in workLoad)
                {
                    k.Abort();
                }
            }
            Thread t = new Thread(() =>
            {
                ClearControl(list_item_movie);
                loading_label.Invoke(new Action(() => { loading_label.Visible = true; }));
                DataTable result = data.searchMovie(keyword).Tables[0];
                loading_label.Invoke(new Action(() => { loading_label.Visible = false; }));
                foreach (DataRow item in result.Rows)
                {
                    list_item_movie.Invoke(new Action(() =>
                    {
                        list_item_movie.Controls.Add(new Movie_Mange.MovieItem()
                        {
                            Movie_id = item["movie_id"].ToString(),
                            Title = item["title"].ToString(),
                            Content = item["plot"].ToString(),
                            Rating = Convert.ToInt32(item["rating"]),
                            Director = item["director"].ToString(),
                            MovieLink = item["movie_link"].ToString(),
                            Background_link = item["poster"].ToString(),
                            Year = item["year_create"].ToString(),
                            Nation = item["nation"].ToString()
                        });
                    }));
                }
            });
            t.IsBackground = true;
            workLoad.Add(t);
            t.Start();

        }

        private void GenreChooseLoad(object sender, EventArgs e) // Load Follow Genres
        {
            if (workLoad.Count != 0)
            {
                foreach (Thread k in workLoad)
                {
                    k.Abort();
                }
                workLoad.Clear();
            }
            Thread t = new Thread(() =>
            {
                loadMovie(Convert.ToInt32(Regex.Match(((Button)sender).Name, @"\d{1,}").Value));
            });
            t.IsBackground = true;
            workLoad.Add(t);
            t.Start();
        }

        #endregion

        #region Manage Movie

        private void manage_poster_link_Leave(object sender, EventArgs e)
        {
            if (manage_poster_link.Text != string.Empty && IsImageUrl(manage_poster_link.Text))
            {
                manage_poster.Image =  Image.FromStream(DownloadData(manage_poster_link.Text));
            }
            else
            {
                MessageWarning message = new MessageWarning("Link poster không hợp lệ");
                message.ShowDialog();
            }
        }

        public bool IsImageUrl(string URL) // Check if url is a image or not  
        {
            var req = (HttpWebRequest)HttpWebRequest.Create(URL);
            req.Method = "HEAD";
            using (var resp = req.GetResponse())
            {
                return resp.ContentType.ToLower(CultureInfo.InvariantCulture)
                           .StartsWith("image/");
            }
        }

        private Stream DownloadData(string url) // Download image to poster
        {
            HttpWebRequest webRequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
            webRequest.AllowWriteStreamBuffering = true;
            webRequest.Timeout = 30000;

            System.Net.WebResponse webResponse = webRequest.GetResponse();

            return webResponse.GetResponseStream();

        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            MessageWarning message = new MessageWarning("");
            if (manage_title.Text != string.Empty && manage_poster_link.Text != string.Empty && manage_movie_link.Text != string.Empty)
            {
                string movieid = Regex.Match(manage_movie_link.Text, @"d\/(.*?)\/view").Groups[1].Value;
                if (!data.checkExist(movieid))
                {
                    if (data.MovieAdd(movieid, manage_title.Text, manage_content.Text, Convert.ToInt32(manage_rating.Value), manage_director.Text, manage_movie_link.Text, manage_poster_link.Text, manage_nation.Text, Convert.ToInt32(manage_year.Value).ToString()) && data.MovieGenresAdd(getGenre(movieid)))
                    {
                        message.message = "Thêm thành công";
                        message.ShowDialog();
                    }
                    else
                    {
                        if (data.checkExist(movieid)) data.MovieDel(movieid);
                        message.message = "Thêm thất bại";
                        message.ShowDialog();
                    }
                }
                else
                {
                    message.message = "Đã tồn tại phim trong cơ sở dữ liệu !";
                    message.ShowDialog();
                }
            }
            else
            {
                message.message = "Vui lòng điền đầy đủ thông tin !";
                message.ShowDialog();
            }
        }
        public string[] getGenre(string movieid)
        {
            List<string> result = new List<string>();
            foreach (CheckBox genre in flowLayoutPanel2.Controls)
            {
                if (genre.Checked)
                {
                    result.Add(string.Format("(N'{0}',{1})", movieid, genre.Name.Replace("manage_genre", string.Empty)));
                }
            }
            return result.ToArray();
        }



        #endregion
    }
}
