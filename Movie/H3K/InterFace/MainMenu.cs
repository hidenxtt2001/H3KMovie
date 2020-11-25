using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            this.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(this, true, null);
        }

        #region  Action with Menu
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

        private void CollumnMain_Click(object sender, EventArgs e)
        {

            if (mainFocus == (Button)sender)
            {
                changeFocus(mainFocus, 1);
            }
            else if (mainFocus == null)
                changeFocus((Button)sender, 2);
            else changeFocus((Button)sender, 3);
        }
        private Button mainFocus { get; set; }
        private void changeFocus(Button main, int check)
        {
            if (check == 1 || check == 3)
            {
                this.mainFocus.ImageIndex = -1;
                this.mainFocus.BackColor = Color.FromArgb(25, 28, 31);
                this.mainFocus = null;
            }
            if (check == 2 || check == 3)
            {
                main.ImageIndex = 0;
                main.BackColor = Color.FromArgb(34, 43, 49);
                this.mainFocus = main;
            }
        }
        #endregion



    }
}
