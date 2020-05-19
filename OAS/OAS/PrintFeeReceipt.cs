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
    public partial class PrintFeeReceipt : Telerik.WinControls.UI.RadForm
    {
        public PrintFeeReceipt()
        {
            InitializeComponent();
        }

        private void PrintFeeReceipt_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Url = new Uri(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FeeReceipt.html");
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }
    }
}
