using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Flurl.Http;
using System.Net;
using System.IO;
using FireSharp.Interfaces;
using System.Threading;
using HSCTSV.Model;
using HSCTSV;

namespace HSCTSV
{
    public partial class Login : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Login()
        {
            InitializeComponent();
            checkUpdate();
            txtUserName.Text = Properties.Settings.Default.UserName;
            txtPassword.Text = Properties.Settings.Default.Password;
        }
        public static HSUser userLogin;
        private async void btnLogin_Click(object sender, EventArgs e)
        {      
            HSUser userLogin = new HSUser();
            try
            {           
                var objReq = new Dictionary<string, string>()
                {
                    {"UserName",txtUserName.Text},
                    {"Password",txtPassword.Text }
                };
                Login.userLogin = await new HSCTSV.ConnectDB.UserDB().userLogin(objReq);
                Login.userLogin.UserName = txtUserName.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            if (Login.userLogin.RespCode == 0)
            {
                if (!Login.userLogin.MoreInfo.Contains("10"))
                {
                    MessageBox.Show("Chưa được cấp quyền sử dụng phần mềm!");
                    return;
                }
                if ( cbxSave.Checked == true)
                {
                    Properties.Settings.Default.UserName = txtUserName.Text;
                    Properties.Settings.Default.Password = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.UserName = null;
                    Properties.Settings.Default.Password = null;
                    Properties.Settings.Default.Save();
                }
                Home home = new Home();
                this.Hide();
                home.ShowDialog();
                //this.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(Login.userLogin.RespText);
                txtUserName.Focus();
            }
        }
       
        
        Update update;
        string version = "0.1.6";
        IFirebaseClient client = FirebaseConnect.Instance.client;
        public async void checkUpdate()
        {
            try
            {
                var response = await client.GetAsync("Update");
                    if (response == null) return;
                update = response.ResultAs<Update>();
                if (update.Version.CompareTo(version) > 0)
                {
                    lblUpdate.Text = update.Detail;
                }
                else update = null;
            }
            catch
            {
                MessageBox.Show("Kiểm tra kết nối internet !");
            }
        }
        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                double bytesIn = double.Parse((e.BytesReceived).ToString());
                double totalBytes = double.Parse((e.TotalBytesToReceive).ToString());
                double percentage = bytesIn / totalBytes * 100;
                lblUpdate.Text = "Downloaded " + ((float)e.BytesReceived / 1000000.0).ToString("0.00") + "MB of " + ((float)e.TotalBytesToReceive / 1000000.0).ToString("0.00") + "MB";
            }));
        }
        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                lblUpdate.Text = "Hoàn thành!";
                System.Diagnostics.Process.Start("C:/EMGLAB/HSCTSV.exe");
                Application.Exit();
            }));
        }
        private void lblUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (update == null) return;
            if (MessageBox.Show("Xác nhận cập nhật?","Cập nhật?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool folderExists = Directory.Exists(@"C:/EMGLAB");
                if (!folderExists)
                {
                    Directory.CreateDirectory(@"C:/EMGLAB");
                }
                Thread thread = new Thread(() =>
                  {
                      WebClient client1 = new WebClient();
                      client1.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                      client1.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                      client1.DownloadFileAsync(new Uri(update.Link), "C:/EMGLAB/HSCTSV.exe");
                  });
                thread.Start();
            }
        }        
    }
}
