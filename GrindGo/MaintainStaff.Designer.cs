namespace GrindGo
{
    partial class MaintainStaff
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
            this.lbl_SearchStaff = new System.Windows.Forms.Label();
            this.lbl_Staff_Search_Username = new System.Windows.Forms.Label();
            this.txBx_searchStaff = new System.Windows.Forms.TextBox();
            this.btn_SearchStaff = new System.Windows.Forms.Button();
            this.btn_createStaff = new System.Windows.Forms.Button();
            this.btn_advancedSearch_Staff = new System.Windows.Forms.Button();
            this.btn_refreshTable_Staff = new System.Windows.Forms.Button();
            this.btn_goBack_Staff = new System.Windows.Forms.Button();
            this.btn_deleteStaff = new System.Windows.Forms.Button();
            this.btn_updateStaff = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grindGoDataSet2 = new GrindGo.GrindGoDataSet2();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTAFFTableAdapter = new GrindGo.GrindGoDataSet2TableAdapters.STAFFTableAdapter();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.residentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindGoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SearchStaff
            // 
            this.lbl_SearchStaff.AutoSize = true;
            this.lbl_SearchStaff.Location = new System.Drawing.Point(12, 9);
            this.lbl_SearchStaff.Name = "lbl_SearchStaff";
            this.lbl_SearchStaff.Size = new System.Drawing.Size(147, 13);
            this.lbl_SearchStaff.TabIndex = 1;
            this.lbl_SearchStaff.Text = "Edit an existing Staff Member:";
            // 
            // lbl_Staff_Search_Username
            // 
            this.lbl_Staff_Search_Username.AutoSize = true;
            this.lbl_Staff_Search_Username.Location = new System.Drawing.Point(12, 36);
            this.lbl_Staff_Search_Username.Name = "lbl_Staff_Search_Username";
            this.lbl_Staff_Search_Username.Size = new System.Drawing.Size(58, 13);
            this.lbl_Staff_Search_Username.TabIndex = 3;
            this.lbl_Staff_Search_Username.Text = "Username:";
            // 
            // txBx_searchStaff
            // 
            this.txBx_searchStaff.Location = new System.Drawing.Point(87, 33);
            this.txBx_searchStaff.Name = "txBx_searchStaff";
            this.txBx_searchStaff.Size = new System.Drawing.Size(149, 20);
            this.txBx_searchStaff.TabIndex = 4;
            // 
            // btn_SearchStaff
            // 
            this.btn_SearchStaff.Location = new System.Drawing.Point(242, 33);
            this.btn_SearchStaff.Name = "btn_SearchStaff";
            this.btn_SearchStaff.Size = new System.Drawing.Size(75, 20);
            this.btn_SearchStaff.TabIndex = 5;
            this.btn_SearchStaff.Text = "Search";
            this.btn_SearchStaff.UseVisualStyleBackColor = true;
            this.btn_SearchStaff.Click += new System.EventHandler(this.btn_SearchStaff_Click);
            // 
            // btn_createStaff
            // 
            this.btn_createStaff.Location = new System.Drawing.Point(466, 384);
            this.btn_createStaff.Name = "btn_createStaff";
            this.btn_createStaff.Size = new System.Drawing.Size(192, 54);
            this.btn_createStaff.TabIndex = 9;
            this.btn_createStaff.Text = "CREATE NEW STAFF MEMBER";
            this.btn_createStaff.UseVisualStyleBackColor = true;
            this.btn_createStaff.Click += new System.EventHandler(this.btn_createStaff_Click);
            // 
            // btn_advancedSearch_Staff
            // 
            this.btn_advancedSearch_Staff.Location = new System.Drawing.Point(466, 324);
            this.btn_advancedSearch_Staff.Name = "btn_advancedSearch_Staff";
            this.btn_advancedSearch_Staff.Size = new System.Drawing.Size(192, 54);
            this.btn_advancedSearch_Staff.TabIndex = 10;
            this.btn_advancedSearch_Staff.Text = "ADVANCED SEARCH";
            this.btn_advancedSearch_Staff.UseVisualStyleBackColor = true;
            // 
            // btn_refreshTable_Staff
            // 
            this.btn_refreshTable_Staff.Location = new System.Drawing.Point(466, 215);
            this.btn_refreshTable_Staff.Name = "btn_refreshTable_Staff";
            this.btn_refreshTable_Staff.Size = new System.Drawing.Size(192, 54);
            this.btn_refreshTable_Staff.TabIndex = 11;
            this.btn_refreshTable_Staff.Text = "REFRESH TABLE";
            this.btn_refreshTable_Staff.UseVisualStyleBackColor = true;
            this.btn_refreshTable_Staff.Click += new System.EventHandler(this.btn_refreshTable_Staff_Click);
            // 
            // btn_goBack_Staff
            // 
            this.btn_goBack_Staff.Location = new System.Drawing.Point(15, 384);
            this.btn_goBack_Staff.Name = "btn_goBack_Staff";
            this.btn_goBack_Staff.Size = new System.Drawing.Size(105, 54);
            this.btn_goBack_Staff.TabIndex = 12;
            this.btn_goBack_Staff.Text = "RETURN";
            this.btn_goBack_Staff.UseVisualStyleBackColor = true;
            this.btn_goBack_Staff.Click += new System.EventHandler(this.btn_goBack_Staff_Click);
            // 
            // btn_deleteStaff
            // 
            this.btn_deleteStaff.Location = new System.Drawing.Point(12, 215);
            this.btn_deleteStaff.Name = "btn_deleteStaff";
            this.btn_deleteStaff.Size = new System.Drawing.Size(105, 54);
            this.btn_deleteStaff.TabIndex = 13;
            this.btn_deleteStaff.Text = "DELETE SELECTED";
            this.btn_deleteStaff.UseVisualStyleBackColor = true;
            this.btn_deleteStaff.Click += new System.EventHandler(this.btn_deleteStaff_Click);
            // 
            // btn_updateStaff
            // 
            this.btn_updateStaff.Location = new System.Drawing.Point(123, 215);
            this.btn_updateStaff.Name = "btn_updateStaff";
            this.btn_updateStaff.Size = new System.Drawing.Size(105, 54);
            this.btn_updateStaff.TabIndex = 14;
            this.btn_updateStaff.Text = "UPDATE SELECTED";
            this.btn_updateStaff.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.idNumDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.residentAddressDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sTAFFBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // grindGoDataSet2
            // 
            this.grindGoDataSet2.DataSetName = "GrindGoDataSet2";
            this.grindGoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.grindGoDataSet2;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
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
            // idNumDataGridViewTextBoxColumn
            // 
            this.idNumDataGridViewTextBoxColumn.DataPropertyName = "id_Num";
            this.idNumDataGridViewTextBoxColumn.HeaderText = "id_Num";
            this.idNumDataGridViewTextBoxColumn.Name = "idNumDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "dateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // residentAddressDataGridViewTextBoxColumn
            // 
            this.residentAddressDataGridViewTextBoxColumn.DataPropertyName = "residentAddress";
            this.residentAddressDataGridViewTextBoxColumn.HeaderText = "residentAddress";
            this.residentAddressDataGridViewTextBoxColumn.Name = "residentAddressDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // MaintainStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_updateStaff);
            this.Controls.Add(this.btn_deleteStaff);
            this.Controls.Add(this.btn_goBack_Staff);
            this.Controls.Add(this.btn_refreshTable_Staff);
            this.Controls.Add(this.btn_advancedSearch_Staff);
            this.Controls.Add(this.btn_createStaff);
            this.Controls.Add(this.btn_SearchStaff);
            this.Controls.Add(this.txBx_searchStaff);
            this.Controls.Add(this.lbl_Staff_Search_Username);
            this.Controls.Add(this.lbl_SearchStaff);
            this.Name = "MaintainStaff";
            this.Text = "MaintainStaff";
            this.Load += new System.EventHandler(this.MaintainStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grindGoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SearchStaff;
        private System.Windows.Forms.Label lbl_Staff_Search_Username;
        private System.Windows.Forms.TextBox txBx_searchStaff;
        private System.Windows.Forms.Button btn_SearchStaff;
        private System.Windows.Forms.Button btn_createStaff;
        private System.Windows.Forms.Button btn_advancedSearch_Staff;
        private System.Windows.Forms.Button btn_refreshTable_Staff;
        private System.Windows.Forms.Button btn_goBack_Staff;
        private System.Windows.Forms.Button btn_deleteStaff;
        private System.Windows.Forms.Button btn_updateStaff;
        private System.Windows.Forms.DataGridView dataGridView1;
        private GrindGoDataSet2 grindGoDataSet2;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private GrindGoDataSet2TableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn residentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
    }
}