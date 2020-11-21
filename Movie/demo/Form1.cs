using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCategory_MouseHover(object sender, EventArgs e)
        {
            panelCategory.Visible = true;
            foreach (Button item in panelCategory.Controls)
            {
                if (item.Tag == "Category")
                {
                    item.Visible = true;
                }
                else
                    item.Visible = false;
            }
            
        }

        private void buttonNation_MouseHover(object sender, EventArgs e)
        {
            panelCategory.Visible = true;
            foreach (Button item in panelCategory.Controls)
            {
                if (item.Tag == "nation")
                {
                    item.Visible = true;
                }
                else
                    item.Visible = false;
            }

        }

        private void buttonMovieTh_MouseHover(object sender, EventArgs e)
        {
            panelCategory.Visible = true;
            foreach (Button item in panelCategory.Controls)
            {
                if (item.Tag == "Movie")
                {
                    item.Visible = true;
                }
                else
                    item.Visible = false;
            }

        }

        private void buttonTVseries_MouseHover(object sender, EventArgs e)
        {
            panelCategory.Visible = true;
            foreach (Button item in panelCategory.Controls)
            {
                if (item.Tag == "TV")
                {
                    item.Visible = true;
                }
                else
                    item.Visible = false;
            }

        }
    }
}
