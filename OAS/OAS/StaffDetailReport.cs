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
    public partial class StaffDetailReport : Telerik.WinControls.UI.RadForm
    {
        public StaffDetailReport()
        {
            InitializeComponent();
        }

        private void StaffDetailReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.staffDataSet.Staff);

        }
    }
}
