using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseLayer;
using BusinessLayer;
namespace BusinessLayer
{
    public class ManageClass
    {
        OASEntities Entities = new OASEntities();

        public void PopulateClass(ComboBox cmbClass)
        {
            cmbClass.DataSource = Entities.ClassDetails.ToList();
            cmbClass.ValueMember = "ClassId";
            cmbClass.DisplayMember = "CName";
        }

        public void PopulateDivision(ComboBox cmbDiv,int ClassId)
        {
            cmbDiv.DataSource = Entities.Divisions.Where(o=> o.Class_id == ClassId).ToList();
            cmbDiv.ValueMember = "DivId";
            cmbDiv.DisplayMember = "DivName";
        }

    }
}
