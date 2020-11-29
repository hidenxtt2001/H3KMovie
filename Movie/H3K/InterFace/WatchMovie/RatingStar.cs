using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace.WatchMovie
{
    public partial class RatingStar : UserControl
    {
        private int _point = 50;

        public RatingStar()
        {
            InitializeComponent();
        }

        public int Point { get => _point; set { 
                _point = value;
                setValue();
            } }

        private void RatingStar_Load(object sender, EventArgs e)
        {
            setValue();
        }
        private void setValue()
        {
            star1.BackgroundImage = Point < 10 ? icon_star.Images[0] : Point < 20 ? icon_star.Images[1] : icon_star.Images[2];
            star2.BackgroundImage = Point < 30 ? icon_star.Images[0] : Point < 40 ? icon_star.Images[1] : icon_star.Images[2];
            star3.BackgroundImage = Point < 50 ? icon_star.Images[0] : Point < 60 ? icon_star.Images[1] : icon_star.Images[2];
            star4.BackgroundImage = Point < 70 ? icon_star.Images[0] : Point < 80 ? icon_star.Images[1] : icon_star.Images[2];
            star5.BackgroundImage = Point < 90 ? icon_star.Images[0] : Point < 100 ? icon_star.Images[1] : icon_star.Images[2];
        }
    }
}
