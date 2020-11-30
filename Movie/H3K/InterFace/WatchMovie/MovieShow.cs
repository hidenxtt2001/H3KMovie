using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace.WatchMovie
{
    public partial class MovieShow : Form
    {
        [DllImport("KERNEL32.DLL", EntryPoint = "SetProcessWorkingSetSize", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetProcessWorkingSetSize(IntPtr pProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

        [DllImport("KERNEL32.DLL", EntryPoint = "GetCurrentProcess", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr GetCurrentProcess();

        
            
        private static string id { get; set; }
        public MovieShow(string link,string title)
        {
            InitializeComponent();
            id = Regex.Match(link, @"[-\w]{25,}").Value;
            this.Text = title;
        }

        private void MovieShow_Load(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<div style=\"position:fixed; top: 0; left: 0;width: 100%; height: 100%;\" > <iframe width=\"100%\" height=\"100%\" src=\"{0}\"></iframe> </div>" +
            "</body></html>";
            var url = "https://drive.google.com/file/d/" + id + "/preview";
            webBrowser1.DocumentText = string.Format(embed, url);
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void MovieShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            IntPtr pHandle = GetCurrentProcess();
            SetProcessWorkingSetSize(pHandle, -1, -1);
            webBrowser1.Dispose();
            webBrowser1 = null;
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            System.GC.Collect();
        }
    }
}
