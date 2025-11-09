using Microsoft.EntityFrameworkCore;
using DbDemo.Core.Models.Common;
using DbDemo.Core.Models.Education;
using DbDemo.Core.Models.Healthcare;
using DbDemo.Core.Models.Housing;
using DbDemo.Core.Models.Economy;
using DbDemo.Core.Models.Transport;

namespace DbDemo.Core.Context
{
    public class DemoDbContext : DbContext
    {
        // Common
        public DbSet<District> Districts => Set<District>();
        public DbSet<Address> Addresses => Set<Address>();
        public DbSet<Resident> Residents => Set<Resident>();

        // Education
        public DbSet<School> Schools => Set<School>();
        public DbSet<Class> Classes => Set<Class>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
        public DbSet<Student> Students => Set<Student>();

        // Healthcare
        public DbSet<Hospital> Hospitals => Set<Hospital>();
        public DbSet<Doctor> Doctors => Set<Doctor>();
        public DbSet<Patient> Patients => Set<Patient>();
        public DbSet<MedicalReception> MedicalReceptions => Set<MedicalReception>();

        // Housing
        public DbSet<Building> Buildings => Set<Building>();
        public DbSet<Apartment> Apartments => Set<Apartment>();
        public DbSet<ResidentApartment> ResidentApartments => Set<ResidentApartment>();
        public DbSet<UtilityBill> UtilityBills => Set<UtilityBill>();
        public DbSet<BillPayment> BillPayments => Set<BillPayment>();

        // Economy
        public DbSet<Industry> Industries => Set<Industry>();
        public DbSet<Company> Companies => Set<Company>();
        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<License> Licenses => Set<License>();
        public DbSet<TaxPayment> TaxPayments => Set<TaxPayment>();

        // Transport
        public DbSet<Route> Routes => Set<Route>();
        public DbSet<Stop> Stops => Set<Stop>();
        public DbSet<RouteStop> RouteStops => Set<RouteStop>();
        public DbSet<Driver> Drivers => Set<Driver>();
        public DbSet<Vehicle> Vehicles => Set<Vehicle>();
        public DbSet<Trip> Trips => Set<Trip>();
        public DbSet<Schedule> Schedules => Set<Schedule>();
        public DbSet<Passenger> Passengers => Set<Passenger>();
        public DbSet<PassengerTrip> PassengerTrips => Set<PassengerTrip>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost,1433;Database=DbDemo;User Id=sa;Password=MyStr0ng!Passw0rd;TrustServerCertificate=True;",
                sql => sql.MigrationsHistoryTable("__EFMigrationsHistory", "meta")
            );
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            base.OnModelCreating(mb);

            // схема за замовчуванням
            mb.HasDefaultSchema("app");

