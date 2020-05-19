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
using System.IO;
using System.Speech.Synthesis;
namespace OAS
{
    public partial class AddStudentForm : Telerik.WinControls.UI.RadForm
    {
        public AddStudentForm()
        {
            InitializeComponent();
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

        public void TextLimit(RadTextBox txt, RadLabel lbl, int limit)
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
                    lbl.Text = "*Required";
                }
                else
                {
                    lbl.Text = "*";
                }
            }

        }


        private void radLabel23_Click(object sender, EventArgs e)
        {

        }

        private void radLabel22_Click(object sender, EventArgs e)
        {

        }

        private void radLabel25_Click(object sender, EventArgs e)
        {

        }

        private void radTextBox9_TextChanged(object sender, EventArgs e)
        {

        }
        Image img;

        public void Clear()
        {
            txtAdd.Text = "";
            txtFather.Text = "";
            txtFOcc.Text = "";
            txtGN.Text = "";
            txtGrNo.Text = "";
            txtHpno.Text = "";
            txtMOcc.Text = "";
            txtMother.Text = "";
            txtNationality.Text = "";
            txtPhno.Text = "";
            txtReligion.Text = "";
            txtSAdhar.Text = "";
            txtSchool.Text = "";
            txtStudName.Text = "";
        }
        private void btnbrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            img = Image.FromFile(openFileDialog1.FileName);
            pictureBox1.Image = img;
        }
        public string GrNo = null;
        ManageClass MC = new ManageClass();
        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            MC.PopulateClass(cmbClass);
            Regions.PopulateCountry(cmbCountry);
            dtDob.MaxDate = System.DateTime.Now.AddYears(-3);
            dtAddDate.MaxDate = System.DateTime.Now;
            dtDob.Value = System.DateTime.Now.AddYears(-4);

            if (GrNo != null)
            {
                btnEdit.Enabled = true;
                btnSave.Enabled = false;
                Student SD = new Student();
                SD = StudDetail.FetchData(GrNo);
                txtAdd.Text = SD.Address;
                txtGrNo.Text = SD.General_Regis_No;
                txtStudName.Text = SD.Student_Name;
                txtFather.Text = SD.Father_Name;
                txtMother.Text = SD.Mother_Name;
                txtFOcc.Text = SD.Father_Occupation;
                txtMOcc.Text = SD.Mother_Occupation;
                txtGN.Text = SD.Guardian_Name;
                txtReligion.Text = SD.Religion;
                txtNationality.Text = SD.Nationality;
                txtSchool.Text = SD.Previous_School_Name;
                txtPhno.Text = SD.Phone_No;
                txtHpno.Text = SD.HomePhoneNo;
                txtSAdhar.Text = SD.AadhaarNo;
                cmbCountry.SelectedValue = SD.Country_Id;
                Regions.PopulateState(cmbState, Convert.ToInt32(cmbCountry.SelectedValue));
                cmbState.SelectedValue = SD.State_Id;
                Regions.PopulateCity(cmbCity, Convert.ToInt32(cmbState.SelectedValue));
                cmbCity.SelectedValue = SD.City_Id;

                cmbClass.SelectedValue = SD.Classid;
                MC.PopulateDivision(cmbDiv, Convert.ToInt32(cmbClass.SelectedValue));
                cmbDiv.SelectedValue = SD.Divid;

                if (SD.Gender == "Male")
                {
                    rdbMale.Checked = true;
                }
                else
                {
                    rdbFemale.Checked = true;
                }

                if(SD.Cast == "OBC")
                {
                    rdbOBC.Checked = true;
                }
                else if (SD.Cast == "SC/ST")
                {

                    rdbSC.Checked = true;
                }
                else
                {

                    rdbGeneral.Checked = true;
                }
                dtAddDate.Value =Convert.ToDateTime(SD.Date_Of_Addmission);
                dtDob.Value = Convert.ToDateTime(SD.Date_Of_Birth);
                MemoryStream MS = new MemoryStream(SD.Photo);
                Image img = Image.FromStream(MS);
                pictureBox1.Image = img;
               


            }
            else
            {
                cmbCountry.Text = "Select Country";
                cmbState.Text = "Select State";
                cmbCity.Text = "Select City";
                cmbClass.Text = "Select Class";
                cmbDiv.Text = "Select Division";
            }

        }

        private void cmbClass_DropDownClosed(object sender, EventArgs e)
        {
            MC.PopulateDivision(cmbDiv, Convert.ToInt32(cmbClass.SelectedValue));
            cmbDiv.Text = "Select Division";
        }
        int cnt = 0;
        public void Validation()
        {
            cnt = 0;
            IsEmpty(txtGrNo, lblErrGrno);
            TextLimit(txtGrNo, lblErrGrno, 8);

            IsEmpty(txtStudName, lblErrStudName);
            TextLimit(txtStudName, lblErrStudName, 48);

            IsEmpty(txtFather, lblErrFather);
            TextLimit(txtFather, lblErrFather, 48);

            IsEmpty(txtFOcc, lblErrFatherOccupation);
            TextLimit(txtFOcc, lblErrFatherOccupation, 28);

            IsEmpty(txtMother, lblErrMother);
            TextLimit(txtMother, lblErrMother, 48);

            IsEmpty(txtMOcc, radLabel2);
            TextLimit(txtMOcc, radLabel2, 28);



            IsEmpty(txtReligion, lblErrReligion);
            TextLimit(txtReligion, lblErrReligion, 12);

            IsEmpty(txtNationality, lblErrNationality);
            TextLimit(txtNationality, lblErrNationality, 18);

            if (txtSchool.Text.Length > 48)
            {
                cnt++;
                lblErrSchooName.Text = "*Length Should be Less Than 48 Characters";
            }
            else
            {
                lblErrSchooName.Text = "";

            }

            if (txtGN.Text.Length > 48)
            {
                cnt++;
                lblErrGName.Text = "* Length Should be Less Than 48 Characters";

            }
            else
            {
                lblErrGName.Text = "";
            }


            IsEmpty(txtPhno, lblErrPhno);
            TextLimit(txtPhno, lblErrPhno, 10);

            IsEmpty(txtHpno, lblErrHPhone);
            TextLimit(txtHpno, lblErrHPhone, 10);

            IsEmpty(txtAdd, lblErrAddress);

            IsEmpty(txtSAdhar, radLabel10);
            TextLimit(txtSAdhar, radLabel10, 12);

            IsComboSeletected(cmbClass, lblErrClass, "Select Class");

            IsComboSeletected(cmbDiv, lblErrDiv, "Select Division");

            IsComboSeletected(cmbCountry, lblErrCountry, "Select Country");

            IsComboSeletected(cmbState, lblErrState, "Select State");

            IsComboSeletected(cmbCity, lblErrCity, "Select City");

            if (GrNo == null)
            {
                if (openFileDialog1.FileName == "openFileDialog1")
                {
                    cnt++;
                    lblErrPhoto.Text = "*Required";
                }
                else
                {
                    lblErrPhoto.Text = "*";
                }
            }
        }

        public void IsComboSeletected(ComboBox cmb, RadLabel lbl, string txt)
        {
            if (cmb.Text == txt)
            {
                cnt++;
                lbl.Text = "*Required";
            }
            else
            {
                lbl.Text = "*";
            }
        }

        ManageStudentDetail StudDetail = new ManageStudentDetail();
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
                Student stud = new Student();
                stud.General_Regis_No = txtGrNo.Text;
                stud.Date_Of_Addmission = dtAddDate.Value;
                stud.Student_Name = txtStudName.Text;
                stud.Father_Name = txtFather.Text;
                stud.Mother_Name = txtMother.Text;
                stud.Father_Occupation = txtFOcc.Text;
                stud.Mother_Occupation = txtMOcc.Text;
                stud.Guardian_Name = txtGN.Text;
                stud.Religion = txtReligion.Text;
                stud.Nationality = txtNationality.Text;
                stud.Previous_School_Name = txtSchool.Text;
                stud.Phone_No = txtPhno.Text;
                stud.HomePhoneNo = txtHpno.Text;
                stud.Address = txtAdd.Text;
                stud.Classid = Convert.ToInt32(cmbClass.SelectedValue);
                stud.Divid = Convert.ToInt32(cmbDiv.SelectedValue);
                stud.City_Id = Convert.ToInt32(cmbCity.SelectedValue);
                stud.State_Id = Convert.ToInt32(cmbState.SelectedValue);
                stud.Country_Id = Convert.ToInt32(cmbCountry.SelectedValue);
                stud.Date_Of_Birth = dtDob.Value;
                stud.Date_Of_Addmission = dtAddDate.Value;
                stud.Gender = Gender;
                stud.Cast = Cast;
                stud.AadhaarNo = txtSAdhar.Text;
                byte[] bytes = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
                stud.Photo = bytes;
                if (StudDetail.AddStudent(stud) == 0)
                {
                    Speech("Successfully Saved");
                    MessageBox.Show("Successfully Saved", "OAS");
                    Clear();
                }
                else
                {
                    Speech("Data Already Exist");
                    MessageBox.Show("Data Already Exist", "OAS");
                }
            }
        }

        PopulateRegion Regions = new PopulateRegion();

        private void cmbCountry_DropDownClosed(object sender, EventArgs e)
        {
            Regions.PopulateState(cmbState, Convert.ToInt32(cmbCountry.SelectedValue));
            cmbState.Text = "Select State";
        }

        private void cmbState_DropDownClosed(object sender, EventArgs e)
        {
            Regions.PopulateCity(cmbCity, Convert.ToInt32(cmbState.SelectedValue));

            cmbCity.Text = "Select City";
        }

        string Cast = "General", Gender = "Male";
        private void rdbOBC_Click(object sender, EventArgs e)
        {
            Cast = "OBC";
        }
        private void rdbSC_Click(object sender, EventArgs e)
        {
            Cast = "SC/ST";
        }
        private void rdbGeneral_Click(object sender, EventArgs e)
        {
            Cast = "General";
        }

        private void rdbMale_Click(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rdbFemale_Click(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Validation();

            if (cnt == 0)
            {
                Student stud = new Student();
                stud = StudDetail.FetchData(GrNo);
                stud.General_Regis_No = txtGrNo.Text;
                stud.Date_Of_Addmission = dtAddDate.Value;
                stud.Student_Name = txtStudName.Text;
                stud.Father_Name = txtFather.Text;
                stud.Mother_Name = txtMother.Text;
                stud.Father_Occupation = txtFOcc.Text;
                stud.Mother_Occupation = txtMOcc.Text;
                stud.Guardian_Name = txtGN.Text;
                stud.Religion = txtReligion.Text;
                stud.Nationality = txtNationality.Text;
                stud.Previous_School_Name = txtSchool.Text;
                stud.Phone_No = txtPhno.Text;
                stud.HomePhoneNo = txtHpno.Text;
                stud.Address = txtAdd.Text;
                stud.Classid = Convert.ToInt32(cmbClass.SelectedValue);
                stud.Divid = Convert.ToInt32(cmbDiv.SelectedValue);
                stud.City_Id = Convert.ToInt32(cmbCity.SelectedValue);
                stud.State_Id = Convert.ToInt32(cmbState.SelectedValue);
                stud.Country_Id = Convert.ToInt32(cmbCountry.SelectedValue);
                stud.Date_Of_Birth = dtDob.Value;
                stud.Date_Of_Addmission = dtAddDate.Value;
                stud.Gender = Gender;
                stud.Cast = Cast;
                stud.AadhaarNo = txtSAdhar.Text;

                if (img != null)
                {
                    byte[] bytes = (byte[])(new ImageConverter()).ConvertTo(img, typeof(byte[]));
                    stud.Photo = bytes;
                }
                StudDetail.EditStudData(stud);
                Speech("Data Successfully Saved");
                MessageBox.Show("Data Successfully Saved", "OAS");
                this.Dispose();
              
            }

        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
