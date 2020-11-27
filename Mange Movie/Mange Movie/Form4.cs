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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Start();
        }

        private void Fom4_load(object sender, EventArgs e)
        {
            timer2.Start();
            pictureBox3.Enabled = false;
            label2.Visible = false;
            timer4.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Right < panel2.Right+20)
            {
                pictureBox2.Left += 5;
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                pictureBox3.BringToFront();
                label2.BringToFront();
                pictureBox3.Enabled = true;
                label2.Visible = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Enabled == true)
            {
                timer4.Stop();
                pictureBox3.Enabled = false;
            }
        }
    }
}
