using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbDemo.Core.Migrations
{
    /// <inheritdoc />
    public partial class Add_Healtcare : Migration
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
                name: "FK_MedicalReception_Doctor_DoctorId",
                schema: "app",
                table: "MedicalReception");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalReception_Patient_PatientId",
                schema: "app",
                table: "MedicalReception");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalReception_Residents_ResidentId",
                schema: "app",
                table: "MedicalReception");

            migrationBuilder.DropForeignKey(
                name: "FK_Patient_Residents_ResidentId",
                schema: "app",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                schema: "app",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalReception",
                schema: "app",
                table: "MedicalReception");

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
                name: "MedicalReception",
                schema: "app",
                newName: "MedicalReceptions",
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
                name: "IX_MedicalReception_ResidentId",
                schema: "app",
                table: "MedicalReceptions",
                newName: "IX_MedicalReceptions_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalReception_PatientId",
                schema: "app",
                table: "MedicalReceptions",
                newName: "IX_MedicalReceptions_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalReception_DoctorId",
                schema: "app",
                table: "MedicalReceptions",
                newName: "IX_MedicalReceptions_DoctorId");

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
                name: "PK_MedicalReceptions",
                schema: "app",
                table: "MedicalReceptions",
                column: "MedicalReceptionId");

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
                name: "FK_MedicalReceptions_Doctors_DoctorId",
                schema: "app",
                table: "MedicalReceptions",
                column: "DoctorId",
                principalSchema: "app",
                principalTable: "Doctors",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalReceptions_Patients_PatientId",
                schema: "app",
                table: "MedicalReceptions",
                column: "PatientId",
                principalSchema: "app",
                principalTable: "Patients",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalReceptions_Residents_ResidentId",
                schema: "app",
                table: "MedicalReceptions",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId");

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
                name: "FK_MedicalReceptions_Doctors_DoctorId",
                schema: "app",
                table: "MedicalReceptions");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalReceptions_Patients_PatientId",
                schema: "app",
                table: "MedicalReceptions");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalReceptions_Residents_ResidentId",
                schema: "app",
                table: "MedicalReceptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Residents_ResidentId",
                schema: "app",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                schema: "app",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalReceptions",
                schema: "app",
                table: "MedicalReceptions");

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
                name: "MedicalReceptions",
                schema: "app",
                newName: "MedicalReception",
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
                name: "IX_MedicalReceptions_ResidentId",
                schema: "app",
                table: "MedicalReception",
                newName: "IX_MedicalReception_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalReceptions_PatientId",
                schema: "app",
                table: "MedicalReception",
                newName: "IX_MedicalReception_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalReceptions_DoctorId",
                schema: "app",
                table: "MedicalReception",
                newName: "IX_MedicalReception_DoctorId");

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
                name: "PK_MedicalReception",
                schema: "app",
                table: "MedicalReception",
                column: "MedicalReceptionId");

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
                name: "FK_MedicalReception_Doctor_DoctorId",
                schema: "app",
                table: "MedicalReception",
                column: "DoctorId",
                principalSchema: "app",
                principalTable: "Doctor",
                principalColumn: "DoctorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalReception_Patient_PatientId",
                schema: "app",
                table: "MedicalReception",
                column: "PatientId",
                principalSchema: "app",
                principalTable: "Patient",
                principalColumn: "PatientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalReception_Residents_ResidentId",
                schema: "app",
                table: "MedicalReception",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId");

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
