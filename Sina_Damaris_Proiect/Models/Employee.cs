using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sina_Damaris_Proiect.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int CompanyID { get; set; }
        public int JobID { get; set; }
    }
}
