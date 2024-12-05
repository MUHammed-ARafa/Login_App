namespace Login_App
{
    partial class frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_login = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_email = new TextBox();
            txt_pass = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lbl_register = new Label();
            btn_close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.None;
            btn_login.BackColor = Color.Crimson;
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Malgun Gothic", 15.25F, FontStyle.Regular, GraphicsUnit.Pixel, 0, true);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(222, 196);
            btn_login.MinimumSize = new Size(108, 29);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(108, 32);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.TextAlign = ContentAlignment.TopCenter;
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 23);
            label1.Name = "label1";
            label1.Size = new Size(69, 30);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(96, 124);
            label2.Name = "label2";
            label2.Size = new Size(42, 17);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(150, 121);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(180, 20);
            txt_email.TabIndex = 4;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(150, 161);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(180, 20);
            txt_pass.TabIndex = 5;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(72, 162);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.mug;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Location = new Point(447, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 362);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 326);
            label4.Name = "label4";
            label4.Size = new Size(158, 16);
            label4.TabIndex = 8;
            label4.Text = "Don't Have an Account?";
            // 
            // lbl_register
            // 
            lbl_register.AutoSize = true;
            lbl_register.BackColor = Color.Transparent;
            lbl_register.Cursor = Cursors.Hand;
            lbl_register.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_register.ForeColor = Color.Red;
            lbl_register.Location = new Point(184, 326);
            lbl_register.Name = "lbl_register";
            lbl_register.Size = new Size(53, 16);
            lbl_register.TabIndex = 9;
            lbl_register.Text = "SignUp";
            lbl_register.Click += lbl_register_Click;
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.None;
            btn_close.BackColor = Color.Transparent;
            btn_close.BackgroundImage = Properties.Resources.close;
            btn_close.BackgroundImageLayout = ImageLayout.Stretch;
            btn_close.Cursor = Cursors.Hand;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.ForeColor = Color.White;
            btn_close.Location = new Point(587, 2);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(26, 24);
            btn_close.TabIndex = 10;
            btn_close.UseVisualStyleBackColor = false;
            btn_close.Click += btn_close_Click;
            // 
            // frm_Login
            // 
            AcceptButton = btn_login;
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(616, 362);
            Controls.Add(btn_close);
            Controls.Add(lbl_register);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(txt_pass);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Font = new Font("Arial", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += frm_Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Label label1;
        private Label label2;
        private TextBox txt_email;
        private TextBox txt_pass;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private Label lbl_register;
        private Button btn_close;
    }
}