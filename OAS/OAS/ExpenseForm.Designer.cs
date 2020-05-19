namespace OAS
{
    partial class ExpenseForm
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
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblErrdesc = new Telerik.WinControls.UI.RadLabel();
            this.lblErrAmt = new Telerik.WinControls.UI.RadLabel();
            this.lblErrIN = new Telerik.WinControls.UI.RadLabel();
            this.lblErrPT = new Telerik.WinControls.UI.RadLabel();
            this.txtAmt = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.cmbExpType = new System.Windows.Forms.ComboBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.dtPaidDate = new System.Windows.Forms.DateTimePicker();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.txtDesc = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtPaidTo = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtInvoice = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnEdit = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrdesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnEdit);
            this.radGroupBox1.Controls.Add(this.lblErrdesc);
            this.radGroupBox1.Controls.Add(this.lblErrAmt);
            this.radGroupBox1.Controls.Add(this.lblErrIN);
            this.radGroupBox1.Controls.Add(this.lblErrPT);
            this.radGroupBox1.Controls.Add(this.txtAmt);
            this.radGroupBox1.Controls.Add(this.cmbExpType);
            this.radGroupBox1.Controls.Add(this.radLabel6);
            this.radGroupBox1.Controls.Add(this.btnSave);
            this.radGroupBox1.Controls.Add(this.dtPaidDate);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.txtDesc);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.txtPaidTo);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.txtInvoice);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.HeaderText = "Add Expense Detail";
            this.radGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(651, 349);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Add Expense Detail";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            this.radGroupBox1.Click += new System.EventHandler(this.radGroupBox1_Click);
            // 
            // lblErrdesc
            // 
            this.lblErrdesc.ForeColor = System.Drawing.Color.Red;
            this.lblErrdesc.Location = new System.Drawing.Point(430, 164);
            this.lblErrdesc.Name = "lblErrdesc";
            this.lblErrdesc.Size = new System.Drawing.Size(11, 18);
            this.lblErrdesc.TabIndex = 16;
            this.lblErrdesc.Text = "*";
            this.lblErrdesc.ThemeName = "ControlDefault";
            // 
            // lblErrAmt
            // 
            this.lblErrAmt.ForeColor = System.Drawing.Color.Red;
            this.lblErrAmt.Location = new System.Drawing.Point(102, 163);
            this.lblErrAmt.Name = "lblErrAmt";
            this.lblErrAmt.Size = new System.Drawing.Size(11, 18);
            this.lblErrAmt.TabIndex = 15;
            this.lblErrAmt.Text = "*";
            this.lblErrAmt.ThemeName = "ControlDefault";
            // 
            // lblErrIN
            // 
            this.lblErrIN.ForeColor = System.Drawing.Color.Red;
            this.lblErrIN.Location = new System.Drawing.Point(158, 100);
            this.lblErrIN.Name = "lblErrIN";
            this.lblErrIN.Size = new System.Drawing.Size(11, 18);
            this.lblErrIN.TabIndex = 14;
            this.lblErrIN.Text = "*";
            this.lblErrIN.ThemeName = "ControlDefault";
            // 
            // lblErrPT
            // 
            this.lblErrPT.ForeColor = System.Drawing.Color.Red;
            this.lblErrPT.Location = new System.Drawing.Point(403, 98);
            this.lblErrPT.Name = "lblErrPT";
            this.lblErrPT.Size = new System.Drawing.Size(11, 18);
            this.lblErrPT.TabIndex = 13;
            this.lblErrPT.Text = "*";
            this.lblErrPT.ThemeName = "ControlDefault";
            // 
            // txtAmt
            // 
            this.txtAmt.Culture = new System.Globalization.CultureInfo("en-IN");
            this.txtAmt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAmt.Location = new System.Drawing.Point(31, 190);
            this.txtAmt.Mask = "c";
            this.txtAmt.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.Size = new System.Drawing.Size(282, 30);
            this.txtAmt.TabIndex = 3;
            this.txtAmt.TabStop = false;
            this.txtAmt.Text = "₹ 0.00";
            this.txtAmt.ThemeName = "TelerikMetroBlue";
            // 
            // cmbExpType
            // 
            this.cmbExpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpType.FormattingEnabled = true;
            this.cmbExpType.Location = new System.Drawing.Point(33, 66);
            this.cmbExpType.Name = "cmbExpType";
            this.cmbExpType.Size = new System.Drawing.Size(284, 28);
            this.cmbExpType.TabIndex = 0;
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.radLabel6.Location = new System.Drawing.Point(31, 35);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(110, 25);
            this.radLabel6.TabIndex = 11;
            this.radLabel6.Text = "Expense Type";
            // 
            // dtPaidDate
            // 
            this.dtPaidDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPaidDate.Location = new System.Drawing.Point(31, 258);
            this.dtPaidDate.Name = "dtPaidDate";
            this.dtPaidDate.Size = new System.Drawing.Size(282, 26);
            this.dtPaidDate.TabIndex = 5;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.radLabel5.Location = new System.Drawing.Point(29, 227);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(80, 25);
            this.radLabel5.TabIndex = 8;
            this.radLabel5.Text = "Paid Date";
            // 
            // txtDesc
            // 
            this.txtDesc.AutoSize = false;
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDesc.Location = new System.Drawing.Point(335, 190);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(284, 94);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.radLabel4.Location = new System.Drawing.Point(335, 159);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(92, 25);
            this.radLabel4.TabIndex = 6;
            this.radLabel4.Text = "Description";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.radLabel3.Location = new System.Drawing.Point(29, 159);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(68, 25);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "Amount";
            // 
            // txtPaidTo
            // 
            this.txtPaidTo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPaidTo.Location = new System.Drawing.Point(335, 123);
            this.txtPaidTo.Name = "txtPaidTo";
            this.txtPaidTo.Size = new System.Drawing.Size(284, 30);
            this.txtPaidTo.TabIndex = 2;
            this.txtPaidTo.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.radLabel2.Location = new System.Drawing.Point(335, 92);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(64, 25);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "Paid To";
            // 
            // txtInvoice
            // 
            this.txtInvoice.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtInvoice.Location = new System.Drawing.Point(31, 123);
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(284, 30);
            this.txtInvoice.TabIndex = 1;
            this.txtInvoice.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Microsoft JhengHei Light", 12F);
            this.radLabel1.Location = new System.Drawing.Point(31, 98);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(127, 25);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Invoice Number";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Image = global::OAS.Properties.Resources.if_icon_136_document_edit_314724;
            this.btnCancel.Location = new System.Drawing.Point(222, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 36);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "     Cancel";
            this.btnCancel.ThemeName = "TelerikMetroBlue";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEdit.Image = global::OAS.Properties.Resources.if_icon_136_document_edit_314724;
            this.btnEdit.Location = new System.Drawing.Point(133, 290);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 36);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "   Edit";
            this.btnEdit.ThemeName = "TelerikMetroBlue";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Image = global::OAS.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(29, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.ThemeName = "TelerikMetroBlue";
            this.btnSave.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // ExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 373);
            this.Controls.Add(this.radGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpenseForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.ThemeName = "TelerikMetroBlue";
            this.Load += new System.EventHandler(this.Expense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrdesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblErrPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPaidTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadTextBox txtPaidTo;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtInvoice;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.DateTimePicker dtPaidDate;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox txtDesc;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.ComboBox cmbExpType;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadMaskedEditBox txtAmt;
        private Telerik.WinControls.UI.RadLabel lblErrdesc;
        private Telerik.WinControls.UI.RadLabel lblErrAmt;
        private Telerik.WinControls.UI.RadLabel lblErrIN;
        private Telerik.WinControls.UI.RadLabel lblErrPT;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnEdit;


    }
}
