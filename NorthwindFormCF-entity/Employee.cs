﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindFormCF_entity
{
    public class Employee
    {

        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public int PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public int Extension { get; set; }
        public string Photo { get; set; }
        public string Notes { get; set; }
        public object ReportsTo { get; set; }
        public string PhotoPath { get; set; }

    }
}
