using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            category_scroll.HorizontalScroll.Maximum = 0;
            category_scroll.AutoScrollPosition = new Point(0, 0);
            category_scroll.AutoScroll = true;
            list_item_movie.VerticalScroll.Maximum = 0;
            list_item_movie.AutoScroll = false;
            list_item_movie.VerticalScroll.Visible = false;
            list_item_movie.AutoScroll = true;
            this.list_item_movie.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(this.list_item_movie, true, null);
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
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void search_input_Leave(object sender, EventArgs e)
        {
            if(search_input.Text.Replace(" ",string.Empty) == string.Empty)
            {
                search_input.Text = "Search";
            }
        }
        private void search_input_Enter(object sender, EventArgs e)
        {
            search_input.Text = "";
        }
        #endregion

        #region Category Movie
        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Tag = 1;
            timer1.Enabled = true;
        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Tag = 0;
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

            if (!category_scroll.Focus()) category_scroll.Focus();
            for (int i = 0; i < 5; i++)
            {
                SendMessage(this.category_scroll.Handle, WM_SCROLL, (IntPtr)Convert.ToInt32(timer1.Tag), IntPtr.Zero);
            }
        }
        #endregion

        
    }
}
