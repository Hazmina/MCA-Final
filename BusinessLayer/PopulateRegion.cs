using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseLayer;
namespace BusinessLayer
{
    public class PopulateRegion
    {
        OASEntities Entities = new OASEntities();
        public void PopulateCountry(ComboBox cmb)
        {
            cmb.DataSource = Entities.Countries.ToList();
            cmb.ValueMember = "Country_Id";
            cmb.DisplayMember = "Country_Name";
        }
        public void PopulateState(ComboBox cmb,int CountryId)
        {
            cmb.DataSource = Entities.States.Where(o=> o.Country_Id == CountryId).ToList();
            cmb.ValueMember = "State_Id";
            cmb.DisplayMember = "State_Name";
        }
        public void PopulateCity(ComboBox cmb, int StateId)
        {
            cmb.DataSource = Entities.Cities.Where(o => o.State_Id == StateId).ToList();
            cmb.ValueMember = "City_Id";
            cmb.DisplayMember = "City_Name";
        }
    }
}
