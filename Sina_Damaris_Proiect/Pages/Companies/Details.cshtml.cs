﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sina_Damaris_Proiect.Data;
using Sina_Damaris_Proiect.Models;

namespace Sina_Damaris_Proiect.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly Sina_Damaris_Proiect.Data.Sina_Damaris_ProiectContext _context;

        public DetailsModel(Sina_Damaris_Proiect.Data.Sina_Damaris_ProiectContext context)
        {
            _context = context;
        }

        public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Company = await _context.Company.FirstOrDefaultAsync(m => m.ID == id);

            if (Company == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
