namespace OAS
{
    partial class ManageFeeDetailForm
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn2 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn3 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.lblErrAmt = new Telerik.WinControls.UI.RadLabel();
            this.txtAmt = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.lblErrFeeType = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtFeeType = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.feeDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feeDetailDataSet = new OAS.FeeDetailDataSet();
            this.feeDetailTableAdapter = new OAS.FeeDetailDataSetTableAdapters.FeeDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrFeeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeDetailDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnEdit);
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnSave);
            this.radGroupBox1.Controls.Add(this.lblErrAmt);
            this.radGroupBox1.Controls.Add(this.txtAmt);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.lblErrFeeType);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.txtFeeType);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.cmbClass);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.HeaderText = "Fee Detail";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(654, 205);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Fee Detail";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEdit.Image = global::OAS.Properties.Resources.if_icon_136_document_edit_314724;
            this.btnEdit.Location = new System.Drawing.Point(121, 156);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 36);
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Text = "   Edit";
            this.btnEdit.ThemeName = "TelerikMetroBlue";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Image = global::OAS.Properties.Resources.if_icon_136_document_edit_314724;
            this.btnCancel.Location = new System.Drawing.Point(210, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 36);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "     Cancel";
            this.btnCancel.ThemeName = "TelerikMetroBlue";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Image = global::OAS.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(17, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 36);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeName = "TelerikMetroBlue";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblErrAmt
            // 
            this.lblErrAmt.ForeColor = System.Drawing.Color.Red;
            this.lblErrAmt.Location = new System.Drawing.Point(394, 93);
            this.lblErrAmt.Name = "lblErrAmt";
            this.lblErrAmt.Size = new System.Drawing.Size(11, 18);
            this.lblErrAmt.TabIndex = 24;
            this.lblErrAmt.Text = "*";
            this.lblErrAmt.ThemeName = "ControlDefault";
            // 
            // txtAmt
            // 
            this.txtAmt.Culture = new System.Globalization.CultureInfo("en-IN");
            this.txtAmt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAmt.Location = new System.Drawing.Point(323, 120);
            this.txtAmt.Mask = "c";
            this.txtAmt.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(282, 30);
            this.txtAmt.TabIndex = 21;
            this.txtAmt.TabStop = false;
            this.txtAmt.Text = "₹ 0.00";
            this.txtAmt.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.radLabel3.Location = new System.Drawing.Point(321, 89);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(68, 25);
            this.radLabel3.TabIndex = 22;
            this.radLabel3.Text = "Amount";
            // 
            // lblErrFeeType
            // 
            this.lblErrFeeType.ForeColor = System.Drawing.Color.Red;
            this.lblErrFeeType.Location = new System.Drawing.Point(98, 102);
            this.lblErrFeeType.Name = "lblErrFeeType";
            this.lblErrFeeType.Size = new System.Drawing.Size(11, 18);
            this.lblErrFeeType.TabIndex = 20;
            this.lblErrFeeType.Text = "*";
            this.lblErrFeeType.ThemeName = "ControlDefault";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.radLabel2.Location = new System.Drawing.Point(321, 89);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(2, 2);
            this.radLabel2.TabIndex = 18;
            // 
            // txtFeeType
            // 
            this.txtFeeType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFeeType.Location = new System.Drawing.Point(17, 120);
            this.txtFeeType.Name = "txtFeeType";
            this.txtFeeType.Size = new System.Drawing.Size(284, 30);
            this.txtFeeType.TabIndex = 16;
            this.txtFeeType.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.radLabel1.Location = new System.Drawing.Point(17, 95);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(75, 25);
            this.radLabel1.TabIndex = 15;
            this.radLabel1.Text = "Fee Type";
            // 
            // cmbClass
            // 
            this.cmbClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(17, 61);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(284, 28);
            this.cmbClass.TabIndex = 13;
            this.cmbClass.DropDownClosed += new System.EventHandler(this.cmbClass_DropDownClosed);
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.radLabel6.Location = new System.Drawing.Point(17, 30);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(45, 25);
            this.radLabel6.TabIndex = 12;
            this.radLabel6.Text = "Class";
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 223);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn1.DataType = typeof(int);
            gridViewDecimalColumn1.FieldName = "FeeDetailid";
            gridViewDecimalColumn1.HeaderText = "FeeDetailid";
            gridViewDecimalColumn1.IsAutoGenerated = true;
            gridViewDecimalColumn1.IsVisible = false;
            gridViewDecimalColumn1.Name = "FeeDetailid";
            gridViewDecimalColumn1.ReadOnly = true;
            gridViewDecimalColumn2.DataType = typeof(int);
            gridViewDecimalColumn2.FieldName = "Classid";
            gridViewDecimalColumn2.HeaderText = "Classid";
            gridViewDecimalColumn2.IsAutoGenerated = true;
            gridViewDecimalColumn2.IsVisible = false;
            gridViewDecimalColumn2.Name = "Classid";
            gridViewDecimalColumn2.VisibleInColumnChooser = false;
            gridViewTextBoxColumn1.FieldName = "FeeType";
            gridViewTextBoxColumn1.HeaderText = "FeeType";
            gridViewTextBoxColumn1.IsAutoGenerated = true;
            gridViewTextBoxColumn1.Name = "FeeType";
            gridViewTextBoxColumn1.Width = 350;
            gridViewDecimalColumn3.DataType = typeof(double);
            gridViewDecimalColumn3.FieldName = "Amount";
            gridViewDecimalColumn3.HeaderText = "Amount";
            gridViewDecimalColumn3.IsAutoGenerated = true;
            gridViewDecimalColumn3.Name = "Amount";
            gridViewDecimalColumn3.Width = 150;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn1,
            gridViewDecimalColumn2,
            gridViewTextBoxColumn1,
            gridViewDecimalColumn3});
            this.radGridView1.MasterTemplate.DataSource = this.feeDetailBindingSource;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(654, 245);
            this.radGridView1.TabIndex = 1;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "TelerikMetroBlue";
            this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_CellFormatting);
            this.radGridView1.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellClick);
            this.radGridView1.GroupSummaryEvaluate += new Telerik.WinControls.UI.GroupSummaryEvaluateEventHandler(this.radGridView1_GroupSummaryEvaluate);
            // 
            // feeDetailBindingSource
            // 
            this.feeDetailBindingSource.DataMember = "FeeDetail";
            this.feeDetailBindingSource.DataSource = this.feeDetailDataSet;
            // 
            // feeDetailDataSet
            // 
            this.feeDetailDataSet.DataSetName = "FeeDetailDataSet";
            this.feeDetailDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feeDetailTableAdapter
            // 
            this.feeDetailTableAdapter.ClearBeforeFill = true;
            // 
            // ManageFeeDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 485);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "ManageFeeDetailForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageFeeDetail";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.ManageFeeDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrFeeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFeeType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeDetailDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private System.Windows.Forms.ComboBox cmbClass;
        private Telerik.WinControls.UI.RadLabel lblErrFeeType;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtFeeType;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel lblErrAmt;
        private Telerik.WinControls.UI.RadMaskedEditBox txtAmt;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private FeeDetailDataSet feeDetailDataSet;
        private System.Windows.Forms.BindingSource feeDetailBindingSource;
        private FeeDetailDataSetTableAdapters.FeeDetailTableAdapter feeDetailTableAdapter;
        private Telerik.WinControls.UI.RadButton btnEdit;
    }
}
