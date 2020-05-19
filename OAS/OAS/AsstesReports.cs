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
    public partial class AsstesReports : Telerik.WinControls.UI.RadForm
    {
        public AsstesReports()
        {
            InitializeComponent();
        }

        private void AsstesReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assetsReportDataSet.Assets' table. You can move, or remove it, as needed.
            this.assetsTableAdapter.Fill(this.assetsReportDataSet.Assets);

        }
    }
}
