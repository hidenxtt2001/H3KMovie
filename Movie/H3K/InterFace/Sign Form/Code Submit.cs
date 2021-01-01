using Nancy.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H3K.InterFace.Sign_Form
{
    public partial class Code_reset_from : Form
    {
        private string username { get; set; }
        public Code_reset_from(string username)
        {
            InitializeComponent();
            this.username = username;            
        }

        private void newpassword_forgot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void Reset_Password_Click(object sender, EventArgs e)
        {
            MessageWarning message = new MessageWarning("");
            if(new_password.Text.Length >= 6)
            {
                if (SubmitCode(code_reset.Text, new_password.Text))
                {
                    message.message = "Reset Pass Successful";
                    message.ShowDialog();
                    this.Close();
                }
                else
                {
                    message.message = "Your code invalid";
                    message.ShowDialog();
                }
            }
            else
            {
                new MessageWarning("Your password must longer than 6.").ShowDialog();
                return;
            }
        }

        private bool SubmitCode(string code,string newpass)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.hidenxtt.somee.com/reset-pass");
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentType = "application/json";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = new JavaScriptSerializer().Serialize(new
                {
                    username = username,
                    code = code,
                    new_password = newpass
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
    }
}
