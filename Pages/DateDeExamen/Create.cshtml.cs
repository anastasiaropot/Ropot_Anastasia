using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Ropot_Anastasia.Data;
using Ropot_Anastasia.Models;

namespace Ropot_Anastasia.Pages.DateDeExamen
{
    public class CreateModel : PageModel
    {
        private readonly Ropot_Anastasia.Data.Ropot_AnastasiaContext _context;

        public CreateModel(Ropot_Anastasia.Data.Ropot_AnastasiaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Data_Ex Data_Ex { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Data_Ex.Add(Data_Ex);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
