using NorthwindFormCF_DAL;
using NorthwindFormCF_entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindFormCF_BLL
{
    public class CustomerBLL
    {

		public static NortwindDbContext db = new NortwindDbContext();
		public static List<Customer> GetCustomer()
        {
           
            return db.Customers.ToList();
        }

		public static void AddCustomer(Customer cus)
		{

			Customer customer = new Customer();
			customer.CustomerID = cus.CustomerID;
			customer.ContactName = cus.ContactName;
			customer.CompanyName = cus.CompanyName;
			customer.ContactTitle = cus.ContactTitle;
			customer.City = cus.City;
			customer.Address = cus.Address;
			customer.Fax = cus.Fax;
			customer.Phone = cus.Phone;
			customer.PostalCode = cus.PostalCode;
			customer.Region = cus.Region;

			db.Customers.Add(customer);
			db.SaveChanges();
			



				
		}



    }
}
