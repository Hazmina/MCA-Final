using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using BusinessLayer;
using DataBaseLayer;
using System.Speech.Synthesis;
namespace OAS
{
    public partial class AddLeaveTypeForm : Telerik.WinControls.UI.RadForm
    {
        public AddLeaveTypeForm()
        {
            InitializeComponent();
        }

        private void AddLeaveTypeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaveTypeDataSet.LeaveType' table. You can move, or remove it, as needed.
            this.leaveTypeTableAdapter.Fill(this.leaveTypeDataSet.LeaveType);
            btnEdit.Enabled = false;
            GridViewImageColumn EditColumn = new GridViewImageColumn();
            EditColumn.Name = "Edit";
            EditColumn.HeaderText = "Edit";
            EditColumn.ImageLayout = ImageLayout.Zoom;
            radGridView1.MasterTemplate.Columns.Insert(3, EditColumn);

            GridViewImageColumn DeleteColumn = new GridViewImageColumn();
            DeleteColumn.Name = "Delete";
            DeleteColumn.HeaderText = "Delete";
            DeleteColumn.ImageLayout = ImageLayout.Zoom;
            radGridView1.MasterTemplate.Columns.Insert(4, DeleteColumn);
        }

        public int cnt = 0;
        public int LeaveId = 0;
        public void isEmpty(RadTextBox TextBox, RadLabel lbl)
        {
            if (TextBox.Text == "")
            {
                cnt++;
                lbl.Text = "*Required";
            }
            else
            {
                lbl.Text = "";
            }
        }

        public void ValidLength(RadTextBox TextBox, RadLabel lbl, int Length)
        {
            if (Length < Convert.ToInt32(TextBox.Text.Length))
            {
                cnt++;
                lbl.Text = "*Not More Then " + Length + " Charecters";
            }
            else
            {
                if (TextBox.Text != "")
                {
                    lbl.Text = "";
                }
            }
        }
        public void Validation()
        {
            cnt = 0;
            isEmpty(txtLevName, lblErrLeave);
            ValidLength(txtLevName, lblErrLeave, 28);

            isEmpty(txtNoL, lblErrNoL);
        }
        public void Clear()
        {
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            txtLevName.Text = "";
            txtNoL.Text = "";
        }
        ManageLeaveType MLT = new ManageLeaveType();
        public void Speech(string Message)
        {
            SpeechSynthesizer Sapi = new SpeechSynthesizer();
            Sapi.SpeakAsync(Message);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Validation();
            if (cnt == 0)
            {
                LeaveType LT = new LeaveType();
                LT.L_Name = txtLevName.Text;
                LT.No_Leave = Convert.ToInt32(txtNoL.Text);

                if (MLT.AddLeaveType(LT) == 0)
                {
                    Speech("Data Succefully Saved");
                    MessageBox.Show("Data Sucessfull Saved","OAS");
                    // TODO: This line of code loads data into the 'leaveTypeDataSet.LeaveType' table. You can move, or remove it, as needed.
                    this.leaveTypeTableAdapter.Fill(this.leaveTypeDataSet.LeaveType);
                }
                else
                {
                    MessageBox.Show("Data Already Exist");
                }
            }
        } 
        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            ImageList imagesList = new ImageList();
            e.CellElement.ForeColor = Color.Black;
            Image Editimage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"/edit-12-32.ico");
            imagesList.Images.Add(Editimage);

            Image Deleteimage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"/delete-32.ico");
            imagesList.Images.Add(Deleteimage);

            if (e.CellElement.ColumnIndex == 3)
            {
                e.CellElement.Image = imagesList.Images[0];
            }
            else if (e.CellElement.ColumnIndex == 4)
            {
                e.CellElement.Image = imagesList.Images[1];
            }
        }

        private void radGridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (radGridView1.CurrentRow.Cells[3].IsCurrent == true)
            {
                btnSave.Enabled = false;
                btnEdit.Enabled = true;
                txtLevName.Text = radGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNoL.Text = radGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            else if (radGridView1.CurrentRow.Cells[4].IsCurrent == true)
            {
                Speech("Are You Sure Want to Delete That Recored!");
                string confirm = MessageBox.Show("Are You Sure Want to Delete That Recored!", "HOS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk).ToString();
                if (confirm == "Yes")
                {
                    MLT.DeleteData(Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
                    Speech("SuccessFully Deleted");
                    MessageBox.Show("SuccessFully Deleted", "OAS");
                    // TODO: This line of code loads data into the 'leaveTypeDataSet.LeaveType' table. You can move, or remove it, as needed.
                    this.leaveTypeTableAdapter.Fill(this.leaveTypeDataSet.LeaveType);
                }
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Validation();
            if (cnt == 0)
            {
                LeaveId = Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value);
                LeaveType LT = new LeaveType();
                LT = MLT.FetchData(LeaveId);
                LT.L_Name = txtLevName.Text;
                LT.No_Leave = Convert.ToInt32(txtNoL.Text);
                MLT.EditLeaveTypeData(LT);
                Speech("Data Sucessfully Save");
                MessageBox.Show("Data Sucessfully Save","OAS");
                // TODO: This line of code loads data into the 'leaveTypeDataSet.LeaveType' table. You can move, or remove it, as needed.
                this.leaveTypeTableAdapter.Fill(this.leaveTypeDataSet.LeaveType);
                Clear();  
            }
        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
