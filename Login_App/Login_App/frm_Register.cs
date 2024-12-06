using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Login_App
{
    public partial class frm_Register : Form
    {
        public frm_Register()
        {
            InitializeComponent();
        }
        private void txt_box_email_Enter(object sender, EventArgs e)
        {
            if (txt_box_email.Text == "example@example.com")
            {
                txt_box_email.Text = "";
                txt_box_email.ForeColor = Color.Black;
            }
        }
        private void txt_box_email_Leave(object sender, EventArgs e)
        {
            if (txt_box_email.Text == "")
            {
                txt_box_email.Text = "example@example.com";
                txt_box_email.ForeColor = Color.Gray;
            }
        }
        private void txt_box_phone_Enter(object sender, EventArgs e)
        {
            if (txt_box_phone.Text == "(000) 000 000")
            {
                txt_box_phone.Text = "";
                txt_box_phone.ForeColor = Color.Black;
            }
        }
        private void txt_box_phone_Leave(object sender, EventArgs e)
        {
            if (txt_box_phone.Text == "")
            {
                txt_box_phone.Text = "00 000 000 000";
                txt_box_phone.ForeColor = Color.Gray;
            }
        }
        private void btn_submit_Click(object sender, EventArgs e)
        {
            #region checking interred data if empty or invalid
            string? gender;
            if (!checkBM.Checked && !checkBF.Checked) gender = "unChecked";
            else if (checkBM.Checked && checkBF.Checked) gender = "allChecked";
            else if (checkBM.Checked) gender = "Male";
            else gender = "Female";
            if (string.IsNullOrEmpty(txt_box_FN.Text) || string.IsNullOrEmpty(txt_box_LN.Text) || string.IsNullOrEmpty(txt_box_email.Text) || string.IsNullOrEmpty(txt_box_pass.Text) || string.IsNullOrEmpty(txt_box_phone.Text))
            {
                frm_Msg msg = new("empty values not allowed!");
                msg.ShowDialog();
            }
            else if (txt_box_phone.Text.Length != 11 || !long.TryParse(txt_box_phone.Text, out _))
            {
                frm_Msg msg = new("Invalid Number!");
                msg.ShowDialog();
            }
            else if (gender == "unChecked")
            {
                frm_Msg msg = new("choose a Gender!");
                msg.ShowDialog();
            }
            else if (gender == "allChecked")
            {
                frm_Msg msg = new("choose only Gender!");
                msg.ShowDialog();
            }
            #endregion
            #region checking if email is exist or not
            else
            {
                bool isExist = false;
                List<Dictionary<string, string>> usersData = DataFile.readUsersData(DataFile.dataPath);
                foreach (var user in usersData)
                { //checking existance of the email
                    if (user["Email"] == txt_box_email.Text)
                    {
                        frm_Msg msg = new("This Email is already exist!");
                        msg.ShowDialog();
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    DataFile.writeData(txt_box_FN.Text, txt_box_LN.Text, txt_box_email.Text, txt_box_pass.Text, gender, txt_box_phone.Text, DataFile.dataPath);
                    frm_Login loginForm = new(false);
                    frm_Msg msg = new("Account created ...");
                    msg.ShowDialog();
                    loginForm.Show();
                    this.Close();
                }
            }
            #endregion
        }
        private void btn_clothe_Click(object sender, EventArgs e)
        {
            frm_Login loginForm = new(false);
            loginForm.Show();
            this.Close();
        }
    }
}