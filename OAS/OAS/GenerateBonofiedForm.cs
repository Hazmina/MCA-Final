using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using BusinessLayer;
using DataBaseLayer;

namespace OAS
{
    public partial class GenerateBonofiedForm : Telerik.WinControls.UI.RadForm
    {
        public GenerateBonofiedForm()
        {
            InitializeComponent();
        }

        private void GenerateBonofiedForm_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BonofiedCertificate.html");
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
        public int classId;
        public string GrNo;
        ManageBonoFiedCerti MBFC = new ManageBonoFiedCerti();
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Bonofied B = new Bonofied();
            B.Gr_No = GrNo;
            B.Class_Id = classId;
            B.Date_Of_Generation = System.DateTime.Today;
            MBFC.AddBonofied(B);
            webBrowser1.ShowPrintPreviewDialog();
        }
    }
}
