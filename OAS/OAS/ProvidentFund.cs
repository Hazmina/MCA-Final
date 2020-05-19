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
    public partial class ProvidentFund : Telerik.WinControls.UI.RadForm
    {
        public ProvidentFund()
        {
            InitializeComponent();
        }

        private void ProvidentFund_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'staffPFDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.staffPFDataSet.Staff);
            // TODO: This line of code loads data into the 'allowanceDataSet.AllowanceType' table. You can move, or remove it, as needed.
            this.allowanceTypeTableAdapter.Fill(this.allowanceDataSet.AllowanceType, Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));

        }

        private void radGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            // TODO: This line of code loads data into the 'allowanceDataSet.AllowanceType' table. You can move, or remove it, as needed.
            this.allowanceTypeTableAdapter.Fill(this.allowanceDataSet.AllowanceType, Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
        }

        private void radGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            // TODO: This line of code loads data into the 'allowanceDataSet.AllowanceType' table. You can move, or remove it, as needed.
            this.allowanceTypeTableAdapter.Fill(this.allowanceDataSet.AllowanceType, Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
        }

        private void radGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            // TODO: This line of code loads data into the 'allowanceDataSet.AllowanceType' table. You can move, or remove it, as needed.
            this.allowanceTypeTableAdapter.Fill(this.allowanceDataSet.AllowanceType, Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
        }
    }
}
