namespace Login_App
{
    partial class frm_Main
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_fullName = new TextBox();
            txt_email = new TextBox();
            txt_pass = new TextBox();
            txt_phone = new TextBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            label3 = new Label();
            btn_sign_out = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(381, 108);
            label2.Name = "label2";
            label2.Size = new Size(68, 16);
            label2.TabIndex = 3;
            label2.Text = "Full Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(381, 174);
            label4.Name = "label4";
            label4.Size = new Size(95, 16);
            label4.TabIndex = 5;
            label4.Text = "Email Address";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(381, 238);
            label5.Name = "label5";
            label5.Size = new Size(67, 16);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(381, 300);
            label6.Name = "label6";
            label6.Size = new Size(97, 16);
            label6.TabIndex = 7;
            label6.Text = "Phone Number";
            // 
            // txt_fullName
            // 
            txt_fullName.Anchor = AnchorStyles.None;
            txt_fullName.Enabled = false;
            txt_fullName.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold);
            txt_fullName.ForeColor = Color.FromArgb(64, 64, 64);
            txt_fullName.ImeMode = ImeMode.NoControl;
            txt_fullName.Location = new Point(381, 127);
            txt_fullName.Name = "txt_fullName";
            txt_fullName.Size = new Size(246, 22);
            txt_fullName.TabIndex = 8;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.Enabled = false;
            txt_email.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold);
            txt_email.ForeColor = Color.FromArgb(64, 64, 64);
            txt_email.Location = new Point(381, 193);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(246, 22);
            txt_email.TabIndex = 10;
            // 
            // txt_pass
            // 
            txt_pass.Anchor = AnchorStyles.None;
            txt_pass.Enabled = false;
            txt_pass.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold);
            txt_pass.ForeColor = Color.FromArgb(64, 64, 64);
            txt_pass.Location = new Point(381, 257);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(246, 22);
            txt_pass.TabIndex = 11;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_phone
            // 
            txt_phone.Anchor = AnchorStyles.None;
            txt_phone.Enabled = false;
            txt_phone.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Bold);
            txt_phone.ForeColor = Color.FromArgb(64, 64, 64);
            txt_phone.Location = new Point(381, 319);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(246, 22);
            txt_phone.TabIndex = 12;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Malgun Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(421, 386);
            button1.Name = "button1";
            button1.Size = new Size(158, 35);
            button1.TabIndex = 13;
            button1.Text = "Update info";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(253, 253, 253);
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(226, 494);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(253, 253, 253);
            pictureBox3.BackgroundImage = Properties.Resources.face;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(0, 127);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(226, 140);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.Red;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Malgun Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(45, 311);
            button2.Name = "button2";
            button2.Size = new Size(137, 30);
            button2.TabIndex = 16;
            button2.Text = "Upload New Photo";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(253, 253, 253);
            label3.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(78, 40);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 19;
            label3.Text = "Profile";
            // 
            // btn_sign_out
            // 
            btn_sign_out.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_sign_out.BackColor = Color.Transparent;
            btn_sign_out.BackgroundImageLayout = ImageLayout.Zoom;
            btn_sign_out.Cursor = Cursors.Hand;
            btn_sign_out.FlatStyle = FlatStyle.Flat;
            btn_sign_out.ForeColor = Color.FromArgb(253, 253, 253);
            btn_sign_out.Location = new Point(24, 439);
            btn_sign_out.Name = "btn_sign_out";
            btn_sign_out.Size = new Size(27, 32);
            btn_sign_out.TabIndex = 20;
            btn_sign_out.UseVisualStyleBackColor = false;
            btn_sign_out.Click += btn_sign_out_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(253, 253, 253);
            label1.Font = new Font("Malgun Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 474);
            label1.Name = "label1";
            label1.Size = new Size(50, 13);
            label1.TabIndex = 21;
            label1.Text = "Sign out";
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(801, 494);
            Controls.Add(label1);
            Controls.Add(btn_sign_out);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(txt_phone);
            Controls.Add(txt_pass);
            Controls.Add(txt_email);
            Controls.Add(txt_fullName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Font = new Font("Malgun Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HelpButton = true;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(817, 533);
            Name = "frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            FormClosed += frm_Profile_FormClosed;
            Load += frm_Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_fullName;
        private TextBox txt_email;
        private TextBox txt_pass;
        private TextBox txt_phone;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button2;
        private Label label3;
        private Button btn_sign_out;
        private Label label1;
    }
}