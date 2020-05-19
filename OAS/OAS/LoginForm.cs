using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DataBaseLayer;
using BusinessLayer;
using System.Speech.Synthesis;
using Telerik.WinControls.UI;
namespace OAS
{
    public partial class LoginForm : Telerik.WinControls.UI.RadForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public void Speech(string Message)
        {
            SpeechSynthesizer Sapi = new SpeechSynthesizer();
            Sapi.SpeakAsync(Message);
        }
        ManageStaff MgtStaff = new ManageStaff();

        private void radButton1_Click(object sender, EventArgs e)
        {
            Validate();
            if (cnt == 0)
            {
                DataTable dt = new DataTable();
                dt = MgtStaff.LoginProcess(txtUser.Text, txtPass.Text);
                if (dt.Rows.Count > 0)
                {
                    MDIForm MDI = new MDIForm();
                    MDI.lblUser.Text = "Welcome, " + dt.Rows[0][0].ToString();
                    Speech("Welcome, to our Office Automation System Software");
                    txtUser.Text = "";
                    txtPass.Text = "";
                    MDI.ShowDialog();
                }
                else
                {
                    Speech("Wrong UserName or Password");
                    MessageBox.Show("Wrong UserName or Password");
                }
            }
        }
        int cnt = 0;
        public void isEmpty(RadTextBox TextBox, RadLabel lbl)
        {
            if (TextBox.Text == "")
            {
                cnt++;
                lbl.Text = "*Required";
            }
            else
            {
                lbl.Text = "";
            }
        }

        public void Validation()
        {
            cnt = 0;
            isEmpty(txtUser, lblErrorUserName);
            isEmpty(txtPass, lblErrorPasswd);
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
