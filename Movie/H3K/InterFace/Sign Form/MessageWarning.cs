using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace.Sign_Form
{
    public partial class MessageWarning : Form
    {
        private string _message;
        public string message { get { return _message; } set { this._message = value; label1.Text = value; } }
        public MessageWarning(string message)
        {
            InitializeComponent();
            this._message = message;
            label1.Text = this.message;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
