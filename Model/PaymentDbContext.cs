using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace CreditCardPayment.Model
{
    public class PaymentDbContext : DbContext
    {
        public DbSet<PaymentDetails> paymentdetails { get; set; }
        public DbSet<PaymentStatus> paymentstatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SYW078;Database=PaymentDB;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PaymentDetails>(entity =>
            {
                entity.HasKey(e => e.PaymentId);
                entity.Property(e => e.PaymentId).
                ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PaymentStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);
                entity.Property(e => e.StatusId).
                ValueGeneratedOnAdd();
            });

        }
    }
}

