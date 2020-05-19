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
using Spire.Barcode;

namespace OAS
{
    public partial class ShowStudDataForm : Telerik.WinControls.UI.RadForm
    {
        public ShowStudDataForm()
        {
            InitializeComponent();
        }
        private void ShowStudDataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentListDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentListDataSet.Student);
            // TODO: This line of code loads data into the 'studentListDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentListDataSet.Student);
            FetchData();

        }
        ManageStudentDetail StudDetail = new ManageStudentDetail();
        int classId,studId;
        Image Img;
        string Div;
        public void FetchData()
        {
            try
            {
                Student stud = new Student();
                stud = StudDetail.FetchData(radGridView1.CurrentRow.Cells[2].Value.ToString());
                classId = Convert.ToInt32(stud.Classid);
                studId = stud.Stud_Id;
                lblStudName.Text = stud.Student_Name;
                lblFatherName.Text = stud.Father_Name;
                lblMotherName.Text = stud.Mother_Name;
                lblFatheOcc.Text = stud.Father_Occupation;
                lblMotherOcc.Text = stud.Mother_Occupation;
                lblgname.Text = stud.Guardian_Name;
                lblPhone.Text = stud.Phone_No;
                lblHomePhone.Text = stud.HomePhoneNo;
                lblAddress.Text = stud.Address;
                lblcast.Text = stud.Cast;
                lblgender.Text = stud.Gender;
                classId = Convert.ToInt32(stud.Classid);
                lblreligion.Text = stud.Religion;
                lblnationality.Text = stud.Nationality;
                lblpschool.Text = stud.Previous_School_Name;
                lblAadhar.Text = stud.AadhaarNo;
                lbldob.Text = Convert.ToDateTime(stud.Date_Of_Birth).ToShortDateString();
                lbldoa.Text = Convert.ToDateTime(stud.Date_Of_Addmission).ToShortDateString();
                Div = radGridView1.CurrentRow.Cells[1].Value.ToString();
                MemoryStream MS = new MemoryStream(stud.Photo);
                Img = Image.FromStream(MS);
                StudPic.Image = Img;

            }
            catch (Exception exp)
            { 
            
            }
           
        }

        private void radGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            FetchData();
        }

        private void radGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            FetchData();
        }

        private void radGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            FetchData();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddStudentForm ASF = new AddStudentForm();
            ASF.GrNo = radGridView1.CurrentRow.Cells[2].Value.ToString();
            ASF.ShowDialog();
        }
        private void ShowStudDataForm_Activated(object sender, EventArgs e)
        {
            FetchData();
        }
        private void btnBonofied_Click(object sender, EventArgs e)
        {
            GenerateBonofied();
            GenerateBonofiedForm GBF = new GenerateBonofiedForm();
            GBF.GrNo = radGridView1.CurrentRow.Cells[2].Value.ToString();
            GBF.classId = classId;
            GBF.ShowDialog();
        }
        public void GenerateBonofied()
        {
            StudPic.Image.Save(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Pic.jpg");
            using (StreamWriter writer =
            new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BonofiedCertificate.html"))
            {
                writer.WriteLine("<html><head><meta http-equiv='Content-Type' content='text/html; charset=iso-8859-1' /></head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<table style='width:100%'>");
                writer.WriteLine("<tr><td align='center'>Managed By:- Bharuch Welfare Hospital & Education Trust.<br /><font size='8'>Bharuch Welfare School</font><br /> Welfare Dental & Nursing Building<br /> Nr, Manubar Chokdi Road, Bharuch.<br />Phone:- 02642-112457<br/> <br/> </td></tr>");
                writer.WriteLine("<tr><td align='center'> <font style='font-style:italic; font-size:40px;'>Bonofied Certificate</font><br/> <br/> </td></tr>");
                writer.WriteLine(" <tr><td align='center'> <img src='" + System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Pic.jpg' height='150' /><br /><br /></td> </tr>");
                writer.WriteLine("<tr><td align='center'><font style='font-style:italic; font-size:larger'> This is to certify that Shri/Kumari</font><br/><font style='font-style:italic; font-family:Arial; font-size:x-large'>" + lblStudName.Text + "</font> <br/><font style='font-style:italic; font-size:larger'> is/was a bonofide student of this</font><br/> <font style='font-style:italic; font-size:larger'> school and is/was studying in standard</font><br /><font style='font-style:italic; font-family:Arial; font-size:x-large'>" + radGridView1.CurrentRow.Cells[0].Value + "</font><font style='font-style:italic; font-size:larger'> during the year</font><font style='font-style:italic; font-family:Arial; font-size:x-large'>" + Convert.ToDateTime(lbldoa.Text).Year + "-" + ( Convert.ToInt32(Convert.ToDateTime(lbldoa.Text).Year) + 1 ) + "</font><br /><br /> <br /> <br /><br /><br /> <br /> <br /></td></tr>");
                writer.WriteLine(" <tr style='height:100px'><td valign='bottom'><table style='width:100%'><tr><td> <b style='font-size:larger'> Date: " + System.DateTime.Today.ToShortDateString() +  "</b><br /><b style ='font-size:larger'> Place: Bharuch</b></td><td align='right'><b style='font-size:larger'>Bharuch Welfare School</b>&nbsp;&nbsp;&nbsp;&nbsp;<br /> <br /> <br /> <b style='font-size:larger'>  Principal Signature </b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td> </tr> </table></td></tr>");
                writer.WriteLine("</table>");
                writer.WriteLine("</body></html>");
            }
            
        }
        private void btnFeeCollection_Click(object sender, EventArgs e)
        {
            FeesCollection Fc = new FeesCollection();
            Fc.lblGrNo.Text = radGridView1.CurrentRow.Cells[2].Value.ToString();
            Fc.lblStudName.Text = lblStudName.Text;
            Fc.lblreligion.Text = lblreligion.Text;
            Fc.lblCast.Text = lblcast.Text;
            Fc.lbldoa.Text = lbldoa.Text;
            Fc.Img = Img;
            Fc.ClassId = classId;
            Fc.StudId = studId;
            Fc.Div = Div;
            Fc.Class = radGridView1.CurrentRow.Cells[0].Value.ToString();
            Fc.ShowDialog();
        }
        public BarcodeSettings settings;
        public void Barcode(string data)
        {
            settings = new BarcodeSettings();

            settings.Data2D = data;
            settings.Data = data;


            settings.Type = (BarCodeType)Enum.Parse(typeof(BarCodeType), "Code128");

            short fontSize = 8;

            settings.TextFont = new System.Drawing.Font("Arial Black", fontSize, FontStyle.Bold);

            short barHeight = 15;
            settings.BarHeight = barHeight;
            settings.ShowText = true;

            settings.ForeColor = Color.FromName("Black");

            //generate the barcode use the settings
            BarCodeGenerator generator = new BarCodeGenerator(settings);
            System.Drawing.Image barcode = generator.GenerateImage();

            string Path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Barcode.png";
           
            barcode.Save(Path);
            //Image3.ImageUrl = "~/Admin/Barcode/barcode.png" + "?" + System.DateTime.Now.Ticks.ToString();
            //launch the generated barcode image
            //System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + @"\barcode.png");
        }
        private void btnICard_Click(object sender, EventArgs e)
        {
            StudPic.Image.Save(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Pic.jpg");
            using (StreamWriter writer =
            new StreamWriter(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\StudIcard.html"))
            {
                Barcode(radGridView1.CurrentRow.Cells[2].Value.ToString());
                writer.WriteLine("<html><head><meta http-equiv='Content-Type' content='text/html; charset=iso-8859-1' /></head>");
                writer.WriteLine("<body>");
                writer.WriteLine("<table width='40%'>");
                writer.WriteLine("<tr align='centre'><td colspan='2' align='center' bgcolor='skyblue'> <font size='3' color='white'> <b>Bharuch Welfare School</b> </font><br /><font size='2' color='white'> Welfare Dental & Nursing Building<br />Nr, Manubar Chokdi Road, Bharuch.<br /> Phone:- 02642-112457</font></td></tr>");
                writer.WriteLine("<tr><td colspan='2' align='center'><img src='" + System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Pic.jpg' style='width:80px ; height:80px ; border-radius:50%'></td></tr>");
                writer.WriteLine(" <tr> <td colspan='2' align='center'><font size='1'><img src='" +  System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Barcode.png" + "'></td></tr>");
                writer.WriteLine(" <tr> <td colspan='2' align='center'><font size='1'><b>Date of Addmission:</b>&nbsp;&nbsp;" + string.Format("{0:dd MMMM yyyy}", Convert.ToDateTime(lbldoa.Text)) + " </font></td></tr>");
                writer.WriteLine("<tr> <td > <font size='1'><b>Student:</td><td><font size='1'>" + lblStudName.Text + " </font> </td></tr>");
                writer.WriteLine(" <tr> <td > <font size='1'><b>Father:</td><td><font size='1'>" + lblFatherName.Text + "</font> </td></tr>");
                writer.WriteLine("<tr> <td > <font size='1'><b>DOB:</td><td><font size='1'>" + Convert.ToDateTime(lbldob.Text).ToShortDateString() + "</font> </td></tr> ");
                writer.WriteLine("<tr> <td > <font size='1'><b>Contact:</td><td><font size='1'>" + lblPhone.Text + "</font> </td></tr> ");
                writer.WriteLine("<tr><td colspan='2' align='right'><br><br><b>Principal Signature&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</b></td></tr>");
                writer.WriteLine("<tr><td align='center' colspan='2' bgcolor='skyblue'><font size='3' color='white'> <b> Dedicated To Excellence</b></font><br /></td></tr>");
                writer.WriteLine("</table>");
                writer.WriteLine("</body></html>");

                
            }

            GenerateICardForm GIF = new GenerateICardForm();
            GIF.ShowDialog();
        }
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            PaymentMode PM = new PaymentMode();
            PM.lblClass.Text = radGridView1.CurrentRow.Cells[0].Value.ToString();
            PM.lblDiv.Text = radGridView1.CurrentRow.Cells[1].Value.ToString();
            PM.lblGrNo.Text = radGridView1.CurrentRow.Cells[2].Value.ToString();
            PM.lblStudName.Text = radGridView1.CurrentRow.Cells[3].Value.ToString();
            PM.Img = Img;
            PM.lbldoa.Text = lbldoa.Text;
            PM.ShowDialog();
        }
    }
}
