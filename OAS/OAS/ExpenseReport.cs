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
    public partial class ExpenseReport : Telerik.WinControls.UI.RadForm
    {
        public ExpenseReport()
        {
            InitializeComponent();
        }

        private void ExpenseReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expenseReportDataSet.Expense' table. You can move, or remove it, as needed.
           

         
        }

        private void dtTo_CloseUp(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expenseReportDataSet.Expense' table. You can move, or remove it, as needed.
            this.expenseTableAdapter.Fill(this.expenseReportDataSet.Expense, dtFrom.Value, dtTo.Value);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
