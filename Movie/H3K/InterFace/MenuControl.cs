using H3K.InterFace;
using H3K.InterFace.Movie_Mange;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K
{
    public partial class MenuControl : Form
    {
        public MenuControl()
        {
            InitializeComponent();
            this.movie_items.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(this.movie_items, true, null);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            category_dropdow = true;
            movie_items.VerticalScroll.Maximum = 0;
            movie_items.AutoScroll = false;
            movie_items.HorizontalScroll.Visible = false;
            movie_items.AutoScroll = true;
            this.DoubleBuffered = true;
            using (Wait_Form fm = new Wait_Form(getDatabase))
            {
                fm.ShowDialog(this);
            }
            category_Selection(genre1, null);
        }
        private void category_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        #region DropDowItems
        private bool category_dropdow { get; set; }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!category_dropdow)
            {
                panel_category.Height += 25;
                if(panel_category.Height == genre1.Height*23)
                {
                    timer1.Stop();
                    category_dropdow = true;
                }
            }
            else
            {
                panel_category.Height -= 25;
                if (panel_category.Height == 0)
                {
                    timer1.Stop();
                    category_dropdow = false;
                }
            }

        }
        #endregion

        #region Get Database
        private static DataSet dataMovie { get; set; }
        private static DataSet dataMovie_genres { get; set; }
        private static DataTable dataTemp { get; set; }

        private static ConnectData connectData { get; set; }
        private Dictionary<int, MovieItem> items { get; set; }
        private void getDatabase()
        {
            /*connectData = new ConnectData();
            dataTemp = new DataTable();
            items = new Dictionary<int, MovieItem>();
            try
            {
                dataMovie = connectData.dataMovie();
                dataMovie_genres = connectData.dataGenres();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi kết nối tới server");
                this.Close();
            }
            foreach (DataRow dataRow in dataMovie.Tables[0].Rows)
            {
                using (var image = new MemoryStream((byte[])(dataRow["poster"])))
                {
                    items.Add(Convert.ToInt32(dataRow["movieid"]), new MovieItem()
                    {
                        ImageBackgournd = Image.FromStream(image),
                        Title = Regex.Replace(dataRow["title"].ToString(), @"\s+", " "),
                        Director = dataRow["director"].ToString(),
                        MovieLink = dataRow["movie_link"].ToString(),
                        Rating = Convert.ToInt32(dataRow["rating"]),
                        Content = dataRow["plot"].ToString()
                    });
                }
            }*/
        }

        #endregion

        #region List Movie to Layout
        
        private void category_Selection(object sender, EventArgs e)
        {
            dataTemp.Clear();
            var temp = from table1 in dataMovie.Tables[0].AsEnumerable()
                       join table2 in dataMovie_genres.Tables[0].AsEnumerable()
                       on (int)table1["movieid"] equals (int)table2["movieid"]
                       where (int)table2["genreid"] == Convert.ToInt32(Regex.Match(((Button)sender).Name, @"\d{1,}").Value)
                       select table1;
            if (temp.Count() != 0)
            dataTemp = temp.CopyToDataTable<DataRow>();
            LoadData();
        }
        private void LoadData()
        {
            new Thread(() =>
            {
                this.Invoke(new Action(() => {
                    clearControl();
                    movie_items.Controls.Clear();
                    foreach (DataRow item in dataTemp.Rows)
                    {
                        movie_items.Controls.Add(items[Convert.ToInt32(item["movieid"])]);
                    }
                }));
            }).Start();
        }
        private void clearControl()
        {
            movie_items.Controls.Clear();
        }
        #endregion

        #region Watch Movie
        #endregion
    }
}
