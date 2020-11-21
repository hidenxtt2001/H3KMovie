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

        //form shadow
        private const int CS_DropShadow = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }
        //form shadow

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_tick(object sender, EventArgs e)
        {
            if (panel1.Left < pictureBox1.Left)
                pictureBox1.Left -= 10;
            else
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Start();
            }
        }

        private void Fom4_load(object sender, EventArgs e)
        {
            timer2.Start();
            pictureBox3.Enabled = false;
            timer4.Start();
            pictureBox1.Top = pictureBox1.Top - 30;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Right < panel2.Right)
            {
                pictureBox2.Left += 10;
            }
            else if (pictureBox2.Left >= panel2.Left)
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                pictureBox3.Enabled = true;
                panel5.Visible = false;
                panel4.Left -= 30;

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
