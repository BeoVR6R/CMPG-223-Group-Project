namespace GrindGo
{
    partial class AddStock
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
            this.btn_addStock = new System.Windows.Forms.Button();
            this.lbl_S_itemName = new System.Windows.Forms.Label();
            this.lbl_S_itemPrice = new System.Windows.Forms.Label();
            this.txtBx_S_itemName = new System.Windows.Forms.TextBox();
            this.txtBx_S_itemCostPrice = new System.Windows.Forms.TextBox();
            this.btn_add_s_return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addStock
            // 
            this.btn_addStock.Location = new System.Drawing.Point(266, 86);
            this.btn_addStock.Name = "btn_addStock";
            this.btn_addStock.Size = new System.Drawing.Size(110, 60);
            this.btn_addStock.TabIndex = 18;
            this.btn_addStock.Text = "ADD";
            this.btn_addStock.UseVisualStyleBackColor = true;
            this.btn_addStock.Click += new System.EventHandler(this.btn_addStock_Click);
            // 
            // lbl_S_itemName
            // 
            this.lbl_S_itemName.AutoSize = true;
            this.lbl_S_itemName.Location = new System.Drawing.Point(12, 19);
            this.lbl_S_itemName.Name = "lbl_S_itemName";
            this.lbl_S_itemName.Size = new System.Drawing.Size(61, 13);
            this.lbl_S_itemName.TabIndex = 19;
            this.lbl_S_itemName.Text = "Item Name:";
            // 
            // lbl_S_itemPrice
            // 
            this.lbl_S_itemPrice.AutoSize = true;
            this.lbl_S_itemPrice.Location = new System.Drawing.Point(12, 45);
            this.lbl_S_itemPrice.Name = "lbl_S_itemPrice";
            this.lbl_S_itemPrice.Size = new System.Drawing.Size(81, 13);
            this.lbl_S_itemPrice.TabIndex = 20;
            this.lbl_S_itemPrice.Text = "Item Cost Price:";
            // 
            // txtBx_S_itemName
            // 
            this.txtBx_S_itemName.Location = new System.Drawing.Point(197, 12);
            this.txtBx_S_itemName.Name = "txtBx_S_itemName";
            this.txtBx_S_itemName.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_itemName.TabIndex = 21;
            // 
            // txtBx_S_itemCostPrice
            // 
            this.txtBx_S_itemCostPrice.Location = new System.Drawing.Point(197, 38);
            this.txtBx_S_itemCostPrice.Name = "txtBx_S_itemCostPrice";
            this.txtBx_S_itemCostPrice.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_itemCostPrice.TabIndex = 22;
            // 
            // btn_add_s_return
            // 
            this.btn_add_s_return.Location = new System.Drawing.Point(12, 86);
            this.btn_add_s_return.Name = "btn_add_s_return";
            this.btn_add_s_return.Size = new System.Drawing.Size(110, 60);
            this.btn_add_s_return.TabIndex = 23;
            this.btn_add_s_return.Text = "RETURN";
            this.btn_add_s_return.UseVisualStyleBackColor = true;
            this.btn_add_s_return.Click += new System.EventHandler(this.btn_add_s_return_Click);
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 153);
            this.Controls.Add(this.btn_add_s_return);
            this.Controls.Add(this.txtBx_S_itemCostPrice);
            this.Controls.Add(this.txtBx_S_itemName);
            this.Controls.Add(this.lbl_S_itemPrice);
            this.Controls.Add(this.lbl_S_itemName);
            this.Controls.Add(this.btn_addStock);
            this.Name = "AddStock";
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addStock;
        private System.Windows.Forms.Label lbl_S_itemName;
        private System.Windows.Forms.Label lbl_S_itemPrice;
        private System.Windows.Forms.TextBox txtBx_S_itemName;
        private System.Windows.Forms.TextBox txtBx_S_itemCostPrice;
        private System.Windows.Forms.Button btn_add_s_return;
    }
}