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
    public partial class LeaveTakenReport : Telerik.WinControls.UI.RadForm
    {
        public LeaveTakenReport()
        {
            InitializeComponent();
        }

        private void LeaveTakenReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaveTakenReportDataSet.LeaveTaken' table. You can move, or remove it, as needed.
            this.leaveTakenTableAdapter1.Fill(this.leaveTakenReportDataSet.LeaveTaken);
            // TODO: This line of code loads data into the 'employeeListSalaryDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.employeeListSalaryDataSet.Staff);

        }
    }
}
