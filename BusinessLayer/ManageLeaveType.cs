using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class ManageLeaveType
    {
        OASEntities Entities = new OASEntities();

        public int AddLeaveType(LeaveType LT)
        {
            if(Entities.LeaveTypes.Any(o=> o.L_Name == LT.L_Name))
            {
                return 1;
            }
            else
            {
                Entities.LeaveTypes.Add(LT);
                Entities.SaveChanges();
                return 0;
            }
        }
        public void DeleteData(int? LeaveType_Id)
        {
            LeaveType LT = Entities.LeaveTypes.Find(LeaveType_Id);
            Entities.LeaveTypes.Remove(LT);
            Entities.SaveChanges();
        }
        public void DeleteStaffLeave(int? Leave_Id)
        {
            LeaveTaken LT = Entities.LeaveTakens.Find(Leave_Id);
            Entities.LeaveTakens.Remove(LT);
            Entities.SaveChanges();
        }
        public LeaveType FetchData(int? LeaveType_Id)
        {
            LeaveType LT = Entities.LeaveTypes.Find(LeaveType_Id);
            return LT;
        }
        public void EditLeaveTypeData(LeaveType LT)
        {
            Entities.Entry(LT).State = System.Data.Entity.EntityState.Modified;
            Entities.SaveChanges();
        }

        public void PopulateLeave(ComboBox CmbLeave)
        {
            CmbLeave.DataSource = Entities.LeaveTypes.ToList();
            CmbLeave.ValueMember = "Ltype_Id";
            CmbLeave.DisplayMember = "L_Name";
        }
    }
}
