using H3K.InterFace.Movie_Mange;
using H3K.InterFace.WatchMovie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace H3K.InterFace
{
    public partial class WatchMovieForm : Form
    {
        private static MovieInfor movie { get; set; }
        public WatchMovieForm(MovieInfor item)
        {
            InitializeComponent();
            movie = item;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        //Making Round Corner

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     
           int nTopRect,      
           int nRightRect,    
           int nBottomRect,   
           int nWidthEllipse, 
           int nHeightEllipse 
       );

        private void WatchMovieForm_Load(object sender, EventArgs e)
        {
            title.Text = movie.Title;
            director.Text =   movie.Director;
            content.Text =  movie.Content;
            rating.Text = "Rating : ★" + movie.Rating.ToString();
            poster.Image = movie.ImageBackgournd;

            //transparent
            panel4.BackColor = Color.FromArgb(125, Color.Black);

            //star for rating 
            if (movie.Rating <= 10)
                pictureBox3.Image = Properties.Resources.star_half_empty_50px;
            else
            {
                pictureBox3.Image = Properties.Resources.star_50px;
                if (movie.Rating <= 30 && movie.Rating > 20)
                    pictureBox4.Image = Properties.Resources.star_half_empty_50px;
                else if(movie.Rating > 30)
                {
                    pictureBox4.Image = Properties.Resources.star_50px;
                    if (movie.Rating <= 50 && movie.Rating > 40)
                        pictureBox5.Image = Properties.Resources.star_half_empty_50px;
                    else if(movie.Rating > 50)
                    {
                        pictureBox5.Image = Properties.Resources.star_50px;
                        if (movie.Rating <= 70 && movie.Rating > 60)
                            pictureBox6.Image = Properties.Resources.star_half_empty_50px;
                        else if(movie.Rating > 70)
                        {
                            pictureBox6.Image = Properties.Resources.star_50px;
                            if (movie.Rating <= 90 && movie.Rating > 80)
                                pictureBox7.Image = Properties.Resources.star_half_empty_50px;
                            else if(movie.Rating > 90)
                            {
                                pictureBox7.Image = Properties.Resources.star_50px;
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MovieShow show = new MovieShow(movie.MovieLink))
            {
                this.Hide();
                show.ShowDialog();
                show.Dispose();
            }

            this.Close();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Yellow;
       }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button_WOC2_Click(sender, e);
        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {

        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.LightGray;
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            //button1_Click(sender, e);
        }
        private void button_WOC1_MouseDown(object sender, MouseEventArgs e)
        {
            button_WOC1.OnHoverBorderColor = Color.Transparent;
        }

        private void button_WOC1_MouseUp(object sender, MouseEventArgs e)
        {
            button_WOC1.OnHoverBorderColor = Color.FromArgb(255, 66, 79);
        }
        private void button_WOC2_MouseDown(object sender, MouseEventArgs e)
        {
            button_WOC2.OnHoverBorderColor = Color.Transparent;
        }

        private void button_WOC2_MouseUp(object sender, MouseEventArgs e)
        {
            button_WOC2.OnHoverBorderColor = Color.FromArgb(255, 66, 79);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.FromArgb(255, 66, 79);
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.White;
        }
    }
}
