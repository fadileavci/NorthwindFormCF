using NorthwindFormCF_entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindFormCF_DAL.Mapping
{
    public class OrderMapping:EntityTypeConfiguration<Order>
    {
        public OrderMapping()
        {
            ToTable("Orders");
            HasKey(o=> o.OrderID);
        }


    }
}
