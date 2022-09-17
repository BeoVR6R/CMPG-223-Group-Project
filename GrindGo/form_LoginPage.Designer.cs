﻿namespace GrindGo
{
    partial class form_LoginPage
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
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txtBx_Email = new System.Windows.Forms.TextBox();
            this.txtBx_Password = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_DevLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(359, 38);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(96, 24);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome!";
            this.lbl_Welcome.Click += new System.EventHandler(this.lbl_Welcome_Click);
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(257, 112);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(76, 13);
            this.lbl_Email.TabIndex = 1;
            this.lbl_Email.Text = "Email Address:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(277, 156);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password:";
            // 
            // txtBx_Email
            // 
            this.txtBx_Email.Location = new System.Drawing.Point(398, 105);
            this.txtBx_Email.Name = "txtBx_Email";
            this.txtBx_Email.Size = new System.Drawing.Size(176, 20);
            this.txtBx_Email.TabIndex = 3;
            // 
            // txtBx_Password
            // 
            this.txtBx_Password.Location = new System.Drawing.Point(398, 149);
            this.txtBx_Password.Name = "txtBx_Password";
            this.txtBx_Password.Size = new System.Drawing.Size(176, 20);
            this.txtBx_Password.TabIndex = 4;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(280, 233);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(499, 233);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // btn_DevLogin
            // 
            this.btn_DevLogin.Location = new System.Drawing.Point(12, 415);
            this.btn_DevLogin.Name = "btn_DevLogin";
            this.btn_DevLogin.Size = new System.Drawing.Size(75, 23);
            this.btn_DevLogin.TabIndex = 7;
            this.btn_DevLogin.Text = "DEV LOGIN";
            this.btn_DevLogin.UseVisualStyleBackColor = true;
            this.btn_DevLogin.Click += new System.EventHandler(this.btn_DevLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GrindGo.Properties.Resources.GrindGo_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(341, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // form_LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_DevLogin);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.txtBx_Password);
            this.Controls.Add(this.txtBx_Email);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Welcome);
            this.Name = "form_LoginPage";
            this.Text = "GrindGo -  Login Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txtBx_Email;
        private System.Windows.Forms.TextBox txtBx_Password;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_DevLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

