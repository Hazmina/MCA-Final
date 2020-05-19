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
    public partial class FeesPaidList : Telerik.WinControls.UI.RadForm
    {
        public FeesPaidList()
        {
            InitializeComponent();
        }

        Databaselayer DBLayer = new Databaselayer();
        private void FeesPaidList_Load(object sender, EventArgs e)
        {
            radGridView1.DataSource = DBLayer.FetchData("select b.CName,c.DivName,a.General_Regis_No,a.Student_Name,a.Phone_No,isnull((select LastMonthSpel from FeeCollection where FeeCollectionId=(select max(FeeCollectionId) from FeeCollection where Studid=a.Stud_Id)),'Not Paid in Any Month') as 'Last Month',(select EntryDate from FeeCollection where FeeCollectionId=(select max(FeeCollectionId) from FeeCollection where Studid=a.Stud_Id)) as 'Paid Date' from Student as a,ClassDetail as b,Division as c where a.Classid=b.ClassId and a.Divid=c.DivId and a.Stud_Id in (select Stud_Id from FeeCollection where Classid=a.Classid and Studid=a.Stud_Id)").Tables[0];
            radGridView1.Columns[0].Width = 100;
            radGridView1.Columns[1].Width = 100;
            radGridView1.Columns[2].Width = 150;
            radGridView1.Columns[3].Width = 300;
            radGridView1.Columns[4].Width = 150;
            radGridView1.Columns[5].Width = 150;
            radGridView1.Columns[6].Width = 150;
        }
    }
}
