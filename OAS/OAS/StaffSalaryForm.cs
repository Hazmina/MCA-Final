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
using System.IO;
using Telerik.WinControls.UI;
using System.Globalization;

namespace HOS
{
    public partial class StaffSalaryForm : Telerik.WinControls.UI.RadForm
    {
        public StaffSalaryForm()
        {
            InitializeComponent();
        }
        public int StaffId, alwId;
        public Image Img;
        public int cnt = 0;
        public string IFSC, BankName, ACNo;
        ManageStaff MS = new ManageStaff();
        ManageLeaveType MLT = new ManageLeaveType();
        FormateString FS = new FormateString();
        double Salary;
        public void FethchData()
        {
            try
            {
                clear();
                StaffDetail SD = new StaffDetail();
                SD = null;

                SD = MS.AddStaffDetail(Convert.ToInt32(radGridView1.CurrentRow.Cells[2].Value));
                lblSName.Text = SD.Fname + " " + SD.Lname;
                lblStaffNo.Text = Convert.ToInt32(SD.StaffNo).ToString();
                lblGender.Text = SD.Gender;
                lblCno.Text = SD.Cno;
                lblRFID.Text = SD.RFID_Id;
                lblAdd.Text = SD.Address;
                Salary = Convert.ToInt32(SD.Salary);
                StaffId = SD.StaffDet_Id;
                IFSC = SD.IFSC;
                BankName = SD.Bank_Name;
                ACNo = SD.Account_No;
                if (SD.Photo != null)
                {
                    MemoryStream Ms = new MemoryStream(SD.Photo);
                    Img = System.Drawing.Image.FromStream(Ms);
                    PPhoto.Image = Img;
                }
                else
                {
                    Img = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"/Default.jpg");
                    PPhoto.Image = Img;
                }

            }
            catch (Exception e)
            {

            }
        }
        Databaselayer db = new Databaselayer();
        public void CalculateSalary()
        {
            DataSet ds = new DataSet();
            try
            {
                ds = db.FetchData("SELECT Sundays = count(*) FROM (SELECT TOP ( datediff(DAY,'" + dtFrom.Value + "','" + dtTo.Value + "') + 1 )[Date] = dateadd(DAY,ROW_NUMBER() OVER(ORDER BY c1.name),DATEADD(DD,-1,'" + dtFrom.Value + "')) FROM   [master].[dbo].[spt_values] c1 ) x WHERE  datepart(dw,[Date]) = 1;");
                lblSundayCount.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception e)
            {
                lblSundayCount.Text = "0";
            }
            try
            {
                ds.Clear();
                ds = db.FetchData("(SELECT Sundays = count(*)  FROM (SELECT TOP ( datediff(DAY,'" + dtFrom.Value + "','" + dtTo.Value + "') + 1 ) [Date] = dateadd(DAY,ROW_NUMBER() OVER(ORDER BY c1.name),DATEADD(DD,-1,'" + dtFrom.Value + "')) FROM [master].[dbo].[spt_values] c1 ) x WHERE  datepart(dw,[Date]) <> 1)");
                lblWorkingDays.Text = ds.Tables[0].Rows[0][0].ToString();
                lblTotalDays.Text = (Convert.ToInt32(lblSundayCount.Text) + Convert.ToInt32(lblWorkingDays.Text)).ToString();
            }
            catch
            {
                lblTotalDays.Text = "0";
            }
            try
            {
                //ds = db.FetchData("select isnull((sum(DATEDIFF(HOUR,Att_In,Att_Out)) / 8),0) from Attendance where Att_Date between '" + dtFrom.Value + "' and '" + dtTo.Value + "' and RFID_Id='" + lblRFID.Text + "' and DATENAME(dw,Att_Date) <> 'Sunday'");
                ds = db.FetchData("select isnull((sum(DATEDIFF(HOUR,Att_In,Att_Out)) / 8),0) from Attendance where Att_Date between '" + dtFrom.Value + "' and '" + dtTo.Value + "' and RFID_Id='" + lblRFID.Text + "'");
                lblWHours.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception e)
            {
                lblWHours.Text = "0";
            }

            if (lblWHours.Text != "0")
            {
                CalculateLeaveTaken();
                CalculatePendingLeave();
                AdjusmentLeave();
            }
            else
            {
                lblPendingLeave.Text = "0";
            }
        }
        public void GenerateSalaryRecipt()
        {

            string FwSlash = @"\";
            string BkSlash = @"/";
            StreamWriter Writer = new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\SalarySlip.html");
            Writer.WriteLine("<html>");
            Writer.WriteLine("<Body>");
            Writer.WriteLine("<table width='100%' height='100%' style='border: 1px solid;'><tr height='5%'><td>&nbsp;&nbsp;<img  style='height:50;width:150' src='" + AppDomain.CurrentDomain.BaseDirectory.ToString().Replace(FwSlash, BkSlash) + "logo1.png' /><br><br></td></tr>");
            Writer.WriteLine("<tr height='80%'><td align='center' style='font-size:25px;vertical-align:top'><br><b><u><b>SALARY SLIP</b></u><br><br><b>" + string.Format("{0:MMMM yyyy}", System.DateTime.Today) + "</b><br><br>");
            Writer.WriteLine("<table width='100%'><tr height='30px'><td width='25%'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Name:</b></td><td width='25%'>" + lblSName.Text + "</td><td width='25%'><b>Staff Type:</b></td><td width='25%'>" + radGridView1.CurrentRow.Cells[1].Value.ToString() + "</td></tr>");
            Writer.WriteLine("<tr height='30px'><td >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Staff No:</b></td><td >" + lblStaffNo.Text + "</td><td ><b>Contact No:</b></td><td >" + lblCno.Text + "</td></tr><tr height='30px'><td >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Bank Name:</b></td><td >" + BankName + "</td><td ><b>IFSC Code:</b></td><td >" + IFSC + "</td></tr>");
            Writer.WriteLine("<tr height='30px'><td >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>A/C No:</b></td><td >" + ACNo + "</td><td ><b>Working Days:</b></td><td >" + lblTotalDays.Text + "</td></tr><tr height='30px'><td >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Worked Days:</b></td><td >" + lblWHours.Text + "</td><td ><b>No of Leaves:</b></td><td >" + lblNoofLeaves.Text + "</td></tr>");
            Writer.WriteLine("<tr height='30px'><td >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Adjustment Leave:</b></td><td >" + lblAdj.Text + "</td><td ><b>After Adjustment:</b></td><td >" + lblAdjAdded.Text + "</td></tr><tr height='30px' bgcolor='#99FF33'><td colspan='3' style='border: 1px solid;'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>Earnings</b></td><td style='border: 1px solid;' align='center'><b>Amount</b></td></tr><tr height='30px'><td colspan='3'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Basic Salary</td><td align='center'>" + lblBS.Text + "</td></tr>");
            Writer.WriteLine("<tr height='30px'><td colspan='3'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Provident Fund " + allwance + "% Deducted</td><td align='center'>-" + lblAD.Text + "</td></tr><tr height='30px'><td colspan='3'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Leaves Without Pay</td><td align='center'>-" + lblDLC.Text + "</td></tr><tr height='30px' bgcolor='#99FF33'><td colspan='3' style='border: 1px solid;'>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Total</td><td style='border: 1px solid;' align='center'>" + lblNS.Text + "</td></tr></table></td></tr>");
            Writer.WriteLine("<tr height='5%' style='vertical-align:bottom'><td align='center' style='color:#33CCCC'> Ground Floor, Vim Complex, Old Sasrod Road, Palej, Bharuch-392220, Opposite,Pithwala, <b>Call:</b>(02642) 261515, <b>Email:</b>metcarehospital@gmail.com<br><br></td></tr></table>");
            Writer.WriteLine("</Body>");
            Writer.WriteLine("</html>");
            Writer.Close();

        }
        public void clear()
        {
            lblSundayCount.Text = "0";
            lblTotalDays.Text = "0";
            lblWorkingDays.Text = "0";
            lblNoofLeaves.Text = "0";
            lblSalPerday.Text = "0";
            lblWHours.Text = "0";
            lblAdj.Text = "0";
            lblBAdjust.Text = "0";
            lblAdjAdded.Text = "0";
            lblPendingLeave.Text = "0";
            lblBS.Text = "0";
            lblAD.Text = "0";
            lblDLC.Text = "0";
            lblNS.Text = "0";
        }

