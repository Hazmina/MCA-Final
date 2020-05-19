using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class ManageExpenseData
    {
        OASEntities Entities  = new OASEntities();

        public int AddExpenseData(Expense E)
        {
            Entities.Expenses.Add(E);
            Entities.SaveChanges();
            return 0;
        }

        

        public Expense FetchData(int ExpId)
        {
            return Entities.Expenses.Find(ExpId);
        }

        public void PopulateExpenseType(ComboBox CmbExpType)
        {
            CmbExpType.DataSource = Entities.ExpenseTypes.ToList();
            CmbExpType.ValueMember =  "ExpTypeId";
            CmbExpType.DisplayMember ="ExpType";
        }

        public void EditData(Expense E)
        {
            Entities.Entry(E).State = System.Data.Entity.EntityState.Modified;
            Entities.SaveChanges();
        }

        public void DeleteData(int Id)
        {
            Expense Exp = new Expense();
            Exp = Entities.Expenses.Find(Id);
            Entities.Expenses.Remove(Exp);
            Entities.SaveChanges();

        }
   }
    
}
