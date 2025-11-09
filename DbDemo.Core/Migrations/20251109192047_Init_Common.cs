using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbDemo.Core.Migrations
{
    /// <inheritdoc />
    public partial class Init_Common : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "app");

            migrationBuilder.CreateTable(
                name: "Districts",
                schema: "app",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "Industry",
                schema: "app",
                columns: table => new
                {
                    IndustryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndustryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry", x => x.IndustryId);
                });

            migrationBuilder.CreateTable(
                name: "Route",
                schema: "app",
                columns: table => new
                {
                    RouteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.RouteId);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                schema: "app",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalSchema: "app",
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Building",
                schema: "app",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Floors = table.Column<int>(type: "int", nullable: false),
                    NumRooms = table.Column<int>(type: "int", nullable: false),
                    BuildYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.BuildingId);
                    table.ForeignKey(
                        name: "FK_Building_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "app",
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                schema: "app",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    NumberOfEmployees = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                    table.ForeignKey(
                        name: "FK_Company_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "app",
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Company_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalSchema: "app",
                        principalTable: "Industry",
                        principalColumn: "IndustryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
                schema: "app",
                columns: table => new
                {
                    HospitalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.HospitalId);
                    table.ForeignKey(
                        name: "FK_Hospital_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "app",
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Residents",
                schema: "app",
                columns: table => new
                {
                    ResidentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.ResidentId);
                    table.ForeignKey(
                        name: "FK_Residents_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "app",
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "School",
                schema: "app",
                columns: table => new
                {
                    SchoolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.SchoolId);
                    table.ForeignKey(
                        name: "FK_School_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "app",
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stop",
                schema: "app",
                columns: table => new
                {
                    StopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stop", x => x.StopId);
                    table.ForeignKey(
                        name: "FK_Stop_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalSchema: "app",
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Apartment",
                schema: "app",
                columns: table => new
                {
                    ApartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    ApartmentNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumRooms = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment", x => x.ApartmentId);
                    table.ForeignKey(
                        name: "FK_Apartment_Building_BuildingId",
                        column: x => x.BuildingId,
                        principalSchema: "app",
                        principalTable: "Building",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "License",
                schema: "app",
                columns: table => new
                {
                    LicenseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    LicenseType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_License", x => x.LicenseId);
                    table.ForeignKey(
                        name: "FK_License_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "app",
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaxPayment",
                schema: "app",
                columns: table => new
                {
                    TaxPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxPayment", x => x.TaxPaymentId);
                    table.ForeignKey(
                        name: "FK_TaxPayment_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "app",
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                schema: "app",
                columns: table => new
                {
                    DoctorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalId = table.Column<int>(type: "int", nullable: false),
                    ResidentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.DoctorId);
                    table.ForeignKey(
                        name: "FK_Doctor_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalSchema: "app",
                        principalTable: "Hospital",
                        principalColumn: "HospitalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctor_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalSchema: "app",
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                schema: "app",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "int", nullable: false),
                    LicenseCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_Driver_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalSchema: "app",
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                schema: "app",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ResidentId = table.Column<int>(type: "int", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalSchema: "app",
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employee_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalSchema: "app",
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Passenger",
                schema: "app",
                columns: table => new
                {
                    PassengerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "int", nullable: false),
                    TicketNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passenger", x => x.PassengerId);
                    table.ForeignKey(
                        name: "FK_Passenger_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalSchema: "app",
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                schema: "app",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "int", nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalHistory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patient_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalSchema: "app",
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                schema: "app",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    ExperienceYears = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.TeacherId);
                    table.ForeignKey(
                        name: "FK_Teacher_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalSchema: "app",
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teacher_School_SchoolId",
                        column: x => x.SchoolId,
                        principalSchema: "app",
                        principalTable: "School",
                        principalColumn: "SchoolId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RouteStop",
                schema: "app",
                columns: table => new
                {
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    StopId = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteStop", x => new { x.RouteId, x.StopId });
                    table.ForeignKey(
                        name: "FK_RouteStop_Route_RouteId",
                        column: x => x.RouteId,
                        principalSchema: "app",
                        principalTable: "Route",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RouteStop_Stop_StopId",
                        column: x => x.StopId,
                        principalSchema: "app",
                        principalTable: "Stop",
                        principalColumn: "StopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResidentApartment",
                schema: "app",
                columns: table => new
                {
                    ResidentApartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "int", nullable: false),
                    ApartmentId = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidentApartment", x => x.ResidentApartmentId);
                    table.ForeignKey(
                        name: "FK_ResidentApartment_Apartment_ApartmentId",
                        column: x => x.ApartmentId,
                        principalSchema: "app",
                        principalTable: "Apartment",
                        principalColumn: "ApartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResidentApartment_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalSchema: "app",
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UtilityBill",
                schema: "app",
                columns: table => new
                {
                    UtilityBillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartmentId = table.Column<int>(type: "int", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UtilityBill", x => x.UtilityBillId);
                    table.ForeignKey(
                        name: "FK_UtilityBill_Apartment_ApartmentId",
                        column: x => x.ApartmentId,
                        principalSchema: "app",
                        principalTable: "Apartment",
                        principalColumn: "ApartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                schema: "app",
                columns: table => new
                {
                    VehicleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlate = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    DriverId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.VehicleId);
                    table.ForeignKey(
                        name: "FK_Vehicle_Driver_DriverId",
                        column: x => x.DriverId,
                        principalSchema: "app",
                        principalTable: "Driver",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalReception",
                schema: "app",
                columns: table => new
                {
                    MedicalReceptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReceptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Annotation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    ResidentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalReception", x => x.MedicalReceptionId);
                    table.ForeignKey(
                        name: "FK_MedicalReception_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalSchema: "app",
                        principalTable: "Doctor",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalReception_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "app",
                        principalTable: "Patient",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalReception_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalSchema: "app",
                        principalTable: "Residents",
                        principalColumn: "ResidentId");
                });

            migrationBuilder.CreateTable(
                name: "Class",
                schema: "app",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ClassId);
                    table.ForeignKey(
                        name: "FK_Class_School_SchoolId",
                        column: x => x.SchoolId,
                        principalSchema: "app",
                        principalTable: "School",
                        principalColumn: "SchoolId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Class_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalSchema: "app",
                        principalTable: "Teacher",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "BillPayment",
                schema: "app",
                columns: table => new
                {
                    BillPaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UtilityBillId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillPayment", x => x.BillPaymentId);
                    table.ForeignKey(
                        name: "FK_BillPayment_UtilityBill_UtilityBillId",
                        column: x => x.UtilityBillId,
                        principalSchema: "app",
                        principalTable: "UtilityBill",
                        principalColumn: "UtilityBillId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trip",
                schema: "app",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteId = table.Column<int>(type: "int", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.TripId);
                    table.ForeignKey(
                        name: "FK_Trip_Route_RouteId",
                        column: x => x.RouteId,
                        principalSchema: "app",
                        principalTable: "Route",
                        principalColumn: "RouteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trip_Vehicle_VehicleId",
                        column: x => x.VehicleId,
                        principalSchema: "app",
                        principalTable: "Vehicle",
                        principalColumn: "VehicleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                schema: "app",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Class_ClassId",
                        column: x => x.ClassId,
                        principalSchema: "app",
                        principalTable: "Class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalSchema: "app",
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_School_SchoolId",
                        column: x => x.SchoolId,
                        principalSchema: "app",
                        principalTable: "School",
                        principalColumn: "SchoolId");
                });

            migrationBuilder.CreateTable(
                name: "PassengerTrip",
                schema: "app",
                columns: table => new
                {
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    Seat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerTrip", x => new { x.PassengerId, x.TripId });
                    table.ForeignKey(
                        name: "FK_PassengerTrip_Passenger_PassengerId",
                        column: x => x.PassengerId,
                        principalSchema: "app",
                        principalTable: "Passenger",
                        principalColumn: "PassengerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PassengerTrip_Trip_TripId",
                        column: x => x.TripId,
                        principalSchema: "app",
                        principalTable: "Trip",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                schema: "app",
                columns: table => new
                {
                    ScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.ScheduleId);
                    table.ForeignKey(
                        name: "FK_Schedule_Trip_TripId",
                        column: x => x.TripId,
                        principalSchema: "app",
                        principalTable: "Trip",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_DistrictId_Street_HouseNumber",
                schema: "app",
                table: "Addresses",
                columns: new[] { "DistrictId", "Street", "HouseNumber" });

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_BuildingId",
                schema: "app",
                table: "Apartment",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_BillPayment_UtilityBillId",
                schema: "app",
                table: "BillPayment",
                column: "UtilityBillId");

            migrationBuilder.CreateIndex(
                name: "IX_Building_AddressId",
                schema: "app",
                table: "Building",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_SchoolId",
                schema: "app",
                table: "Class",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_TeacherId",
                schema: "app",
                table: "Class",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_AddressId",
                schema: "app",
                table: "Company",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_IndustryId",
                schema: "app",
                table: "Company",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_HospitalId",
                schema: "app",
                table: "Doctor",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_ResidentId",
                schema: "app",
                table: "Doctor",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_ResidentId",
                schema: "app",
                table: "Driver",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CompanyId",
                schema: "app",
                table: "Employee",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ResidentId",
                schema: "app",
                table: "Employee",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_AddressId",
                schema: "app",
                table: "Hospital",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_License_CompanyId",
                schema: "app",
                table: "License",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalReception_DoctorId",
                schema: "app",
                table: "MedicalReception",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalReception_PatientId",
                schema: "app",
                table: "MedicalReception",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalReception_ResidentId",
                schema: "app",
                table: "MedicalReception",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Passenger_ResidentId",
                schema: "app",
                table: "Passenger",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_PassengerTrip_TripId",
                schema: "app",
                table: "PassengerTrip",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_ResidentId",
                schema: "app",
                table: "Patient",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_ResidentApartment_ApartmentId",
                schema: "app",
                table: "ResidentApartment",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ResidentApartment_ResidentId",
                schema: "app",
                table: "ResidentApartment",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_AddressId",
                schema: "app",
                table: "Residents",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_RouteStop_StopId",
                schema: "app",
                table: "RouteStop",
                column: "StopId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_TripId",
                schema: "app",
                table: "Schedule",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_School_AddressId",
                schema: "app",
                table: "School",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Stop_AddressId",
                schema: "app",
                table: "Stop",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassId",
                schema: "app",
                table: "Student",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ResidentId",
                schema: "app",
                table: "Student",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_SchoolId",
                schema: "app",
                table: "Student",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_TaxPayment_CompanyId",
                schema: "app",
                table: "TaxPayment",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_ResidentId",
                schema: "app",
                table: "Teacher",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_SchoolId",
                schema: "app",
                table: "Teacher",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_RouteId",
                schema: "app",
                table: "Trip",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_VehicleId",
                schema: "app",
                table: "Trip",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_UtilityBill_ApartmentId",
                schema: "app",
                table: "UtilityBill",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_DriverId",
                schema: "app",
                table: "Vehicle",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_LicensePlate",
                schema: "app",
                table: "Vehicle",
                column: "LicensePlate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillPayment",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Employee",
                schema: "app");

            migrationBuilder.DropTable(
                name: "License",
                schema: "app");

            migrationBuilder.DropTable(
                name: "MedicalReception",
                schema: "app");

            migrationBuilder.DropTable(
                name: "PassengerTrip",
                schema: "app");

            migrationBuilder.DropTable(
                name: "ResidentApartment",
                schema: "app");

            migrationBuilder.DropTable(
                name: "RouteStop",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Schedule",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Student",
                schema: "app");

            migrationBuilder.DropTable(
                name: "TaxPayment",
                schema: "app");

            migrationBuilder.DropTable(
                name: "UtilityBill",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Doctor",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Patient",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Passenger",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Stop",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Trip",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Class",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Company",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Apartment",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Hospital",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Route",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Vehicle",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Teacher",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Industry",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Building",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Driver",
                schema: "app");

            migrationBuilder.DropTable(
                name: "School",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Residents",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Addresses",
                schema: "app");

            migrationBuilder.DropTable(
                name: "Districts",
                schema: "app");
        }
    }
}
