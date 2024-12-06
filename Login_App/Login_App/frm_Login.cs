using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login_App
{
    public partial class frm_Login : Form
    {
        public bool isBasic { get; set; }
        public frm_Login(bool isBasic)
        {
            InitializeComponent();
            this.isBasic = isBasic; // is the current login form the first form or not?
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
            // if there is a stored user, open its profile directly without login process:
            if (File.Exists(DataFile.currecntUserDataPath))
            {
                FileInfo testIfEmpty = new(DataFile.currecntUserDataPath);
                if (testIfEmpty.Length != 0)
                {
                    List<Dictionary<string, string>> currentUser = DataFile.readUsersData(DataFile.currecntUserDataPath);
                    frm_Main mainForm = new(currentUser[0]["First Name"], currentUser[0]["Last Name"], currentUser[0]["Email"], currentUser[0]["Password"], currentUser[0]["Phone NO"], true);
                    mainForm.fName = currentUser[0]["First Name"];
                    mainForm.lName = currentUser[0]["Last Name"];
                    mainForm.gender = currentUser[0]["Gender"];
                    mainForm.ShowDialog();
                }
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            #region Checking interred values
            if (string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_pass.Text))
            {
                frm_Msg msg = new("User name or Password is empty!");
                msg.ShowDialog();
            }
            else
            {
                List<Dictionary<string, string>> usersData = DataFile.readUsersData(DataFile.dataPath);
                bool isfound = false;
                foreach (var user in usersData)
                {
                    if (user["Email"] == txt_email.Text && user["Password"] == txt_pass.Text)
                    {   // if interred valuse matching with a created account
                        frm_Main mainForm = new(user["First Name"], user["Last Name"], user["Email"], user["Password"], user["Phone NO"], false);
                        mainForm.fName = user["First Name"];
                        mainForm.lName = user["Last Name"];
                        mainForm.gender = user["Gender"];
                        mainForm.Show();
                        isfound = true;
                        if (isBasic) // if true so it's can't be closed
                        {
                            this.Hide();
                        }
                        else this.Close();
                        break;
                    }
                }
                if (!isfound) // if interred values doesn't match with a created account
                {
                    frm_Msg msg = new("User name or Password is not correct!");
                    msg.ShowDialog();
                }
            }
            #endregion
        }
        private void lbl_register_Click(object sender, EventArgs e)
        {
            frm_Register regist = new();
            regist.Show();
            if (isBasic)
            {
                this.Hide();
            }
            else this.Close();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
