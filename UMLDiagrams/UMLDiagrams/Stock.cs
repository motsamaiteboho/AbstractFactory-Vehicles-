using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLDiagrams
{
    class Stock
    {
        private List<CVehicle> lstVehicles;

        public Stock()
        {
            lstVehicles = new List<CVehicle>();
        }
        
        public void AddVehicle(CVehicle vehicle)
        {
            lstVehicles.Add(vehicle);
        }

        public List<CVehicle> ListStock()
        {
            return lstVehicles;
        }
    }
}
