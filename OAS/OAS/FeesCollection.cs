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
using System.IO;

namespace OAS
{
    public partial class FeesCollection : Telerik.WinControls.UI.RadForm
    {
        public FeesCollection()
        {
            InitializeComponent();
        }
        public Image Img;
        public int ClassId, StudId;
        public string Div,Class;
        public void FetchMonth()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MonthId", System.Type.GetType("System.Int32"));
            dt.Columns.Add("MonthName", System.Type.GetType("System.String"));

            DataRow Sample = dt.NewRow();
            Sample["MonthId"] = 0;
            Sample["MonthName"] = "Select Month";
            dt.Rows.Add(Sample);

            DataRow newrow5 = dt.NewRow();
            newrow5["MonthId"] = 1;
            newrow5["MonthName"] = "June";
            dt.Rows.Add(newrow5);

            DataRow newrow6 = dt.NewRow();
            newrow6["MonthId"] = 2;
            newrow6["MonthName"] = "July";
            dt.Rows.Add(newrow6);

            DataRow newrow7 = dt.NewRow();
            newrow7["MonthId"] = 3;
            newrow7["MonthName"] = "August";
            dt.Rows.Add(newrow7);


            DataRow newrow8 = dt.NewRow();
            newrow8["MonthId"] = 4;
            newrow8["MonthName"] = "September";
            dt.Rows.Add(newrow8);

            DataRow newrow9 = dt.NewRow();
            newrow9["MonthId"] = 5;
            newrow9["MonthName"] = "October";
            dt.Rows.Add(newrow9);

            DataRow newrow10 = dt.NewRow();
            newrow10["MonthId"] = 6;
            newrow10["MonthName"] = "November";
            dt.Rows.Add(newrow10);

            DataRow newrow11 = dt.NewRow();
            newrow11["MonthId"] = 7;
            newrow11["MonthName"] = "December";
            dt.Rows.Add(newrow11);

            DataRow newrow = dt.NewRow();
            newrow["MonthId"] = 8;
            newrow["MonthName"] = "January";
            dt.Rows.Add(newrow);

            DataRow newrow1 = dt.NewRow();
            newrow1["MonthId"] = 9;
            newrow1["MonthName"] = "February";
            dt.Rows.Add(newrow1);

            DataRow newrow2 = dt.NewRow();
            newrow2["MonthId"] = 10;
            newrow2["MonthName"] = "March";
            dt.Rows.Add(newrow2);


            DataRow newrow3 = dt.NewRow();
            newrow3["MonthId"] = 11;
            newrow3["MonthName"] = "April";
            dt.Rows.Add(newrow3);


            DataRow newrow4 = dt.NewRow();
            newrow4["MonthId"] = 12;
            newrow4["MonthName"] = "May";
            dt.Rows.Add(newrow4);

