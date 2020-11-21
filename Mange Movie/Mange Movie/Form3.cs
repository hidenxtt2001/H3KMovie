using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mange_Movie
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Form1 form1 = new Form1();
        private void LoadForm3(object sender, EventArgs e)
        {
            this.Top = 80;
            this.Left = form1.Width + form1.Width / 2 + 80;
            timer1.Start();
            show.Start();
            callClose.Start();
        }
        private void timeout_tick(object sender, EventArgs e)
        {
            this.Close();
        }
        int interval = 0;

        private void show_Tick(object sender, EventArgs e)
        {
            if (this.Top < 200)
            {
                this.Top += interval;
                interval += 2;
            }
            else
            {
                show.Stop();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
                this.Opacity -= 0.1;
            else
                this.Close();
        }

        private void callClose_Tick(object sender, EventArgs e)
        {
            close.Start();
        }
    }
}
