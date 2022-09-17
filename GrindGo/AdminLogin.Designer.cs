namespace GrindGo
{
    partial class AdminLogin
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
            this.lbl_adminPassword = new System.Windows.Forms.Label();
            this.txtBx_adminPassword = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_adminLogin = new System.Windows.Forms.Button();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_adminPassword
            // 
            this.lbl_adminPassword.AutoSize = true;
            this.lbl_adminPassword.Location = new System.Drawing.Point(148, 9);
            this.lbl_adminPassword.Name = "lbl_adminPassword";
            this.lbl_adminPassword.Size = new System.Drawing.Size(119, 13);
            this.lbl_adminPassword.TabIndex = 0;
            this.lbl_adminPassword.Text = "Enter Master Password:";
            // 
            // txtBx_adminPassword
            // 
            this.txtBx_adminPassword.Location = new System.Drawing.Point(151, 25);
            this.txtBx_adminPassword.Name = "txtBx_adminPassword";
            this.txtBx_adminPassword.Size = new System.Drawing.Size(116, 20);
            this.txtBx_adminPassword.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(117, 91);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_adminLogin
            // 
            this.btn_adminLogin.Location = new System.Drawing.Point(229, 91);
            this.btn_adminLogin.Name = "btn_adminLogin";
            this.btn_adminLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_adminLogin.TabIndex = 3;
            this.btn_adminLogin.Text = "LOGIN";
            this.btn_adminLogin.UseVisualStyleBackColor = true;
            this.btn_adminLogin.Click += new System.EventHandler(this.btn_adminLogin_Click);
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Location = new System.Drawing.Point(192, 62);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(0, 13);
            this.lbl_Message.TabIndex = 4;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(433, 126);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.btn_adminLogin);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txtBx_adminPassword);
            this.Controls.Add(this.lbl_adminPassword);
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_adminPassword;
        private System.Windows.Forms.TextBox txtBx_adminPassword;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_adminLogin;
        private System.Windows.Forms.Label lbl_Message;
    }
}