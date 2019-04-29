using NorthwindFormCF_DAL.Mapping;
using NorthwindFormCF_entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindFormCF_DAL
{
    public class NortwindDbContext:DbContext
    {

        public NortwindDbContext():base("name=ConnectionStringAdi")
        {
            Database.SetInitializer<NortwindDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMapping());
            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Configurations.Add(new EmployeeMapping());
        }

       

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

    }
}
