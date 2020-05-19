namespace OAS
{
    partial class ExpenseTypeForm
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn4 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition4 = new Telerik.WinControls.UI.TableViewDefinition();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblErrExp = new Telerik.WinControls.UI.RadLabel();
            this.txtInvoice = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.expenseTypeDataSet = new OAS.ExpenseTypeDataSet();
            this.expenseTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expenseTypeTableAdapter = new OAS.ExpenseTypeDataSetTableAdapters.ExpenseTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radGridView1);
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnEdit);
            this.radGroupBox1.Controls.Add(this.btnSave);
            this.radGroupBox1.Controls.Add(this.lblErrExp);
            this.radGroupBox1.Controls.Add(this.txtInvoice);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Expense Type";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(478, 469);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Expense Type";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // lblErrExp
            // 
            this.lblErrExp.ForeColor = System.Drawing.Color.Red;
            this.lblErrExp.Location = new System.Drawing.Point(141, 40);
            this.lblErrExp.Name = "lblErrExp";
            this.lblErrExp.Size = new System.Drawing.Size(11, 18);
            this.lblErrExp.TabIndex = 17;
            this.lblErrExp.Text = "*";
            this.lblErrExp.ThemeName = "ControlDefault";
            // 
            // txtInvoice
            // 
            this.txtInvoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtInvoice.Location = new System.Drawing.Point(25, 64);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(284, 30);
            this.txtInvoice.TabIndex = 16;
            this.txtInvoice.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.radLabel1.Location = new System.Drawing.Point(25, 39);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(110, 25);
            this.radLabel1.TabIndex = 15;
            this.radLabel1.Text = "Expense Type";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Image = global::OAS.Properties.Resources.if_icon_136_document_edit_314724;
            this.btnCancel.Location = new System.Drawing.Point(218, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 36);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "     Cancel";
            this.btnCancel.ThemeName = "TelerikMetroBlue";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEdit.Image = global::OAS.Properties.Resources.if_icon_136_document_edit_314724;
            this.btnEdit.Location = new System.Drawing.Point(129, 100);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 36);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "   Edit";
            this.btnEdit.ThemeName = "TelerikMetroBlue";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Image = global::OAS.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(25, 100);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 36);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeName = "TelerikMetroBlue";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(25, 142);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn4.DataType = typeof(int);
            gridViewDecimalColumn4.FieldName = "ExpTypeId";
            gridViewDecimalColumn4.HeaderText = "ExpTypeId";
            gridViewDecimalColumn4.IsAutoGenerated = true;
            gridViewDecimalColumn4.IsVisible = false;
            gridViewDecimalColumn4.Name = "ExpTypeId";
            gridViewDecimalColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.FieldName = "ExpType";
            gridViewTextBoxColumn4.HeaderText = "ExpType";
            gridViewTextBoxColumn4.IsAutoGenerated = true;
            gridViewTextBoxColumn4.Name = "ExpType";
            gridViewTextBoxColumn4.Width = 290;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn4,
            gridViewTextBoxColumn4});
            this.radGridView1.MasterTemplate.DataSource = this.expenseTypeBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition4;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(426, 304);
            this.radGridView1.TabIndex = 22;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "TelerikMetroBlue";
            this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_CellFormatting);
            this.radGridView1.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellClick);
            // 
            // expenseTypeDataSet
            // 
            this.expenseTypeDataSet.DataSetName = "ExpenseTypeDataSet";
            this.expenseTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expenseTypeBindingSource
            // 
            this.expenseTypeBindingSource.DataMember = "ExpenseType";
            this.expenseTypeBindingSource.DataSource = this.expenseTypeDataSet;
            // 
            // expenseTypeTableAdapter
            // 
            this.expenseTypeTableAdapter.ClearBeforeFill = true;
            // 
            // ExpenseTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 493);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ExpenseTypeForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpenseTypeForm";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.ExpenseTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel lblErrExp;
        private Telerik.WinControls.UI.RadTextBox txtInvoice;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private ExpenseTypeDataSet expenseTypeDataSet;
        private System.Windows.Forms.BindingSource expenseTypeBindingSource;
        private ExpenseTypeDataSetTableAdapters.ExpenseTypeTableAdapter expenseTypeTableAdapter;
    }
}
