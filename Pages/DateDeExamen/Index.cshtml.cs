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
    public class IndexModel : PageModel
    {
        private readonly Ropot_Anastasia.Data.Ropot_AnastasiaContext _context;

        public IndexModel(Ropot_Anastasia.Data.Ropot_AnastasiaContext context)
        {
            _context = context;
        }

        public IList<Data_Ex> Data_Ex { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Data_Ex != null)
            {
                Data_Ex = await _context.Data_Ex.ToListAsync();
            }
        }
    }
}
