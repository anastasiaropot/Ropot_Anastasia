using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ropot_Anastasia.Data;
using Ropot_Anastasia.Models;

namespace Ropot_Anastasia.Pages.Examene
{
    public class DetailsModel : PageModel
    {
        private readonly Ropot_Anastasia.Data.Ropot_AnastasiaContext _context;

        public DetailsModel(Ropot_Anastasia.Data.Ropot_AnastasiaContext context)
        {
            _context = context;
        }

      public Examen Examen { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Examen == null)
            {
                return NotFound();
            }

            var examen = await _context.Examen.FirstOrDefaultAsync(m => m.ID == id);
            if (examen == null)
            {
                return NotFound();
            }
            else 
            {
                Examen = examen;
                ViewData["Data_Ex"] = new SelectList(_context.Set<Data_Ex>(), "ID",
                "Data_Ex");

            }
            return Page();
        }
    }
}
