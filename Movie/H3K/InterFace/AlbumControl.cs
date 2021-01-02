using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace H3K
{

    public partial class AlbumControl : UserControl
    {
        public AlbumControl()
        {
            InitializeComponent();
        }
        public static void EnableDoubleBuferring(Control control)
        {
            foreach (Control item in control.Controls)
            {
                EnableDoubleBuferring(item);
            }
            var property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            property.SetValue(control, true, null);
        }
        private void Album_Control_Load(object sender, EventArgs e)
        {
            this.hover_icon.BackColor = Color.FromArgb(125, Color.FromArgb(99, 99, 99));
            EnableDoubleBuferring(this);
            
        }
        private void Album_Control_MouseEnter(object sender, EventArgs e)
        {
            this.hover_icon.Visible = true;
        }
        private void hover_icon_MouseLeave(object sender, EventArgs e)
        {
            this.hover_icon.Visible = false;
        }
        public delegate void EventClickAlbumControl(object sender, EventArgs e);
        public event EventClickAlbumControl ClickAlbumControl;

       
        private void AlbumControl_Click(object sender, EventArgs e)
        {
            if (this.ClickAlbumControl != null)
                this.ClickAlbumControl(this, e);
        }
    }
}
