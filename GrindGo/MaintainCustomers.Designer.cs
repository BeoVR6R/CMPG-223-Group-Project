namespace GrindGo
{
    partial class MaintainCustomers
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
            this.lbl_SearchCustomer = new System.Windows.Forms.Label();
            this.txBx_searchCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grindGoDataSet = new GrindGo.GrindGoDataSet();
            this.cUSTOMERTableAdapter = new GrindGo.GrindGoDataSetTableAdapters.CUSTOMERTableAdapter();
            this.btn_deleteCustomer = new System.Windows.Forms.Button();
            this.btn_goBack = new System.Windows.Forms.Button();
            this.btn_createCustomer = new System.Windows.Forms.Button();
            this.btn_advancedSearch = new System.Windows.Forms.Button();
            this.btn_refreshTable = new System.Windows.Forms.Button();
            this.grindGoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loyaltyQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grindGoDataSet1 = new GrindGo.GrindGoDataSet1();
            this.cUSTOMERTableAdapter1 = new GrindGo.GrindGoDataSet1TableAdapters.CUSTOMERTableAdapter();
            this.btn_updateCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindGoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindGoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindGoDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SearchCustomer
            // 
            this.lbl_SearchCustomer.AutoSize = true;
            this.lbl_SearchCustomer.Location = new System.Drawing.Point(12, 9);
            this.lbl_SearchCustomer.Name = "lbl_SearchCustomer";
            this.lbl_SearchCustomer.Size = new System.Drawing.Size(128, 13);
            this.lbl_SearchCustomer.TabIndex = 0;
            this.lbl_SearchCustomer.Text = "Edit an existing Customer:";
            // 
            // txBx_searchCustomer
            // 
            this.txBx_searchCustomer.Location = new System.Drawing.Point(88, 34);
            this.txBx_searchCustomer.Name = "txBx_searchCustomer";
            this.txBx_searchCustomer.Size = new System.Drawing.Size(149, 20);
            this.txBx_searchCustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email Adress:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(243, 34);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 20);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.grindGoDataSet;
            // 
            // grindGoDataSet
            // 
            this.grindGoDataSet.DataSetName = "GrindGoDataSet";
            this.grindGoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // btn_deleteCustomer
            // 
            this.btn_deleteCustomer.Location = new System.Drawing.Point(15, 287);
            this.btn_deleteCustomer.Name = "btn_deleteCustomer";
            this.btn_deleteCustomer.Size = new System.Drawing.Size(105, 54);
            this.btn_deleteCustomer.TabIndex = 5;
            this.btn_deleteCustomer.Text = "DELETE SELECTED";
            this.btn_deleteCustomer.UseVisualStyleBackColor = true;
            this.btn_deleteCustomer.Click += new System.EventHandler(this.btn_deleteCustomer_Click);
            // 
            // btn_goBack
            // 
            this.btn_goBack.Location = new System.Drawing.Point(12, 384);
            this.btn_goBack.Name = "btn_goBack";
            this.btn_goBack.Size = new System.Drawing.Size(105, 54);
            this.btn_goBack.TabIndex = 7;
            this.btn_goBack.Text = "RETURN";
            this.btn_goBack.UseVisualStyleBackColor = true;
            this.btn_goBack.Click += new System.EventHandler(this.btn_goBack_Click);
            // 
            // btn_createCustomer
            // 
            this.btn_createCustomer.Location = new System.Drawing.Point(596, 384);
            this.btn_createCustomer.Name = "btn_createCustomer";
            this.btn_createCustomer.Size = new System.Drawing.Size(192, 54);
            this.btn_createCustomer.TabIndex = 8;
            this.btn_createCustomer.Text = "CREATE NEW CUSTOMER";
            this.btn_createCustomer.UseVisualStyleBackColor = true;
            this.btn_createCustomer.Click += new System.EventHandler(this.btn_createCustomer_Click);
            // 
            // btn_advancedSearch
            // 
            this.btn_advancedSearch.Location = new System.Drawing.Point(596, 324);
            this.btn_advancedSearch.Name = "btn_advancedSearch";
            this.btn_advancedSearch.Size = new System.Drawing.Size(192, 54);
            this.btn_advancedSearch.TabIndex = 9;
            this.btn_advancedSearch.Text = "ADVANCED SEARCH";
            this.btn_advancedSearch.UseVisualStyleBackColor = true;
            // 
            // btn_refreshTable
            // 
            this.btn_refreshTable.Location = new System.Drawing.Point(605, 63);
            this.btn_refreshTable.Name = "btn_refreshTable";
            this.btn_refreshTable.Size = new System.Drawing.Size(192, 54);
            this.btn_refreshTable.TabIndex = 10;
            this.btn_refreshTable.Text = "REFRESH TABLE";
            this.btn_refreshTable.UseVisualStyleBackColor = true;
            this.btn_refreshTable.Click += new System.EventHandler(this.btn_refreshTable_Click);
            // 
            // grindGoDataSetBindingSource
            // 
            this.grindGoDataSetBindingSource.DataSource = this.grindGoDataSet;
            this.grindGoDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.residentAddressDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.loyaltyQtyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTOMERBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 218);
            this.dataGridView1.TabIndex = 11;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "firstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "lastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // residentAddressDataGridViewTextBoxColumn
            // 
            this.residentAddressDataGridViewTextBoxColumn.DataPropertyName = "residentAddress";
            this.residentAddressDataGridViewTextBoxColumn.HeaderText = "residentAddress";
            this.residentAddressDataGridViewTextBoxColumn.Name = "residentAddressDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "emailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "emailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // loyaltyQtyDataGridViewTextBoxColumn
            // 
            this.loyaltyQtyDataGridViewTextBoxColumn.DataPropertyName = "loyalty_Qty";
            this.loyaltyQtyDataGridViewTextBoxColumn.HeaderText = "loyalty_Qty";
            this.loyaltyQtyDataGridViewTextBoxColumn.Name = "loyaltyQtyDataGridViewTextBoxColumn";
            // 
            // cUSTOMERBindingSource1
            // 
            this.cUSTOMERBindingSource1.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource1.DataSource = this.grindGoDataSet1;
            // 
            // grindGoDataSet1
            // 
            this.grindGoDataSet1.DataSetName = "GrindGoDataSet1";
            this.grindGoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERTableAdapter1
            // 
            this.cUSTOMERTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_updateCustomer
            // 
            this.btn_updateCustomer.Location = new System.Drawing.Point(126, 287);
            this.btn_updateCustomer.Name = "btn_updateCustomer";
            this.btn_updateCustomer.Size = new System.Drawing.Size(105, 54);
            this.btn_updateCustomer.TabIndex = 6;
            this.btn_updateCustomer.Text = "UPDATE SELECTED";
            this.btn_updateCustomer.UseVisualStyleBackColor = true;
            this.btn_updateCustomer.Click += new System.EventHandler(this.btn_updateCustomer_Click);
            // 
            // MaintainCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_refreshTable);
            this.Controls.Add(this.btn_advancedSearch);
            this.Controls.Add(this.btn_createCustomer);
            this.Controls.Add(this.btn_goBack);
            this.Controls.Add(this.btn_updateCustomer);
            this.Controls.Add(this.btn_deleteCustomer);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txBx_searchCustomer);
            this.Controls.Add(this.lbl_SearchCustomer);
            this.Name = "MaintainCustomers";
            this.Text = "MaintainCustomers";
            this.Load += new System.EventHandler(this.MaintainCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindGoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindGoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindGoDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SearchCustomer;
        private System.Windows.Forms.TextBox txBx_searchCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
        private GrindGoDataSet grindGoDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private GrindGoDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.Button btn_deleteCustomer;
        private System.Windows.Forms.Button btn_goBack;
        private System.Windows.Forms.Button btn_createCustomer;
        private System.Windows.Forms.Button btn_advancedSearch;
        private System.Windows.Forms.Button btn_refreshTable;
        private System.Windows.Forms.BindingSource grindGoDataSetBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GrindGoDataSet1 grindGoDataSet1;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource1;
        private GrindGoDataSet1TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loyaltyQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_updateCustomer;
    }
}