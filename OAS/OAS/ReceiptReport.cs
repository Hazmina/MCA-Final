using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace OAS
{
    public partial class ReceiptReport : Telerik.WinControls.UI.RadForm
    {
        public ReceiptReport()
        {
            InitializeComponent();
        }

        private void ReceiptReport_Load(object sender, EventArgs e)
        {

        }

        private void dtTo_CloseUp(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'receiptReportDataSet.ReciptDetail' table. You can move, or remove it, as needed.
            this.reciptDetailTableAdapter.Fill(this.receiptReportDataSet.ReciptDetail, dtFrom.Value, dtTo.Value);
            this.reportViewer1.RefreshReport();
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
