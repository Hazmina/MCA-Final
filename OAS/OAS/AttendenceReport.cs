using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.Charting;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace OAS
{
    public partial class AttendenceReport : Telerik.WinControls.UI.RadForm
    {
        public AttendenceReport()
        {
            InitializeComponent();
        }
        Databaselayer DBLayer = new Databaselayer();
        private void dtTo_CloseUp(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = DBLayer.FetchData("select Staffid,(select count(*) from Attendance where RFID_Id=a.Rfid and Att_Date between '" + dtFrom.Value + "' and '" + dtTo.Value + "') as c from Staff as a");
            radChartView1.Series.Clear();
            BarSeries barSeries = new BarSeries("Performance", "RepresentativeName");
            barSeries.Name = "Attendance Report";
            radChartView1.Title = "Attendance Report";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToInt32(ds.Tables[0].Rows[i][1]), ds.Tables[0].Rows[i][0].ToString()));
                this.radChartView1.Series.Add(barSeries);
            }
            radChartView1.Area.View.Palette = KnownPalette.Cold;
            //LineSeries LS = new LineSeries();
            //radChartView1.Series.Add(LS);
            //LS.ValueMember = "c";
            //LS.CategoryMember = "StaffName";
            //LS.DataSource = ds.Tables[0];
        }

        private void AttendenceReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDetailAttendenceDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.staffDetailAttendenceDataSet.Staff);

           
        }
    }
}
