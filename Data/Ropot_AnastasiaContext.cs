using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ropot_Anastasia.Models;

namespace Ropot_Anastasia.Data
{
    public class Ropot_AnastasiaContext : DbContext
    {
        public Ropot_AnastasiaContext (DbContextOptions<Ropot_AnastasiaContext> options)
            : base(options)
        {
        }

        public DbSet<Ropot_Anastasia.Models.Examen> Examen { get; set; } = default!;

        public DbSet<Ropot_Anastasia.Models.Data_Examen> Data_Examen { get; set; }
    }
}
