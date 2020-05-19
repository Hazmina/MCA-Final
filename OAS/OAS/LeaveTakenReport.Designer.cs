namespace OAS
{
    partial class LeaveTakenReport
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeListSalaryDataSet = new OAS.EmployeeListSalaryDataSet();
            this.staffTableAdapter = new OAS.EmployeeListSalaryDataSetTableAdapters.StaffTableAdapter();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            this.leaveTakenDataSet = new OAS.LeaveTakenDataSet();
            this.leaveTakenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveTakenTableAdapter = new OAS.LeaveTakenDataSetTableAdapters.LeaveTakenTableAdapter();
            this.leaveTakenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.leaveTakenReportDataSet = new OAS.LeaveTakenReportDataSet();
            this.leaveTakenTableAdapter1 = new OAS.LeaveTakenReportDataSetTableAdapters.LeaveTakenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListSalaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTakenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTakenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTakenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTakenReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radGridView2);
            this.radGroupBox1.HeaderText = "Leave Taken";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(943, 600);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Leave Taken";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.employeeListSalaryDataSet;
            // 
            // employeeListSalaryDataSet
            // 
            this.employeeListSalaryDataSet.DataSetName = "EmployeeListSalaryDataSet";
            this.employeeListSalaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // radGridView2
            // 
            this.radGridView2.Location = new System.Drawing.Point(21, 36);
            // 
            // 
            // 
            this.radGridView2.MasterTemplate.AllowAddNewRow = false;
            this.radGridView2.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "Taken_Id";
            gridViewDecimalColumn1.HeaderText = "Taken_Id";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "Taken_Id";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.FieldName = "Staff Name";
            gridViewTextBoxColumn1.HeaderText = "Staff Name";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "Staff Name";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 300;
            gridViewTextBoxColumn2.FieldName = "Leave Name";
            gridViewTextBoxColumn2.HeaderText = "Leave Name";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "Leave Name";
            gridViewTextBoxColumn2.Width = 100;
            gridViewDateTimeColumn1.FieldName = "Leave Start";
            gridViewDateTimeColumn1.FormatString = "{0:dd-MMMM-yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Leave Start";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "Leave Start";
            gridViewDateTimeColumn1.Width = 150;
            gridViewDateTimeColumn2.FieldName = "Leave End";
            gridViewDateTimeColumn2.FormatString = "{0:dd-MMMM-yyyy}";
            gridViewDateTimeColumn2.HeaderText = "Leave End";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "Leave End";
            gridViewDateTimeColumn2.Width = 150;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "Total Leave Taken";
            gridViewDecimalColumn2.HeaderText = "Total Leave Taken";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.Name = "Total Leave Taken";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDecimalColumn2.Width = 150;
            this.radGridView2.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn2});
            this.radGridView2.MasterTemplate.DataSource = this.leaveTakenBindingSource1;
            this.radGridView2.MasterTemplate.EnableFiltering = true;
            this.radGridView2.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView2.Name = "radGridView2";
            this.radGridView2.ReadOnly = true;
            this.radGridView2.Size = new System.Drawing.Size(901, 541);
            this.radGridView2.TabIndex = 1;
            this.radGridView2.Text = "radGridView2";
            this.radGridView2.ThemeName = "TelerikMetroBlue";
            // 
            // leaveTakenDataSet
            // 
            this.leaveTakenDataSet.DataSetName = "LeaveTakenDataSet";
            this.leaveTakenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveTakenBindingSource
            // 
            this.leaveTakenBindingSource.DataMember = "LeaveTaken";
            this.leaveTakenBindingSource.DataSource = this.leaveTakenDataSet;
            // 
            // leaveTakenTableAdapter
            // 
            this.leaveTakenTableAdapter.ClearBeforeFill = true;
            // 
            // leaveTakenBindingSource1
            // 
            this.leaveTakenBindingSource1.DataMember = "LeaveTaken";
            this.leaveTakenBindingSource1.DataSource = this.leaveTakenReportDataSet;
            // 
            // leaveTakenReportDataSet
            // 
            this.leaveTakenReportDataSet.DataSetName = "LeaveTakenReportDataSet";
            this.leaveTakenReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveTakenTableAdapter1
            // 
            this.leaveTakenTableAdapter1.ClearBeforeFill = true;
            // 
            // LeaveTakenReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 630);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LeaveTakenReport";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeaveTakenReport";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.LeaveTakenReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeListSalaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTakenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTakenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTakenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTakenReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private EmployeeListSalaryDataSet employeeListSalaryDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private EmployeeListSalaryDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadGridView radGridView2;
        private System.Windows.Forms.BindingSource leaveTakenBindingSource;
        private LeaveTakenDataSet leaveTakenDataSet;
        private LeaveTakenDataSetTableAdapters.LeaveTakenTableAdapter leaveTakenTableAdapter;
        private LeaveTakenReportDataSet leaveTakenReportDataSet;
        private System.Windows.Forms.BindingSource leaveTakenBindingSource1;
        private LeaveTakenReportDataSetTableAdapters.LeaveTakenTableAdapter leaveTakenTableAdapter1;
    }
}
