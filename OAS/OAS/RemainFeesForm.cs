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
    public partial class RemainFeesForm : Telerik.WinControls.UI.RadForm
    {
        public RemainFeesForm()
        {
            InitializeComponent();
        }
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
        private void RemainFeesForm_Load(object sender, EventArgs e)
        {
            FetchMonth();
        }
        Databaselayer DBLayer = new Databaselayer();
        private void cmbMonth_DropDownClosed(object sender, EventArgs e)
        {
            radGridView1.DataSource = DBLayer.FetchData("select b.CName,c.DivName,a.General_Regis_No,a.Student_Name,a.Phone_No,a.Gender,a.Religion,a.Cast,isnull((select LastMonthSpel from FeeCollection where FeeCollectionId=(select max(FeeCollectionId) from FeeCollection where Studid=a.Stud_Id)),'Not Paid in Any Month') as 'Last Month' from Student as a,ClassDetail as b,Division as c where a.Classid=b.ClassId and a.Divid=c.DivId and a.Stud_Id not in (select Stud_Id from FeeCollection where Classid=a.Classid and Studid=a.Stud_Id and LastMonth >= " + cmbMonth.SelectedValue + ")").Tables[0];
            radGridView1.Columns[0].Width = 100;
            radGridView1.Columns[1].Width = 100;
            radGridView1.Columns[2].Width = 150;
            radGridView1.Columns[3].Width = 300;
            radGridView1.Columns[4].Width = 150;
            radGridView1.Columns[5].Width = 100;
            radGridView1.Columns[6].Width = 100;
            radGridView1.Columns[7].Width = 100;
            radGridView1.Columns[8].Width = 170;
        }
    }
}
