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
        public DbSet<SpaFinalProject.Components.Models.Service> Service { get; set; } = default!;
        public DbSet<SpaFinalProject.Components.Models.Employee> Employee { get; set; } = default!;
        public DbSet<SpaFinalProject.Components.Models.Appointment> Appointment { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Customer)
                .WithMany()
                .HasForeignKey(a => a.Customer_Id)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Employee)
                .WithMany()
                .HasForeignKey(a => a.Employee_Id)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Service)
                .WithMany()
                .HasForeignKey(a => a.Service_Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
