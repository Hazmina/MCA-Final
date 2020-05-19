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
using System.Speech.Synthesis;
namespace OAS
{
    public partial class AddLeaveTaken : Telerik.WinControls.UI.RadForm
    {
        public AddLeaveTaken()
        {
            InitializeComponent();
        }

        private void AddLeaveTaken_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'staffDetailAttendenceDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.staffDetailAttendenceDataSet.Staff);
            // TODO: This line of code loads data into the 'leaveTakenDataSet.LeaveTaken' table. You can move, or remove it, as needed.
            this.leaveTakenTableAdapter.Fill(this.leaveTakenDataSet.LeaveTaken, Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
            MLT.PopulateLeave(cmbType);
            cmbType.Text = "Select Leave Type";
            FethchData();
            GridViewImageColumn DeleteColumn = new GridViewImageColumn();
            DeleteColumn.Name = "Delete";
            DeleteColumn.HeaderText = "Delete";
            DeleteColumn.ImageLayout = ImageLayout.Zoom;
            radGridView2.MasterTemplate.Columns.Insert(6, DeleteColumn);
        }

        public int StaffId;
        public Image Img;
        public int cnt = 0;
        ManageStaff MS = new ManageStaff();
        ManageLeaveType MLT = new ManageLeaveType();

        public void Validation()
        {
            cnt = 0;


            if (cmbType.Text == "Select Leave Type")
            {
                lblErrLeaveT.Text = "* Required";
                cnt++;
            }
            else
            {
                lblErrLeaveT.Text = "*";
            }
        }

        public void FethchData()
        {
            try
            {
                Staff SD = new Staff();
                SD = null;
                SD = MS.Fetch(Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
                lblSName.Text = SD.FNname + " " + SD.Mname + " " + SD.Lname;
                txtStaffNo.Text = SD.Staffid.ToString();
                lblGender.Text = SD.Gender;
                lblCno.Text = SD.Cno1;

                lblAdd.Text = SD.Address;

                StaffId = SD.Staffid;

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
                // TODO: This line of code loads data into the 'leaveTakenDataSet.LeaveTaken' table. You can move, or remove it, as needed.
                this.leaveTakenTableAdapter.Fill(this.leaveTakenDataSet.LeaveTaken, Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
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

        private void brnSave_Click(object sender, EventArgs e)
        {
            Validation();
            if (cnt == 0)
            {
                LeaveTaken LT = new LeaveTaken();
                LT.LType_Id = Convert.ToInt32(cmbType.SelectedValue);
                LT.StaffNo = Convert.ToInt32(txtStaffNo.Text);
                LT.F_Date = Convert.ToDateTime(dateTimePicker1.Value);
                LT.T_Date = Convert.ToDateTime(dateTimePicker2.Value);
                if (MS.AddLeaveTaken(LT) == 0)
                {
                    Speech("Data Sucessfully Save");
                    MessageBox.Show("Data Sucessfully Save", "OAS");
                    // TODO: This line of code loads data into the 'leaveTakenDataSet.LeaveTaken' table. You can move, or remove it, as needed.
                    this.leaveTakenTableAdapter.Fill(this.leaveTakenDataSet.LeaveTaken, Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
                }
                else
                {
                    Speech("Data Already Exists");
                    MessageBox.Show("Data Already Exists", "OAS");
                }
            }

        }

        private void radGridView2_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (radGridView2.CurrentRow.Cells[5].IsCurrent == true)
            {
                string confirm = MessageBox.Show("Are You Sure Want to Delete That Recored!", "HOS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk).ToString();
                if (confirm == "Yes")
                {
                    MLT.DeleteStaffLeave(Convert.ToInt32(radGridView2.CurrentRow.Cells[0].Value));
                    Speech("Data Successfully Deleted");
                    MessageBox.Show("Data Successfully Deleted", "OAS");
                    // TODO: This line of code loads data into the 'leaveTakenDataSet.LeaveTaken' table. You can move, or remove it, as needed.
                    this.leaveTakenTableAdapter.Fill(this.leaveTakenDataSet.LeaveTaken, Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
                }
            }
        }

        private void radGridView2_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            ImageList imagesList = new ImageList();
            e.CellElement.ForeColor = Color.Black;

            Image Deleteimage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"/delete-32.ico");
            imagesList.Images.Add(Deleteimage);

            if (e.CellElement.ColumnIndex == 6)
            {
                e.CellElement.Image = imagesList.Images[0];
            }

        }
    }
}
