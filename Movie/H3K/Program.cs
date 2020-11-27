using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using H3K.InterFace;
using H3K.InterFace.Movie_Mange;
using System.Drawing;

namespace H3K
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new InterFace.MainMenu());
            MovieInfor tempmovie = new MovieInfor();
            tempmovie.Title = ("Avengers 4: Endgame (2019)");
            tempmovie.Content = ("Sau cái chết bất ngờ của người vợ, John Wick (Reeves) nhận được món quà cuối cùng từ cô ấy, một chú chó nhỏ giống beagle tên Daisy, và một lời nhắn :\"Xin anh đừng quên cách yêu thương\". Nhưng cuộc sống của John lại bị quấy rối khi chiếc Boss Mustang 1969 lọt vào tầm ngắm của tên mafia Nga Iosef Tarasov (Alfie Allen).");
            tempmovie.Director = ("Khanh SB");
            tempmovie.Rating = 70;
            tempmovie.ImageBackgournd = Properties.Resources.image__4_;
            Application.Run(new WatchMovieForm(tempmovie));
        }
    }
}
