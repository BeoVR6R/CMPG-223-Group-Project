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
            this.lbl_Order = new System.Windows.Forms.Label();
            this.btn_HouseBlend = new System.Windows.Forms.Button();
            this.btn_Cappuccino = new System.Windows.Forms.Button();
            this.btn_ColdDrink = new System.Windows.Forms.Button();
            this.btn_HotDrinks = new System.Windows.Forms.Button();
            this.btn_Fanta = new System.Windows.Forms.Button();
            this.btn_Coke = new System.Windows.Forms.Button();
            this.rTB_Order = new System.Windows.Forms.RichTextBox();
            this.btn_ClearOrder = new System.Windows.Forms.Button();
            this.btnCalculatePrice = new System.Windows.Forms.Button();
            this.btn_placeOrder = new System.Windows.Forms.Button();
            this.btn_cashierReceipt = new System.Windows.Forms.Button();
            this.lbl_activeUser = new System.Windows.Forms.Label();
            this.btn_H_needHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(12, 349);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(145, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "LOGOUT";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_adminPanel
            // 
            this.btn_adminPanel.Location = new System.Drawing.Point(12, 320);
            this.btn_adminPanel.Name = "btn_adminPanel";
            this.btn_adminPanel.Size = new System.Drawing.Size(145, 23);
            this.btn_adminPanel.TabIndex = 1;
            this.btn_adminPanel.Text = "ADMIN PANEL";
            this.btn_adminPanel.UseVisualStyleBackColor = true;
            this.btn_adminPanel.Click += new System.EventHandler(this.btn_adminPanel_Click);
            // 
            // lbl_Order
            // 
            this.lbl_Order.AutoSize = true;
            this.lbl_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Order.Location = new System.Drawing.Point(648, 9);
            this.lbl_Order.Name = "lbl_Order";
            this.lbl_Order.Size = new System.Drawing.Size(121, 16);
            this.lbl_Order.TabIndex = 3;
            this.lbl_Order.Text = "Items in your Order:";
            // 
            // btn_HouseBlend
            // 
            this.btn_HouseBlend.Location = new System.Drawing.Point(12, 130);
            this.btn_HouseBlend.Name = "btn_HouseBlend";
            this.btn_HouseBlend.Size = new System.Drawing.Size(92, 74);
            this.btn_HouseBlend.TabIndex = 4;
            this.btn_HouseBlend.Text = "House Blend R9,99";
            this.btn_HouseBlend.UseVisualStyleBackColor = true;
            this.btn_HouseBlend.Click += new System.EventHandler(this.btn_HouseBlend_Click);
            // 
            // btn_Cappuccino
            // 
            this.btn_Cappuccino.Location = new System.Drawing.Point(110, 130);
            this.btn_Cappuccino.Name = "btn_Cappuccino";
            this.btn_Cappuccino.Size = new System.Drawing.Size(92, 74);
            this.btn_Cappuccino.TabIndex = 5;
            this.btn_Cappuccino.Text = "Cappuccino R13,99";
            this.btn_Cappuccino.UseVisualStyleBackColor = true;
            this.btn_Cappuccino.Click += new System.EventHandler(this.btn_Cappuccino_Click);
            // 
            // btn_ColdDrink
            // 
            this.btn_ColdDrink.Location = new System.Drawing.Point(12, 28);
            this.btn_ColdDrink.Name = "btn_ColdDrink";
            this.btn_ColdDrink.Size = new System.Drawing.Size(92, 74);
            this.btn_ColdDrink.TabIndex = 6;
            this.btn_ColdDrink.Text = "Cold Drinks";
            this.btn_ColdDrink.UseVisualStyleBackColor = true;
            this.btn_ColdDrink.Click += new System.EventHandler(this.btn_ColdDrink_Click);
            // 
            // btn_HotDrinks
            // 
            this.btn_HotDrinks.Location = new System.Drawing.Point(110, 28);
            this.btn_HotDrinks.Name = "btn_HotDrinks";
            this.btn_HotDrinks.Size = new System.Drawing.Size(92, 74);
            this.btn_HotDrinks.TabIndex = 7;
            this.btn_HotDrinks.Text = "Hot Drinks";
            this.btn_HotDrinks.UseVisualStyleBackColor = true;
            this.btn_HotDrinks.Click += new System.EventHandler(this.btn_HotDrinks_Click);
            // 
            // btn_Fanta
            // 
            this.btn_Fanta.Location = new System.Drawing.Point(12, 210);
            this.btn_Fanta.Name = "btn_Fanta";
            this.btn_Fanta.Size = new System.Drawing.Size(92, 74);
            this.btn_Fanta.TabIndex = 8;
            this.btn_Fanta.Text = "Fanta R9,99";
            this.btn_Fanta.UseVisualStyleBackColor = true;
            this.btn_Fanta.Click += new System.EventHandler(this.btn_Fanta_Click);
            // 
            // btn_Coke
            // 
            this.btn_Coke.Location = new System.Drawing.Point(110, 210);
            this.btn_Coke.Name = "btn_Coke";
            this.btn_Coke.Size = new System.Drawing.Size(92, 74);
            this.btn_Coke.TabIndex = 9;
            this.btn_Coke.Text = "Coke R9,99";
            this.btn_Coke.UseVisualStyleBackColor = true;
            this.btn_Coke.Click += new System.EventHandler(this.btn_Coke_Click);
            // 
            // rTB_Order
            // 
            this.rTB_Order.Location = new System.Drawing.Point(651, 28);
            this.rTB_Order.Name = "rTB_Order";
            this.rTB_Order.Size = new System.Drawing.Size(137, 256);
            this.rTB_Order.TabIndex = 10;
            this.rTB_Order.Text = "";
            // 
            // btn_ClearOrder
            // 
            this.btn_ClearOrder.Location = new System.Drawing.Point(508, 89);
            this.btn_ClearOrder.Name = "btn_ClearOrder";
            this.btn_ClearOrder.Size = new System.Drawing.Size(137, 55);
            this.btn_ClearOrder.TabIndex = 11;
            this.btn_ClearOrder.Text = "CLEAR ORDER";
            this.btn_ClearOrder.UseVisualStyleBackColor = true;
            this.btn_ClearOrder.Click += new System.EventHandler(this.btn_ClearOrder_Click);
            // 
            // btnCalculatePrice
            // 
            this.btnCalculatePrice.Location = new System.Drawing.Point(508, 229);
            this.btnCalculatePrice.Name = "btnCalculatePrice";
            this.btnCalculatePrice.Size = new System.Drawing.Size(137, 55);
            this.btnCalculatePrice.TabIndex = 12;
            this.btnCalculatePrice.Text = "CALCULATE PRICE";
            this.btnCalculatePrice.UseVisualStyleBackColor = true;
            this.btnCalculatePrice.Click += new System.EventHandler(this.btnCalculatePrice_Click);
            // 
            // btn_placeOrder
            // 
            this.btn_placeOrder.Location = new System.Drawing.Point(651, 302);
            this.btn_placeOrder.Name = "btn_placeOrder";
            this.btn_placeOrder.Size = new System.Drawing.Size(137, 74);
            this.btn_placeOrder.TabIndex = 14;
            this.btn_placeOrder.Text = "PLACE ORDER";
            this.btn_placeOrder.UseVisualStyleBackColor = true;
            this.btn_placeOrder.Click += new System.EventHandler(this.btn_placeOrder_Click);
            // 
            // btn_cashierReceipt
            // 
            this.btn_cashierReceipt.Location = new System.Drawing.Point(508, 302);
            this.btn_cashierReceipt.Name = "btn_cashierReceipt";
            this.btn_cashierReceipt.Size = new System.Drawing.Size(137, 74);
            this.btn_cashierReceipt.TabIndex = 15;
            this.btn_cashierReceipt.Text = "CASHIER RECEIPT";
            this.btn_cashierReceipt.UseVisualStyleBackColor = true;
            this.btn_cashierReceipt.Click += new System.EventHandler(this.btn_cashierReceipt_Click);
            // 
            // lbl_activeUser
            // 
            this.lbl_activeUser.AutoSize = true;
            this.lbl_activeUser.Location = new System.Drawing.Point(12, 9);
            this.lbl_activeUser.Name = "lbl_activeUser";
            this.lbl_activeUser.Size = new System.Drawing.Size(35, 13);
            this.lbl_activeUser.TabIndex = 16;
            this.lbl_activeUser.Text = "label1";
            // 
            // btn_H_needHelp
            // 
            this.btn_H_needHelp.Location = new System.Drawing.Point(508, 28);
            this.btn_H_needHelp.Name = "btn_H_needHelp";
            this.btn_H_needHelp.Size = new System.Drawing.Size(137, 55);
            this.btn_H_needHelp.TabIndex = 17;
            this.btn_H_needHelp.Text = "NEED HELP?";
            this.btn_H_needHelp.UseVisualStyleBackColor = true;
            this.btn_H_needHelp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // form_Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.btn_H_needHelp);
            this.Controls.Add(this.lbl_activeUser);
            this.Controls.Add(this.btn_cashierReceipt);
            this.Controls.Add(this.btn_placeOrder);
            this.Controls.Add(this.btnCalculatePrice);
            this.Controls.Add(this.btn_ClearOrder);
            this.Controls.Add(this.rTB_Order);
            this.Controls.Add(this.btn_Coke);
            this.Controls.Add(this.btn_Fanta);
            this.Controls.Add(this.btn_HotDrinks);
            this.Controls.Add(this.btn_ColdDrink);
            this.Controls.Add(this.btn_Cappuccino);
            this.Controls.Add(this.btn_HouseBlend);
            this.Controls.Add(this.lbl_Order);
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
        private System.Windows.Forms.Label lbl_Order;
        private System.Windows.Forms.Button btn_HouseBlend;
        private System.Windows.Forms.Button btn_Cappuccino;
        private System.Windows.Forms.Button btn_ColdDrink;
        private System.Windows.Forms.Button btn_HotDrinks;
        private System.Windows.Forms.Button btn_Fanta;
        private System.Windows.Forms.Button btn_Coke;
        private System.Windows.Forms.RichTextBox rTB_Order;
        private System.Windows.Forms.Button btn_ClearOrder;
        private System.Windows.Forms.Button btnCalculatePrice;
        private System.Windows.Forms.Button btn_placeOrder;
        private System.Windows.Forms.Button btn_cashierReceipt;
        public System.Windows.Forms.Label lbl_activeUser;
        private System.Windows.Forms.Button btn_H_needHelp;
    }
}