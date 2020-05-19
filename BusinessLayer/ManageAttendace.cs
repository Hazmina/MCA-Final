using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;

namespace BusinessLayer
{
    public class ManageAttendace
    {
        OASEntities Entities = new OASEntities();
        public int AddAttendance(Attendance ATD)
        {
            //&& o.Att_Date == ATD.Att_Date
            if (Entities.Attendances.Any(o => o.RFID_Id == ATD.RFID_Id ))
            {
                return 1;
            }
            else
            {
                Entities.Attendances.Add(ATD);
                Entities.SaveChanges();
                return 0;
            }
        }
    }
}
