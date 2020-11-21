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

        public static string connectionString = @"Server=tcp:hunghuy201280.database.windows.net,1433;Initial Catalog=H3K;Persist Security Info=False;User ID=hunghuy2009;Password=Hunghuy123;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        public SqlConnection data;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            data = new SqlConnection(connectionString);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            if (textBox1.Text != "" && check_MovieLink() && check_PosterLink() && textBox4.Text != null)
                try
                {
                    data.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        int countmovie, countmoviegenres;
                        using (SqlDataAdapter da = new SqlDataAdapter(@"SELECT [movieid] FROM [H3K].[dbo].[Movies]", data))
                        {
                            using (DataSet ds = new DataSet())
                            {
                                da.Fill(ds);
                                countmovie = ds.Tables[0].Rows.Count + 1;
                            }
                        }
                        cmd.Connection = data;
                        byte[] arr;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            arr = ms.ToArray();
                        }
                        cmd.CommandText = "insert into Movies (movieid,title,plot,rating,director,movie_link,poster) values(" + countmovie + ",N'" + Regex.Replace(textBox1.Text, @"\s+", " ") + "',@plot," + numericUpDown1.Value + ",N'" + textBox4.Text + "',N'" + textBox5.Text + "',@arr)";
                        cmd.Parameters.AddWithValue("@plot", textBox2.Text);
                        cmd.Parameters.AddWithValue("@arr", arr);
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "insert into Movie_genres values " + string.Join(",", getGenre(countmovie));
                        cmd.ExecuteNonQuery();
                    }
                    data.Close();
                    //MessageBox.Show("Thêm thành công");
                    form2.Show();
                }
                catch (Exception ex)
                {
                    data.Close();
                    MessageBox.Show(ex.Message);
                }
            else
                //MessageBox.Show("Điền đầy đủ thông tin");
                form3.Show();
        }
        public string getGenres(int moviegenresid, int movieid)
        {
            string result = "";
            if (checkBox1.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 1 ),";
            if (checkBox2.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 2 ),";
            if (checkBox3.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 3 ),";
            if (checkBox4.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 4 ),";
            if (checkBox5.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 5 ),";
            if (checkBox6.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 6 ),";
            if (checkBox7.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 7 ),";
            if (checkBox8.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 8 ),";
            if (checkBox9.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 9 ),";
            if (checkBox10.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 10 ),";
            if (checkBox11.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 11),";
            if (checkBox12.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 12 ),";
            if (checkBox13.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 13 ),";
            if (checkBox14.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 14 ),";
            if (checkBox15.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 15 ),";
            if (checkBox16.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 16 ),";
            if (checkBox17.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 17 ),";
            if (checkBox18.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 18 ),";
            if (checkBox19.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 19 ),";
            if (checkBox20.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 20 ),";
            if (checkBox21.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 21 ),";
            if (checkBox22.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 22 ),";
            if (checkBox23.Checked) result += "(" + moviegenresid++ + "," + movieid + ", 23 ),";
            result = result.Remove(result.Length - 1);
            return result;
        }

        public string[] getGenre(int movieid)
        {
            List<string> result = new List<string>();
            foreach(CheckBox genre in flowLayoutPanel1.Controls)
            {
                if (genre.Checked)
                {
                    result.Add(string.Format("({0},{1})", movieid, genre.Name.Replace("checkBox",string.Empty)));
                }
            }
            return result.ToArray();
        }

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
            if (panel6.Width < pictureBox4.Width)
                panel6.Width = panel6.Width + 10;
            else
                timer1.Stop();
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
        private void MouseEnterPic2(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void MouseLeavePic4(object sender, EventArgs e)
        {
            timer1.Stop();
            panel6.Width = 0;
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
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
