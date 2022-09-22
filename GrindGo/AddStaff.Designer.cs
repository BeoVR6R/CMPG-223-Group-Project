namespace GrindGo
{
    partial class AddStaff
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
            this.btn_add_c_return = new System.Windows.Forms.Button();
            this.btn_addStaff = new System.Windows.Forms.Button();
            this.lbl_S_staff_ID = new System.Windows.Forms.Label();
            this.lbl_Staff_firstName = new System.Windows.Forms.Label();
            this.lbl_Staff_lastName = new System.Windows.Forms.Label();
            this.lbl_Staff_IDnum = new System.Windows.Forms.Label();
            this.lbl_Staff_dob = new System.Windows.Forms.Label();
            this.lbl_Staff_residentAddress = new System.Windows.Forms.Label();
            this.lbl_Staff_username = new System.Windows.Forms.Label();
            this.lbl_Staff_password = new System.Windows.Forms.Label();
            this.lbl_Staff_confirmPassword = new System.Windows.Forms.Label();
            this.txtBx_S_staffID = new System.Windows.Forms.TextBox();
            this.txtBx_S_stafffirstName = new System.Windows.Forms.TextBox();
            this.txtBx_S_stafflastName = new System.Windows.Forms.TextBox();
            this.txtBx_S_staff_IDNum = new System.Windows.Forms.TextBox();
            this.txtBx_S_staff_residentAddress = new System.Windows.Forms.TextBox();
            this.txtBx_S_staff_username = new System.Windows.Forms.TextBox();
            this.txtBx_S_staff_password = new System.Windows.Forms.TextBox();
            this.txtBx_S_staff_confirmPassword = new System.Windows.Forms.TextBox();
            this.dateTimePicker_staff_add = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_add_c_return
            // 
            this.btn_add_c_return.Location = new System.Drawing.Point(12, 265);
            this.btn_add_c_return.Name = "btn_add_c_return";
            this.btn_add_c_return.Size = new System.Drawing.Size(110, 60);
            this.btn_add_c_return.TabIndex = 14;
            this.btn_add_c_return.Text = "RETURN";
            this.btn_add_c_return.UseVisualStyleBackColor = true;
            this.btn_add_c_return.Click += new System.EventHandler(this.btn_add_c_return_Click);
            // 
            // btn_addStaff
            // 
            this.btn_addStaff.Location = new System.Drawing.Point(266, 265);
            this.btn_addStaff.Name = "btn_addStaff";
            this.btn_addStaff.Size = new System.Drawing.Size(110, 60);
            this.btn_addStaff.TabIndex = 15;
            this.btn_addStaff.Text = "ADD";
            this.btn_addStaff.UseVisualStyleBackColor = true;
            this.btn_addStaff.Click += new System.EventHandler(this.btn_addStaff_Click);
            // 
            // lbl_S_staff_ID
            // 
            this.lbl_S_staff_ID.AutoSize = true;
            this.lbl_S_staff_ID.Location = new System.Drawing.Point(9, 19);
            this.lbl_S_staff_ID.Name = "lbl_S_staff_ID";
            this.lbl_S_staff_ID.Size = new System.Drawing.Size(49, 13);
            this.lbl_S_staff_ID.TabIndex = 16;
            this.lbl_S_staff_ID.Text = "Staff ID: ";
            // 
            // lbl_Staff_firstName
            // 
            this.lbl_Staff_firstName.AutoSize = true;
            this.lbl_Staff_firstName.Location = new System.Drawing.Point(9, 45);
            this.lbl_Staff_firstName.Name = "lbl_Staff_firstName";
            this.lbl_Staff_firstName.Size = new System.Drawing.Size(60, 13);
            this.lbl_Staff_firstName.TabIndex = 17;
            this.lbl_Staff_firstName.Text = "First Name:";
            // 
            // lbl_Staff_lastName
            // 
            this.lbl_Staff_lastName.AutoSize = true;
            this.lbl_Staff_lastName.Location = new System.Drawing.Point(9, 71);
            this.lbl_Staff_lastName.Name = "lbl_Staff_lastName";
            this.lbl_Staff_lastName.Size = new System.Drawing.Size(61, 13);
            this.lbl_Staff_lastName.TabIndex = 18;
            this.lbl_Staff_lastName.Text = "Last Name:";
            // 
            // lbl_Staff_IDnum
            // 
            this.lbl_Staff_IDnum.AutoSize = true;
            this.lbl_Staff_IDnum.Location = new System.Drawing.Point(9, 97);
            this.lbl_Staff_IDnum.Name = "lbl_Staff_IDnum";
            this.lbl_Staff_IDnum.Size = new System.Drawing.Size(110, 13);
            this.lbl_Staff_IDnum.TabIndex = 19;
            this.lbl_Staff_IDnum.Text = "Identification Number:";
            // 
            // lbl_Staff_dob
            // 
            this.lbl_Staff_dob.AutoSize = true;
            this.lbl_Staff_dob.Location = new System.Drawing.Point(9, 123);
            this.lbl_Staff_dob.Name = "lbl_Staff_dob";
            this.lbl_Staff_dob.Size = new System.Drawing.Size(69, 13);
            this.lbl_Staff_dob.TabIndex = 20;
            this.lbl_Staff_dob.Text = "Date of Birth:";
            // 
            // lbl_Staff_residentAddress
            // 
            this.lbl_Staff_residentAddress.AutoSize = true;
            this.lbl_Staff_residentAddress.Location = new System.Drawing.Point(9, 149);
            this.lbl_Staff_residentAddress.Name = "lbl_Staff_residentAddress";
            this.lbl_Staff_residentAddress.Size = new System.Drawing.Size(103, 13);
            this.lbl_Staff_residentAddress.TabIndex = 21;
            this.lbl_Staff_residentAddress.Text = "Residential Address:";
            // 
            // lbl_Staff_username
            // 
            this.lbl_Staff_username.AutoSize = true;
            this.lbl_Staff_username.Location = new System.Drawing.Point(9, 175);
            this.lbl_Staff_username.Name = "lbl_Staff_username";
            this.lbl_Staff_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_Staff_username.TabIndex = 22;
            this.lbl_Staff_username.Text = "Username:";
            // 
            // lbl_Staff_password
            // 
            this.lbl_Staff_password.AutoSize = true;
            this.lbl_Staff_password.Location = new System.Drawing.Point(9, 201);
            this.lbl_Staff_password.Name = "lbl_Staff_password";
            this.lbl_Staff_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Staff_password.TabIndex = 23;
            this.lbl_Staff_password.Text = "Password:";
            // 
            // lbl_Staff_confirmPassword
            // 
            this.lbl_Staff_confirmPassword.AutoSize = true;
            this.lbl_Staff_confirmPassword.Location = new System.Drawing.Point(9, 227);
            this.lbl_Staff_confirmPassword.Name = "lbl_Staff_confirmPassword";
            this.lbl_Staff_confirmPassword.Size = new System.Drawing.Size(94, 13);
            this.lbl_Staff_confirmPassword.TabIndex = 24;
            this.lbl_Staff_confirmPassword.Text = "Confirm Password:";
            // 
            // txtBx_S_staffID
            // 
            this.txtBx_S_staffID.Location = new System.Drawing.Point(197, 12);
            this.txtBx_S_staffID.Name = "txtBx_S_staffID";
            this.txtBx_S_staffID.ReadOnly = true;
            this.txtBx_S_staffID.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_staffID.TabIndex = 25;
            // 
            // txtBx_S_stafffirstName
            // 
            this.txtBx_S_stafffirstName.Location = new System.Drawing.Point(197, 38);
            this.txtBx_S_stafffirstName.Name = "txtBx_S_stafffirstName";
            this.txtBx_S_stafffirstName.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_stafffirstName.TabIndex = 26;
            // 
            // txtBx_S_stafflastName
            // 
            this.txtBx_S_stafflastName.Location = new System.Drawing.Point(197, 64);
            this.txtBx_S_stafflastName.Name = "txtBx_S_stafflastName";
            this.txtBx_S_stafflastName.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_stafflastName.TabIndex = 27;
            // 
            // txtBx_S_staff_IDNum
            // 
            this.txtBx_S_staff_IDNum.Location = new System.Drawing.Point(197, 90);
            this.txtBx_S_staff_IDNum.Name = "txtBx_S_staff_IDNum";
            this.txtBx_S_staff_IDNum.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_staff_IDNum.TabIndex = 28;
            // 
            // txtBx_S_staff_residentAddress
            // 
            this.txtBx_S_staff_residentAddress.Location = new System.Drawing.Point(197, 142);
            this.txtBx_S_staff_residentAddress.Name = "txtBx_S_staff_residentAddress";
            this.txtBx_S_staff_residentAddress.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_staff_residentAddress.TabIndex = 30;
            // 
            // txtBx_S_staff_username
            // 
            this.txtBx_S_staff_username.Location = new System.Drawing.Point(197, 168);
            this.txtBx_S_staff_username.Name = "txtBx_S_staff_username";
            this.txtBx_S_staff_username.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_staff_username.TabIndex = 31;
            // 
            // txtBx_S_staff_password
            // 
            this.txtBx_S_staff_password.Location = new System.Drawing.Point(197, 194);
            this.txtBx_S_staff_password.Name = "txtBx_S_staff_password";
            this.txtBx_S_staff_password.PasswordChar = '*';
            this.txtBx_S_staff_password.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_staff_password.TabIndex = 32;
            // 
            // txtBx_S_staff_confirmPassword
            // 
            this.txtBx_S_staff_confirmPassword.Location = new System.Drawing.Point(197, 220);
            this.txtBx_S_staff_confirmPassword.Name = "txtBx_S_staff_confirmPassword";
            this.txtBx_S_staff_confirmPassword.PasswordChar = '*';
            this.txtBx_S_staff_confirmPassword.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_staff_confirmPassword.TabIndex = 33;
            // 
            // dateTimePicker_staff_add
            // 
            this.dateTimePicker_staff_add.Location = new System.Drawing.Point(197, 116);
            this.dateTimePicker_staff_add.Name = "dateTimePicker_staff_add";
            this.dateTimePicker_staff_add.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker_staff_add.TabIndex = 34;
            this.dateTimePicker_staff_add.Value = new System.DateTime(2022, 9, 22, 0, 0, 0, 0);
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 337);
            this.Controls.Add(this.dateTimePicker_staff_add);
            this.Controls.Add(this.txtBx_S_staff_confirmPassword);
            this.Controls.Add(this.txtBx_S_staff_password);
            this.Controls.Add(this.txtBx_S_staff_username);
            this.Controls.Add(this.txtBx_S_staff_residentAddress);
            this.Controls.Add(this.txtBx_S_staff_IDNum);
            this.Controls.Add(this.txtBx_S_stafflastName);
            this.Controls.Add(this.txtBx_S_stafffirstName);
            this.Controls.Add(this.txtBx_S_staffID);
            this.Controls.Add(this.lbl_Staff_confirmPassword);
            this.Controls.Add(this.lbl_Staff_password);
            this.Controls.Add(this.lbl_Staff_username);
            this.Controls.Add(this.lbl_Staff_residentAddress);
            this.Controls.Add(this.lbl_Staff_dob);
            this.Controls.Add(this.lbl_Staff_IDnum);
            this.Controls.Add(this.lbl_Staff_lastName);
            this.Controls.Add(this.lbl_Staff_firstName);
            this.Controls.Add(this.lbl_S_staff_ID);
            this.Controls.Add(this.btn_addStaff);
            this.Controls.Add(this.btn_add_c_return);
            this.Name = "AddStaff";
            this.Text = "AddStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add_c_return;
        private System.Windows.Forms.Button btn_addStaff;
        private System.Windows.Forms.Label lbl_S_staff_ID;
        private System.Windows.Forms.Label lbl_Staff_firstName;
        private System.Windows.Forms.Label lbl_Staff_lastName;
        private System.Windows.Forms.Label lbl_Staff_IDnum;
        private System.Windows.Forms.Label lbl_Staff_dob;
        private System.Windows.Forms.Label lbl_Staff_residentAddress;
        private System.Windows.Forms.Label lbl_Staff_username;
        private System.Windows.Forms.Label lbl_Staff_password;
        private System.Windows.Forms.Label lbl_Staff_confirmPassword;
        private System.Windows.Forms.TextBox txtBx_S_staffID;
        private System.Windows.Forms.TextBox txtBx_S_stafffirstName;
        private System.Windows.Forms.TextBox txtBx_S_stafflastName;
        private System.Windows.Forms.TextBox txtBx_S_staff_IDNum;
        private System.Windows.Forms.TextBox txtBx_S_staff_residentAddress;
        private System.Windows.Forms.TextBox txtBx_S_staff_username;
        private System.Windows.Forms.TextBox txtBx_S_staff_password;
        private System.Windows.Forms.TextBox txtBx_S_staff_confirmPassword;
        private System.Windows.Forms.DateTimePicker dateTimePicker_staff_add;
    }
}