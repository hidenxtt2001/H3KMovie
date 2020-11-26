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

namespace H3K.InterFace
{
    public partial class WatchMovieForm : Form
    {
        private static MovieItem movie { get; set; }
        public WatchMovieForm(MovieItem item)
        {
            InitializeComponent();
            movie = item;
        }

        private void WatchMovieForm_Load(object sender, EventArgs e)
        {
            title.Text = movie.Title;
            director.Text = "Director : " + movie.Director;
            content.Text = "Content : " +  movie.Content;
            rating.Text = "Rating : ★" + movie.Rating.ToString();
            poster.Image = movie.ImageBackgournd;
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
    }
}
