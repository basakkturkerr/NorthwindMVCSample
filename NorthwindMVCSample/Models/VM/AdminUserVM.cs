using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthwindMVCSample.Models.VM
{
    public class AdminUserVM
    {
        public int ID { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? LastLoginDate { get; set; }
    }
}