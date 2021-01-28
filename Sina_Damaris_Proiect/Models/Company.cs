using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sina_Damaris_Proiect.Models
{
    public class Company
    {
        public int ID { get; set; }
        [Display(Name = "Companies Names")]

        public string Name { get; set; }
        [Display(Name = "Companies Adresses")]
        public string Adress { get; set; }
    }
}
