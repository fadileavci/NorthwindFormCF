using NorthwindFormCF_entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindFormCF_DAL
{
   public class CustomerMapping:EntityTypeConfiguration<Customer>
    {

        public CustomerMapping()
        {
            ToTable("Customers");
            HasKey(c=> c.CustomerID);
        }

    }
}
