using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindMVCSample.Models.VM
{
    public class EmployeeVM
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

    }
}