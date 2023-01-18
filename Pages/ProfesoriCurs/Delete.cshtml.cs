using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ropot_Anastasia.Data;
using Ropot_Anastasia.Models;

namespace Ropot_Anastasia.Pages.ProfesoriCurs
{
    public class DeleteModel : PageModel
    {
        private readonly Ropot_Anastasia.Data.Ropot_AnastasiaContext _context;

        public DeleteModel(Ropot_Anastasia.Data.Ropot_AnastasiaContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ProfesorCurs ProfesorCurs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ProfesorCurs == null)
            {
                return NotFound();
            }

            var profesorcurs = await _context.ProfesorCurs.FirstOrDefaultAsync(m => m.ID == id);

            if (profesorcurs == null)
            {
                return NotFound();
            }
            else 
            {
                ProfesorCurs = profesorcurs;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ProfesorCurs == null)
            {
                return NotFound();
            }
            var profesorcurs = await _context.ProfesorCurs.FindAsync(id);

            if (profesorcurs != null)
            {
                ProfesorCurs = profesorcurs;
                _context.ProfesorCurs.Remove(ProfesorCurs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
