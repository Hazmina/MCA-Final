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
using System.Globalization;
using System.Speech.Synthesis;


namespace OAS
{
    public partial class ManageFeeDetailForm : Telerik.WinControls.UI.RadForm
    {
        int cnt = 0;
        StringHandling Sh = new StringHandling();
        public ManageFeeDetailForm()
        {
            InitializeComponent();
        }
        ManageFeeDetail MFD = new ManageFeeDetail();

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void ManageFeeDetail_Load(object sender, EventArgs e)
        {
            Clear();
            MFD.PopulateClass(cmbClass);
            this.feeDetailTableAdapter.Fill(this.feeDetailDataSet.FeeDetail, Convert.ToInt32(cmbClass.SelectedValue));
            GridViewImageColumn EditColumn = new GridViewImageColumn();
            EditColumn.Name = "Edit";
            //imageColumn.FieldName = "Photo";
            EditColumn.HeaderText = "Edit";
            EditColumn.ImageLayout = ImageLayout.Zoom;
            radGridView1.MasterTemplate.Columns.Insert(4, EditColumn);

            GridViewImageColumn DeleteColumn = new GridViewImageColumn();
            DeleteColumn.Name = "Delete";
            //imageColumn.FieldName = "Photo";
            DeleteColumn.HeaderText = "Delete";
            DeleteColumn.ImageLayout = ImageLayout.Zoom;
            radGridView1.MasterTemplate.Columns.Insert(5, DeleteColumn);

            for (int i = 0; i < radGridView1.Rows.Count; i++)
            {
                radGridView1.Rows[i].Height = 40;
            }

            GridViewSummaryItem Amount = new GridViewSummaryItem("Amount", "TOTAL: {0}", GridAggregateFunction.Sum);

            GridViewSummaryRowItem subtotalRow = new GridViewSummaryRowItem(new GridViewSummaryItem[] { Amount });
            this.radGridView1.SummaryRowsBottom.Add(subtotalRow);
            this.radGridView1.ViewCellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);
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
                    cnt++;
                    lbl.Text = "*Required";
                }
                else
                {
                    lbl.Text = "*";
                }
            }

        }

        public void Validation()
        {
            cnt = 0;
            IsEmpty(txtFeeType, lblErrFeeType);
            TextLimit(txtFeeType, lblErrFeeType, 28);
            if (txtAmt.Text == "₹ 0.00")
            {
                cnt++;
                lblErrAmt.Text = "*Required";
            }
            else
            {
                lblErrAmt.Text = "*";
            }

        }
        public void Clear()
        {
            txtFeeType.Text = "";
            txtAmt.Text = "";
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
        }
        public void Speech(string Message)
        {
            SpeechSynthesizer Sapi = new SpeechSynthesizer();
            Sapi.SpeakAsync(Message);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cnt == 0)
            {
                FeeDetail FD = new FeeDetail();
                FD.FeeType = txtFeeType.Text;
                FD.Amount = Convert.ToDouble(Sh.ExtractDecimalFromString(txtAmt.Text));
                FD.Classid = Convert.ToInt32(cmbClass.SelectedValue);
                MessageBox.Show(cmbClass.SelectedValue + " " + txtFeeType.Text);
                if (MFD.AddFeeDetail(FD) == 0)
                {
                    Speech("Data Successfully Saved");
                    MessageBox.Show("Data Successfully Saved");
                    this.feeDetailTableAdapter.Fill(this.feeDetailDataSet.FeeDetail, Convert.ToInt32(cmbClass.SelectedValue));
                }
                else
                {
                    Speech("Data Already Exist");
                    MessageBox.Show("Data Already Exist");
                }
                Clear();
            }
        }

        private void cmbClass_DropDownClosed(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'feeDetailDataSet.FeeDetail' table. You can move, or remove it, as needed.
            this.feeDetailTableAdapter.Fill(this.feeDetailDataSet.FeeDetail, Convert.ToInt32(cmbClass.SelectedValue));
        }

        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            ImageList imagesList = new ImageList();
            e.CellElement.ForeColor = Color.Black;
            Image Editimage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"/edit-12-32.ico");
            imagesList.Images.Add(Editimage);

            Image Deleteimage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"/delete-32.ico");
            imagesList.Images.Add(Deleteimage);

            if (e.CellElement.ColumnIndex == 4)
            {
                e.CellElement.Image = imagesList.Images[0];
            }
            else if (e.CellElement.ColumnIndex == 5)
            {
                e.CellElement.Image = imagesList.Images[1];
            }
            else if (e.CellElement.ColumnIndex == 3)
            {
                CultureInfo cultureInfo = new CultureInfo("en-IN");
                e.CellElement.Text = String.Format(cultureInfo, "{0:C}", e.CellElement.Value);
            }
        }

        private void radGridView1_GroupSummaryEvaluate(object sender, GroupSummaryEvaluationEventArgs e)
        {
            if (e.SummaryItem.Name == "Amount")
            {
                CultureInfo cultureInfo = new CultureInfo("en-IN");
                e.Value = String.Format(cultureInfo, "{0:C}", e.Value);
            }
        }
        int Id;
        public void Fetch()
        {
            this.feeDetailTableAdapter.Fill(this.feeDetailDataSet.FeeDetail, Convert.ToInt32(cmbClass.SelectedValue));
            for (int i = 0; i < radGridView1.Rows.Count; i++)
            {
                radGridView1.Rows[i].Height = 40;
            }
        }
        private void radGridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView1.CurrentCell.ColumnIndex == 4)
                {
                    Id = Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value);
                    txtFeeType.Text = radGridView1.CurrentRow.Cells[2].Value.ToString();
                    txtAmt.Text = radGridView1.CurrentRow.Cells[3].Value.ToString();
                    cmbClass.SelectedValue = radGridView1.CurrentRow.Cells[1].Value;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                }
                else if (radGridView1.CurrentCell.ColumnIndex == 5)
                {
                    int id = Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value);
                    Speech("Are You Sure Want to Delete That Recored!");
                    string confirm = MessageBox.Show("Are You Sure Want to Delete That Recored!", "Walfare OAS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk).ToString();
                    if (confirm == "Yes")
                    {
                        MFD.DeleteData(id);
                        Fetch();
                    }
                }
            }
            catch (Exception exp)
            { 
                
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cnt == 0)
            {
                FeeDetail FD = new FeeDetail();
                FD = MFD.FetchData(Id);
                FD.FeeType = txtFeeType.Text;
                FD.Amount = Convert.ToDouble(Sh.ExtractDecimalFromString(txtAmt.Text));
                FD.Classid = Convert.ToInt32(cmbClass.SelectedValue);
                MFD.EditFeeDetail(FD);
                Clear();
                Fetch();
                Speech("Data Successfully Changed");
                MessageBox.Show("Data Successfully Changed");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }

}
