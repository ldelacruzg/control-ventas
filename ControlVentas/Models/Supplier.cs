using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlVentas.Models
{
    public class Supplier : Company
    {
        private int supplierID;
        private Occupation occupation;

        public Supplier()
        {
        }

        public int SupplierID { get => supplierID; set => supplierID = value; }
        public Occupation Occupation { get => occupation; set => occupation = value; }
    }
}
