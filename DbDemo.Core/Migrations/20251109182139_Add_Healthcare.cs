using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbDemo.Core.Migrations
{
    /// <inheritdoc />
    public partial class Add_Healthcare : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Hospital_HospitalId",
                schema: "app",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_Residents_ResidentId",
                schema: "app",
                table: "Doctor");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospital_Addresses_AddressId",
                schema: "app",
                table: "Hospital");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisit_Doctor_DoctorId",
                schema: "app",
                table: "MedicalVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisit_Patient_PatientId",
                schema: "app",
                table: "MedicalVisit");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Residents_ResidentId",
                schema: "app",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                schema: "app",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalVisit",
                schema: "app",
                table: "MedicalVisit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hospital",
                schema: "app",
                table: "Hospital");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                schema: "app",
                table: "Doctor");

            migrationBuilder.RenameTable(
                name: "Patient",
                schema: "app",
                newName: "Patients",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "MedicalVisit",
                schema: "app",
                newName: "MedicalVisits",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Hospital",
                schema: "app",
                newName: "Hospitals",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Doctor",
                schema: "app",
                newName: "Doctors",
                newSchema: "app");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_ResidentId",
                schema: "app",
                table: "Patients",
                newName: "IX_Patients_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalVisit_PatientId",
                schema: "app",
                table: "MedicalVisits",
                newName: "IX_MedicalVisits_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalVisit_DoctorId",
                schema: "app",
                table: "MedicalVisits",
                newName: "IX_MedicalVisits_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Hospital_AddressId",
                schema: "app",
                table: "Hospitals",
                newName: "IX_Hospitals_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_ResidentId",
                schema: "app",
                table: "Doctors",
                newName: "IX_Doctors_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_HospitalId",
                schema: "app",
                table: "Doctors",
                newName: "IX_Doctors_HospitalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                schema: "app",
                table: "Patients",
                column: "PatientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalVisits",
                schema: "app",
                table: "MedicalVisits",
                column: "MedicalVisitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hospitals",
                schema: "app",
                table: "Hospitals",
                column: "HospitalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                schema: "app",
                table: "Doctors",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Hospitals_HospitalId",
                schema: "app",
                table: "Doctors",
                column: "HospitalId",
                principalSchema: "app",
                principalTable: "Hospitals",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Residents_ResidentId",
                schema: "app",
                table: "Doctors",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospitals_Addresses_AddressId",
                schema: "app",
                table: "Hospitals",
                column: "AddressId",
                principalSchema: "app",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalVisits_Doctors_DoctorId",
                schema: "app",
                table: "MedicalVisits",
                column: "DoctorId",
                principalSchema: "app",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalVisits_Patients_PatientId",
                schema: "app",
                table: "MedicalVisits",
                column: "PatientId",
                principalSchema: "app",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Residents_ResidentId",
                schema: "app",
                table: "Patients",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Hospitals_HospitalId",
                schema: "app",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Residents_ResidentId",
                schema: "app",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospitals_Addresses_AddressId",
                schema: "app",
                table: "Hospitals");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisits_Doctors_DoctorId",
                schema: "app",
                table: "MedicalVisits");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalVisits_Patients_PatientId",
                schema: "app",
                table: "MedicalVisits");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Residents_ResidentId",
                schema: "app",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                schema: "app",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalVisits",
                schema: "app",
                table: "MedicalVisits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hospitals",
                schema: "app",
                table: "Hospitals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                schema: "app",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "Patients",
                schema: "app",
                newName: "Patient",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "MedicalVisits",
                schema: "app",
                newName: "MedicalVisit",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Hospitals",
                schema: "app",
                newName: "Hospital",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Doctors",
                schema: "app",
                newName: "Doctor",
                newSchema: "app");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_ResidentId",
                schema: "app",
                table: "Patient",
                newName: "IX_Patient_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalVisits_PatientId",
                schema: "app",
                table: "MedicalVisit",
                newName: "IX_MedicalVisit_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalVisits_DoctorId",
                schema: "app",
                table: "MedicalVisit",
                newName: "IX_MedicalVisit_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_Hospitals_AddressId",
                schema: "app",
                table: "Hospital",
                newName: "IX_Hospital_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_ResidentId",
                schema: "app",
                table: "Doctor",
                newName: "IX_Doctor_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_HospitalId",
                schema: "app",
                table: "Doctor",
                newName: "IX_Doctor_HospitalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                schema: "app",
                table: "Patient",
                column: "PatientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalVisit",
                schema: "app",
                table: "MedicalVisit",
                column: "MedicalVisitId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hospital",
                schema: "app",
                table: "Hospital",
                column: "HospitalId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                schema: "app",
                table: "Doctor",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Hospital_HospitalId",
                schema: "app",
                table: "Doctor",
                column: "HospitalId",
                principalSchema: "app",
                principalTable: "Hospital",
                principalColumn: "HospitalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_Residents_ResidentId",
                schema: "app",
                table: "Doctor",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hospital_Addresses_AddressId",
                schema: "app",
                table: "Hospital",
                column: "AddressId",
                principalSchema: "app",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalVisit_Doctor_DoctorId",
                schema: "app",
                table: "MedicalVisit",
                column: "DoctorId",
                principalSchema: "app",
                principalTable: "Doctor",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalVisit_Patient_PatientId",
                schema: "app",
                table: "MedicalVisit",
                column: "PatientId",
                principalSchema: "app",
                principalTable: "Patient",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_Residents_ResidentId",
                schema: "app",
                table: "Patient",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
