namespace OAS
{
    partial class ProvidentFund
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn1 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn2 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn3 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGridView2 = new Telerik.WinControls.UI.RadGridView();
            this.allowanceTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.allowanceDataSet = new OAS.AllowanceDataSet();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffPFDataSet = new OAS.StaffPFDataSet();
            this.staffTableAdapter = new OAS.StaffPFDataSetTableAdapters.StaffTableAdapter();
            this.allowanceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allowanceTypeTableAdapter = new OAS.AllowanceDataSetTableAdapters.AllowanceTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowanceTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffPFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowanceTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radGroupBox3);
            this.radGroupBox1.Controls.Add(this.radGroupBox2);
            this.radGroupBox1.HeaderText = "Providend Fund";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1334, 655);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Providend Fund";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.radGridView2);
            this.radGroupBox3.HeaderText = "Provident Fund Deduct";
            this.radGroupBox3.Location = new System.Drawing.Point(581, 33);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(729, 600);
            this.radGroupBox3.TabIndex = 2;
            this.radGroupBox3.Text = "Provident Fund Deduct";
            this.radGroupBox3.ThemeName = "TelerikMetroBlue";
            // 
            // radGridView2
            // 
            this.radGridView2.Location = new System.Drawing.Point(16, 35);
            // 
            // 
            // 
            this.radGridView2.MasterTemplate.AllowAddNewRow = false;
            this.radGridView2.MasterTemplate.AllowColumnReorder = false;
            gridViewTextBoxColumn1.FieldName = "All_Type";
            gridViewTextBoxColumn1.HeaderText = "All_Type";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "All_Type";
            gridViewTextBoxColumn1.Width = 100;
            gridViewDecimalColumn1.DataType = typeof(double);
            gridViewDecimalColumn1.FieldName = "All_Perc";
            gridViewDecimalColumn1.HeaderText = "Percentage";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.Name = "All_Perc";
            gridViewDecimalColumn1.Width = 80;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "All_TransId";
            gridViewDecimalColumn2.HeaderText = "All_TransId";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "All_TransId";
            gridViewDecimalColumn2.ReadOnly = true;
            gridViewDateTimeColumn1.FieldName = "F_Date";
            gridViewDateTimeColumn1.FormatString = "{0:dd-MMMM-yyyy}";
            gridViewDateTimeColumn1.HeaderText = "From";
            gridViewDateTimeColumn1.IsAutoGenerated = true;
            gridViewDateTimeColumn1.Name = "F_Date";
            gridViewDateTimeColumn1.Width = 150;
            gridViewDateTimeColumn2.FieldName = "Entry_Date";
            gridViewDateTimeColumn2.FormatString = "{0:dd-MMMM-yyyy}";
            gridViewDateTimeColumn2.HeaderText = "Entry Date";
            gridViewDateTimeColumn2.IsAutoGenerated = true;
            gridViewDateTimeColumn2.Name = "Entry_Date";
            gridViewDateTimeColumn2.Width = 150;
            gridViewDecimalColumn3.DataType = typeof(double);
            gridViewDecimalColumn3.FieldName = "Amt";
            gridViewDecimalColumn3.HeaderText = "Amount";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "Amt";
            gridViewDecimalColumn3.Width = 150;
            this.radGridView2.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewDateTimeColumn1,
            gridViewDateTimeColumn2,
            gridViewDecimalColumn3});
            this.radGridView2.MasterTemplate.DataSource = this.allowanceTypeBindingSource1;
            this.radGridView2.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView2.Name = "radGridView2";
            this.radGridView2.ReadOnly = true;
            this.radGridView2.Size = new System.Drawing.Size(697, 546);
            this.radGridView2.TabIndex = 1;
            this.radGridView2.Text = "radGridView2";
            this.radGridView2.ThemeName = "TelerikMetroBlue";
            // 
            // allowanceTypeBindingSource1
            // 
            this.allowanceTypeBindingSource1.DataMember = "AllowanceType";
            this.allowanceTypeBindingSource1.DataSource = this.allowanceDataSet;
            // 
            // allowanceDataSet
            // 
            this.allowanceDataSet.DataSetName = "AllowanceDataSet";
            this.allowanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radGridView1);
            this.radGroupBox2.HeaderText = "Employee List";
            this.radGroupBox2.Location = new System.Drawing.Point(16, 33);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(559, 600);
            this.radGroupBox2.TabIndex = 1;
            this.radGroupBox2.Text = "Employee List";
            this.radGroupBox2.ThemeName = "TelerikMetroBlue";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(15, 35);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.FieldName = "Staffid";
            gridViewDecimalColumn4.HeaderText = "Staffid";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "Staffid";
            gridViewDecimalColumn4.ReadOnly = true;
            gridViewTextBoxColumn2.FieldName = "name";
            gridViewTextBoxColumn2.HeaderText = "Staff Type";
            gridViewTextBoxColumn2.IsAutoGenerated = true;
            gridViewTextBoxColumn2.Name = "name";
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.FieldName = "Staff Name";
            gridViewTextBoxColumn3.HeaderText = "Staff Name";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Staff Name";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 200;
            gridViewDateTimeColumn3.FieldName = "Doj";
            gridViewDateTimeColumn3.FormatString = "{0:dd-MMMM-yyyy}";
            gridViewDateTimeColumn3.HeaderText = "Doj";
            gridViewDateTimeColumn3.IsAutoGenerated = true;
            gridViewDateTimeColumn3.Name = "Doj";
            gridViewDateTimeColumn3.Width = 120;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn4,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewDateTimeColumn3});
            this.radGridView1.MasterTemplate.DataSource = this.staffBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(529, 546);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "TelerikMetroBlue";
            this.radGridView1.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellClick);
            this.radGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.radGridView1_KeyDown);
            this.radGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.radGridView1_KeyUp);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.staffPFDataSet;
            // 
            // staffPFDataSet
            // 
            this.staffPFDataSet.DataSetName = "StaffPFDataSet";
            this.staffPFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // allowanceTypeBindingSource
            // 
            this.allowanceTypeBindingSource.DataMember = "AllowanceType";
            this.allowanceTypeBindingSource.DataSource = this.allowanceDataSet;
            // 
            // allowanceTypeTableAdapter
            // 
            this.allowanceTypeTableAdapter.ClearBeforeFill = true;
            // 
            // ProvidentFund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 679);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "ProvidentFund";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ProvidentFund";
            this.ThemeName = "TelerikMetroBlue";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProvidentFund_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowanceTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffPFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allowanceTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadGridView radGridView2;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private StaffPFDataSet staffPFDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private StaffPFDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private AllowanceDataSet allowanceDataSet;
        private System.Windows.Forms.BindingSource allowanceTypeBindingSource;
        private AllowanceDataSetTableAdapters.AllowanceTypeTableAdapter allowanceTypeTableAdapter;
        private System.Windows.Forms.BindingSource allowanceTypeBindingSource1;
    }
}
