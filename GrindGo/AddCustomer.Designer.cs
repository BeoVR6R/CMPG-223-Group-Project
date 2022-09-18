namespace GrindGo
{
    partial class AddCustomer
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
            this.lbl_C_firstName = new System.Windows.Forms.Label();
            this.lbl_C_lastName = new System.Windows.Forms.Label();
            this.lbl_C_Address = new System.Windows.Forms.Label();
            this.lbl_C_emailAddress = new System.Windows.Forms.Label();
            this.lbl_C_Password = new System.Windows.Forms.Label();
            this.txtBx_firstName = new System.Windows.Forms.TextBox();
            this.txtBx_lastName = new System.Windows.Forms.TextBox();
            this.txtBx_Address = new System.Windows.Forms.TextBox();
            this.txtBx_emailAddress = new System.Windows.Forms.TextBox();
            this.txtBx_Password = new System.Windows.Forms.TextBox();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_C_firstName
            // 
            this.lbl_C_firstName.AutoSize = true;
            this.lbl_C_firstName.Location = new System.Drawing.Point(12, 21);
            this.lbl_C_firstName.Name = "lbl_C_firstName";
            this.lbl_C_firstName.Size = new System.Drawing.Size(60, 13);
            this.lbl_C_firstName.TabIndex = 0;
            this.lbl_C_firstName.Text = "First Name:";
            // 
            // lbl_C_lastName
            // 
            this.lbl_C_lastName.AutoSize = true;
            this.lbl_C_lastName.Location = new System.Drawing.Point(12, 51);
            this.lbl_C_lastName.Name = "lbl_C_lastName";
            this.lbl_C_lastName.Size = new System.Drawing.Size(61, 13);
            this.lbl_C_lastName.TabIndex = 1;
            this.lbl_C_lastName.Text = "Last Name:";
            // 
            // lbl_C_Address
            // 
            this.lbl_C_Address.AutoSize = true;
            this.lbl_C_Address.Location = new System.Drawing.Point(12, 77);
            this.lbl_C_Address.Name = "lbl_C_Address";
            this.lbl_C_Address.Size = new System.Drawing.Size(103, 13);
            this.lbl_C_Address.TabIndex = 2;
            this.lbl_C_Address.Text = "Residential Address:";
            // 
            // lbl_C_emailAddress
            // 
            this.lbl_C_emailAddress.AutoSize = true;
            this.lbl_C_emailAddress.Location = new System.Drawing.Point(12, 103);
            this.lbl_C_emailAddress.Name = "lbl_C_emailAddress";
            this.lbl_C_emailAddress.Size = new System.Drawing.Size(76, 13);
            this.lbl_C_emailAddress.TabIndex = 3;
            this.lbl_C_emailAddress.Text = "Email Address:";
            // 
            // lbl_C_Password
            // 
            this.lbl_C_Password.AutoSize = true;
            this.lbl_C_Password.Location = new System.Drawing.Point(12, 129);
            this.lbl_C_Password.Name = "lbl_C_Password";
            this.lbl_C_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_C_Password.TabIndex = 4;
            this.lbl_C_Password.Text = "Password:";
            // 
            // txtBx_firstName
            // 
            this.txtBx_firstName.Location = new System.Drawing.Point(196, 18);
            this.txtBx_firstName.Name = "txtBx_firstName";
            this.txtBx_firstName.Size = new System.Drawing.Size(179, 20);
            this.txtBx_firstName.TabIndex = 5;
            // 
            // txtBx_lastName
            // 
            this.txtBx_lastName.Location = new System.Drawing.Point(196, 44);
            this.txtBx_lastName.Name = "txtBx_lastName";
            this.txtBx_lastName.Size = new System.Drawing.Size(179, 20);
            this.txtBx_lastName.TabIndex = 6;
            // 
            // txtBx_Address
            // 
            this.txtBx_Address.Location = new System.Drawing.Point(196, 70);
            this.txtBx_Address.Name = "txtBx_Address";
            this.txtBx_Address.Size = new System.Drawing.Size(179, 20);
            this.txtBx_Address.TabIndex = 7;
            // 
            // txtBx_emailAddress
            // 
            this.txtBx_emailAddress.Location = new System.Drawing.Point(196, 96);
            this.txtBx_emailAddress.Name = "txtBx_emailAddress";
            this.txtBx_emailAddress.Size = new System.Drawing.Size(179, 20);
            this.txtBx_emailAddress.TabIndex = 8;
            // 
            // txtBx_Password
            // 
            this.txtBx_Password.Location = new System.Drawing.Point(196, 126);
            this.txtBx_Password.Name = "txtBx_Password";
            this.txtBx_Password.Size = new System.Drawing.Size(179, 20);
            this.txtBx_Password.TabIndex = 9;
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Location = new System.Drawing.Point(265, 203);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(110, 60);
            this.btn_addCustomer.TabIndex = 10;
            this.btn_addCustomer.Text = "ADD";
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 275);
            this.Controls.Add(this.btn_addCustomer);
            this.Controls.Add(this.txtBx_Password);
            this.Controls.Add(this.txtBx_emailAddress);
            this.Controls.Add(this.txtBx_Address);
            this.Controls.Add(this.txtBx_lastName);
            this.Controls.Add(this.txtBx_firstName);
            this.Controls.Add(this.lbl_C_Password);
            this.Controls.Add(this.lbl_C_emailAddress);
            this.Controls.Add(this.lbl_C_Address);
            this.Controls.Add(this.lbl_C_lastName);
            this.Controls.Add(this.lbl_C_firstName);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_C_firstName;
        private System.Windows.Forms.Label lbl_C_lastName;
        private System.Windows.Forms.Label lbl_C_Address;
        private System.Windows.Forms.Label lbl_C_emailAddress;
        private System.Windows.Forms.Label lbl_C_Password;
        private System.Windows.Forms.TextBox txtBx_firstName;
        private System.Windows.Forms.TextBox txtBx_lastName;
        private System.Windows.Forms.TextBox txtBx_Address;
        private System.Windows.Forms.TextBox txtBx_emailAddress;
        private System.Windows.Forms.TextBox txtBx_Password;
        private System.Windows.Forms.Button btn_addCustomer;
    }
}