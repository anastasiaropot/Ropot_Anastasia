using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ropot_Anastasia.Data;
using Ropot_Anastasia.Models;
using Ropot_Anastasia.Models.ViewModels;

namespace Ropot_Anastasia.Pages.ProfesoriCurs
{
    public class IndexModel : PageModel
    {
        private readonly Ropot_Anastasia.Data.Ropot_AnastasiaContext _context;

        public IndexModel(Ropot_Anastasia.Data.Ropot_AnastasiaContext context)
        {
            _context = context;
        }

        public IList<ProfesorCurs> ProfesorCurs { get; set; } = default!;
        public ProfesorCursIndexData ProfesorCursData { get; set; }
        public int ProfesorCursID { get; set; }
        public int ExamenID { get; set; }
        public async Task OnGetAsync(int? id, int? bookID)
        {
            ProfesorCursData = new ProfesorCursIndexData();
            ProfesorCursData.ProfesoriCurs = await _context.ProfesorCurs
            .Include(i => i.Examene)
            .ThenInclude(c => c.Profesor)
            .OrderBy(i => i.Nume_ProfesorCurs)
            .ToListAsync();
            if (id != null)
            {
                ProfesorCursID = id.Value;
                ProfesorCurs ProfesorCurs = ProfesorCursData.ProfesoriCurs
                .Where(i => i.ID == id.Value).Single();
                ProfesorCursData.Examene = ProfesorCurs.Examene;
            }

            {
                if (_context.ProfesorCurs != null)
                {
                    ProfesorCurs = await _context.ProfesorCurs.ToListAsync();
                }
            }
        }
    }
}

