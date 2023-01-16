using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ropot_Anastasia.Data;
using Ropot_Anastasia.Models;

namespace Ropot_Anastasia.Pages.DateExamen
{
    public class DeleteModel : PageModel
    {
        private readonly Ropot_Anastasia.Data.Ropot_AnastasiaContext _context;

        public DeleteModel(Ropot_Anastasia.Data.Ropot_AnastasiaContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Data_Examen Data_Examen { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Data_Examen == null)
            {
                return NotFound();
            }

            var data_examen = await _context.Data_Examen.FirstOrDefaultAsync(m => m.ID == id);

            if (data_examen == null)
            {
                return NotFound();
            }
            else 
            {
                Data_Examen = data_examen;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Data_Examen == null)
            {
                return NotFound();
            }
            var data_examen = await _context.Data_Examen.FindAsync(id);

            if (data_examen != null)
            {
                Data_Examen = data_examen;
                _context.Data_Examen.Remove(Data_Examen);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
