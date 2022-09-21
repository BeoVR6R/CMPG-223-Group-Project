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
            this.SuspendLayout();
            // 
            // btn_addStock
            // 
            this.btn_addStock.Location = new System.Drawing.Point(266, 203);
            this.btn_addStock.Name = "btn_addStock";
            this.btn_addStock.Size = new System.Drawing.Size(110, 60);
            this.btn_addStock.TabIndex = 18;
            this.btn_addStock.Text = "ADD";
            this.btn_addStock.UseVisualStyleBackColor = true;
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 275);
            this.Controls.Add(this.btn_addStock);
            this.Name = "AddStock";
            this.Text = "AddStock";
            this.Load += new System.EventHandler(this.AddStock_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_addStock;
    }
}