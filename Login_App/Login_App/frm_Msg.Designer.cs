namespace Login_App
{
    partial class frm_Msg
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
            components = new System.ComponentModel.Container();
            lbl_msg = new Label();
            timer_msg = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbl_msg
            // 
            lbl_msg.Anchor = AnchorStyles.None;
            lbl_msg.AutoSize = true;
            lbl_msg.Location = new Point(144, 66);
            lbl_msg.Name = "lbl_msg";
            lbl_msg.Size = new Size(62, 17);
            lbl_msg.TabIndex = 0;
            lbl_msg.Text = "Message";
            // 
            // timer_msg
            // 
            timer_msg.Enabled = true;
            timer_msg.Interval = 2000;
            timer_msg.Tick += timer_msg_Tick;
            // 
            // frm_Msg
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 149);
            Controls.Add(lbl_msg);
            Font = new Font("Malgun Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Msg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Msg";
            Load += frm_lgn_msg_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_msg;
        private System.Windows.Forms.Timer timer_msg;
    }
}