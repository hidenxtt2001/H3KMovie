using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace H3K.InterFace.Movie_Mange
{
    class SmoothScrollPanel: FlowLayoutPanel
    {
        public SmoothScrollPanel()
        {
            var property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            property.SetValue(this, true, null);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            this.Invalidate();
            base.OnMouseWheel(e);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_CLIPCHILDREN
                return cp;
            }
        }
    }
}
