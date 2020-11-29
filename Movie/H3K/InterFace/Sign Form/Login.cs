using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace.Sign_Form
{
    public partial class Login : Form
    {

        #region Mouse Drag Panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public bool loginSubmit {get;set;}
        private ConnectData connect { get; set; }

        public Login(ConnectData connectdata)
        {
            InitializeComponent();
            password_input.PasswordChar = '*';
            password_sign_up.PasswordChar = '*';
            loginSubmit = false;
            EnableDoubleBuferring(this);
            connect = connectdata;
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

        private void Login_Load(object sender, EventArgs e)
        {            
        }

        #region Action Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sign_up.SendToBack();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sign_up.BringToFront();
        }




        #endregion

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            if (!checkSpecialCharacter(username_sign_up.Text)) // Check ký tự đặc biệt
            {

                new MessageWarning("Username cant contain Special Character!").ShowDialog();
                return;
            }
            else if (!checkValidEmail(email_sign_up.Text)) // Kiểm tra định dạng email
            {
                new MessageWarning("Email not valid!").ShowDialog();
                return;
            }

            // Kiểm tra tài khoản có tồn tại trong database hay không ?
            if (connect.Register(username_sign_up.Text, password_sign_up.Text,email_sign_up.Text)) 
            {
                new MessageWarning("Sign Up Success").ShowDialog();
                sign_up.SendToBack();
            }
            else
            {
                new MessageWarning("Username or Email already Exists").ShowDialog();
            }
        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            if(username_input.Text == string.Empty || password_input.Text == string.Empty)
            {
                new MessageWarning("Please enter your complete information !!").ShowDialog();
                return;
            }
            if(!checkSpecialCharacter(username_input.Text))
            {
                new MessageWarning("Username cant contain Special Character !!").ShowDialog();
                return;
            }
           
            if(connect.Login(username_input.Text, password_input.Text))
            {
                loginSubmit = true;
                this.Close();
            }
            else
            {
                new MessageWarning("Please check correct your login input !!").ShowDialog();
            }
        }

        #region Check Textbox
        private void username_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login_Button.PerformClick();
            }
        }
        private bool checkSpecialCharacter(string text)
        {
            return Regex.IsMatch(text, @"^[a-zA-Z0-9]*$");
        }

        private bool checkValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }

        #endregion
    }
}
