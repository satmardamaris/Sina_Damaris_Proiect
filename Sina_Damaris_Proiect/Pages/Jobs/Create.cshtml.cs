using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sina_Damaris_Proiect.Data;
using Sina_Damaris_Proiect.Models;

namespace Sina_Damaris_Proiect.Pages.Jobs
{
    public class CreateModel : PageModel
    {
        private readonly Sina_Damaris_Proiect.Data.Sina_Damaris_ProiectContext _context;

        public CreateModel(Sina_Damaris_Proiect.Data.Sina_Damaris_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Job Job { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Job.Add(Job);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
