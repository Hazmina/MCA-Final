using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using BusinessLayer;
namespace OAS
{
    public partial class MDIForm : Telerik.WinControls.UI.RadForm
    {
        public MDIForm()
        {
            InitializeComponent();
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            ExpenseTypeForm ETF = new ExpenseTypeForm();
            ETF.ShowDialog();
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            ShowExpDetailForm SEDF = new ShowExpDetailForm();
            SEDF.ShowDialog();
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            AddLeaveTypeForm ALTF = new AddLeaveTypeForm();
            ALTF.ShowDialog();
        }

        private void radMenuItem6_Click(object sender, EventArgs e)
        {
            AddLeaveTaken ALT = new AddLeaveTaken();
            ALT.ShowDialog();
        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            CalculateSalary CS = new CalculateSalary();
            CS.ShowDialog();
        }

        private void radMenuItem10_Click(object sender, EventArgs e)
        {
            ShowStudDataForm SSDF = new ShowStudDataForm();
            SSDF.ShowDialog();
        }

        private void radMenuItem9_Click(object sender, EventArgs e)
        {
            AddStudentForm ASF = new AddStudentForm();
            ASF.ShowDialog();
        }

        private void radMenuItem13_Click(object sender, EventArgs e)
        {
            RemainFeesForm RFF = new RemainFeesForm();
            RFF.ShowDialog();
        }

        private void radMenuItem12_Click(object sender, EventArgs e)
        {
            FeesPaidList FPI = new FeesPaidList();
            FPI.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Date: " + System.DateTime.Now.ToString();
        }

        private void btnBonofied_Click(object sender, EventArgs e)
        {
            BonofiedReport BR = new BonofiedReport();
            BR.ShowDialog();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            ReceiptReport RR = new ReceiptReport();
            RR.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ExpenseReport ER = new ExpenseReport();
            ER.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ProvidentFund PF = new ProvidentFund();
            PF.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AttendenceReport AR = new AttendenceReport();
            AR.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            StaffDetailReport SDR = new StaffDetailReport();
            SDR.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            AsstesReports AR = new AsstesReports();
            AR.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            SubjectAllocation SA = new SubjectAllocation();
            SA.ShowDialog();
        }
        
        private void MDIForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            LeaveTakenReport LTR = new LeaveTakenReport();
            LTR.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowStudDataForm SSDF = new ShowStudDataForm();
            SSDF.ShowDialog();
        }

        private void radMenuItem14_Click(object sender, EventArgs e)
        {
            ManageFeeDetailForm MFDF = new ManageFeeDetailForm();
            MFDF.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SalaryReportForm SRF = new SalaryReportForm();
            SRF.ShowDialog();
        }

        private void radMenuItem15_Click(object sender, EventArgs e)
        {
            SalaryHistory SH = new SalaryHistory();
            SH.ShowDialog();
        }

        private void radMenuItem16_Click(object sender, EventArgs e)
        {
            ImportAttendance IA = new ImportAttendance();
            IA.ShowDialog();
        }
    }
}
