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


        public static List<Customer> GetCustomer()
        {
            NortwindDbContext db = new NortwindDbContext();
            return db.Customers.ToList();
        }


    }
}
