using Nancy.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
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
            timer.AutoReset = true;
            timer.SynchronizingObject = this;
            timer.Elapsed += timer_Elapsed;
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
            sign_in.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sign_up.BringToFront();
        }

        private void Forgot_Pass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forgot_password.BringToFront();
        }


        #endregion

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            if (!checkSpecialCharacter(username_sign_up.Text)) // Check ký tự đặc biệt
            {

                new MessageWarning("Username cant contain Special Character!").ShowDialog();
                return;
            }
            else if (password_sign_up.Text.Length <= 6)
            {
                new MessageWarning("Your password must longer than 6.").ShowDialog();
                return;
            }
            else if (!checkValidEmail(email_sign_up.Text)) // Kiểm tra định dạng email
            {
                new MessageWarning("Email not valid!").ShowDialog();
                return;
            }
            


            // Kiểm tra tài khoản có tồn tại trong database hay không ?
            if (password_sign_up.Text.Length >= 6 && connect.Register(username_sign_up.Text, password_sign_up.Text,email_sign_up.Text)) 
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
            string username = username_input.Text;
            string pass = password_input.Text;
            if (connect.Login(username, pass))
            {
                FormLoadingAction();
                
            }
            else
            {
                new MessageWarning("Please check correct your login input !!").ShowDialog();
            }
        }
        System.Timers.Timer timer = new System.Timers.Timer(1);
        private void FormLoadingAction()
        {
            
            panel1.Visible = false;
            loginSubmit = true;
            timer.Start();
            
        }
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            logo.Width += 6;

            if (logo.Width > 748)
            {
                timer.Stop();
                Thread.Sleep(2000);
                this.Close();
            }
                
        }
        private void Reset_Password_Click(object sender, EventArgs e)
        {
            MessageWarning message = new MessageWarning("");
            if (RequestCode(user_forgot.Text, email_forgot.Text))
            {
                message.message = "The Code has been sent to your email!";
                Code_reset_from from = new Code_reset_from(user_forgot.Text);
                from.ShowDialog();
                sign_in.BringToFront();
            }
            else
            {
                message.message = "Username or Email not correct!";
                message.ShowDialog();
            }

        }
        private bool RequestCode(string username,string email)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.hidenxtt.somee.com/request-code-reset");
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    username = username,
                    email = email
                });
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
            try
            {
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    return Convert.ToBoolean(streamReader.ReadToEnd());
                }
            }
            catch (WebException ex)
            {
                return Convert.ToBoolean(new StreamReader(ex.Response.GetResponseStream()).ReadToEnd());
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
