using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sina_Damaris_Proiect.Data;
using Sina_Damaris_Proiect.Models;

namespace Sina_Damaris_Proiect.Pages.Jobs
{
    public class IndexModel : PageModel
    {
        private readonly Sina_Damaris_Proiect.Data.Sina_Damaris_ProiectContext _context;

        public IndexModel(Sina_Damaris_Proiect.Data.Sina_Damaris_ProiectContext context)
        {
            _context = context;
        }

        public IList<Job> Job { get;set; }

        public async Task OnGetAsync()
        {
            Job = await _context.Job.ToListAsync();
        }
    }
}
