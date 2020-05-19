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
using System.Speech.Synthesis;
using System.Data.OleDb;

namespace OAS
{
    public partial class ImportAttendance : Telerik.WinControls.UI.RadForm
    {
        public ImportAttendance()
        {
            InitializeComponent();
        }
        public int StaffId;
        public Image Img;
        public int cnt = 0;
        ManageStaff MS = new ManageStaff();
        public void FethchData()
        {
            try
            {
                Staff SD = new Staff();
                SD = null;
                SD = MS.Fetch(Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
                lblSName.Text = SD.FNname + " " + SD.Mname + " " + SD.Lname;
                lblGender.Text = SD.Gender;
                lblCno.Text = SD.Cno1;

                lblAdd.Text = SD.Address;

                StaffId = SD.Staffid;
                lblRFID.Text = SD.Rfid;

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
        private void radGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            FethchData();
        }
        public void Speech(string Message)
        {
            SpeechSynthesizer Sapi = new SpeechSynthesizer();
            Sapi.SpeakAsync(Message);
        }
        private void ImportAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDetailAttendenceDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.staffDetailAttendenceDataSet.Staff);
            FethchData();
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {
            FethchData();
        }

        private void radGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            FethchData();
        }
        private void radGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            FethchData();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();

            }
            catch (Exception)
            {

            }
        }
        string Valid = "";

        ManageAttendace MA = new ManageAttendace();
        private void radButton1_Click(object sender, EventArgs e)
        {
            string In = null, Out = null, Status;
            for (int i = 0; i < radGridView2.Rows.Count; i++)
            {
                try
                {
                    Status = "False";
                    if ((radGridView2.Rows[i].Cells[3].Value.ToString() != "--:--" && radGridView2.Rows[i].Cells[3].Value.ToString() != "" && radGridView2.Rows[i].Cells[0].Value.ToString() != ""))
                    {
                        In = Convert.ToDateTime(radGridView2.Rows[i].Cells[0].Value.ToString() + " " + string.Format("{0:hh:mm}", radGridView2.Rows[i].Cells[3].Value) + ":00").ToString();
                        Status = "True";
                    }
                    else
                    {
                        Status = "False";
                    }

                    if (radGridView2.Rows[i].Cells[18].Value.ToString() != "--:--" && radGridView2.Rows[i].Cells[18].Value.ToString() != "")
                    {
                        Out = string.Format("{0:hh:mm}", radGridView2.Rows[i].Cells[18].Value);
                        Out = Convert.ToDateTime(radGridView2.Rows[i].Cells[0].Value.ToString() + " " + Out + ":00").ToString();
                    }
                    else
                    {
                        if (Status == "True")
                        {
                            Out = Convert.ToDateTime(radGridView2.Rows[i].Cells[0].Value.ToString() + " " + string.Format("{0:hh:mm}", radGridView2.Rows[i].Cells[0].Value) + ":00").AddHours(8).ToString();
                        }
                    }
                    if (Status == "True")
                    {
                        Attendance Att = new Attendance();
                        Att.Att_Date = Convert.ToDateTime(radGridView2.Rows[i].Cells[0].Value);
                        MessageBox.Show(In);
                        MessageBox.Show(Out);
                        Att.Att_In = Convert.ToDateTime(In);
                        Att.Att_Out = Convert.ToDateTime(Out);
                        Att.RFID_Id = lblRFID.Text;
                        MA.AddAttendance(Att);
                    }
                }
                catch (Exception exp)
                {

                }
            }
            MessageBox.Show("Data Successfully Imported To Database");
        }
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (System.IO.Path.GetExtension(openFileDialog1.FileName) == ".xls" || System.IO.Path.GetExtension(openFileDialog1.FileName) == ".xlsx")
            {
                Valid = "True";
                string filePath = openFileDialog1.FileName;
                string extension = Path.GetExtension(filePath);
                string header = rbHeaderYes.Checked ? "YES" : "NO";
                string conStr, sheetName;

                conStr = string.Empty;
                switch (extension)
                {

                    case ".xls": //Excel 97-03
                        conStr = string.Format(Excel03ConString, filePath, header);
                        break;

                    case ".xlsx": //Excel 07
                        conStr = string.Format(Excel07ConString, filePath, header);
                        break;
                }

                //Get the name of the First Sheet.
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        con.Close();
                    }
                }

                //Read Data from the First Sheet.
                using (OleDbConnection con = new OleDbConnection(conStr))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        using (OleDbDataAdapter oda = new OleDbDataAdapter())
                        {
                            DataTable dt = new DataTable();
                            cmd.CommandText = "SELECT * From [" + sheetName + "]";
                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            con.Close();
                            //Populate DataGridView.
                            radGridView2.DataSource = null;
                            radGridView2.DataSource = dt;
                        }
                    }
                }
            }
            else
            {
                Valid = "False";
                MessageBox.Show("Invalid Extenson");
            }
        }
    }
}
