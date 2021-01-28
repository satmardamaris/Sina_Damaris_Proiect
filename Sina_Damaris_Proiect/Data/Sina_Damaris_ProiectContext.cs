using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sina_Damaris_Proiect.Models;

namespace Sina_Damaris_Proiect.Data
{
    public class Sina_Damaris_ProiectContext : DbContext
    {
        public Sina_Damaris_ProiectContext (DbContextOptions<Sina_Damaris_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Sina_Damaris_Proiect.Models.Company> Company { get; set; }

        public DbSet<Sina_Damaris_Proiect.Models.Employee> Employee { get; set; }

        public DbSet<Sina_Damaris_Proiect.Models.Job> Job { get; set; }
    }
}
