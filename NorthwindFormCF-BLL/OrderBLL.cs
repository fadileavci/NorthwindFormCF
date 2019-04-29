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

       public static NortwindDbContext db = new NortwindDbContext();
        public static List<Order> GetOrder(string CustomerID)
        {
            
            return db.Orders.Where(o => o.CustomerID == CustomerID).ToList(); 
        }

        public static List<OrderDto> searchOrder(string SearchText)
        {

            var Sorgu = from c in db.Customers
                        join o in db.Orders on c.CustomerID  equals o.CustomerID
                        where c.ContactName.Contains(SearchText) 

                        select new OrderDto
                        {

                           OrderID = o.OrderID,
                             ContactName=c.ContactName,
                              ShipCountry =o.ShipCountry
                        };

            return Sorgu.ToList();

        }


        
    }
}
