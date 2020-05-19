using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using DataBaseLayer;
using BusinessLayer;
using System.Speech.Synthesis;
namespace OAS
{
    public partial class ShowExpDetailForm : Telerik.WinControls.UI.RadForm
    {
        public ShowExpDetailForm()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            ExpenseForm EF = new ExpenseForm();
            EF.ShowDialog();
        }

        private void ShowExpDetailForm_Load(object sender, EventArgs e)
        {

            Fetch();
        }

        public void Fetch()
        {
            // TODO: This line of code loads data into the 'showExpenseDetailDataSet.Expense' table. You can move, or remove it, as needed.
            this.expenseTableAdapter.Fill(this.showExpenseDetailDataSet.Expense);
            GridViewImageColumn EditColumn = new GridViewImageColumn();
            EditColumn.Name = "Edit";
            //imageColumn.FieldName = "Photo";
            EditColumn.HeaderText = "Edit";
            EditColumn.ImageLayout = ImageLayout.Zoom;
            radGridView1.MasterTemplate.Columns.Insert(9, EditColumn);

            GridViewImageColumn DeleteColumn = new GridViewImageColumn();
            DeleteColumn.Name = "Delete";
            //imageColumn.FieldName = "Photo";
            DeleteColumn.HeaderText = "Delete";
            DeleteColumn.ImageLayout = ImageLayout.Zoom;
            radGridView1.MasterTemplate.Columns.Insert(10, DeleteColumn);

            for (int i = 0; i < radGridView1.Rows.Count; i++)
            {
                radGridView1.Rows[i].Height = 40;
            }

            GridViewSummaryItem Amount = new GridViewSummaryItem("Amount", "TOTAL: {0}", GridAggregateFunction.Sum);
            GridViewSummaryRowItem subtotalRow = new GridViewSummaryRowItem(new GridViewSummaryItem[] { Amount });
            this.radGridView1.SummaryRowsBottom.Add(subtotalRow);
            this.radGridView1.ViewCellFormatting += new CellFormattingEventHandler(radGridView1_CellFormatting);
        }

        private void ShowExpDetailForm_Activated(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'showExpenseDetailDataSet.Expense' table. You can move, or remove it, as needed.
            this.expenseTableAdapter.Fill(this.showExpenseDetailDataSet.Expense);
            for (int i = 0; i < radGridView1.Rows.Count; i++)
            {
                radGridView1.Rows[i].Height = 40;
            }
        }

        private void radGridView1_CellFormatting(object sender, Telerik.WinControls.UI.CellFormattingEventArgs e)
        {
            ImageList imagesList = new ImageList();
            e.CellElement.ForeColor = Color.Black;
            Image Editimage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"/edit-12-32.ico");
            imagesList.Images.Add(Editimage);

            Image Deleteimage = Image.FromFile(AppDomain.CurrentDomain.BaseDirectory + @"/delete-32.ico");
            imagesList.Images.Add(Deleteimage);

            if (e.CellElement.ColumnIndex == 9)
            {
                e.CellElement.Image = imagesList.Images[0];
            }
            else if (e.CellElement.ColumnIndex == 10)
            {
                e.CellElement.Image = imagesList.Images[1];
            }
            else if (e.CellElement.ColumnIndex == 5)
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

        ManageExpenseData ManageExp = new ManageExpenseData();
        public void Speech(string Message)
        {
            SpeechSynthesizer Sapi = new SpeechSynthesizer();
            Sapi.SpeakAsync(Message);
        }
        private void radGridView1_CellClick(object sender, GridViewCellEventArgs e)
        {
            try
            {
                if (radGridView1.CurrentCell.ColumnIndex == 9)
                {
                    ExpenseForm EF = new ExpenseForm();
                    EF.ExpId = Convert.ToInt32( radGridView1.CurrentRow.Cells[0].Value);
                    EF.ShowDialog();
                }
                else if (radGridView1.CurrentCell.ColumnIndex == 10)
                {
                    int id = Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value);
                    Speech("Are You Sure Want to Delete That Recored!");
                    string confirm = MessageBox.Show("Are You Sure Want to Delete That Recored!", "Walfare OAS", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk).ToString();
                    if (confirm == "Yes")
                    {
                        ManageExp.DeleteData(id);
                        Speech("Successfully Deleted");
                        MessageBox.Show("Successfully Deleted","OAS");
                        // TODO: This line of code loads data into the 'showExpenseDetailDataSet.Expense' table. You can move, or remove it, as needed.
                        this.expenseTableAdapter.Fill(this.showExpenseDetailDataSet.Expense);
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

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
