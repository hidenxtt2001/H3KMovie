using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace.Movie_Mange
{
    public partial class Wait_Form : Form
    {
        private Action action { get; set; }
        public Wait_Form(Action worker)
        {
            InitializeComponent();
            if (worker == null) throw new ArgumentException();
            action = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(action).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void Wait_Form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Left += 2;
            if (panel2.Left > 600)
            {
                panel2.Left = -100;
            }
        }
    }
}
