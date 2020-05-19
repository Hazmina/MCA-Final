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
    public partial class SalaryHistory : Telerik.WinControls.UI.RadForm
    {
        public SalaryHistory()
        {
            InitializeComponent();
        }

        private void SalaryHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDetailAttendenceDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.staffDetailAttendenceDataSet.Staff);
            // TODO: This line of code loads data into the 'salaryHistoryDataSet.SalaryDetail' table. You can move, or remove it, as needed.
            this.salaryDetailTableAdapter.Fill(this.salaryHistoryDataSet.SalaryDetail, Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
        }

        private void radGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'salaryHistoryDataSet.SalaryDetail' table. You can move, or remove it, as needed.
                this.salaryDetailTableAdapter.Fill(this.salaryHistoryDataSet.SalaryDetail, Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
            }
            catch (Exception CellClickExp)
            {

            }
        }

        private void radGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'salaryHistoryDataSet.SalaryDetail' table. You can move, or remove it, as needed.
                this.salaryDetailTableAdapter.Fill(this.salaryHistoryDataSet.SalaryDetail, Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
            }
            catch (Exception KeyUpExp)
            {

            }
        }

        private void radGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'salaryHistoryDataSet.SalaryDetail' table. You can move, or remove it, as needed.
                this.salaryDetailTableAdapter.Fill(this.salaryHistoryDataSet.SalaryDetail, Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
            }
            catch (Exception KeyDownExp)
            {

            }
        }
    }
}
