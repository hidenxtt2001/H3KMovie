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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MouseEnterX(object sender, EventArgs e)
        {
            //label2.Text 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadForm2(object sender, EventArgs e)
        {
            this.Top = 50;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 200;
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
            if(this.Top < 100)
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
