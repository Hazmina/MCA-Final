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
    public partial class SubjectAllocation : Telerik.WinControls.UI.RadForm
    {
        public SubjectAllocation()
        {
            InitializeComponent();
        }

        private void SubjectAllocation_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'subjectAllocationDataSet.SubjectAllocation' table. You can move, or remove it, as needed.
                this.subjectAllocationTableAdapter.Fill(this.subjectAllocationDataSet.SubjectAllocation);
            }
            catch (Exception exp)
            { 
            
            }
        }
    }
}
