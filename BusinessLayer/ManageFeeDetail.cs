using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;
using System.Windows.Forms;

namespace BusinessLayer
{
    public class ManageFeeDetail
    {
        OASEntities Entities = new OASEntities();

        public int AddFeeDetail(FeeDetail FD)
        {
            if (Entities.FeeDetails.Any(o => o.Classid == o.Classid || o.FeeType == o.FeeType))
            {
                return 1;
            }
            else
            {
                Entities.FeeDetails.Add(FD);
                Entities.SaveChanges();
                return 0;
            }
        }
        public FeeDetail FetchData(int FeeId)
        {
            return Entities.FeeDetails.Find(FeeId);
        }
        public void EditFeeDetail(FeeDetail FD)
        {
            Entities.Entry(FD).State = System.Data.Entity.EntityState.Modified;
            Entities.SaveChanges();
        }
        public void PopulateClass(ComboBox CmbClass)
        {
            CmbClass.DataSource = Entities.ClassDetails.ToList();
            CmbClass.ValueMember = "ClassId";
            CmbClass.DisplayMember = "CName";
        }
        public void DeleteData(int FeeId)
        {
            FeeDetail FD = new FeeDetail();
            FD = Entities.FeeDetails.Find(FeeId);
            Entities.FeeDetails.Remove(FD);
            Entities.SaveChanges();
        }

        public FeeCollection FetchFeeData(int StudId,int ClassId)
        {
            return Entities.FeeCollections.OrderByDescending(o=> o.FeeCollectionId).Where(o => o.Studid == StudId && o.Classid == ClassId).FirstOrDefault();
        }

        public int AddFeeCollectionData(FeeCollection Fc)
        {
            if (Entities.FeeCollections.Any(o => o.Classid == Fc.Classid && o.LastMonth == Fc.LastMonth && o.Studid == Fc.Studid))
            {
                return 1;
            }
            else
            {
                Entities.FeeCollections.Add(Fc);
                Entities.SaveChanges();
                return 0;
            }

        }

        public FeeConcession FetchConcession(string Caste)
        {
            return Entities.FeeConcessions.Where(o => o.Cast == Caste).FirstOrDefault();
        }
    }
}
