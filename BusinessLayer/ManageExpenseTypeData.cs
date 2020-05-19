using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;

namespace BusinessLayer
{
   public class ManageExpenseTypeData
    {
       OASEntities Entities = new OASEntities();

       public int AddExpenseTypeData(ExpenseType ET)
       {

           if(Entities.ExpenseTypes.Any(o => o.ExpType == ET.ExpType))
           {
               return 1;

           }
           else
           {
               Entities.ExpenseTypes.Add(ET);
               Entities.SaveChanges();
               return 0;
           }
       }

       public ExpenseType FetchData(int Id)
       {
           return Entities.ExpenseTypes.Find(Id);
       }
       public void EditData(ExpenseType ExpType)
       {
           Entities.Entry(ExpType).State = System.Data.Entity.EntityState.Modified;
           Entities.SaveChanges();
       }
       public void RemoveData(int id)
       {
           Entities.ExpenseTypes.Remove(FetchData(id));
           Entities.SaveChanges();
       }

    }

}
