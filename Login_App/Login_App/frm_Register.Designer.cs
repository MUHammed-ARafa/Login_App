namespace Login_App
{
    partial class frm_Register
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
            btn_clothe = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txt_box_FN = new TextBox();
            txt_box_LN = new TextBox();
            txt_box_email = new TextBox();
            txt_box_phone = new TextBox();
            btn_submit = new Button();
            txt_box_pass = new TextBox();
            label6 = new Label();
            checkBM = new CheckBox();
            checkBF = new CheckBox();
            lbl_gender = new Label();
            SuspendLayout();
            // 
            // btn_clothe
            // 
            btn_clothe.Anchor = AnchorStyles.None;
            btn_clothe.BackColor = Color.Transparent;
            btn_clothe.BackgroundImage = Properties.Resources.close;
            btn_clothe.BackgroundImageLayout = ImageLayout.Stretch;
            btn_clothe.Cursor = Cursors.Hand;
            btn_clothe.FlatStyle = FlatStyle.Flat;
            btn_clothe.ForeColor = Color.White;
            btn_clothe.Location = new Point(394, 3);
            btn_clothe.Name = "btn_clothe";
            btn_clothe.Size = new Size(26, 24);
            btn_clothe.TabIndex = 0;
            btn_clothe.UseVisualStyleBackColor = false;
            btn_clothe.Click += btn_clothe_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Malgun Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(159, 54);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 1;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Bold);
            label2.Location = new Point(57, 103);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 2;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic Semilight", 8.25F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(59, 149);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(59, 13);
            label3.TabIndex = 3;
            label3.Text = "First Name";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Malgun Gothic Semilight", 8.25F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(223, 149);
            label4.Name = "label4";
            label4.Size = new Size(59, 13);
            label4.TabIndex = 4;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Bold);
            label5.Location = new Point(57, 182);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 5;
            label5.Text = "Email Address";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Bold);
            label7.Location = new Point(57, 372);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 7;
            label7.Text = "Contact Number";
            // 
            // txt_box_FN
            // 
            txt_box_FN.Anchor = AnchorStyles.None;
            txt_box_FN.BackColor = Color.White;
            txt_box_FN.ForeColor = SystemColors.ActiveCaptionText;
            txt_box_FN.Location = new Point(61, 126);
            txt_box_FN.Name = "txt_box_FN";
            txt_box_FN.Size = new Size(144, 20);
            txt_box_FN.TabIndex = 9;
            // 
            // txt_box_LN
            // 
            txt_box_LN.Anchor = AnchorStyles.None;
            txt_box_LN.BackColor = Color.White;
            txt_box_LN.ForeColor = SystemColors.ActiveCaptionText;
            txt_box_LN.Location = new Point(223, 126);
            txt_box_LN.Name = "txt_box_LN";
            txt_box_LN.Size = new Size(144, 20);
            txt_box_LN.TabIndex = 10;
            // 
            // txt_box_email
            // 
            txt_box_email.Anchor = AnchorStyles.None;
            txt_box_email.BackColor = Color.White;
            txt_box_email.ForeColor = Color.Gray;
            txt_box_email.Location = new Point(61, 205);
            txt_box_email.Name = "txt_box_email";
            txt_box_email.Size = new Size(306, 20);
            txt_box_email.TabIndex = 11;
            txt_box_email.Text = "example@example.com";
            txt_box_email.Enter += txt_box_email_Enter;
            txt_box_email.Leave += txt_box_email_Leave;
            // 
            // txt_box_phone
            // 
            txt_box_phone.Anchor = AnchorStyles.None;
            txt_box_phone.BackColor = Color.White;
            txt_box_phone.ForeColor = SystemColors.ControlDarkDark;
            txt_box_phone.Location = new Point(61, 395);
            txt_box_phone.Name = "txt_box_phone";
            txt_box_phone.Size = new Size(306, 20);
            txt_box_phone.TabIndex = 12;
            txt_box_phone.Text = "(000) 000 000";
            txt_box_phone.Enter += txt_box_phone_Enter;
            txt_box_phone.Leave += txt_box_phone_Leave;
            // 
            // btn_submit
            // 
            btn_submit.Anchor = AnchorStyles.None;
            btn_submit.BackColor = Color.MediumBlue;
            btn_submit.FlatStyle = FlatStyle.Flat;
            btn_submit.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_submit.ForeColor = Color.Transparent;
            btn_submit.Location = new Point(164, 464);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(96, 29);
            btn_submit.TabIndex = 13;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = false;
            btn_submit.Click += btn_submit_Click;
            // 
            // txt_box_pass
            // 
            txt_box_pass.Anchor = AnchorStyles.None;
            txt_box_pass.Location = new Point(61, 279);
            txt_box_pass.Name = "txt_box_pass";
            txt_box_pass.Size = new Size(306, 20);
            txt_box_pass.TabIndex = 14;
            txt_box_pass.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(57, 256);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 15;
            label6.Text = "Password";
            // 
            // checkBM
            // 
            checkBM.AutoSize = true;
            checkBM.Location = new Point(170, 324);
            checkBM.Name = "checkBM";
            checkBM.Size = new Size(48, 18);
            checkBM.TabIndex = 16;
            checkBM.Text = "Male";
            checkBM.UseVisualStyleBackColor = true;
            // 
            // checkBF
            // 
            checkBF.AutoSize = true;
            checkBF.Location = new Point(268, 323);
            checkBF.Name = "checkBF";
            checkBF.Size = new Size(60, 18);
            checkBF.TabIndex = 17;
            checkBF.Text = "Female";
            checkBF.UseVisualStyleBackColor = true;
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.Font = new Font("Malgun Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_gender.Location = new Point(58, 323);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(60, 20);
            lbl_gender.TabIndex = 18;
            lbl_gender.Text = "Gender";
            // 
            // frm_Register
            // 
            AcceptButton = btn_submit;
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(424, 532);
            Controls.Add(lbl_gender);
            Controls.Add(checkBF);
            Controls.Add(checkBM);
            Controls.Add(label6);
            Controls.Add(txt_box_pass);
            Controls.Add(btn_submit);
            Controls.Add(txt_box_phone);
            Controls.Add(txt_box_email);
            Controls.Add(txt_box_LN);
            Controls.Add(txt_box_FN);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btn_clothe);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 8.25F);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_clothe;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txt_box_FN;
        private TextBox txt_box_LN;
        private TextBox txt_box_email;
        private TextBox txt_box_phone;
        private Button btn_submit;
        private TextBox txt_box_pass;
        private Label label6;
        private CheckBox checkBM;
        private CheckBox checkBF;
        private Label lbl_gender;
    }
}