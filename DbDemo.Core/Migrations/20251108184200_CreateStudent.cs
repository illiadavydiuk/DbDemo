using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbDemo.Core.Migrations
{
    /// <inheritdoc />
    public partial class CreateStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResidentId1",
                schema: "app",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolId1",
                schema: "app",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                schema: "app",
                table: "Classes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Students",
                schema: "app",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResidentId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    ClassId1 = table.Column<int>(type: "int", nullable: true),
                    ResidentId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId",
                        column: x => x.ClassId,
                        principalSchema: "app",
                        principalTable: "Classes",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Classes_ClassId1",
                        column: x => x.ClassId1,
                        principalSchema: "app",
                        principalTable: "Classes",
                        principalColumn: "ClassId");
                    table.ForeignKey(
                        name: "FK_Students_Residents_ResidentId",
                        column: x => x.ResidentId,
                        principalSchema: "app",
                        principalTable: "Residents",
                        principalColumn: "ResidentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Students_Residents_ResidentId1",
                        column: x => x.ResidentId1,
                        principalSchema: "app",
                        principalTable: "Residents",
                        principalColumn: "ResidentId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ResidentId1",
                schema: "app",
                table: "Teachers",
                column: "ResidentId1");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SchoolId1",
                schema: "app",
                table: "Teachers",
                column: "SchoolId1");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TeacherId",
                schema: "app",
                table: "Classes",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId",
                schema: "app",
                table: "Students",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassId1",
                schema: "app",
                table: "Students",
                column: "ClassId1");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ResidentId",
                schema: "app",
                table: "Students",
                column: "ResidentId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ResidentId1",
                schema: "app",
                table: "Students",
                column: "ResidentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Teachers_TeacherId",
                schema: "app",
                table: "Classes",
                column: "TeacherId",
                principalSchema: "app",
                principalTable: "Teachers",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Residents_ResidentId1",
                schema: "app",
                table: "Teachers",
                column: "ResidentId1",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolId1",
                schema: "app",
                table: "Teachers",
                column: "SchoolId1",
                principalSchema: "app",
                principalTable: "Schools",
                principalColumn: "SchoolId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_TeacherId",
                schema: "app",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Residents_ResidentId1",
                schema: "app",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolId1",
                schema: "app",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Students",
                schema: "app");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_ResidentId1",
                schema: "app",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_SchoolId1",
                schema: "app",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Classes_TeacherId",
                schema: "app",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "ResidentId1",
                schema: "app",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SchoolId1",
                schema: "app",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                schema: "app",
                table: "Classes");
        }
    }
}
