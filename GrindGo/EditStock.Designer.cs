namespace GrindGo
{
    partial class EditStock
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
            this.btn_updateStock = new System.Windows.Forms.Button();
            this.lbl_S_stockID = new System.Windows.Forms.Label();
            this.lbl_S_Name = new System.Windows.Forms.Label();
            this.lbl_S_costPrice = new System.Windows.Forms.Label();
            this.txtBx_S_edit_Name = new System.Windows.Forms.TextBox();
            this.txtBx_S_edit_costPrice = new System.Windows.Forms.TextBox();
            this.txtBx_S_stockID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_updateStock
            // 
            this.btn_updateStock.Location = new System.Drawing.Point(266, 116);
            this.btn_updateStock.Name = "btn_updateStock";
            this.btn_updateStock.Size = new System.Drawing.Size(110, 60);
            this.btn_updateStock.TabIndex = 17;
            this.btn_updateStock.Text = "UPDATE";
            this.btn_updateStock.UseVisualStyleBackColor = true;
            this.btn_updateStock.Click += new System.EventHandler(this.btn_updateStock_Click);
            // 
            // lbl_S_stockID
            // 
            this.lbl_S_stockID.AutoSize = true;
            this.lbl_S_stockID.Location = new System.Drawing.Point(12, 19);
            this.lbl_S_stockID.Name = "lbl_S_stockID";
            this.lbl_S_stockID.Size = new System.Drawing.Size(44, 13);
            this.lbl_S_stockID.TabIndex = 18;
            this.lbl_S_stockID.Text = "Item ID:";
            // 
            // lbl_S_Name
            // 
            this.lbl_S_Name.AutoSize = true;
            this.lbl_S_Name.Location = new System.Drawing.Point(12, 45);
            this.lbl_S_Name.Name = "lbl_S_Name";
            this.lbl_S_Name.Size = new System.Drawing.Size(61, 13);
            this.lbl_S_Name.TabIndex = 19;
            this.lbl_S_Name.Text = "Item Name:";
            // 
            // lbl_S_costPrice
            // 
            this.lbl_S_costPrice.AutoSize = true;
            this.lbl_S_costPrice.Location = new System.Drawing.Point(12, 71);
            this.lbl_S_costPrice.Name = "lbl_S_costPrice";
            this.lbl_S_costPrice.Size = new System.Drawing.Size(81, 13);
            this.lbl_S_costPrice.TabIndex = 20;
            this.lbl_S_costPrice.Text = "Item Cost Price:";
            // 
            // txtBx_S_edit_Name
            // 
            this.txtBx_S_edit_Name.Location = new System.Drawing.Point(197, 38);
            this.txtBx_S_edit_Name.Name = "txtBx_S_edit_Name";
            this.txtBx_S_edit_Name.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_edit_Name.TabIndex = 21;
            // 
            // txtBx_S_edit_costPrice
            // 
            this.txtBx_S_edit_costPrice.Location = new System.Drawing.Point(197, 64);
            this.txtBx_S_edit_costPrice.Name = "txtBx_S_edit_costPrice";
            this.txtBx_S_edit_costPrice.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_edit_costPrice.TabIndex = 22;
            // 
            // txtBx_S_stockID
            // 
            this.txtBx_S_stockID.Location = new System.Drawing.Point(197, 12);
            this.txtBx_S_stockID.Name = "txtBx_S_stockID";
            this.txtBx_S_stockID.ReadOnly = true;
            this.txtBx_S_stockID.Size = new System.Drawing.Size(179, 20);
            this.txtBx_S_stockID.TabIndex = 23;
            // 
            // EditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 188);
            this.Controls.Add(this.txtBx_S_stockID);
            this.Controls.Add(this.txtBx_S_edit_costPrice);
            this.Controls.Add(this.txtBx_S_edit_Name);
            this.Controls.Add(this.lbl_S_costPrice);
            this.Controls.Add(this.lbl_S_Name);
            this.Controls.Add(this.lbl_S_stockID);
            this.Controls.Add(this.btn_updateStock);
            this.Name = "EditStock";
            this.Text = "EditStock";
            this.Load += new System.EventHandler(this.EditStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_updateStock;
        private System.Windows.Forms.Label lbl_S_stockID;
        private System.Windows.Forms.Label lbl_S_Name;
        private System.Windows.Forms.Label lbl_S_costPrice;
        private System.Windows.Forms.TextBox txtBx_S_edit_Name;
        private System.Windows.Forms.TextBox txtBx_S_edit_costPrice;
        private System.Windows.Forms.TextBox txtBx_S_stockID;
    }
}