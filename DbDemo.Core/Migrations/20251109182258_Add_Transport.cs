using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbDemo.Core.Migrations
{
    /// <inheritdoc />
    public partial class Add_Transport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Driver_Residents_ResidentId",
                schema: "app",
                table: "Driver");

            migrationBuilder.DropForeignKey(
                name: "FK_RouteStop_Route_RouteId",
                schema: "app",
                table: "RouteStop");

            migrationBuilder.DropForeignKey(
                name: "FK_RouteStop_Stop_StopId",
                schema: "app",
                table: "RouteStop");

            migrationBuilder.DropForeignKey(
                name: "FK_Stop_Addresses_AddressId",
                schema: "app",
                table: "Stop");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Driver_DriverId",
                schema: "app",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                schema: "app",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stop",
                schema: "app",
                table: "Stop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RouteStop",
                schema: "app",
                table: "RouteStop");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Route",
                schema: "app",
                table: "Route");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Driver",
                schema: "app",
                table: "Driver");

            migrationBuilder.RenameTable(
                name: "Vehicle",
                schema: "app",
                newName: "Vehicles",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Stop",
                schema: "app",
                newName: "Stops",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "RouteStop",
                schema: "app",
                newName: "RouteStops",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Route",
                schema: "app",
                newName: "Routes",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Driver",
                schema: "app",
                newName: "Drivers",
                newSchema: "app");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_DriverId",
                schema: "app",
                table: "Vehicles",
                newName: "IX_Vehicles_DriverId");

            migrationBuilder.RenameIndex(
                name: "IX_Stop_AddressId",
                schema: "app",
                table: "Stops",
                newName: "IX_Stops_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_RouteStop_StopId",
                schema: "app",
                table: "RouteStops",
                newName: "IX_RouteStops_StopId");

            migrationBuilder.RenameIndex(
                name: "IX_Driver_ResidentId",
                schema: "app",
                table: "Drivers",
                newName: "IX_Drivers_ResidentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                schema: "app",
                table: "Vehicles",
                column: "VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stops",
                schema: "app",
                table: "Stops",
                column: "StopId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RouteStops",
                schema: "app",
                table: "RouteStops",
                columns: new[] { "RouteId", "StopId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Routes",
                schema: "app",
                table: "Routes",
                column: "RouteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Drivers",
                schema: "app",
                table: "Drivers",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Drivers_Residents_ResidentId",
                schema: "app",
                table: "Drivers",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RouteStops_Routes_RouteId",
                schema: "app",
                table: "RouteStops",
                column: "RouteId",
                principalSchema: "app",
                principalTable: "Routes",
                principalColumn: "RouteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RouteStops_Stops_StopId",
                schema: "app",
                table: "RouteStops",
                column: "StopId",
                principalSchema: "app",
                principalTable: "Stops",
                principalColumn: "StopId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stops_Addresses_AddressId",
                schema: "app",
                table: "Stops",
                column: "AddressId",
                principalSchema: "app",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Drivers_DriverId",
                schema: "app",
                table: "Vehicles",
                column: "DriverId",
                principalSchema: "app",
                principalTable: "Drivers",
                principalColumn: "DriverId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Drivers_Residents_ResidentId",
                schema: "app",
                table: "Drivers");

            migrationBuilder.DropForeignKey(
                name: "FK_RouteStops_Routes_RouteId",
                schema: "app",
                table: "RouteStops");

            migrationBuilder.DropForeignKey(
                name: "FK_RouteStops_Stops_StopId",
                schema: "app",
                table: "RouteStops");

            migrationBuilder.DropForeignKey(
                name: "FK_Stops_Addresses_AddressId",
                schema: "app",
                table: "Stops");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Drivers_DriverId",
                schema: "app",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                schema: "app",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stops",
                schema: "app",
                table: "Stops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RouteStops",
                schema: "app",
                table: "RouteStops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Routes",
                schema: "app",
                table: "Routes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Drivers",
                schema: "app",
                table: "Drivers");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                schema: "app",
                newName: "Vehicle",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Stops",
                schema: "app",
                newName: "Stop",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "RouteStops",
                schema: "app",
                newName: "RouteStop",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Routes",
                schema: "app",
                newName: "Route",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Drivers",
                schema: "app",
                newName: "Driver",
                newSchema: "app");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_DriverId",
                schema: "app",
                table: "Vehicle",
                newName: "IX_Vehicle_DriverId");

            migrationBuilder.RenameIndex(
                name: "IX_Stops_AddressId",
                schema: "app",
                table: "Stop",
                newName: "IX_Stop_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_RouteStops_StopId",
                schema: "app",
                table: "RouteStop",
                newName: "IX_RouteStop_StopId");

            migrationBuilder.RenameIndex(
                name: "IX_Drivers_ResidentId",
                schema: "app",
                table: "Driver",
                newName: "IX_Driver_ResidentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                schema: "app",
                table: "Vehicle",
                column: "VehicleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stop",
                schema: "app",
                table: "Stop",
                column: "StopId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RouteStop",
                schema: "app",
                table: "RouteStop",
                columns: new[] { "RouteId", "StopId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Route",
                schema: "app",
                table: "Route",
                column: "RouteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Driver",
                schema: "app",
                table: "Driver",
                column: "DriverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Driver_Residents_ResidentId",
                schema: "app",
                table: "Driver",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RouteStop_Route_RouteId",
                schema: "app",
                table: "RouteStop",
                column: "RouteId",
                principalSchema: "app",
                principalTable: "Route",
                principalColumn: "RouteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RouteStop_Stop_StopId",
                schema: "app",
                table: "RouteStop",
                column: "StopId",
                principalSchema: "app",
                principalTable: "Stop",
                principalColumn: "StopId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stop_Addresses_AddressId",
                schema: "app",
                table: "Stop",
                column: "AddressId",
                principalSchema: "app",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Driver_DriverId",
                schema: "app",
                table: "Vehicle",
                column: "DriverId",
                principalSchema: "app",
                principalTable: "Driver",
                principalColumn: "DriverId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
