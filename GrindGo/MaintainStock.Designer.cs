namespace GrindGo
{
    partial class MaintainStock
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
            this.components = new System.ComponentModel.Container();
            this.lbl_searchStock = new System.Windows.Forms.Label();
            this.lbl_search_Stock_Name = new System.Windows.Forms.Label();
            this.txBx_searchStock = new System.Windows.Forms.TextBox();
            this.btn_SearchStock = new System.Windows.Forms.Button();
            this.btn_goBackStock = new System.Windows.Forms.Button();
            this.btn_deleteStock = new System.Windows.Forms.Button();
            this.btn_updateStock = new System.Windows.Forms.Button();
            this.btn_createStock = new System.Windows.Forms.Button();
            this.btn_advancedSearch_stock = new System.Windows.Forms.Button();
            this.btn_refreshTable_Stock = new System.Windows.Forms.Button();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockcostPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTOCKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grindGoStock = new GrindGo.GrindGoStock();
            this.sTOCKTableAdapter = new GrindGo.GrindGoStockTableAdapters.STOCKTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindGoStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_searchStock
            // 
            this.lbl_searchStock.AutoSize = true;
            this.lbl_searchStock.Location = new System.Drawing.Point(12, 9);
            this.lbl_searchStock.Name = "lbl_searchStock";
            this.lbl_searchStock.Size = new System.Drawing.Size(95, 13);
            this.lbl_searchStock.TabIndex = 1;
            this.lbl_searchStock.Text = "Edit existing stock:";
            // 
            // lbl_search_Stock_Name
            // 
            this.lbl_search_Stock_Name.AutoSize = true;
            this.lbl_search_Stock_Name.Location = new System.Drawing.Point(12, 37);
            this.lbl_search_Stock_Name.Name = "lbl_search_Stock_Name";
            this.lbl_search_Stock_Name.Size = new System.Drawing.Size(69, 13);
            this.lbl_search_Stock_Name.TabIndex = 3;
            this.lbl_search_Stock_Name.Text = "Stock Name:";
            // 
            // txBx_searchStock
            // 
            this.txBx_searchStock.Location = new System.Drawing.Point(87, 34);
            this.txBx_searchStock.Name = "txBx_searchStock";
            this.txBx_searchStock.Size = new System.Drawing.Size(149, 20);
            this.txBx_searchStock.TabIndex = 4;
            // 
            // btn_SearchStock
            // 
            this.btn_SearchStock.Location = new System.Drawing.Point(242, 34);
            this.btn_SearchStock.Name = "btn_SearchStock";
            this.btn_SearchStock.Size = new System.Drawing.Size(75, 20);
            this.btn_SearchStock.TabIndex = 5;
            this.btn_SearchStock.Text = "Search";
            this.btn_SearchStock.UseVisualStyleBackColor = true;
            this.btn_SearchStock.Click += new System.EventHandler(this.btn_SearchStock_Click);
            // 
            // btn_goBackStock
            // 
            this.btn_goBackStock.Location = new System.Drawing.Point(12, 384);
            this.btn_goBackStock.Name = "btn_goBackStock";
            this.btn_goBackStock.Size = new System.Drawing.Size(105, 54);
            this.btn_goBackStock.TabIndex = 8;
            this.btn_goBackStock.Text = "RETURN";
            this.btn_goBackStock.UseVisualStyleBackColor = true;
            this.btn_goBackStock.Click += new System.EventHandler(this.btn_goBackStock_Click);
            // 
            // btn_deleteStock
            // 
            this.btn_deleteStock.Location = new System.Drawing.Point(12, 288);
            this.btn_deleteStock.Name = "btn_deleteStock";
            this.btn_deleteStock.Size = new System.Drawing.Size(105, 54);
            this.btn_deleteStock.TabIndex = 9;
            this.btn_deleteStock.Text = "DELETE SELECTED";
            this.btn_deleteStock.UseVisualStyleBackColor = true;
            this.btn_deleteStock.Click += new System.EventHandler(this.btn_deleteStock_Click);
            // 
            // btn_updateStock
            // 
            this.btn_updateStock.Location = new System.Drawing.Point(123, 288);
            this.btn_updateStock.Name = "btn_updateStock";
            this.btn_updateStock.Size = new System.Drawing.Size(105, 54);
            this.btn_updateStock.TabIndex = 10;
            this.btn_updateStock.Text = "UPDATE SELECTED";
            this.btn_updateStock.UseVisualStyleBackColor = true;
            this.btn_updateStock.Click += new System.EventHandler(this.btn_updateStock_Click);
            // 
            // btn_createStock
            // 
            this.btn_createStock.Location = new System.Drawing.Point(365, 384);
            this.btn_createStock.Name = "btn_createStock";
            this.btn_createStock.Size = new System.Drawing.Size(192, 54);
            this.btn_createStock.TabIndex = 11;
            this.btn_createStock.Text = "CREATE NEW STOCK ITEM";
            this.btn_createStock.UseVisualStyleBackColor = true;
            this.btn_createStock.Click += new System.EventHandler(this.btn_createStock_Click);
            // 
            // btn_advancedSearch_stock
            // 
            this.btn_advancedSearch_stock.Location = new System.Drawing.Point(365, 324);
            this.btn_advancedSearch_stock.Name = "btn_advancedSearch_stock";
            this.btn_advancedSearch_stock.Size = new System.Drawing.Size(192, 54);
            this.btn_advancedSearch_stock.TabIndex = 12;
            this.btn_advancedSearch_stock.Text = "ADVANCED SEARCH";
            this.btn_advancedSearch_stock.UseVisualStyleBackColor = true;
            // 
            // btn_refreshTable_Stock
            // 
            this.btn_refreshTable_Stock.Location = new System.Drawing.Point(365, 60);
            this.btn_refreshTable_Stock.Name = "btn_refreshTable_Stock";
            this.btn_refreshTable_Stock.Size = new System.Drawing.Size(192, 54);
            this.btn_refreshTable_Stock.TabIndex = 13;
            this.btn_refreshTable_Stock.Text = "REFRESH TABLE";
            this.btn_refreshTable_Stock.UseVisualStyleBackColor = true;
            this.btn_refreshTable_Stock.Click += new System.EventHandler(this.btn_refreshTable_Stock_Click);
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AutoGenerateColumns = false;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.stockdescDataGridViewTextBoxColumn,
            this.stockcostPriceDataGridViewTextBoxColumn});
            this.dataGridViewStock.DataSource = this.sTOCKBindingSource;
            this.dataGridViewStock.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.Size = new System.Drawing.Size(347, 222);
            this.dataGridViewStock.TabIndex = 14;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "stock_ID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "stock_ID";
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockdescDataGridViewTextBoxColumn
            // 
            this.stockdescDataGridViewTextBoxColumn.DataPropertyName = "stock_desc";
            this.stockdescDataGridViewTextBoxColumn.HeaderText = "stock_desc";
            this.stockdescDataGridViewTextBoxColumn.Name = "stockdescDataGridViewTextBoxColumn";
            // 
            // stockcostPriceDataGridViewTextBoxColumn
            // 
            this.stockcostPriceDataGridViewTextBoxColumn.DataPropertyName = "stock_costPrice";
            this.stockcostPriceDataGridViewTextBoxColumn.HeaderText = "stock_costPrice";
            this.stockcostPriceDataGridViewTextBoxColumn.Name = "stockcostPriceDataGridViewTextBoxColumn";
            // 
            // sTOCKBindingSource
            // 
            this.sTOCKBindingSource.DataMember = "STOCK";
            this.sTOCKBindingSource.DataSource = this.grindGoStock;
            // 
            // grindGoStock
            // 
            this.grindGoStock.DataSetName = "GrindGoStock";
            this.grindGoStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTOCKTableAdapter
            // 
            this.sTOCKTableAdapter.ClearBeforeFill = true;
            // 
            // MaintainStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.dataGridViewStock);
            this.Controls.Add(this.btn_refreshTable_Stock);
            this.Controls.Add(this.btn_advancedSearch_stock);
            this.Controls.Add(this.btn_createStock);
            this.Controls.Add(this.btn_updateStock);
            this.Controls.Add(this.btn_deleteStock);
            this.Controls.Add(this.btn_goBackStock);
            this.Controls.Add(this.btn_SearchStock);
            this.Controls.Add(this.txBx_searchStock);
            this.Controls.Add(this.lbl_search_Stock_Name);
            this.Controls.Add(this.lbl_searchStock);
            this.Name = "MaintainStock";
            this.Text = "MaintainStock";
            this.Load += new System.EventHandler(this.MaintainStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTOCKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindGoStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_searchStock;
        private System.Windows.Forms.Label lbl_search_Stock_Name;
        private System.Windows.Forms.TextBox txBx_searchStock;
        private System.Windows.Forms.Button btn_SearchStock;
        private System.Windows.Forms.Button btn_goBackStock;
        private System.Windows.Forms.Button btn_deleteStock;
        private System.Windows.Forms.Button btn_updateStock;
        private System.Windows.Forms.Button btn_createStock;
        private System.Windows.Forms.Button btn_advancedSearch_stock;
        private System.Windows.Forms.Button btn_refreshTable_Stock;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private GrindGoStock grindGoStock;
        private System.Windows.Forms.BindingSource sTOCKBindingSource;
        private GrindGoStockTableAdapters.STOCKTableAdapter sTOCKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockcostPriceDataGridViewTextBoxColumn;
    }
}