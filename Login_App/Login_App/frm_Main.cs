using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;

namespace Login_App
{
    public partial class frm_Main : Form
    {
        bool isClosed = true;
        public string fName { get; set; }
        public string lName { get; set; }
        public string gender { get; set; }
        bool isdirectly = false;
        public frm_Main(string fName, string lName, string email, string pass, string phone, bool isdirectly)
        {
            InitializeComponent();
            #region info that shown in main page
            txt_fullName.Text = fName + " " + lName;
            txt_email.Text = email;
            txt_pass.Text = pass;
            txt_phone.Text = phone;
            #endregion
            this.isdirectly = isdirectly; // define if main form opened directly after runnning app or opened after login process, using when sign out from main form.
        }
        private void frm_Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(DataFile.currecntUserDataPath))
            {
                File.Delete(DataFile.currecntUserDataPath);
            }
            // record the current user to inter it directly in case of close main without sign out:
            DataFile.writeData(fName, lName, txt_email.Text, txt_pass.Text, gender, txt_phone.Text, DataFile.currecntUserDataPath);
        }
        private void btn_sign_out_Click(object sender, EventArgs e)
        {
            File.Delete(DataFile.currecntUserDataPath);
            if (!isdirectly)
            {
                frm_Login loginForm = new(false);
                loginForm.Show();
            }
            this.Hide();
        }
        private void frm_Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}