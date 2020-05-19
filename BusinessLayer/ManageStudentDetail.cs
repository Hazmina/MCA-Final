using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;
namespace BusinessLayer
{
    public class ManageStudentDetail
    {
        OASEntities Entities = new OASEntities();
        public int AddStudent(Student stud)
        {
            if (Entities.Students.Any(o => o.Phone_No == stud.Phone_No && o.General_Regis_No == stud.General_Regis_No))
            {
                return 1;
            }
            else
            {
                Entities.Students.Add(stud);
                Entities.SaveChanges();
                return 0;
            }
        }

        public Student FetchData(string GrNo)
        {
            using (var db = new OASEntities())
            {
                return db.Students.Where(o=> o.General_Regis_No == GrNo).FirstOrDefault();
            }
        }

        public void EditStudData(Student Stud)
        {
            Entities.Entry(Stud).State = System.Data.Entity.EntityState.Modified;
            Entities.SaveChanges();
        }

    }
}
