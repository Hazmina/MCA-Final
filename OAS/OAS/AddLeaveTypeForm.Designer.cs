namespace OAS
{
    partial class AddLeaveTypeForm
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
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn5 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDecimalColumn gridViewDecimalColumn6 = new Telerik.WinControls.UI.GridViewDecimalColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblErrNoL = new Telerik.WinControls.UI.RadLabel();
            this.txtNoL = new Telerik.WinControls.UI.RadTextBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnCancle = new Telerik.WinControls.UI.RadButton();
            this.lblErrLeave = new Telerik.WinControls.UI.RadLabel();
            this.txtLevName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.leaveTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveTypeDataSet = new OAS.LeaveTypeDataSet();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.leaveTypeTableAdapter = new OAS.LeaveTypeDataSetTableAdapters.LeaveTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrNoL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLevName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTypeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.lblErrNoL);
            this.radGroupBox1.Controls.Add(this.txtNoL);
            this.radGroupBox1.Controls.Add(this.btnSave);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.btnEdit);
            this.radGroupBox1.Controls.Add(this.btnCancle);
            this.radGroupBox1.Controls.Add(this.lblErrLeave);
            this.radGroupBox1.Controls.Add(this.txtLevName);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radGroupBox1.HeaderText = "Leave Type";
            this.radGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(575, 166);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Leave Type";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // lblErrNoL
            // 
            this.lblErrNoL.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblErrNoL.ForeColor = System.Drawing.Color.Red;
            this.lblErrNoL.Location = new System.Drawing.Point(390, 33);
            this.lblErrNoL.Name = "lblErrNoL";
            this.lblErrNoL.Size = new System.Drawing.Size(15, 25);
            this.lblErrNoL.TabIndex = 4;
            this.lblErrNoL.Text = "*";
            this.lblErrNoL.ThemeName = "TelerikMetroTouch";
            // 
            // txtNoL
            // 
            this.txtNoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNoL.Location = new System.Drawing.Point(295, 62);
            this.txtNoL.Name = "txtNoL";
            this.txtNoL.NullText = "Enter the No of Leave";
            this.txtNoL.Size = new System.Drawing.Size(262, 27);
            this.txtNoL.TabIndex = 3;
            this.txtNoL.ThemeName = "TelerikMetroBlue";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Image = global::OAS.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(9, 104);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 36);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.ThemeName = "TelerikMetroBlue";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radLabel3.Location = new System.Drawing.Point(295, 33);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(96, 22);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "No of Leave";
            this.radLabel3.ThemeName = "TelerikMetroTouch";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEdit.Image = global::OAS.Properties.Resources.if_icon_136_document_edit_314724;
            this.btnEdit.Location = new System.Drawing.Point(92, 104);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.ThemeName = "TelerikMetroBlue";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancle.Image = global::OAS.Properties.Resources.close_window_32;
            this.btnCancle.Location = new System.Drawing.Point(169, 104);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(99, 36);
            this.btnCancle.TabIndex = 4;
            this.btnCancle.Text = "Cancel";
            this.btnCancle.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancle.ThemeName = "TelerikMetroBlue";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // lblErrLeave
            // 
            this.lblErrLeave.ForeColor = System.Drawing.Color.Red;
            this.lblErrLeave.Location = new System.Drawing.Point(104, 33);
            this.lblErrLeave.Name = "lblErrLeave";
            this.lblErrLeave.Size = new System.Drawing.Size(14, 23);
            this.lblErrLeave.TabIndex = 1;
            this.lblErrLeave.Text = "*";
            this.lblErrLeave.ThemeName = "TelerikMetroTouch";
            // 
            // txtLevName
            // 
            this.txtLevName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLevName.Location = new System.Drawing.Point(9, 62);
            this.txtLevName.Name = "txtLevName";
            this.txtLevName.NullText = "Enter the Leave Name";
            this.txtLevName.Size = new System.Drawing.Size(259, 27);
            this.txtLevName.TabIndex = 1;
            this.txtLevName.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radLabel1.Location = new System.Drawing.Point(9, 33);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(101, 22);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Leave Name";
            this.radLabel1.ThemeName = "TelerikMetroTouch";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.radGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.radGroupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.06122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.93877F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 613);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.White;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(3, 175);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.AllowColumnReorder = false;
            gridViewDecimalColumn5.DataType = typeof(int);
            gridViewDecimalColumn5.EnableExpressionEditor = false;
            gridViewDecimalColumn5.FieldName = "Ltype_Id";
            gridViewDecimalColumn5.HeaderText = "Ltype_Id";
            gridViewDecimalColumn5.IsAutoGenerated = true;
            gridViewDecimalColumn5.IsVisible = false;
            gridViewDecimalColumn5.Name = "Ltype_Id";
            gridViewDecimalColumn5.ReadOnly = true;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "L_Name";
            gridViewTextBoxColumn3.HeaderText = "L_Name";
            gridViewTextBoxColumn3.IsAutoGenerated = true;
            gridViewTextBoxColumn3.Name = "Leave Name";
            gridViewTextBoxColumn3.Width = 300;
            gridViewDecimalColumn6.DataType = typeof(int);
            gridViewDecimalColumn6.EnableExpressionEditor = false;
            gridViewDecimalColumn6.FieldName = "No_Leave";
            gridViewDecimalColumn6.HeaderText = "No_Leave";
            gridViewDecimalColumn6.IsAutoGenerated = true;
            gridViewDecimalColumn6.Name = "No. of Leave";
            gridViewDecimalColumn6.Width = 200;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewDecimalColumn5,
            gridViewTextBoxColumn3,
            gridViewDecimalColumn6});
            this.radGridView1.MasterTemplate.DataSource = this.leaveTypeBindingSource;
            this.radGridView1.MasterTemplate.EnableFiltering = true;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.ShowGroupPanel = false;
            this.radGridView1.Size = new System.Drawing.Size(575, 435);
            this.radGridView1.TabIndex = 5;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "TelerikMetroBlue";
            this.radGridView1.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.radGridView1_CellFormatting);
            this.radGridView1.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.radGridView1_CellClick);
            // 
            // leaveTypeBindingSource
            // 
            this.leaveTypeBindingSource.DataMember = "LeaveType";
            this.leaveTypeBindingSource.DataSource = this.leaveTypeDataSet;
            // 
            // leaveTypeDataSet
            // 
            this.leaveTypeDataSet.DataSetName = "LeaveTypeDataSet";
            this.leaveTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveTypeTableAdapter
            // 
            this.leaveTypeTableAdapter.ClearBeforeFill = true;
            // 
            // AddLeaveTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 613);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddLeaveTypeForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "AddLeaveTypeForm";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.AddLeaveTypeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrNoL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLevName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveTypeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel lblErrNoL;
        private Telerik.WinControls.UI.RadTextBox txtNoL;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnEdit;
        private Telerik.WinControls.UI.RadButton btnCancle;
        private Telerik.WinControls.UI.RadLabel lblErrLeave;
        private Telerik.WinControls.UI.RadTextBox txtLevName;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private LeaveTypeDataSet leaveTypeDataSet;
        private System.Windows.Forms.BindingSource leaveTypeBindingSource;
        private LeaveTypeDataSetTableAdapters.LeaveTypeTableAdapter leaveTypeTableAdapter;
    }
}
