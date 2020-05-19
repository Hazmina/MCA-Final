using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;
using System.Data;
namespace BusinessLayer
{
    public class ManageStaff
    {
        OASEntities Entities = new OASEntities();
        EncriptionDecryption Enc = new EncriptionDecryption();
        public Staff Fetch(int Id)
        {
            return Entities.Staffs.Where(o => o.Staffid == Id).FirstOrDefault();
        }
        public int AddLeaveTaken(LeaveTaken LT)
        {
            if (Entities.LeaveTakens.Any(o => o.F_Date == LT.F_Date && o.T_Date == LT.T_Date))
            {
                return 1;
            }
            else
            {
                Entities.LeaveTakens.Add(LT);
                Entities.SaveChanges();
                return 0;
            }
        }
        public int AddTransactionAllowance(TransactionAllowance TA)
        {
            if (Entities.TransactionAllowances.Any(o => o.F_Date == TA.F_Date && o.T_Date == TA.T_Date && o.Staff_Id == TA.Staff_Id))
            {
                return 1;
            }
            else
            {
                Entities.TransactionAllowances.Add(TA);
                Entities.SaveChanges();
                return 0;
            }
        }
        public int AddStaffSalary(SalaryDetail SD)
        {
            if (Entities.SalaryDetails.Any(o => o.DateFrom == SD.DateFrom && o.DateTo == SD.DateTo && o.Staff_Id == SD.Staff_Id))
            {
                return 1;
            }
            else
            {
                Entities.SalaryDetails.Add(SD);
                Entities.SaveChanges();
                return 0;
            }
        }
        public DataTable LoginProcess(string UserName, string Passwd)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("StaffName", System.Type.GetType("System.String"));
            dt.Columns.Add("UserName", System.Type.GetType("System.String"));
            dt.Columns.Add("Email", System.Type.GetType("System.String"));
            Passwd = Enc.Encrypt(Passwd);
            try
            {
                var data = (from staff in Entities.Staffs
                            join acclogin in Entities.AccountantLogins on staff.Staffid equals acclogin.Staffid
                            select new
                            {
                                staffname = staff.FNname + " " + staff.Mname + " " + staff.Lname,
                                acclogin.Password,
                                acclogin.UserName,
                                acclogin.Email
                            }
                ).Where(o => o.UserName == UserName && o.Password == Passwd).FirstOrDefault();

                DataRow newrow = dt.NewRow();
                newrow["StaffName"] = data.staffname;
                newrow["UserName"] = data.UserName;
                newrow["Email"] = data.Email;
                dt.Rows.Add(newrow);
            }
            catch (Exception Exp)
            { 
                
            }
            
            return dt;
        }

       
    }
}
