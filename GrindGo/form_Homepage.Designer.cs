namespace GrindGo
{
    partial class form_Homepage
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_adminPanel = new System.Windows.Forms.Button();
            this.listBx_Order = new System.Windows.Forms.ListBox();
            this.lbl_Order = new System.Windows.Forms.Label();
            this.btn_HouseBlend = new System.Windows.Forms.Button();
            this.btn_Cappuccino = new System.Windows.Forms.Button();
            this.btn_ColdDrink = new System.Windows.Forms.Button();
            this.btn_HotDrinks = new System.Windows.Forms.Button();
            this.btn_Fanta = new System.Windows.Forms.Button();
            this.btn_Coke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(12, 415);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(145, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "LOGOUT";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_adminPanel
            // 
            this.btn_adminPanel.Location = new System.Drawing.Point(12, 386);
            this.btn_adminPanel.Name = "btn_adminPanel";
            this.btn_adminPanel.Size = new System.Drawing.Size(145, 23);
            this.btn_adminPanel.TabIndex = 1;
            this.btn_adminPanel.Text = "ADMIN PANEL";
            this.btn_adminPanel.UseVisualStyleBackColor = true;
            this.btn_adminPanel.Click += new System.EventHandler(this.btn_adminPanel_Click);
            // 
            // listBx_Order
            // 
            this.listBx_Order.FormattingEnabled = true;
            this.listBx_Order.Location = new System.Drawing.Point(668, 34);
            this.listBx_Order.Name = "listBx_Order";
            this.listBx_Order.Size = new System.Drawing.Size(120, 290);
            this.listBx_Order.TabIndex = 2;
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.Location = new System.Drawing.Point(665, 9);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(98, 13);
            this.lbl_Order.TabIndex = 3;
            this.lbl_Order.Text = "Items in your Order:";
            // 
            // btn_HouseBlend
            // 
            this.btn_HouseBlend.Location = new System.Drawing.Point(12, 112);
            this.btn_HouseBlend.Name = "btn_HouseBlend";
            this.btn_HouseBlend.Size = new System.Drawing.Size(92, 74);
            this.btn_HouseBlend.TabIndex = 4;
            this.btn_HouseBlend.Text = "House Blend R9,99";
            this.btn_HouseBlend.UseVisualStyleBackColor = true;
            // 
            // btn_Cappuccino
            // 
            this.btn_Cappuccino.Location = new System.Drawing.Point(110, 112);
            this.btn_Cappuccino.Name = "btn_Cappuccino";
            this.btn_Cappuccino.Size = new System.Drawing.Size(92, 74);
            this.btn_Cappuccino.TabIndex = 5;
            this.btn_Cappuccino.Text = "Cappuccino R13,99";
            this.btn_Cappuccino.UseVisualStyleBackColor = true;
            // 
            // btn_ColdDrink
            // 
            this.btn_ColdDrink.Location = new System.Drawing.Point(12, 12);
            this.btn_ColdDrink.Name = "btn_ColdDrink";
            this.btn_ColdDrink.Size = new System.Drawing.Size(92, 74);
            this.btn_ColdDrink.TabIndex = 6;
            this.btn_ColdDrink.Text = "Cold Drinks";
            this.btn_ColdDrink.UseVisualStyleBackColor = true;
            this.btn_ColdDrink.Click += new System.EventHandler(this.btn_ColdDrink_Click);
            // 
            // btn_HotDrinks
            // 
            this.btn_HotDrinks.Location = new System.Drawing.Point(110, 12);
            this.btn_HotDrinks.Name = "btn_HotDrinks";
            this.btn_HotDrinks.Size = new System.Drawing.Size(92, 74);
            this.btn_HotDrinks.TabIndex = 7;
            this.btn_HotDrinks.Text = "Hot Drinks";
            this.btn_HotDrinks.UseVisualStyleBackColor = true;
            this.btn_HotDrinks.Click += new System.EventHandler(this.btn_HotDrinks_Click);
            // 
            // btn_Fanta
            // 
            this.btn_Fanta.Location = new System.Drawing.Point(12, 192);
            this.btn_Fanta.Name = "btn_Fanta";
            this.btn_Fanta.Size = new System.Drawing.Size(92, 74);
            this.btn_Fanta.TabIndex = 8;
            this.btn_Fanta.Text = "Fanta R9,99";
            this.btn_Fanta.UseVisualStyleBackColor = true;
            // 
            // btn_Coke
            // 
            this.btn_Coke.Location = new System.Drawing.Point(110, 192);
            this.btn_Coke.Name = "btn_Coke";
            this.btn_Coke.Size = new System.Drawing.Size(92, 74);
            this.btn_Coke.TabIndex = 9;
            this.btn_Coke.Text = "Coke R9,99";
            this.btn_Coke.UseVisualStyleBackColor = true;
            // 
            // form_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Coke);
            this.Controls.Add(this.btn_Fanta);
            this.Controls.Add(this.btn_HotDrinks);
            this.Controls.Add(this.btn_ColdDrink);
            this.Controls.Add(this.btn_Cappuccino);
            this.Controls.Add(this.btn_HouseBlend);
            this.Controls.Add(this.lbl_Order);
            this.Controls.Add(this.listBx_Order);
            this.Controls.Add(this.btn_adminPanel);
            this.Controls.Add(this.btn_Login);
            this.Name = "form_Homepage";
            this.Text = "GrindGo - Homepage";
            this.Load += new System.EventHandler(this.form_Homepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_adminPanel;
        private System.Windows.Forms.ListBox listBx_Order;
        private System.Windows.Forms.Label lbl_Order;
        private System.Windows.Forms.Button btn_HouseBlend;
        private System.Windows.Forms.Button btn_Cappuccino;
        private System.Windows.Forms.Button btn_ColdDrink;
        private System.Windows.Forms.Button btn_HotDrinks;
        private System.Windows.Forms.Button btn_Fanta;
        private System.Windows.Forms.Button btn_Coke;
    }
}