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
    public partial class BonofiedReport : Telerik.WinControls.UI.RadForm
    {
        public BonofiedReport()
        {
            InitializeComponent();
        }

        private void BonofiedReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bonofiedReportDataSet.Bonofied' table. You can move, or remove it, as needed.
            this.bonofiedTableAdapter.Fill(this.bonofiedReportDataSet.Bonofied, dtFrom.Value, dtTo.Value);

            this.reportViewer1.RefreshReport();
        }

        private void dtTo_CloseUp(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bonofiedReportDataSet.Bonofied' table. You can move, or remove it, as needed.
           
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
