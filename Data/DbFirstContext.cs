using System.Collections.Generic;
using EmployeDetails.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeDetails.Data
{
    public partial class DbFirstContext : DbContext
    {
        public DbFirstContext()
        {
        }

        public DbFirstContext(DbContextOptions<DbFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Leave empty because DI already handles configuration
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("employee");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");
                entity.Property(e => e.EmpLoc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("emp_loc");
                entity.Property(e => e.EmpName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");
                entity.Property(e => e.EmpSal).HasColumnName("emp_sal");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
