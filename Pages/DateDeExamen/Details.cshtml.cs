using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ropot_Anastasia.Data;
using Ropot_Anastasia.Models;

namespace Ropot_Anastasia.Pages.DateDeExamen
{
    public class DetailsModel : PageModel
    {
        private readonly Ropot_Anastasia.Data.Ropot_AnastasiaContext _context;

        public DetailsModel(Ropot_Anastasia.Data.Ropot_AnastasiaContext context)
        {
            _context = context;
        }

      public Data_Ex Data_Ex { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Data_Ex == null)
            {
                return NotFound();
            }

            var data_ex = await _context.Data_Ex.FirstOrDefaultAsync(m => m.ID == id);
            if (data_ex == null)
            {
                return NotFound();
            }
            else 
            {
                Data_Ex = data_ex;
            }
            return Page();
        }
    }
}
