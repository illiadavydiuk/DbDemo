using DbDemo.Core.Models.Common;
using DbDemo.Core.Models.Education;
using DbDemo.Core.Models.Healthcare;
using DbDemo.Core.Models.Housing;
using DbDemo.Core.Models.Economy;
using DbDemo.Core.Models.Transport;
using Microsoft.EntityFrameworkCore;

namespace DbDemo.Core.Context
{
    public class DemoDbContext : DbContext
    {
        // === Common ===
        public DbSet<District> Districts => Set<District>();
        public DbSet<Address> Addresses => Set<Address>();
        public DbSet<Resident> Residents => Set<Resident>();

        // === Education ===
        public DbSet<School> Schools => Set<School>();
        public DbSet<Class> Classes => Set<Class>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
        public DbSet<Student> Students => Set<Student>();

        // === Healthcare ===
        public DbSet<Hospital> Hospitals => Set<Hospital>();
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<MedicalVisit> MedicalVisits => Set<MedicalVisit>();

        // === Housing ===
        public DbSet<Building> Buildings => Set<Building>();
        public DbSet<Apartment> Apartments => Set<Apartment>();
        public DbSet<ResidentHousing> ResidentHousings => Set<ResidentHousing>();
        public DbSet<UtilityBill> UtilityBills => Set<UtilityBill>();

        // === Economy ===
        public DbSet<Industry> Industries => Set<Industry>();
        public DbSet<Company> Companies => Set<Company>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<License> Licenses => Set<License>();

        // === Transport ===
        public DbSet<Route> Routes => Set<Route>();
        public DbSet<Stop> Stops => Set<Stop>();
        public DbSet<RouteStop> RouteStops => Set<RouteStop>();
        public DbSet<Vehicle> Vehicles => Set<Vehicle>();
        public DbSet<Driver> Drivers => Set<Driver>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ встановлюємо єдину схему
            modelBuilder.HasDefaultSchema("app");

            // === Education relationships ===
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.School)
                .WithMany(s => s.Teachers)
                .HasForeignKey(t => t.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.Resident)
                .WithMany(r => r.Teachers)
                .HasForeignKey(t => t.ResidentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Class>()
                .HasOne(c => c.Teacher)
                .WithMany(t => t.Classes)
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Class>()
                .HasOne(c => c.School)
                .WithMany(s => s.Classes)
                .HasForeignKey(c => c.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Resident)
                .WithMany(r => r.Students)
                .HasForeignKey(s => s.ResidentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Class)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            // === Healthcare relationships ===
            modelBuilder.Entity<Doctor>()
                .HasOne(d => d.Hospital)
                .WithMany(h => h.Doctors)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Doctor>()
                .HasOne(d => d.Resident)
                .WithMany(r => r.Doctors)
                .HasForeignKey(d => d.ResidentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Resident)
                .WithMany(r => r.Patients)
                .HasForeignKey(p => p.ResidentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MedicalVisit>()
                .HasOne(m => m.Patient)
                .WithMany(p => p.Visits)
                .HasForeignKey(m => m.PatientId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<MedicalVisit>()
                .HasOne(m => m.Doctor)
                .WithMany(d => d.Visits)
                .HasForeignKey(m => m.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            // === Housing relationships ===
            modelBuilder.Entity<Building>()
                .HasOne(b => b.Address)
                .WithMany(a => a.Buildings)
                .HasForeignKey(b => b.AddressId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Apartment>()
                .HasOne(a => a.Building)
                .WithMany(b => b.Apartments)
                .HasForeignKey(a => a.BuildingId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ResidentHousing>()
                .HasOne(rh => rh.Resident)
                .WithMany()
                .HasForeignKey(rh => rh.ResidentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ResidentHousing>()
                .HasOne(rh => rh.Apartment)
                .WithMany(a => a.Residents)
                .HasForeignKey(rh => rh.ApartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // === Economy relationships ===
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Company)
                .WithMany(c => c.Employees)
                .HasForeignKey(e => e.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Resident)
                .WithMany(r => r.Employees)
                .HasForeignKey(e => e.ResidentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Company>()
                .HasOne(c => c.Industry)
                .WithMany(i => i.Companies)
                .HasForeignKey(c => c.IndustryId)
                .OnDelete(DeleteBehavior.Restrict);

            // === Transport relationships ===
            modelBuilder.Entity<RouteStop>()
                .HasKey(rs => new { rs.RouteId, rs.StopId });

            modelBuilder.Entity<RouteStop>()
                .HasOne(rs => rs.Route)
                .WithMany(r => r.RouteStops)
                .HasForeignKey(rs => rs.RouteId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RouteStop>()
                .HasOne(rs => rs.Stop)
                .WithMany(s => s.RouteStops)
                .HasForeignKey(rs => rs.StopId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Driver>()
                .HasOne(d => d.Resident)
                .WithMany(r => r.Drivers)
                .HasForeignKey(d => d.ResidentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vehicle>()
                .HasOne(v => v.Driver)
                .WithMany(d => d.Vehicles)
                .HasForeignKey(v => v.DriverId)
                .OnDelete(DeleteBehavior.Restrict);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433; Database=DbDemo; User Id=sa; Password=MyStr0ng!Passw0rd; TrustServerCertificate=True;"
            );
        }
    }
}
