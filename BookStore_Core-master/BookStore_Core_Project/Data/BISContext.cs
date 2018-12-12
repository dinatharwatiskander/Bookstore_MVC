using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_Core_Project.Data
{
    public class BISContext : DbContext
    {
        public BISContext(DbContextOptions<BISContext> options)
        : base(options)
        {
        }
        public DbSet<Models.Author> Authors { get; set; }
        public DbSet<Models.Books> Books { get; set; }
        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Models.Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Enrollment>()
                 .HasKey(en => new { en.CustomerID, en.BookID });


            modelBuilder.Entity<Models.Enrollment>()
                .HasOne(en => en._Customer)
                .WithMany(b => b.Booklist)
                .HasForeignKey(en => en.CustomerID);

            modelBuilder.Entity<Models.Enrollment>()
                .HasOne(en => en._Book)
                .WithMany(c => c.Customerlist)
                .HasForeignKey(en => en.BookID);
        }





    }
}
