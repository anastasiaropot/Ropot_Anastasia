using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ropot_Anastasia.Data;
using Ropot_Anastasia.Models;

namespace Ropot_Anastasia.Pages.DateDeExamen
{
    public class EditModel : PageModel
    {
        private readonly Ropot_Anastasia.Data.Ropot_AnastasiaContext _context;

        public EditModel(Ropot_Anastasia.Data.Ropot_AnastasiaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Data_Ex Data_Ex { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Data_Ex == null)
            {
                return NotFound();
            }

            var data_ex =  await _context.Data_Ex.FirstOrDefaultAsync(m => m.ID == id);
            if (data_ex == null)
            {
                return NotFound();
            }
            Data_Ex = data_ex;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Data_Ex).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Data_ExExists(Data_Ex.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Data_ExExists(int id)
        {
          return _context.Data_Ex.Any(e => e.ID == id);
        }
    }
}
