using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ADOCrud2.Models
{
    public class EmpModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Email { get; set; }
        public int Salary { get; set; }
        public string City { get; set; }
        public string Dept { get; set; }
    }
}