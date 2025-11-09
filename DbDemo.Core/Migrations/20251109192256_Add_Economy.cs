using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbDemo.Core.Migrations
{
    /// <inheritdoc />
    public partial class Add_Economy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Company_Addresses_AddressId",
                schema: "app",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Industry_IndustryId",
                schema: "app",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Company_CompanyId",
                schema: "app",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Residents_ResidentId",
                schema: "app",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_License_Company_CompanyId",
                schema: "app",
                table: "License");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxPayment_Company_CompanyId",
                schema: "app",
                table: "TaxPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxPayment",
                schema: "app",
                table: "TaxPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_License",
                schema: "app",
                table: "License");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Industry",
                schema: "app",
                table: "Industry");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                schema: "app",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                schema: "app",
                table: "Company");

            migrationBuilder.RenameTable(
                name: "TaxPayment",
                schema: "app",
                newName: "TaxPayments",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "License",
                schema: "app",
                newName: "Licenses",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Industry",
                schema: "app",
                newName: "Industries",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Employee",
                schema: "app",
                newName: "Employees",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Company",
                schema: "app",
                newName: "Companies",
                newSchema: "app");

            migrationBuilder.RenameIndex(
                name: "IX_TaxPayment_CompanyId",
                schema: "app",
                table: "TaxPayments",
                newName: "IX_TaxPayments_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_License_CompanyId",
                schema: "app",
                table: "Licenses",
                newName: "IX_Licenses_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_ResidentId",
                schema: "app",
                table: "Employees",
                newName: "IX_Employees_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_CompanyId",
                schema: "app",
                table: "Employees",
                newName: "IX_Employees_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Company_IndustryId",
                schema: "app",
                table: "Companies",
                newName: "IX_Companies_IndustryId");

            migrationBuilder.RenameIndex(
                name: "IX_Company_AddressId",
                schema: "app",
                table: "Companies",
                newName: "IX_Companies_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxPayments",
                schema: "app",
                table: "TaxPayments",
                column: "TaxPaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Licenses",
                schema: "app",
                table: "Licenses",
                column: "LicenseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Industries",
                schema: "app",
                table: "Industries",
                column: "IndustryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                schema: "app",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                schema: "app",
                table: "Companies",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Addresses_AddressId",
                schema: "app",
                table: "Companies",
                column: "AddressId",
                principalSchema: "app",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Industries_IndustryId",
                schema: "app",
                table: "Companies",
                column: "IndustryId",
                principalSchema: "app",
                principalTable: "Industries",
                principalColumn: "IndustryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Companies_CompanyId",
                schema: "app",
                table: "Employees",
                column: "CompanyId",
                principalSchema: "app",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Residents_ResidentId",
                schema: "app",
                table: "Employees",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Licenses_Companies_CompanyId",
                schema: "app",
                table: "Licenses",
                column: "CompanyId",
                principalSchema: "app",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxPayments_Companies_CompanyId",
                schema: "app",
                table: "TaxPayments",
                column: "CompanyId",
                principalSchema: "app",
                principalTable: "Companies",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Addresses_AddressId",
                schema: "app",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Industries_IndustryId",
                schema: "app",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Companies_CompanyId",
                schema: "app",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Residents_ResidentId",
                schema: "app",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Licenses_Companies_CompanyId",
                schema: "app",
                table: "Licenses");

            migrationBuilder.DropForeignKey(
                name: "FK_TaxPayments_Companies_CompanyId",
                schema: "app",
                table: "TaxPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TaxPayments",
                schema: "app",
                table: "TaxPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Licenses",
                schema: "app",
                table: "Licenses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Industries",
                schema: "app",
                table: "Industries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                schema: "app",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                schema: "app",
                table: "Companies");

            migrationBuilder.RenameTable(
                name: "TaxPayments",
                schema: "app",
                newName: "TaxPayment",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Licenses",
                schema: "app",
                newName: "License",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Industries",
                schema: "app",
                newName: "Industry",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Employees",
                schema: "app",
                newName: "Employee",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Companies",
                schema: "app",
                newName: "Company",
                newSchema: "app");

            migrationBuilder.RenameIndex(
                name: "IX_TaxPayments_CompanyId",
                schema: "app",
                table: "TaxPayment",
                newName: "IX_TaxPayment_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Licenses_CompanyId",
                schema: "app",
                table: "License",
                newName: "IX_License_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_ResidentId",
                schema: "app",
                table: "Employee",
                newName: "IX_Employee_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_CompanyId",
                schema: "app",
                table: "Employee",
                newName: "IX_Employee_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_IndustryId",
                schema: "app",
                table: "Company",
                newName: "IX_Company_IndustryId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_AddressId",
                schema: "app",
                table: "Company",
                newName: "IX_Company_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TaxPayment",
                schema: "app",
                table: "TaxPayment",
                column: "TaxPaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_License",
                schema: "app",
                table: "License",
                column: "LicenseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Industry",
                schema: "app",
                table: "Industry",
                column: "IndustryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                schema: "app",
                table: "Employee",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                schema: "app",
                table: "Company",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Addresses_AddressId",
                schema: "app",
                table: "Company",
                column: "AddressId",
                principalSchema: "app",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Industry_IndustryId",
                schema: "app",
                table: "Company",
                column: "IndustryId",
                principalSchema: "app",
                principalTable: "Industry",
                principalColumn: "IndustryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Company_CompanyId",
                schema: "app",
                table: "Employee",
                column: "CompanyId",
                principalSchema: "app",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Residents_ResidentId",
                schema: "app",
                table: "Employee",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_License_Company_CompanyId",
                schema: "app",
                table: "License",
                column: "CompanyId",
                principalSchema: "app",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaxPayment_Company_CompanyId",
                schema: "app",
                table: "TaxPayment",
                column: "CompanyId",
                principalSchema: "app",
                principalTable: "Company",
                principalColumn: "CompanyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
