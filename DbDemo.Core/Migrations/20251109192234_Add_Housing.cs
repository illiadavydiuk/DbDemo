using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbDemo.Core.Migrations
{
    /// <inheritdoc />
    public partial class Add_Housing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_Building_BuildingId",
                schema: "app",
                table: "Apartment");

            migrationBuilder.DropForeignKey(
                name: "FK_BillPayment_UtilityBill_UtilityBillId",
                schema: "app",
                table: "BillPayment");

            migrationBuilder.DropForeignKey(
                name: "FK_Building_Addresses_AddressId",
                schema: "app",
                table: "Building");

            migrationBuilder.DropForeignKey(
                name: "FK_ResidentApartment_Apartment_ApartmentId",
                schema: "app",
                table: "ResidentApartment");

            migrationBuilder.DropForeignKey(
                name: "FK_ResidentApartment_Residents_ResidentId",
                schema: "app",
                table: "ResidentApartment");

            migrationBuilder.DropForeignKey(
                name: "FK_UtilityBill_Apartment_ApartmentId",
                schema: "app",
                table: "UtilityBill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UtilityBill",
                schema: "app",
                table: "UtilityBill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResidentApartment",
                schema: "app",
                table: "ResidentApartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Building",
                schema: "app",
                table: "Building");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillPayment",
                schema: "app",
                table: "BillPayment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartment",
                schema: "app",
                table: "Apartment");

            migrationBuilder.RenameTable(
                name: "UtilityBill",
                schema: "app",
                newName: "UtilityBills",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "ResidentApartment",
                schema: "app",
                newName: "ResidentApartments",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Building",
                schema: "app",
                newName: "Buildings",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "BillPayment",
                schema: "app",
                newName: "BillPayments",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Apartment",
                schema: "app",
                newName: "Apartments",
                newSchema: "app");

            migrationBuilder.RenameIndex(
                name: "IX_UtilityBill_ApartmentId",
                schema: "app",
                table: "UtilityBills",
                newName: "IX_UtilityBills_ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ResidentApartment_ResidentId",
                schema: "app",
                table: "ResidentApartments",
                newName: "IX_ResidentApartments_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_ResidentApartment_ApartmentId",
                schema: "app",
                table: "ResidentApartments",
                newName: "IX_ResidentApartments_ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Building_AddressId",
                schema: "app",
                table: "Buildings",
                newName: "IX_Buildings_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_BillPayment_UtilityBillId",
                schema: "app",
                table: "BillPayments",
                newName: "IX_BillPayments_UtilityBillId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartment_BuildingId",
                schema: "app",
                table: "Apartments",
                newName: "IX_Apartments_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UtilityBills",
                schema: "app",
                table: "UtilityBills",
                column: "UtilityBillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResidentApartments",
                schema: "app",
                table: "ResidentApartments",
                column: "ResidentApartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Buildings",
                schema: "app",
                table: "Buildings",
                column: "BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillPayments",
                schema: "app",
                table: "BillPayments",
                column: "BillPaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartments",
                schema: "app",
                table: "Apartments",
                column: "ApartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Buildings_BuildingId",
                schema: "app",
                table: "Apartments",
                column: "BuildingId",
                principalSchema: "app",
                principalTable: "Buildings",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillPayments_UtilityBills_UtilityBillId",
                schema: "app",
                table: "BillPayments",
                column: "UtilityBillId",
                principalSchema: "app",
                principalTable: "UtilityBills",
                principalColumn: "UtilityBillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Addresses_AddressId",
                schema: "app",
                table: "Buildings",
                column: "AddressId",
                principalSchema: "app",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResidentApartments_Apartments_ApartmentId",
                schema: "app",
                table: "ResidentApartments",
                column: "ApartmentId",
                principalSchema: "app",
                principalTable: "Apartments",
                principalColumn: "ApartmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResidentApartments_Residents_ResidentId",
                schema: "app",
                table: "ResidentApartments",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UtilityBills_Apartments_ApartmentId",
                schema: "app",
                table: "UtilityBills",
                column: "ApartmentId",
                principalSchema: "app",
                principalTable: "Apartments",
                principalColumn: "ApartmentId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Buildings_BuildingId",
                schema: "app",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_BillPayments_UtilityBills_UtilityBillId",
                schema: "app",
                table: "BillPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Addresses_AddressId",
                schema: "app",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_ResidentApartments_Apartments_ApartmentId",
                schema: "app",
                table: "ResidentApartments");

            migrationBuilder.DropForeignKey(
                name: "FK_ResidentApartments_Residents_ResidentId",
                schema: "app",
                table: "ResidentApartments");

            migrationBuilder.DropForeignKey(
                name: "FK_UtilityBills_Apartments_ApartmentId",
                schema: "app",
                table: "UtilityBills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UtilityBills",
                schema: "app",
                table: "UtilityBills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResidentApartments",
                schema: "app",
                table: "ResidentApartments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Buildings",
                schema: "app",
                table: "Buildings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BillPayments",
                schema: "app",
                table: "BillPayments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartments",
                schema: "app",
                table: "Apartments");

            migrationBuilder.RenameTable(
                name: "UtilityBills",
                schema: "app",
                newName: "UtilityBill",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "ResidentApartments",
                schema: "app",
                newName: "ResidentApartment",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Buildings",
                schema: "app",
                newName: "Building",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "BillPayments",
                schema: "app",
                newName: "BillPayment",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Apartments",
                schema: "app",
                newName: "Apartment",
                newSchema: "app");

            migrationBuilder.RenameIndex(
                name: "IX_UtilityBills_ApartmentId",
                schema: "app",
                table: "UtilityBill",
                newName: "IX_UtilityBill_ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ResidentApartments_ResidentId",
                schema: "app",
                table: "ResidentApartment",
                newName: "IX_ResidentApartment_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_ResidentApartments_ApartmentId",
                schema: "app",
                table: "ResidentApartment",
                newName: "IX_ResidentApartment_ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Buildings_AddressId",
                schema: "app",
                table: "Building",
                newName: "IX_Building_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_BillPayments_UtilityBillId",
                schema: "app",
                table: "BillPayment",
                newName: "IX_BillPayment_UtilityBillId");

            migrationBuilder.RenameIndex(
                name: "IX_Apartments_BuildingId",
                schema: "app",
                table: "Apartment",
                newName: "IX_Apartment_BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UtilityBill",
                schema: "app",
                table: "UtilityBill",
                column: "UtilityBillId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResidentApartment",
                schema: "app",
                table: "ResidentApartment",
                column: "ResidentApartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Building",
                schema: "app",
                table: "Building",
                column: "BuildingId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BillPayment",
                schema: "app",
                table: "BillPayment",
                column: "BillPaymentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartment",
                schema: "app",
                table: "Apartment",
                column: "ApartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_Building_BuildingId",
                schema: "app",
                table: "Apartment",
                column: "BuildingId",
                principalSchema: "app",
                principalTable: "Building",
                principalColumn: "BuildingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BillPayment_UtilityBill_UtilityBillId",
                schema: "app",
                table: "BillPayment",
                column: "UtilityBillId",
                principalSchema: "app",
                principalTable: "UtilityBill",
                principalColumn: "UtilityBillId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Building_Addresses_AddressId",
                schema: "app",
                table: "Building",
                column: "AddressId",
                principalSchema: "app",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResidentApartment_Apartment_ApartmentId",
                schema: "app",
                table: "ResidentApartment",
                column: "ApartmentId",
                principalSchema: "app",
                principalTable: "Apartment",
                principalColumn: "ApartmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResidentApartment_Residents_ResidentId",
                schema: "app",
                table: "ResidentApartment",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UtilityBill_Apartment_ApartmentId",
                schema: "app",
                table: "UtilityBill",
                column: "ApartmentId",
                principalSchema: "app",
                principalTable: "Apartment",
                principalColumn: "ApartmentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
