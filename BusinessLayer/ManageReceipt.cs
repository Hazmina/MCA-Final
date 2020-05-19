using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;
using System.Windows.Forms;
using DataBaseLayer;
namespace BusinessLayer
{
    public class ManageReceipt
    {
        OASEntities Entities = new OASEntities();

        public void AddReceipt(ReciptDetail RD)
        {
            Entities.ReciptDetails.Add(RD);
            Entities.SaveChanges();
        }

        public int GetRecptNo()
        {
            try
            {
                return Entities.ReciptDetails.Max(o => o.Reciept_id);
            }
            catch (Exception Exp)
            {
                return 0;
            }
        }

        public void PopulateCharge(ComboBox Cmb)
        {
            Cmb.DataSource = Entities.Charges.ToList();
            Cmb.ValueMember = "amount";
            Cmb.DisplayMember = "ch_name";
        }
    }
}
