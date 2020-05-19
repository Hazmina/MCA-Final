using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using DataBaseLayer;
using BusinessLayer;
using Telerik.WinControls.UI;
using System.IO;

namespace OAS
{
    public partial class PaymentMode : Telerik.WinControls.UI.RadForm
    {
        public PaymentMode()
        {
            InitializeComponent();
        }
        ConvertIntoWord CIW = new ConvertIntoWord();
        public void GenerateReceipt()
        {
            using (StreamWriter writer =
          new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\ChargesReciept.html"))
            {
                writer.WriteLine("<html><head></head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<table style='width:100%;border:1px solid'>");
                writer.WriteLine("<tr style='background-color:skyblue'><td align='center'><font size='7'>Bharuch Welfare School<br /></font>Welfare Dental & Nursing Building<br /> Nr, Manubar Chokdi Road,Bharuch.<br /> Phone:- 02642-112457<br /> <br /></td></tr>");
                writer.WriteLine("<tr><td><table style='width:100%'>");
                writer.WriteLine("<tr><td colspan='4' style='text-align:center'><h1>Receipt</h1></td></tr>");
                writer.WriteLine("<tr><td style='text-align:right'><b>Receipt No:</b></td><td>" + lblRecptNo.Text + "</td><td style='text-align:right'><b>Date of Payment:</b></td><td>" + dateTimePicker1.Value.ToString("dd-MMMM-yyyy") + "</td></tr>");
                writer.WriteLine("<tr><td style='text-align:right'><b>Receipt For:</b></td><td>" + cmbMonth.Text + "</td></tr>");
                writer.WriteLine("<tr><td style='width:18%;text-align:right'><b>Received From:</b></td><td>" + lblStudName.Text + "</td><td style='text-align:right'><b>Amount:</b></td><td>" + cmbMonth.SelectedValue + "</td></tr>");
                writer.WriteLine("<tr><td style='text-align:right'><b>In Words:</b></td><td>" + CIW.NumWordsWrapper(Convert.ToDouble(cmbMonth.SelectedValue)) + "</td><td style='text-align:right'><b>Payment Mode:</b></td><td>" + Pay + "</td></tr>");
                writer.WriteLine("<tr><td style='text-align:right'><b>Reference No.:</b></td><td>" + txtReference.Text + "</td></tr>");
                writer.WriteLine("<tr><td colspan='4' style='text-align:right'><br /><br /><b>Bharuch Welfare School</b>&nbsp;&nbsp;&nbsp;&nbsp;<br /> <br /> <br /><b>Administrative Signature</b>&nbsp;&nbsp;&nbsp;</td></tr>");
                writer.WriteLine("</table></td></tr></table>");
                writer.WriteLine("</body></html>");
            }
        }
        string Pay = "Cash";
        public Image Img;
        ManageReceipt MR = new ManageReceipt();
        private void PaymentMode_Load(object sender, EventArgs e)
        {
            Fetch();
        }
        public void Fetch()
        {
            StudPic.Image = Img;
            int Cnt = MR.GetRecptNo();
            Cnt++;
            lblRecptNo.Text = Cnt.ToString();

            MR.PopulateCharge(cmbMonth);
            cmbMonth.Text = "Select Receipt For";
        }
        int cnt = 0;
        public void IsEmpty(RadTextBox txt, RadLabel lbl)
        {
            if (txt.Text == "")
            {
                cnt++;
                lbl.Text = "*Required";
            }
            else
            {
                lbl.Text = "*";
            }
        }

        public void TextLimit(RadTextBox txt, RadLabel lbl, int limit)
        {
            if (txt.Text.Length > limit)
            {
                cnt++;
                lbl.Text = "*Not More Then " + limit;
            }
            else
            {
                if (txt.Text == "")
                {
                    lbl.Text = "*Required";
                }
                else
                {
                    lbl.Text = "*";
                }
            }

        }

        public void Validation()
        {
            cnt = 0;
            if (Pay != "Cash")
            {
                IsEmpty(txtReference, lblErrRef);
            }
            else
            {
                lblErrRef.Text = "*";
            }
            if (cmbMonth.Text == "Select Receipt For")
            {
                cnt++;
                lblErrRecptFor.Text = "*Required";
            }
            else
            {
                lblErrRecptFor.Text = "*";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Validation();
            if (cnt == 0)
            {
                ReciptDetail RD = new ReciptDetail();
                RD.Amt = Convert.ToInt32(cmbMonth.SelectedValue);
                RD.Rec_Date = dateTimePicker1.Value;
                RD.RecieptFor = cmbMonth.Text;
                RD.Reference = txtReference.Text;
                RD.P_Mode = Pay;
                RD.RecieptFrom = lblStudName.Text;
                MR.AddReceipt(RD);
                GenerateReceipt();
                Fetch();
                
            }
        }

        private void rdbBank_Click(object sender, EventArgs e)
        {
            Pay = "Bank/NEFT";
        }

        private void rdbDD_Click(object sender, EventArgs e)
        {
            Pay = "DD";
        }

        private void rdbBhim_Click(object sender, EventArgs e)
        {
            Pay = "Bhim";
        }

        private void rdbPaytm_Click(object sender, EventArgs e)
        {
            Pay = "Paytm";
        }

        private void rdbCheque_Click(object sender, EventArgs e)
        {
            Pay = "Cheque";
        }

        private void rdbCash_Click(object sender, EventArgs e)
        {
            Pay = "Cash";
        }
    }
}