        DataSet ds = new DataSet();
        public void CalculateLeaveTaken()
        {
            try
            {
                int cnt = 0;
                ds.Clear();
                ds = db.FetchData("select DATEADD(day,nbr -1,b.F_Date)  from (select ROW_NUMBER() over (order by c.object_id) as Nbr from sys.columns c) nbrs,LeaveTaken as b where MONTH(b.F_Date) = " + Convert.ToDateTime(dtFrom.Value).Month.ToString() + " and b.StaffNo='" + lblStaffNo.Text + "' and nbr -1 <= DATEDIFF(DAY,b.F_Date,b.T_Date)");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        if (dtTo.Value >= Convert.ToDateTime(ds.Tables[0].Rows[i][0]))
                        {
                            cnt++;
                        }
                    }
                }
                else
                {
                    ds.Clear();
                    cnt = 1;
                    ds = db.FetchData("select DATEADD(day,nbr -1,b.F_Date)  from (select ROW_NUMBER() over (order by c.object_id) as Nbr from sys.columns c) nbrs,LeaveTaken as b where MONTH(b.T_Date) = " + Convert.ToDateTime(dtTo.Value).Month.ToString() + " and b.StaffNo='" + lblStaffNo.Text + "' and nbr -1 <= DATEDIFF(DAY,b.F_Date,b.T_Date)");
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        if (dtFrom.Value <= Convert.ToDateTime(ds.Tables[0].Rows[i][0]) && dtTo.Value >= Convert.ToDateTime(ds.Tables[0].Rows[i][0]))
                        {
                            cnt++;
                        }
                    }
                }
                lblNoofLeaves.Text = cnt.ToString();
            }
            catch (Exception e)
            {
                lblNoofLeaves.Text = "0";
                MessageBox.Show(e.Message);
            }
        }
        public void CalculatePendingLeave()
        {
            GridLeaveHostory.DataSource = db.FetchData("select b.L_Name,a.F_Date,a.T_Date,(DATEDIFF(day,a.F_Date,a.T_Date) + 1) as 'Total Days' from LeaveTaken as a, LeaveType as b where a.LType_Id=b.Ltype_Id and a.StaffNo='" + lblStaffNo.Text + "'  order by a.F_Date desc").Tables[0];
            GridLeaveHostory.Columns[0].Width = 220;
            GridLeaveHostory.Columns[0].HeaderText = "Leave Type";
            GridLeaveHostory.Columns[1].Width = 140;
            GridLeaveHostory.Columns[1].HeaderText = "From";
            GridLeaveHostory.Columns[2].HeaderText = "To";
            GridLeaveHostory.Columns[2].Width = 140;
            GridLeaveHostory.Columns[3].Width = 100;
            GridLeaveHostory.Columns[1].FormatString = "{0:dd MMMM yy}";
            GridLeaveHostory.Columns[2].FormatString = "{0:dd MMMM yy}";
        }
        public void AdjusmentLeave()
        {
            ds.Clear();
            ds = db.FetchData("select (select sum(No_Leave) from LeaveType) - (sum(DATEDIFF(day,a.F_Date,a.T_Date) + 1)) from LeaveTaken as a, LeaveType as b where a.LType_Id=b.Ltype_Id and a.StaffNo='" + lblStaffNo.Text + "'");
            int PendingLeave = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

            if (PendingLeave < 0)
            {
                lblPendingLeave.Text = "0";
            }
            
            
            if (PendingLeave > 0)
            {
                if (PendingLeave > Convert.ToInt32(lblNoofLeaves.Text))
                {
                    lblAdj.Text = lblNoofLeaves.Text;
                    lblBAdjust.Text = lblWHours.Text;
                    lblAdjAdded.Text = (Convert.ToInt32(lblAdj.Text) + Convert.ToInt32(lblBAdjust.Text)).ToString();
                }
                else
                {
                    lblAdj.Text = (Convert.ToInt32(lblNoofLeaves.Text) - PendingLeave).ToString();
                    lblBAdjust.Text = lblWHours.Text;
                    lblAdjAdded.Text = (Convert.ToInt32(lblAdj.Text) + Convert.ToInt32(lblBAdjust.Text)).ToString();
                }
            }
            else
            {
                lblAdj.Text = "0";
                lblBAdjust.Text = lblWHours.Text;
                lblAdjAdded.Text = (Convert.ToInt32(lblAdj.Text) + Convert.ToInt32(lblBAdjust.Text)).ToString();
            }
            ds.Clear();
            double AdjAdded = (Salary * Convert.ToInt32(lblAdjAdded.Text));
            ds = db.FetchData("select * from AllowanceType where Salary < " + Salary);
            if (ds.Tables[0].Rows.Count > 0)
            {
                allwance = Convert.ToInt32(ds.Tables[0].Rows[0][2]);
                alwId = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
                Deduct = ((Salary * allwance) / 100);
            }
            else
            {
                allwance = 0;
                alwId = 0;
                Deduct = 0;
            }

            lblBS.Text = Salary.ToString();
            lblAD.Text = Deduct.ToString();
            lblDLC.Text = ((Convert.ToInt32(lblNoofLeaves.Text) - Convert.ToInt32(lblAdj.Text)) * Convert.ToInt32(FS.ExtractDecimalFromString(lblSalPerday.Text))).ToString();
            lblNS.Text = ((Convert.ToInt32(lblBS.Text) - Convert.ToInt32(lblAD.Text)) - Convert.ToInt32(lblDLC.Text)).ToString(); ;
            lblBS.Text = String.Format(cultureInfo, "{0:c}", Salary);
            lblAD.Text = String.Format(cultureInfo, "{0:c}", Convert.ToInt32(lblAD.Text));
            lblNS.Text = String.Format(cultureInfo, "{0:c}", Convert.ToInt32(lblNS.Text));
            lblDLC.Text = String.Format(cultureInfo, "{0:c}", Convert.ToInt32(lblDLC.Text));
        }
        public CultureInfo cultureInfo = new CultureInfo("en-IN");
        private void StaffSalaryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salaryEmployeeDataSet.StaffDetail' table. You can move, or remove it, as needed.
            this.staffDetailTableAdapter.Fill(this.salaryEmployeeDataSet.StaffDetail);
            FethchData();
        }
        private void brnSave_Click(object sender, EventArgs e)
        {

        }
        double TotSal = 0;
        int Diff = 0;
        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            DateTime SD, FD;
            SD = Convert.ToDateTime(dtFrom.Value);
            FD = Convert.ToDateTime(dtTo.Value);
            Diff = Convert.ToInt32((FD - SD).TotalDays + 1);
            lblSalPerday.Text = (Convert.ToInt32(Salary) / Diff).ToString();
            //MessageBox.Show(Diff.ToString() + " * " + Salary.ToString() + (Convert.ToInt32(Salary) / Diff).ToString());
            CalculateSalary();
            
            lblSalPerday.Text = String.Format(cultureInfo, "{0:c}", Convert.ToInt32(lblSalPerday.Text));
        }
        private void dtFrom_CloseUp(object sender, EventArgs e)
        {
            try
            {
                dtTo.Value = Convert.ToDateTime(dtFrom.Value).AddMonths(1).AddDays(-1);
                dtTo.MinDate = Convert.ToDateTime(dtFrom.Value).AddMonths(1).AddDays(-1);
               
                dtTo.MaxDate = Convert.ToDateTime(dtFrom.Value).AddMonths(1).AddDays(-1);
            }
            catch(Exception E)
            {

            }
            
        }
        private void dtTo_ValueChanged(object sender, EventArgs e)
        {

        }
        int allwance;
        double Deduct;
        private void btnSalary_Click(object sender, EventArgs e)
        {
            string DateFrom, DateTo;
            DateFrom = Convert.ToDateTime(dtFrom.Value).ToShortDateString();
            DateTo = Convert.ToDateTime(dtTo.Value).ToShortDateString();
            SalaryDetail SD = new SalaryDetail();
            SD.Staff_Id = StaffId;
            SD.BS = Convert.ToDouble(FS.ExtractDecimalFromString(lblBS.Text));
            SD.NetSalary = Convert.ToDouble(FS.ExtractDecimalFromString(lblNS.Text));
            SD.DateFrom = Convert.ToDateTime(DateFrom);
            SD.DateTo = Convert.ToDateTime(DateTo);
            SD.EntryDate = System.DateTime.Today;
            MS.AddStaffSalary(SD);



            TransactionAllowance TA = new TransactionAllowance();
            TA.All_Id = alwId;
            TA.Staff_Id = StaffId;
            TA.F_Date = Convert.ToDateTime(DateFrom);
            TA.T_Date = Convert.ToDateTime(DateTo);
            TA.Entry_Date = System.DateTime.Today;
            TA.Amt = Convert.ToDouble(FS.ExtractDecimalFromString(lblAD.Text));
            MS.AddTransactionAllowance(TA);
            GenerateSalaryRecipt();
            PrintSalarySlipForm PSSF = new PrintSalarySlipForm();
            PSSF.ShowDialog();

        }

        private void radGridView1_Click(object sender, EventArgs e)
        {
            FethchData();
        }
    }
}
