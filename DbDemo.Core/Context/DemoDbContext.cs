using DbDemo.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace DbDemo.Core.Context
{
    public class DemoDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Role> Roles => Set<Role>();

        public DbSet<District> Districts => Set<District>();
        public DbSet<Address> Addresses => Set<Address>();
        public DbSet<Resident> Residents => Set<Resident>();
        public DbSet<School> Schools => Set<School>();

        // цей метод чисто для зручності, бо докер створює лишні таблички, тому зробив окрему схему
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // змінюємо схему для таблиці історії міграцій
            modelBuilder.HasDefaultSchema("app");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.; Database=DbDemo; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost,1433; Database=master; User Id=sa; Password=MyStr0ng!Passw0rd; TrustServerCertificate=True;"
            );
        }
    }
}
