using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ropot_Anastasia.Data;
using Ropot_Anastasia.Models;

namespace Ropot_Anastasia.Pages.Examene
{
    public class IndexModel : PageModel
    {
        private readonly Ropot_Anastasia.Data.Ropot_AnastasiaContext _context;

        public IndexModel(Ropot_Anastasia.Data.Ropot_AnastasiaContext context)
        {
            _context = context;
        }

        public IList<Examen> Examen { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Examen != null)
            {
                Examen = await _context.Examen
                    .Include(b => b.Data_Ex)
                    .ToListAsync();
            }
        }
    }
}
