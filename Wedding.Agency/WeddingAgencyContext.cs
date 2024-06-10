using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Wedding.Agency;

namespace WeddingAgency.Models
{
    using Microsoft.EntityFrameworkCore;

    public class WeddingAgencyContext : DbContext
    {
        public WeddingAgencyContext(DbContextOptions<WeddingAgencyContext> options)
            : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Consultant> Consultants { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<AssignedStaff> AssignedStaffs { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<InvolvedPartner> InvolvedPartners { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestComposition> RequestCompositions { get; set; }
        public DbSet<EventPlan> EventPlans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasMany(c => c.Requests)
                .WithOne(r => r.Client)
                .HasForeignKey(r => r.ClientId);

            modelBuilder.Entity<Consultant>()
                .HasMany(c => c.Requests)
                .WithOne(r => r.Consultant)
                .HasForeignKey(r => r.ConsultantId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.AssignedStaffs)
                .WithOne(a => a.Employee)
                .HasForeignKey(a => a.EmployeeId);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Consultants)
                .WithOne(c => c.Employee)
                .HasForeignKey(c => c.EmployeeId);

            modelBuilder.Entity<AssignedStaff>()
                .HasMany(a => a.EventPlans)
                .WithOne(e => e.AssignedStaff)
                .HasForeignKey(e => e.AssignedStaffId);

            modelBuilder.Entity<Partner>()
                .HasMany(p => p.InvolvedPartners)
                .WithOne(i => i.Partner)
                .HasForeignKey(i => i.PartnerId);

            modelBuilder.Entity<InvolvedPartner>()
                .HasMany(i => i.EventPlans)
                .WithOne(e => e.InvolvedPartner)
                .HasForeignKey(e => e.InvolvedPartnerId);

            modelBuilder.Entity<Service>()
                .HasMany(s => s.RequestCompositions)
                .WithOne(rc => rc.Service)
                .HasForeignKey(rc => rc.ServiceId);

            modelBuilder.Entity<Request>()
                .HasMany(r => r.RequestCompositions)
                .WithOne(rc => rc.Request)
                .HasForeignKey(rc => rc.RequestId);

            modelBuilder.Entity<Request>()
                .HasMany(r => r.EventPlans)
                .WithOne(e => e.RequestComposition.Request)
                .HasForeignKey(e => e.RequestCompositionId);

            modelBuilder.Entity<RequestComposition>()
                .HasMany(rc => rc.EventPlans)
                .WithOne(e => e.RequestComposition)
                .HasForeignKey(e => e.RequestCompositionId);
        }
    }

}

