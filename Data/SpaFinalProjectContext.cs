using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SpaFinalProject.Components.Models;

namespace SpaFinalProject.Data
{
    public class SpaFinalProjectContext : DbContext
    {
        public SpaFinalProjectContext (DbContextOptions<SpaFinalProjectContext> options)
            : base(options)
        {
        }

        public DbSet<SpaFinalProject.Components.Models.Customer> Customer { get; set; } = default!;
    }
}
