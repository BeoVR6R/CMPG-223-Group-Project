namespace GrindGo
{
    partial class AdminPanel
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
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_maintainCustomers = new System.Windows.Forms.Button();
            this.btn_maintainOrders = new System.Windows.Forms.Button();
            this.btn_maintainStaff = new System.Windows.Forms.Button();
            this.btn_Reports = new System.Windows.Forms.Button();
            this.btn_maintainConsumables = new System.Windows.Forms.Button();
            this.lbl_adminPanel_Maintain = new System.Windows.Forms.Label();
            this.lbl_adminpanel_Reports = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(12, 237);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "LOGOUT";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_maintainCustomers
            // 
            this.btn_maintainCustomers.Location = new System.Drawing.Point(12, 31);
            this.btn_maintainCustomers.Name = "btn_maintainCustomers";
            this.btn_maintainCustomers.Size = new System.Drawing.Size(142, 74);
            this.btn_maintainCustomers.TabIndex = 7;
            this.btn_maintainCustomers.Text = "Maintain Customers";
            this.btn_maintainCustomers.UseVisualStyleBackColor = true;
            this.btn_maintainCustomers.Click += new System.EventHandler(this.btn_maintainCustomers_Click);
            // 
            // btn_maintainOrders
            // 
            this.btn_maintainOrders.Location = new System.Drawing.Point(160, 31);
            this.btn_maintainOrders.Name = "btn_maintainOrders";
            this.btn_maintainOrders.Size = new System.Drawing.Size(142, 74);
            this.btn_maintainOrders.TabIndex = 8;
            this.btn_maintainOrders.Text = "Maintain Orders";
            this.btn_maintainOrders.UseVisualStyleBackColor = true;
            // 
            // btn_maintainStaff
            // 
            this.btn_maintainStaff.Location = new System.Drawing.Point(308, 31);
            this.btn_maintainStaff.Name = "btn_maintainStaff";
            this.btn_maintainStaff.Size = new System.Drawing.Size(142, 74);
            this.btn_maintainStaff.TabIndex = 9;
            this.btn_maintainStaff.Text = "Maintain Staff";
            this.btn_maintainStaff.UseVisualStyleBackColor = true;
            this.btn_maintainStaff.Click += new System.EventHandler(this.btn_maintainStaff_Click);
            // 
            // btn_Reports
            // 
            this.btn_Reports.Location = new System.Drawing.Point(12, 144);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(142, 74);
            this.btn_Reports.TabIndex = 10;
            this.btn_Reports.Text = "REPORTS";
            this.btn_Reports.UseVisualStyleBackColor = true;
            this.btn_Reports.Click += new System.EventHandler(this.btn_Reports_Click);
            // 
            // btn_maintainConsumables
            // 
            this.btn_maintainConsumables.Location = new System.Drawing.Point(456, 31);
            this.btn_maintainConsumables.Name = "btn_maintainConsumables";
            this.btn_maintainConsumables.Size = new System.Drawing.Size(142, 74);
            this.btn_maintainConsumables.TabIndex = 11;
            this.btn_maintainConsumables.Text = "Maintain Stock";
            this.btn_maintainConsumables.UseVisualStyleBackColor = true;
            this.btn_maintainConsumables.Click += new System.EventHandler(this.btn_maintainConsumables_Click);
            // 
            // lbl_adminPanel_Maintain
            // 
            this.lbl_adminPanel_Maintain.AutoSize = true;
            this.lbl_adminPanel_Maintain.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminPanel_Maintain.Location = new System.Drawing.Point(12, 12);
            this.lbl_adminPanel_Maintain.Name = "lbl_adminPanel_Maintain";
            this.lbl_adminPanel_Maintain.Size = new System.Drawing.Size(119, 19);
            this.lbl_adminPanel_Maintain.TabIndex = 12;
            this.lbl_adminPanel_Maintain.Text = "Maintain Records:";
            this.lbl_adminPanel_Maintain.Click += new System.EventHandler(this.lbl_adminPanel_Maintain_Click);
            // 
            // lbl_adminpanel_Reports
            // 
            this.lbl_adminpanel_Reports.AutoSize = true;
            this.lbl_adminpanel_Reports.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adminpanel_Reports.Location = new System.Drawing.Point(12, 125);
            this.lbl_adminpanel_Reports.Name = "lbl_adminpanel_Reports";
            this.lbl_adminpanel_Reports.Size = new System.Drawing.Size(119, 19);
            this.lbl_adminpanel_Reports.TabIndex = 13;
            this.lbl_adminpanel_Reports.Text = "Generate Reports:";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(604, 272);
            this.Controls.Add(this.lbl_adminpanel_Reports);
            this.Controls.Add(this.lbl_adminPanel_Maintain);
            this.Controls.Add(this.btn_maintainConsumables);
            this.Controls.Add(this.btn_Reports);
            this.Controls.Add(this.btn_maintainStaff);
            this.Controls.Add(this.btn_maintainOrders);
            this.Controls.Add(this.btn_maintainCustomers);
            this.Controls.Add(this.btn_Logout);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_maintainCustomers;
        private System.Windows.Forms.Button btn_maintainOrders;
        private System.Windows.Forms.Button btn_maintainStaff;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.Button btn_maintainConsumables;
        private System.Windows.Forms.Label lbl_adminPanel_Maintain;
        private System.Windows.Forms.Label lbl_adminpanel_Reports;
    }
}