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
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(12, 415);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "LOGOUT";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_maintainCustomers
            // 
            this.btn_maintainCustomers.Location = new System.Drawing.Point(12, 12);
            this.btn_maintainCustomers.Name = "btn_maintainCustomers";
            this.btn_maintainCustomers.Size = new System.Drawing.Size(142, 74);
            this.btn_maintainCustomers.TabIndex = 7;
            this.btn_maintainCustomers.Text = "Maintain Customers";
            this.btn_maintainCustomers.UseVisualStyleBackColor = true;
            this.btn_maintainCustomers.Click += new System.EventHandler(this.btn_maintainCustomers_Click);
            // 
            // btn_maintainOrders
            // 
            this.btn_maintainOrders.Location = new System.Drawing.Point(160, 12);
            this.btn_maintainOrders.Name = "btn_maintainOrders";
            this.btn_maintainOrders.Size = new System.Drawing.Size(142, 74);
            this.btn_maintainOrders.TabIndex = 8;
            this.btn_maintainOrders.Text = "Maintain Orders";
            this.btn_maintainOrders.UseVisualStyleBackColor = true;
            // 
            // btn_maintainStaff
            // 
            this.btn_maintainStaff.Location = new System.Drawing.Point(308, 12);
            this.btn_maintainStaff.Name = "btn_maintainStaff";
            this.btn_maintainStaff.Size = new System.Drawing.Size(142, 74);
            this.btn_maintainStaff.TabIndex = 9;
            this.btn_maintainStaff.Text = "Maintain Staff";
            this.btn_maintainStaff.UseVisualStyleBackColor = true;
            // 
            // btn_Reports
            // 
            this.btn_Reports.Location = new System.Drawing.Point(12, 227);
            this.btn_Reports.Name = "btn_Reports";
            this.btn_Reports.Size = new System.Drawing.Size(142, 74);
            this.btn_Reports.TabIndex = 10;
            this.btn_Reports.Text = "REPORTS";
            this.btn_Reports.UseVisualStyleBackColor = true;
            // 
            // btn_maintainConsumables
            // 
            this.btn_maintainConsumables.Location = new System.Drawing.Point(456, 12);
            this.btn_maintainConsumables.Name = "btn_maintainConsumables";
            this.btn_maintainConsumables.Size = new System.Drawing.Size(142, 74);
            this.btn_maintainConsumables.TabIndex = 11;
            this.btn_maintainConsumables.Text = "Maintain Consumables";
            this.btn_maintainConsumables.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_maintainConsumables);
            this.Controls.Add(this.btn_Reports);
            this.Controls.Add(this.btn_maintainStaff);
            this.Controls.Add(this.btn_maintainOrders);
            this.Controls.Add(this.btn_maintainCustomers);
            this.Controls.Add(this.btn_Logout);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_maintainCustomers;
        private System.Windows.Forms.Button btn_maintainOrders;
        private System.Windows.Forms.Button btn_maintainStaff;
        private System.Windows.Forms.Button btn_Reports;
        private System.Windows.Forms.Button btn_maintainConsumables;
    }
}