            // ---------- Education ----------
            mb.Entity<Teacher>()
              .HasOne(t => t.School).WithMany(s => s.Teachers)
              .HasForeignKey(t => t.SchoolId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Teacher>()
              .HasOne(t => t.Resident).WithMany(r => r.Teachers)
              .HasForeignKey(t => t.ResidentId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Class>()
              .HasOne(c => c.School).WithMany(s => s.Classes)
              .HasForeignKey(c => c.SchoolId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Class>()
              .HasOne(c => c.Teacher).WithMany(t => t.Classes)
              .HasForeignKey(c => c.TeacherId).OnDelete(DeleteBehavior.SetNull);

            mb.Entity<Student>()
              .HasOne(s => s.Resident).WithMany(r => r.Students)
              .HasForeignKey(s => s.ResidentId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Student>()
              .HasOne(s => s.Class).WithMany(c => c.Students)
              .HasForeignKey(s => s.ClassId).OnDelete(DeleteBehavior.Restrict);

            // ---------- Healthcare ----------
            mb.Entity<Doctor>()
              .HasOne(d => d.Hospital).WithMany(h => h.Doctors)
              .HasForeignKey(d => d.HospitalId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Doctor>()
              .HasOne(d => d.Resident).WithMany(r => r.Doctors)
              .HasForeignKey(d => d.ResidentId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Patient>()
              .HasOne(p => p.Resident).WithMany(r => r.Patients)
              .HasForeignKey(p => p.ResidentId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<MedicalReception>()
              .HasOne(m => m.Patient).WithMany(p => p.MedicalReceptions)
              .HasForeignKey(m => m.PatientId).OnDelete(DeleteBehavior.Cascade);

            mb.Entity<MedicalReception>()
              .HasOne(m => m.Doctor).WithMany(d => d.MedicalReceptions)
              .HasForeignKey(m => m.DoctorId).OnDelete(DeleteBehavior.Restrict);

            // ---------- Housing ----------
            mb.Entity<Building>()
              .HasOne(b => b.Address).WithMany(a => a.Buildings)
              .HasForeignKey(b => b.AddressId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Apartment>()
              .HasOne(a => a.Building).WithMany(b => b.Apartments)
              .HasForeignKey(a => a.BuildingId).OnDelete(DeleteBehavior.Cascade);

            mb.Entity<ResidentApartment>()
              .HasOne(ra => ra.Resident).WithMany(r => r.ResidentApartments)
              .HasForeignKey(ra => ra.ResidentId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<ResidentApartment>()
              .HasOne(ra => ra.Apartment).WithMany(a => a.Residents)
              .HasForeignKey(ra => ra.ApartmentId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<UtilityBill>()
              .HasOne(ub => ub.Apartment).WithMany(a => a.UtilityBills)
              .HasForeignKey(ub => ub.ApartmentId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<BillPayment>()
              .HasOne(bp => bp.UtilityBill).WithMany(ub => ub.Payments)
              .HasForeignKey(bp => bp.UtilityBillId).OnDelete(DeleteBehavior.Cascade);

            // ---------- Economy ----------
            mb.Entity<Company>()
              .HasOne(c => c.Address).WithMany(a => a.Companies)
              .HasForeignKey(c => c.AddressId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Company>()
              .HasOne(c => c.Industry).WithMany(i => i.Companies)
              .HasForeignKey(c => c.IndustryId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Employee>()
              .HasOne(e => e.Company).WithMany(c => c.Employees)
              .HasForeignKey(e => e.CompanyId).OnDelete(DeleteBehavior.Cascade);

            mb.Entity<Employee>()
              .HasOne(e => e.Resident).WithMany(r => r.Employees)
              .HasForeignKey(e => e.ResidentId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<License>()
              .HasOne(l => l.Company).WithMany(c => c.Licenses)
              .HasForeignKey(l => l.CompanyId).OnDelete(DeleteBehavior.Cascade);

            mb.Entity<TaxPayment>()
              .HasOne(t => t.Company).WithMany(c => c.TaxPayments)
              .HasForeignKey(t => t.CompanyId).OnDelete(DeleteBehavior.Cascade);

            // ---------- Transport ----------
            mb.Entity<RouteStop>().HasKey(rs => new { rs.RouteId, rs.StopId });

            mb.Entity<RouteStop>()
              .HasOne(rs => rs.Route).WithMany(r => r.RouteStops)
              .HasForeignKey(rs => rs.RouteId).OnDelete(DeleteBehavior.Cascade);

            mb.Entity<RouteStop>()
              .HasOne(rs => rs.Stop).WithMany(s => s.RouteStops)
              .HasForeignKey(rs => rs.StopId).OnDelete(DeleteBehavior.Cascade);

            mb.Entity<Stop>()
              .HasOne(s => s.Address).WithMany(a => a.Stops)
              .HasForeignKey(s => s.AddressId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Driver>()
              .HasOne(d => d.Resident).WithMany(r => r.Drivers)
              .HasForeignKey(d => d.ResidentId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Vehicle>()
              .HasOne(v => v.Driver).WithMany(d => d.Vehicles)
              .HasForeignKey(v => v.DriverId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Trip>()
              .HasOne(t => t.Route).WithMany(r => r.Trips)
              .HasForeignKey(t => t.RouteId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Trip>()
              .HasOne(t => t.Vehicle).WithMany(v => v.Trips)
              .HasForeignKey(t => t.VehicleId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Schedule>()
              .HasOne(s => s.Trip).WithMany(t => t.Schedules)
              .HasForeignKey(s => s.TripId).OnDelete(DeleteBehavior.Cascade);

            mb.Entity<Passenger>()
              .HasOne(p => p.Resident).WithMany(r => r.Passengers)
              .HasForeignKey(p => p.ResidentId).OnDelete(DeleteBehavior.Restrict);

            mb.Entity<PassengerTrip>().HasKey(pt => new { pt.PassengerId, pt.TripId });

            mb.Entity<PassengerTrip>()
              .HasOne(pt => pt.Passenger).WithMany(p => p.PassengerTrips)
              .HasForeignKey(pt => pt.PassengerId).OnDelete(DeleteBehavior.Cascade);

            mb.Entity<PassengerTrip>()
              .HasOne(pt => pt.Trip).WithMany(t => t.PassengerTrips)
              .HasForeignKey(pt => pt.TripId).OnDelete(DeleteBehavior.Cascade);

            // індекси для зручності
            mb.Entity<Address>().HasIndex(a => new { a.DistrictId, a.Street, a.HouseNumber });
            mb.Entity<Vehicle>().HasIndex(v => v.LicensePlate);
            mb.Entity<Student>().HasIndex(s => s.ClassId);
            mb.Entity<Employee>().HasIndex(e => e.CompanyId);
        }
    }
}
