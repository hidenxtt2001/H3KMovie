using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mange_Movie
{
    public partial class Form1 : Form
    {

        #region Drag Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        #region Control Action
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(34, 43, 49);
            panel2.BackColor = Color.FromArgb(248, 55, 69);
            checkBox1.ForeColor = Color.White;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
        }
        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (((CheckBox)sender).ForeColor == Color.White)
            {
                ((CheckBox)sender).ForeColor = Color.FromArgb(248, 55, 69);
            }
            else
            {
                ((CheckBox)sender).ForeColor = Color.White;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void Pic4Click(object sender, MouseEventArgs e)
        {
            button1_Click(sender, e);
        }

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private ConnectDatabase data { get; set; }
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            data = new ConnectDatabase();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (check_PosterLink())
            {
                
                    try
                    {
                        pictureBox1.Load("https://drive.google.com/uc?id=" + Regex.Match(textBox3.Text, @"[-\w]{25,}").Value);
                    }
                    catch (Exception) { MessageBox.Show("Lỗi link ảnh"); }
                
            }
            else
            {
                errorProvider1.Clear();
                errorProvider1.SetError(textBox3, "Make sure is a link Image");
            }
        }

        #region Check Valided
        public bool check_PosterLink()
        {
            return Regex.Match(textBox3.Text, @"^(http:\/\/www\.|https:\/\/www\.|http:\/\/|https:\/\/)?[a-z0-9]+([\-\.]{1}[a-z0-9]+)*\.[a-z]{2,5}(:[0-9]{1,5})?(\/.*)?$").Value != "" && !IsImageUrl(textBox3.Text);
        }
        public bool IsImageUrl(string URL)
        {
            var req = (HttpWebRequest)HttpWebRequest.Create(URL);
            req.Method = "HEAD";
            using (var resp = req.GetResponse())
            {
                return resp.ContentType.ToLower(CultureInfo.InvariantCulture)
                           .StartsWith("image/");
            }
        }

        public bool check_MovieLink()
        {
            return Regex.Match(textBox3.Text, @"[-\w]{25,}").Value != "";
        }
        #endregion
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && check_MovieLink() && check_PosterLink() && textBox4.Text != null)
            {
                string movieid = Regex.Match(textBox5.Text, @"d\/(.*?)\/view").Groups[1].Value;
                if (!data.checkExist(movieid))
                {
                    if (data.MovieAdd(movieid, textBox1.Text, textBox2.Text, Convert.ToInt32(numericUpDown1.Value), textBox4.Text, textBox5.Text, ImageToByteArray(pictureBox1.Image), textBox7.Text, textBox6.Text) && data.MovieGenresAdd(getGenre(movieid)))
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        if (data.checkExist(movieid)) data.MovieDel(movieid);
                        MessageBox.Show("Thêm thất bại");
                    }
                }
            }
            else
                MessageBox.Show("Điền đầy đủ thông tin");
        }

        public string[] getGenre(string movieid)
        {
            List<string> result = new List<string>();
            foreach(CheckBox genre in flowLayoutPanel1.Controls)
            {
                if (genre.Checked)
                {
                    result.Add(string.Format("(N'{0}',{1})", movieid, genre.Name.Replace("checkBox",string.Empty)));
                }
            }
            return result.ToArray();
        }
        

    }
}
