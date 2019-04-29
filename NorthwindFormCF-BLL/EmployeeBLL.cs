using NorthwindFormCF_DAL;
using NorthwindFormCF_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindFormCF_BLL
{
 public   class EmployeeBLL
    {

        public static NortwindDbContext db = new NortwindDbContext();
        public static List<OrderDto> searchOrderEmploye(string SearchText)
        {

            var Sorgu = from c in db.Customers
                        join o in db.Orders on c.CustomerID equals o.CustomerID join e in db.Employees
                        on o.EmployeeID equals e.EmployeeID
                        where e.FirstName.Contains(SearchText) || c.ContactName.Contains(SearchText)

                        select new OrderDto
                        {
                            EmployeeID = e.EmployeeID,
                            OrderID = o.OrderID,
                            ContactName = c.ContactName,
                            ShipCountry = o.ShipCountry,
                            FirstName = e.FirstName   
                        };

            return Sorgu.ToList();

        }


    }
}
