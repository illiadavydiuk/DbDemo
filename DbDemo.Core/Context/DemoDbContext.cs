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
        // два класи для прикладу на парі
        //public DbSet<User> Users => Set<User>();
        //public DbSet<Role> Roles => Set<Role>();

        public DbSet<District> Districts => Set<District>();
        public DbSet<Address> Addresses => Set<Address>();
        public DbSet<Resident> Residents => Set<Resident>();
        public DbSet<School> Schools => Set<School>();
        public DbSet<Class> Classes => Set<Class>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
        public DbSet<Student> Students => Set<Student>();

        // цей метод чисто для зручності, бо докер створює лишні таблички, тому зробив окрему схему
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // змінюємо схему для таблиці історії міграцій
            modelBuilder.HasDefaultSchema("app");


            // 🔹 Teacher → School (без каскаду)
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.School)
                .WithMany()
                .HasForeignKey(t => t.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            // 🔹 Teacher → Resident (без каскаду)
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Resident)
                .WithMany()
                .HasForeignKey(t => t.ResidentId)
                .OnDelete(DeleteBehavior.Restrict);

            // 🔹 Class → Teacher (nullable, без каскаду)
            modelBuilder.Entity<Class>()
                .HasOne(c => c.Teacher)
                .WithMany()
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);

            // 🔹 Student → Resident (без каскаду)
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Resident)
                .WithMany()
                .HasForeignKey(s => s.ResidentId)
                .OnDelete(DeleteBehavior.Restrict);

            // 🔹 Student → Class (без каскаду)
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Class)
                .WithMany()
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // підключення до mysql сервера на локальній машині
            //optionsBuilder.UseSqlServer("Server=.; Database=DbDemo; Integrated Security=True; Encrypt=True; TrustServerCertificate=True");
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=localhost,1433; Database=DbDemo; User Id=sa; Password=MyStr0ng!Passw0rd; TrustServerCertificate=True;"
            );
        }
    }
}
