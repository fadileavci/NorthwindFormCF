using NorthwindFormCF_DAL;
using NorthwindFormCF_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindFormCF_BLL
{
    public class OrderBLL
    {


        public static List<Order> GetOrder(string CustomerID)
        {
            NortwindDbContext db = new NortwindDbContext();
            return db.Orders.Where(o => o.CustomerID == CustomerID).ToList(); 
        }



    }
}
