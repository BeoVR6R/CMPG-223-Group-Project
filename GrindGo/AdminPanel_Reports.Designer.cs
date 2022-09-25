namespace GrindGo
{
    partial class AdminPanel_Reports
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
            this.grindGoDataSet3 = new GrindGo.GrindGoDataSet3();
            this.oRDERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRDERSTableAdapter = new GrindGo.GrindGoDataSet3TableAdapters.ORDERSTableAdapter();
            this.lbl_report_searchBy = new System.Windows.Forms.Label();
            this.btn_refreshTable = new System.Windows.Forms.Button();
            this.chkBx_order_ID = new System.Windows.Forms.CheckBox();
            this.chkBx_order_Date = new System.Windows.Forms.CheckBox();
            this.chkBx_order_count = new System.Windows.Forms.CheckBox();
            this.order_include_c_details = new System.Windows.Forms.CheckBox();
            this.chkBx_order_staffDetails = new System.Windows.Forms.CheckBox();
            this.btn_need_help = new System.Windows.Forms.Button();
            this.txtBx_SearchID = new System.Windows.Forms.TextBox();
            this.btn_order_search = new System.Windows.Forms.Button();
            this.btn_order_findID = new System.Windows.Forms.Button();
            this.lbl_datePicker = new System.Windows.Forms.Label();
            this.dateTimePicker_from = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.btn_order_date_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grindGoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grindGoDataSet3
            // 
            this.grindGoDataSet3.DataSetName = "GrindGoDataSet3";
            this.grindGoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oRDERSBindingSource
            // 
            this.oRDERSBindingSource.DataMember = "ORDERS";
            this.oRDERSBindingSource.DataSource = this.grindGoDataSet3;
            // 
            // oRDERSTableAdapter
            // 
            this.oRDERSTableAdapter.ClearBeforeFill = true;
            // 
            // lbl_report_searchBy
            // 
            this.lbl_report_searchBy.AutoSize = true;
            this.lbl_report_searchBy.Location = new System.Drawing.Point(12, 13);
            this.lbl_report_searchBy.Name = "lbl_report_searchBy";
            this.lbl_report_searchBy.Size = new System.Drawing.Size(58, 13);
            this.lbl_report_searchBy.TabIndex = 1;
            this.lbl_report_searchBy.Text = "Search by:";
            // 
            // btn_refreshTable
            // 
            this.btn_refreshTable.Location = new System.Drawing.Point(666, 248);
            this.btn_refreshTable.Name = "btn_refreshTable";
            this.btn_refreshTable.Size = new System.Drawing.Size(192, 54);
            this.btn_refreshTable.TabIndex = 11;
            this.btn_refreshTable.Text = "REFRESH TABLE";
            this.btn_refreshTable.UseVisualStyleBackColor = true;
            this.btn_refreshTable.Click += new System.EventHandler(this.btn_refreshTable_Click);
            // 
            // chkBx_order_ID
            // 
            this.chkBx_order_ID.AutoSize = true;
            this.chkBx_order_ID.Location = new System.Drawing.Point(76, 12);
            this.chkBx_order_ID.Name = "chkBx_order_ID";
            this.chkBx_order_ID.Size = new System.Drawing.Size(66, 17);
            this.chkBx_order_ID.TabIndex = 13;
            this.chkBx_order_ID.Text = "Order ID";
            this.chkBx_order_ID.UseVisualStyleBackColor = true;
            this.chkBx_order_ID.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkBx_order_Date
            // 
            this.chkBx_order_Date.AutoSize = true;
            this.chkBx_order_Date.Location = new System.Drawing.Point(148, 12);
            this.chkBx_order_Date.Name = "chkBx_order_Date";
            this.chkBx_order_Date.Size = new System.Drawing.Size(97, 17);
            this.chkBx_order_Date.TabIndex = 14;
            this.chkBx_order_Date.Text = "Orders by Date";
            this.chkBx_order_Date.UseVisualStyleBackColor = true;
            this.chkBx_order_Date.CheckedChanged += new System.EventHandler(this.chkBx_order_Date_CheckedChanged);
            // 
            // chkBx_order_count
            // 
            this.chkBx_order_count.AutoSize = true;
            this.chkBx_order_count.Location = new System.Drawing.Point(148, 35);
            this.chkBx_order_count.Name = "chkBx_order_count";
            this.chkBx_order_count.Size = new System.Drawing.Size(128, 17);
            this.chkBx_order_count.TabIndex = 15;
            this.chkBx_order_count.Text = "Count Orders by Date";
            this.chkBx_order_count.UseVisualStyleBackColor = true;
            this.chkBx_order_count.CheckedChanged += new System.EventHandler(this.chkBx_order_count_CheckedChanged);
            // 
            // order_include_c_details
            // 
            this.order_include_c_details.AutoSize = true;
            this.order_include_c_details.Location = new System.Drawing.Point(285, 37);
            this.order_include_c_details.Name = "order_include_c_details";
            this.order_include_c_details.Size = new System.Drawing.Size(143, 17);
            this.order_include_c_details.TabIndex = 16;
            this.order_include_c_details.Text = "Include Customer Details";
            this.order_include_c_details.UseVisualStyleBackColor = true;
            this.order_include_c_details.CheckedChanged += new System.EventHandler(this.order_include_c_details_CheckedChanged);
            // 
            // chkBx_order_staffDetails
            // 
            this.chkBx_order_staffDetails.AutoSize = true;
            this.chkBx_order_staffDetails.Location = new System.Drawing.Point(285, 13);
            this.chkBx_order_staffDetails.Name = "chkBx_order_staffDetails";
            this.chkBx_order_staffDetails.Size = new System.Drawing.Size(121, 17);
            this.chkBx_order_staffDetails.TabIndex = 17;
            this.chkBx_order_staffDetails.Text = "Include Staff Details";
            this.chkBx_order_staffDetails.UseVisualStyleBackColor = true;
            // 
            // btn_need_help
            // 
            this.btn_need_help.Location = new System.Drawing.Point(666, 188);
            this.btn_need_help.Name = "btn_need_help";
            this.btn_need_help.Size = new System.Drawing.Size(192, 54);
            this.btn_need_help.TabIndex = 18;
            this.btn_need_help.Text = "NEED HELP?";
            this.btn_need_help.UseVisualStyleBackColor = true;
            // 
            // txtBx_SearchID
            // 
            this.txtBx_SearchID.Location = new System.Drawing.Point(15, 60);
            this.txtBx_SearchID.Name = "txtBx_SearchID";
            this.txtBx_SearchID.Size = new System.Drawing.Size(55, 20);
            this.txtBx_SearchID.TabIndex = 19;
            // 
            // btn_order_search
            // 
            this.btn_order_search.Location = new System.Drawing.Point(76, 60);
            this.btn_order_search.Name = "btn_order_search";
            this.btn_order_search.Size = new System.Drawing.Size(118, 20);
            this.btn_order_search.TabIndex = 20;
            this.btn_order_search.Text = "SEARCH";
            this.btn_order_search.UseVisualStyleBackColor = true;
            this.btn_order_search.Click += new System.EventHandler(this.btn_order_search_Click);
            // 
            // btn_order_findID
            // 
            this.btn_order_findID.Location = new System.Drawing.Point(200, 60);
            this.btn_order_findID.Name = "btn_order_findID";
            this.btn_order_findID.Size = new System.Drawing.Size(118, 20);
            this.btn_order_findID.TabIndex = 21;
            this.btn_order_findID.Text = "FIND ID";
            this.btn_order_findID.UseVisualStyleBackColor = true;
            // 
            // lbl_datePicker
            // 
            this.lbl_datePicker.AutoSize = true;
            this.lbl_datePicker.Location = new System.Drawing.Point(9, 107);
            this.lbl_datePicker.Name = "lbl_datePicker";
            this.lbl_datePicker.Size = new System.Drawing.Size(77, 13);
            this.lbl_datePicker.TabIndex = 22;
            this.lbl_datePicker.Text = "Date between:";
            // 
            // dateTimePicker_from
            // 
            this.dateTimePicker_from.Location = new System.Drawing.Point(92, 101);
            this.dateTimePicker_from.Name = "dateTimePicker_from";
            this.dateTimePicker_from.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker_from.TabIndex = 23;
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Location = new System.Drawing.Point(285, 101);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(187, 20);
            this.dateTimePicker_to.TabIndex = 24;
            // 
            // btn_order_date_search
            // 
            this.btn_order_date_search.Location = new System.Drawing.Point(478, 101);
            this.btn_order_date_search.Name = "btn_order_date_search";
            this.btn_order_date_search.Size = new System.Drawing.Size(118, 20);
            this.btn_order_date_search.TabIndex = 25;
            this.btn_order_date_search.Text = "SEARCH";
            this.btn_order_date_search.UseVisualStyleBackColor = true;
            this.btn_order_date_search.Click += new System.EventHandler(this.btn_order_date_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.orderTotalDataGridViewTextBoxColumn,
            this.staffIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oRDERSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(648, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "order_ID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "order_Time";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "order_Time";
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "order_Date";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "order_Date";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // orderTotalDataGridViewTextBoxColumn
            // 
            this.orderTotalDataGridViewTextBoxColumn.DataPropertyName = "order_Total";
            this.orderTotalDataGridViewTextBoxColumn.HeaderText = "order_Total";
            this.orderTotalDataGridViewTextBoxColumn.Name = "orderTotalDataGridViewTextBoxColumn";
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "staff_ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "staff_ID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // AdminPanel_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 313);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_order_date_search);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.dateTimePicker_from);
            this.Controls.Add(this.lbl_datePicker);
            this.Controls.Add(this.btn_order_findID);
            this.Controls.Add(this.btn_order_search);
            this.Controls.Add(this.txtBx_SearchID);
            this.Controls.Add(this.btn_need_help);
            this.Controls.Add(this.chkBx_order_staffDetails);
            this.Controls.Add(this.order_include_c_details);
            this.Controls.Add(this.chkBx_order_count);
            this.Controls.Add(this.chkBx_order_Date);
            this.Controls.Add(this.chkBx_order_ID);
            this.Controls.Add(this.btn_refreshTable);
            this.Controls.Add(this.lbl_report_searchBy);
            this.Name = "AdminPanel_Reports";
            this.Text = "AdminPanel_Reports";
            this.Load += new System.EventHandler(this.AdminPanel_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grindGoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRDERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GrindGoDataSet3 grindGoDataSet3;
        private System.Windows.Forms.BindingSource oRDERSBindingSource;
        private GrindGoDataSet3TableAdapters.ORDERSTableAdapter oRDERSTableAdapter;
        private System.Windows.Forms.Label lbl_report_searchBy;
        private System.Windows.Forms.Button btn_refreshTable;
        private System.Windows.Forms.CheckBox chkBx_order_ID;
        private System.Windows.Forms.CheckBox chkBx_order_Date;
        private System.Windows.Forms.CheckBox chkBx_order_count;
        private System.Windows.Forms.CheckBox order_include_c_details;
        private System.Windows.Forms.CheckBox chkBx_order_staffDetails;
        private System.Windows.Forms.Button btn_need_help;
        private System.Windows.Forms.TextBox txtBx_SearchID;
        private System.Windows.Forms.Button btn_order_search;
        private System.Windows.Forms.Button btn_order_findID;
        private System.Windows.Forms.Label lbl_datePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.Button btn_order_date_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
    }
}