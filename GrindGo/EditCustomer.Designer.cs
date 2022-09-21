namespace GrindGo
{
    partial class EditCustomer
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
            this.txtBx_C__edit_firstName = new System.Windows.Forms.TextBox();
            this.txtBx_C__edit_lastName = new System.Windows.Forms.TextBox();
            this.txtBx_C__edit_address = new System.Windows.Forms.TextBox();
            this.txtBx_C__edit_emailAddress = new System.Windows.Forms.TextBox();
            this.txtBx_C__edit_password = new System.Windows.Forms.TextBox();
            this.lbl_C_firstName = new System.Windows.Forms.Label();
            this.lbl_C_lastName = new System.Windows.Forms.Label();
            this.lbl_C_Address = new System.Windows.Forms.Label();
            this.lbl_C_emailAddress = new System.Windows.Forms.Label();
            this.lbl_C_Password = new System.Windows.Forms.Label();
            this.btn_updateCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBx_C__edit_firstName
            // 
            this.txtBx_C__edit_firstName.Location = new System.Drawing.Point(197, 12);
            this.txtBx_C__edit_firstName.Name = "txtBx_C__edit_firstName";
            this.txtBx_C__edit_firstName.Size = new System.Drawing.Size(179, 20);
            this.txtBx_C__edit_firstName.TabIndex = 6;
            // 
            // txtBx_C__edit_lastName
            // 
            this.txtBx_C__edit_lastName.Location = new System.Drawing.Point(197, 38);
            this.txtBx_C__edit_lastName.Name = "txtBx_C__edit_lastName";
            this.txtBx_C__edit_lastName.Size = new System.Drawing.Size(179, 20);
            this.txtBx_C__edit_lastName.TabIndex = 7;
            // 
            // txtBx_C__edit_address
            // 
            this.txtBx_C__edit_address.Location = new System.Drawing.Point(197, 64);
            this.txtBx_C__edit_address.Name = "txtBx_C__edit_address";
            this.txtBx_C__edit_address.Size = new System.Drawing.Size(179, 20);
            this.txtBx_C__edit_address.TabIndex = 8;
            // 
            // txtBx_C__edit_emailAddress
            // 
            this.txtBx_C__edit_emailAddress.Location = new System.Drawing.Point(197, 90);
            this.txtBx_C__edit_emailAddress.Name = "txtBx_C__edit_emailAddress";
            this.txtBx_C__edit_emailAddress.Size = new System.Drawing.Size(179, 20);
            this.txtBx_C__edit_emailAddress.TabIndex = 9;
            // 
            // txtBx_C__edit_password
            // 
            this.txtBx_C__edit_password.Location = new System.Drawing.Point(197, 116);
            this.txtBx_C__edit_password.Name = "txtBx_C__edit_password";
            this.txtBx_C__edit_password.Size = new System.Drawing.Size(179, 20);
            this.txtBx_C__edit_password.TabIndex = 10;
            // 
            // lbl_C_firstName
            // 
            this.lbl_C_firstName.AutoSize = true;
            this.lbl_C_firstName.Location = new System.Drawing.Point(12, 19);
            this.lbl_C_firstName.Name = "lbl_C_firstName";
            this.lbl_C_firstName.Size = new System.Drawing.Size(60, 13);
            this.lbl_C_firstName.TabIndex = 11;
            this.lbl_C_firstName.Text = "First Name:";
            // 
            // lbl_C_lastName
            // 
            this.lbl_C_lastName.AutoSize = true;
            this.lbl_C_lastName.Location = new System.Drawing.Point(12, 45);
            this.lbl_C_lastName.Name = "lbl_C_lastName";
            this.lbl_C_lastName.Size = new System.Drawing.Size(61, 13);
            this.lbl_C_lastName.TabIndex = 12;
            this.lbl_C_lastName.Text = "Last Name:";
            // 
            // lbl_C_Address
            // 
            this.lbl_C_Address.AutoSize = true;
            this.lbl_C_Address.Location = new System.Drawing.Point(11, 71);
            this.lbl_C_Address.Name = "lbl_C_Address";
            this.lbl_C_Address.Size = new System.Drawing.Size(103, 13);
            this.lbl_C_Address.TabIndex = 13;
            this.lbl_C_Address.Text = "Residential Address:";
            // 
            // lbl_C_emailAddress
            // 
            this.lbl_C_emailAddress.AutoSize = true;
            this.lbl_C_emailAddress.Location = new System.Drawing.Point(11, 97);
            this.lbl_C_emailAddress.Name = "lbl_C_emailAddress";
            this.lbl_C_emailAddress.Size = new System.Drawing.Size(76, 13);
            this.lbl_C_emailAddress.TabIndex = 14;
            this.lbl_C_emailAddress.Text = "Email Address:";
            // 
            // lbl_C_Password
            // 
            this.lbl_C_Password.AutoSize = true;
            this.lbl_C_Password.Location = new System.Drawing.Point(11, 123);
            this.lbl_C_Password.Name = "lbl_C_Password";
            this.lbl_C_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_C_Password.TabIndex = 15;
            this.lbl_C_Password.Text = "Password:";
            // 
            // btn_updateCustomer
            // 
            this.btn_updateCustomer.Location = new System.Drawing.Point(266, 203);
            this.btn_updateCustomer.Name = "btn_updateCustomer";
            this.btn_updateCustomer.Size = new System.Drawing.Size(110, 60);
            this.btn_updateCustomer.TabIndex = 16;
            this.btn_updateCustomer.Text = "UPDATE";
            this.btn_updateCustomer.UseVisualStyleBackColor = true;
            this.btn_updateCustomer.Click += new System.EventHandler(this.btn_updateCustomer_Click);
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 275);
            this.Controls.Add(this.btn_updateCustomer);
            this.Controls.Add(this.lbl_C_Password);
            this.Controls.Add(this.lbl_C_emailAddress);
            this.Controls.Add(this.lbl_C_Address);
            this.Controls.Add(this.lbl_C_lastName);
            this.Controls.Add(this.lbl_C_firstName);
            this.Controls.Add(this.txtBx_C__edit_password);
            this.Controls.Add(this.txtBx_C__edit_emailAddress);
            this.Controls.Add(this.txtBx_C__edit_address);
            this.Controls.Add(this.txtBx_C__edit_lastName);
            this.Controls.Add(this.txtBx_C__edit_firstName);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBx_C__edit_firstName;
        private System.Windows.Forms.TextBox txtBx_C__edit_lastName;
        private System.Windows.Forms.TextBox txtBx_C__edit_address;
        private System.Windows.Forms.TextBox txtBx_C__edit_emailAddress;
        private System.Windows.Forms.TextBox txtBx_C__edit_password;
        private System.Windows.Forms.Label lbl_C_firstName;
        private System.Windows.Forms.Label lbl_C_lastName;
        private System.Windows.Forms.Label lbl_C_Address;
        private System.Windows.Forms.Label lbl_C_emailAddress;
        private System.Windows.Forms.Label lbl_C_Password;
        private System.Windows.Forms.Button btn_updateCustomer;
    }
}