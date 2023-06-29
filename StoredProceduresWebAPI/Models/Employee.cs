using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoredProceduresWebAPI.Models
{
    public class Employee
    {
        public object Active { get;  set; }
        public object Age { get;  set; }
        public object Name { get;  set; }
        public int Id { get;  set; }
    }
}