using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindFormCF_entity
{
   public class OrderDto
    {
      
     
            public int OrderID { get; set; }
            public string ContactName { get; set; }
            public string ShipCountry { get; set; }


        public int EmployeeID { set; get;  }
        public string FirstName { set; get; }

      

    }
}
