using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_App
{
    public partial class frm_Msg : Form
    {
        public frm_Msg(string message)
        {
            InitializeComponent();
            lbl_msg.Text = message;
        }
        private void frm_lgn_msg_Load(object sender, EventArgs e)
        {
            //lbl_msg.Location = new Point((this.ClientSize.Width - lbl_msg.Width) / 2, 66 );
            lbl_msg.Left = (this.ClientSize.Width - lbl_msg.Width) / 2;
        }
        private void timer_msg_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
