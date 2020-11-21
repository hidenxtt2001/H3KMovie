﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (MenuPanel.ClientRectangle.Contains(MenuPanel.PointToClient(Control.MousePosition)) || buttonMenu.ClientRectangle.Contains(MenuPanel.PointToClient(Control.MousePosition)))
            {
                return;
            }
            else
            {
                base.OnMouseLeave(e);
                MenuPanel.Visible = false;
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            MenuPanel.Visible = true;
        }
    }
}
