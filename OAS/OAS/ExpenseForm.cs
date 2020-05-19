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
using System.Speech.Synthesis;
namespace OAS
{
    public partial class ExpenseForm : Telerik.WinControls.UI.RadForm
    {
        int cnt = 0;
        public ExpenseForm()
        {
            InitializeComponent();
        }
        ManageExpenseData MED = new ManageExpenseData();
        public int ExpId = 0;
        private void Expense_Load(object sender, EventArgs e)
        {
            MED.PopulateExpenseType(cmbExpType);
            if (ExpId != 0)
            {
                Expense Exp = new Expense();
                Exp = MED.FetchData(ExpId);
                txtPaidTo.Text = Exp.PaidTo;
                txtDesc.Text = Exp.Description;
                txtInvoice.Text = Exp.InvoiceNo;
                cmbExpType.SelectedValue = Exp.ExptypeId;
                txtAmt.Text = Exp.Amount.ToString();
                dtPaidDate.Value = Convert.ToDateTime(Exp.PaidDate);
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
            }
            else
            {
                Clear();
            }
        }

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

        public void TextLimit(RadTextBox txt, RadLabel lbl,int limit)
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
                    cnt++;
                    lbl.Text = "*Required";
                }
                else
                {
                    lbl.Text = "*";
                }
            }
           
        }
        public void Speech(string Message)
        {
            SpeechSynthesizer Sapi = new SpeechSynthesizer();
            Sapi.SpeakAsync(Message);
        }
        public void Validation()
        {
            cnt = 0;
            IsEmpty(txtInvoice, lblErrIN);
            TextLimit(txtInvoice, lblErrIN, 18);

            IsEmpty(txtPaidTo, lblErrPT);
            TextLimit(txtPaidTo, lblErrPT, 18);

            IsEmpty(txtDesc, lblErrdesc);

            if (txtAmt.Text == "₹ 0.00")
            {
                cnt++;
                lblErrAmt.Text = "*Required";
            }
            else
            {
                lblErrAmt.Text = "*";
            }
        }

        StringHandling Sh = new StringHandling();

        public void Clear()
        {
            txtAmt.Text = "";
            txtDesc.Text = "";
            txtInvoice.Text = "";
            txtPaidTo.Text = "";
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            Validation();
            if (cnt == 0)
            {
                Expense Exp = new Expense();
                Exp.InvoiceNo = txtInvoice.Text;
                Exp.Amount = Convert.ToDouble(Sh.ExtractDecimalFromString(txtAmt.Text));
                Exp.PaidTo = txtPaidTo.Text;
                Exp.Description = txtDesc.Text;
                Exp.PaidDate = Convert.ToDateTime(dtPaidDate.Value);
                Exp.EntryDate = System.DateTime.Today;
                Exp.ExptypeId = Convert.ToInt32(cmbExpType.SelectedValue);
                MED.AddExpenseData(Exp);
                Clear();
                Speech("Successfully Saved");
                MessageBox.Show("Successfully Saved");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Validation();
            if (cnt == 0)
            {
                Expense Exp = new Expense();
                Exp = MED.FetchData(ExpId);
                Exp.InvoiceNo = txtInvoice.Text;
                Exp.Amount = Convert.ToDouble(Sh.ExtractDecimalFromString(txtAmt.Text));
                Exp.PaidTo = txtPaidTo.Text;
                Exp.Description = txtDesc.Text;
                Exp.PaidDate = Convert.ToDateTime(dtPaidDate.Value);
                Exp.ExptypeId = Convert.ToInt32(cmbExpType.SelectedValue);
                MED.EditData(Exp);
                Speech("Successfully Changed");
                MessageBox.Show("Successfully Changed");
                this.Dispose();
            }
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }   
}
