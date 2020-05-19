using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using BusinessLayer;
using DataBaseLayer;
using Telerik.WinControls.UI;
using System.Speech.Synthesis;
namespace OAS
{
    public partial class ExpenseTypeForm : Telerik.WinControls.UI.RadForm
    {
        public ExpenseTypeForm()
        {
            InitializeComponent();
        }
        int cnt = 0;
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
        private void ExpenseTypeForm_Load(object sender, EventArgs e)
        {
            Clear();
            
            // TODO: This line of code loads data into the 'expenseTypeDataSet.ExpenseType' table. You can move, or remove it, as needed.
            this.expenseTypeTableAdapter.Fill(this.expenseTypeDataSet.ExpenseType);
            GridViewImageColumn EditColumn = new GridViewImageColumn();
            EditColumn.Name = "Edit";
            //imageColumn.FieldName = "Photo";
            EditColumn.HeaderText = "Edit";
            EditColumn.ImageLayout = ImageLayout.Zoom;
            radGridView1.MasterTemplate.Columns.Insert(2, EditColumn);

            GridViewImageColumn DeleteColumn = new GridViewImageColumn();
            DeleteColumn.Name = "Delete";
            //imageColumn.FieldName = "Photo";
            DeleteColumn.HeaderText = "Delete";
            DeleteColumn.ImageLayout = ImageLayout.Zoom;
            radGridView1.MasterTemplate.Columns.Insert(3, DeleteColumn);
        }
        ManageExpenseTypeData METD = new ManageExpenseTypeData();
        public void Validation()
        {
            cnt = 0;
            IsEmpty(txtInvoice, lblErrExp);
            TextLimit(txtInvoice, lblErrExp, 18);
        }
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
                ExpenseType ET = new ExpenseType();
                ET.ExpType = txtInvoice.Text;
                if (METD.AddExpenseTypeData(ET) == 0)
                {
                    Speech("Data Successfully Saved");
                    MessageBox.Show("Data Successfully Saved", "OAS");
                    Clear();
                    this.expenseTypeTableAdapter.Fill(this.expenseTypeDataSet.ExpenseType);
                }
                else
                {
                    Speech("Data Already Exist");
                    MessageBox.Show("Data Already Exist", "OAS");
                }
            } 
        }

        public void Clear()
        {
            txtInvoice.Text = "";
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }
        private void radGridView1_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            ImageList imagesList = new ImageList();
            e.CellElement.ForeColor = Color.Black;
            Image Editimage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"/edit-12-32.ico");
            imagesList.Images.Add(Editimage);

            Image Deleteimage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"/delete-32.ico");
            imagesList.Images.Add(Deleteimage);

            if (e.CellElement.ColumnIndex == 2)
            {
                e.CellElement.Image = imagesList.Images[0];
            }
            else if (e.CellElement.ColumnIndex == 3)
            {
                e.CellElement.Image = imagesList.Images[1];
            }
        }

        private void radGridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView1.CurrentCell.ColumnIndex == 2)
                {
                    txtInvoice.Text = radGridView1.CurrentRow.Cells[1].Value.ToString();
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                }
                else if (radGridView1.CurrentCell.ColumnIndex == 3)
                {
                    int id = Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value);
                    string confirm = MessageBox.Show("Are You Sure Want to Delete That Recored!", "Walfare OAS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk).ToString();
                    if (confirm == "Yes")
                    {
                        METD.RemoveData(id);
                        Speech("Data Successfully Deleted");
                        MessageBox.Show("Data Successfully Deleted");
                        this.expenseTypeTableAdapter.Fill(this.expenseTypeDataSet.ExpenseType);
                        for (int i = 0; i < radGridView1.Rows.Count; i++)
                        {
                            radGridView1.Rows[i].Height = 40;
                        }
                    }
                }
            }
            catch (Exception exp)
            { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ExpenseType ET = new ExpenseType();
            ET = METD.FetchData(Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value));
            ET.ExpType = txtInvoice.Text;
            METD.EditData(ET);
            Speech("Data Successfully Edited");
            MessageBox.Show("Data Successfully Edited");
            this.expenseTypeTableAdapter.Fill(this.expenseTypeDataSet.ExpenseType);
            Clear();
        }
    }
}
