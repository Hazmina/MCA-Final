using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;
namespace BusinessLayer
{
    public class ManageBonoFiedCerti
    {
        OASEntities Entities = new OASEntities();

        public int AddBonofied(Bonofied Bono)
        {
            if (Entities.Bonofieds.Any(o => o.Gr_No == Bono.Gr_No && o.Class_Id == Bono.Class_Id))
            {
                return 1;
            }
            else
            {
                Entities.Bonofieds.Add(Bono);
                Entities.SaveChanges();
                return 0;
            }
        }
    }
}
