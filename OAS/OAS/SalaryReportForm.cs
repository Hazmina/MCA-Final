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
    public partial class SalaryReportForm : Telerik.WinControls.UI.RadForm
    {
        public SalaryReportForm()
        {
            InitializeComponent();
        }

        private void SalaryReportForm_Load(object sender, EventArgs e)
        {
            
        }

        private void dtTo_CloseUp(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalaryReportDataSet.SalaryDetail' table. You can move, or remove it, as needed.
            this.SalaryDetailTableAdapter.Fill(this.SalaryReportDataSet.SalaryDetail, dtFrom.Value.ToString(), dtTo.Value.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