            cmbMonth.DataSource = dt;
            cmbMonth.ValueMember = "MonthId";
            cmbMonth.DisplayMember = "MonthName";
        }
        ManageFeeDetail MFD = new ManageFeeDetail();
        int LastMonth;
        private void FeesCollection_Load(object sender, EventArgs e)
        {
            RecptNo = Convert.ToInt32(MR.GetRecptNo());
            FetchMonth();
            StudPic.Image = Img;
            FeeCollection FC = new FeeCollection();
            FC = MFD.FetchFeeData(StudId, ClassId);
            // TODO: This line of code loads data into the 'feeHistoryDataSet.FeeCollection' table. You can move, or remove it, as needed.
            this.feeCollectionTableAdapter.Fill(this.feeHistoryDataSet.FeeCollection, ClassId, StudId);
            if (FC != null)
            {
                cmbMonth.SelectedValue = FC.LastMonth;
                LastMonth = Convert.ToInt32(FC.LastMonth);
            }
        }
        Databaselayer DBLayer = new Databaselayer();
        private void cmbMonth_DropDownClosed(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbMonth.SelectedValue) <= LastMonth)
            {
                cmbMonth.SelectedValue = LastMonth;
                radGridView1.DataSource = null;
                lblFees.Text = "0";
                lblNetFees.Text = "0";
                lblConces.Text = "0";
            }
            else
            {
                int diff = Convert.ToInt32(cmbMonth.SelectedValue) - LastMonth;
                radGridView1.DataSource = DBLayer.FetchData("select FeeType,Amount,'" + diff + "' as 'No of Month',(Amount * " + diff + ") as Total from FeeDetail where Classid=" + ClassId).Tables[0];
                radGridView1.Columns[0].Width = 150;
                radGridView1.Columns[1].Width = 100;
                radGridView1.Columns[2].Width = 100;

                Fees = 0;

                for (int i = 0; i < radGridView1.Rows.Count; i++)
                {
                    Fees = Fees + Convert.ToInt32(radGridView1.Rows[i].Cells[3].Value);
                }

                if (Fees > 0)
                {
                    FeeConcession Concession = new FeeConcession();
                    Concession = MFD.FetchConcession(lblCast.Text);
                    double Discount = 0;
                    if (Concession != null)
                    {
                        Discount = (Fees * Convert.ToDouble(Concession.Per)) / 100;
                        lblConces.Text = Discount.ToString();
                        lblFees.Text = Fees.ToString();
                        Fees = Fees - Convert.ToInt32(Discount);
                        lblNetFees.Text = Fees.ToString();
                    }
                    else
                    {
                        Discount = 0;
                        lblConces.Text = Discount.ToString();
                        lblFees.Text = Fees.ToString();
                        Fees = Fees - Convert.ToInt32(Discount);
                        lblNetFees.Text = Fees.ToString();
                    }
                }

            }
        }
        int RecptNo = 0;
        int Fees = 0;
        ManageReceipt MR = new ManageReceipt();
        private void btnGenerateFee_Click(object sender, EventArgs e)
        {
            Fees = 0;

            for (int i = 0; i < radGridView1.Rows.Count; i++)
            {
                Fees = Fees + Convert.ToInt32(radGridView1.Rows[i].Cells[3].Value);
            }

            if (Fees > 0)
            {
                FeeConcession Concession = new FeeConcession();
                Concession = MFD.FetchConcession(lblCast.Text);
                double Discount = 0;

                if (Concession != null)
                {
                    Discount = (Fees * Convert.ToDouble(Concession.Per)) / 100;
                    Fees = Fees - Convert.ToInt32(Discount);
                }
                else
                {
                    Discount = 0;
                    Fees = Fees - Convert.ToInt32(Discount);
                }
                FeeCollection FC = new FeeCollection();
                FC.Classid = ClassId;
                FC.Studid = StudId;
                FC.LastMonth = Convert.ToInt32(cmbMonth.SelectedValue);
                FC.Amount = Convert.ToDouble(Fees);
                FC.LastMonthSpel = cmbMonth.Text;
                FC.EntryDate = Convert.ToDateTime(dtPayDate.Value);
                if (MFD.AddFeeCollectionData(FC) == 0)
                {
                    MessageBox.Show("Data Successfully Saved");
                    // TODO: This line of code loads data into the 'feeHistoryDataSet.FeeCollection' table. You can move, or remove it, as needed.
                    this.feeCollectionTableAdapter.Fill(this.feeHistoryDataSet.FeeCollection, ClassId, StudId);
                    GenerateFeeReceipt();
                    ReciptDetail RD = new ReciptDetail();
                    RD.RecieptFor = "Fees";
                    RD.RecieptFrom = lblStudName.Text;
                    RD.Rec_Date = dtPayDate.Value;
                    RD.P_Mode = "Bank";
                    RD.Amt = Convert.ToInt32(lblNetFees.Text);
                    MR.AddReceipt(RD);
                    PrintFeeReceipt PFR = new PrintFeeReceipt();
                    PFR.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Data Already Exist");
                }
            }
        }

        public void GenerateFeeReceipt()
        {
            StudPic.Image.Save(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Pic.jpg");
            using (StreamWriter writer =
            new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\FeeReceipt.html"))
            {
                writer.WriteLine("<html><head></head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<table style='width:100%'><tr><td align='center'>Fee-Receipt<br /><font size='8'>Bharuch Welfare School</font><br />Welfare Dental & Nursing Building<br />Nr, Manubar Chokdi Road, Bharuch.<br />Phone:- 02642-112457<br/> <br/></td></tr>");
                writer.WriteLine("<tr style='height:100px'><td><table style='width:100%'><tr><td><b style='font-size:larger'> Receipt No:</b>" + RecptNo.ToString() + "</td><td align='right'><b style='font-size:larger'>Date of Payment:</b>" + System.DateTime.Today.ToShortDateString() + "</td></tr></table></td></tr></table></td></tr>");
                writer.WriteLine("<tr style='height:100px'><td><table style='width:100%'><tr><td><b style='font-size:larger'> Student Name:</b>" + lblStudName.Text + "</td></tr></table></td></tr></table></td></tr>");
                writer.WriteLine("<tr><td><table style='width:100%'><tr><td><b style='font-size:larger'>Class:</b>" + Class + " </td><td align='right'> <b style='font-size:larger'>Division:</b>" + Div + "</td><td align='right'><b style='font-size:larger'>Months:</b>" + cmbMonth.Text + "</td></tr></table></td></tr></table>");
                writer.WriteLine("<tr style='height:100px'><td><table style='width:100%;border: 1px solid'><tr style='border: 1px solid'><td align='center' style='border: 1px solid;border-left:none;border-top:none'><b style='font-size:larger'>Sr.No.</b></td><td align='center' style='border: 1px solid;border-left:none;border-top:none'><b style='font-size:larger'> Particulars </b></td><td align='center' style='border: 1px solid;border-left:none;border-top:none;border-right:none'><b style='font-size:larger'>Amount </b></td><td align='center' style='border: 1px solid;border-top:none;width:10%'><b style='font-size:larger'>Month</b></td><td align='center' style='border: 1px solid;border-left:none;border-top:none;border-right:none'><b style='font-size:larger'>Total</b></td> </tr>");
                for (int i = 0;i <= radGridView1.Rows.Count -1; i++)
                {
                    writer.WriteLine("<tr><td align='center' style='border: 1px solid;border-left:none;border-bottom:none;border-top:none'>" + (i + 1).ToString() + "</td><td style='border: 1px solid;border-left:none;border-bottom:none;border-top:none'>" + radGridView1.Rows[i].Cells[0].Value.ToString() + "</td><td align='center' style='border: 1px solid;border-left:none;border-bottom:none;border-top:none;border-right:none'>" + radGridView1.Rows[i].Cells[1].Value.ToString() + "</td><td align='center' style='border: 1px solid;border-bottom:none;border-top:none;'>" + radGridView1.Rows[i].Cells[2].Value.ToString() + "</td><td align='center' style='border: 1px solid;border-left:none;border-bottom:none;border-top:none;border-right:none'>" + radGridView1.Rows[i].Cells[3].Value.ToString() + "</td></tr>");
                }
                writer.WriteLine("<tr><td></td><td></td><td colspan='2' align='right' style='border: 1px solid;border-bottom:none;border-top:none;border-left:none'><b>Total&nbsp;&nbsp;</td><td align='center' style='border: 1px solid;border-left:none;border-bottom:none;border-top:none;border-right:none'>" + lblFees.Text + "</td></tr>");
                writer.WriteLine("<tr><td></td><td></td><td colspan='2' align='right' style='border: 1px solid;border-bottom:none;border-top:none;border-left:none'><b>Concession&nbsp;&nbsp;</td><td align='center' style='border: 1px solid;border-left:none;border-bottom:none;border-top:none;border-right:none'>" + lblConces.Text + "</td></tr>");
                writer.WriteLine("<tr><td></td><td></td><td colspan='2' align='right' style='border: 1px solid;border-bottom:none;border-top:none;border-left:none'><b>Net Pay&nbsp;&nbsp;</td><td align='center' style='border: 1px solid;border-left:none;border-bottom:none;border-top:none;border-right:none'>" + lblNetFees.Text + "</td></tr>");
                writer.WriteLine(" <tr style='border: 1px solid'> <td></td><td></td><td></td></tr><tr><td></td><td></td><td></td></tr></table>");
                writer.WriteLine(" <tr style='height:100px'><td valign='bottom'><br><br><br><br><table style='width:100%'><tr><td> <b style='font-size:larger'> Student Signature:</b><br /> <br/> <br/> <br/></td><td align='right'><b style='font-size:larger'>Bharuch Welfare School</b>&nbsp;&nbsp;&nbsp;&nbsp;<br /> <br /> <br /><b style='font-size:larger'>  Principal Signature </b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td></tr></table>");
                writer.WriteLine("</body></html>");
            }

        }

        private void radGroupBox5_Click(object sender, EventArgs e)
        {

        }

    }
}
