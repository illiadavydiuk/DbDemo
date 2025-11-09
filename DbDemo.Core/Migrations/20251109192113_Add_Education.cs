using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbDemo.Core.Migrations
{
    /// <inheritdoc />
    public partial class Add_Education : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_School_SchoolId",
                schema: "app",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_Class_Teacher_TeacherId",
                schema: "app",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_School_Addresses_AddressId",
                schema: "app",
                table: "School");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Class_ClassId",
                schema: "app",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Residents_ResidentId",
                schema: "app",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_School_SchoolId",
                schema: "app",
                table: "Student");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_Residents_ResidentId",
                schema: "app",
                table: "Teacher");

            migrationBuilder.DropForeignKey(
                name: "FK_Teacher_School_SchoolId",
                schema: "app",
                table: "Teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                schema: "app",
                table: "Teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                schema: "app",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_School",
                schema: "app",
                table: "School");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Class",
                schema: "app",
                table: "Class");

            migrationBuilder.RenameTable(
                name: "Teacher",
                schema: "app",
                newName: "Teachers",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Student",
                schema: "app",
                newName: "Students",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "School",
                schema: "app",
                newName: "Schools",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Class",
                schema: "app",
                newName: "Classes",
                newSchema: "app");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_SchoolId",
                schema: "app",
                table: "Teachers",
                newName: "IX_Teachers_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Teacher_ResidentId",
                schema: "app",
                table: "Teachers",
                newName: "IX_Teachers_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_SchoolId",
                schema: "app",
                table: "Students",
                newName: "IX_Students_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_ResidentId",
                schema: "app",
                table: "Students",
                newName: "IX_Students_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Student_ClassId",
                schema: "app",
                table: "Students",
                newName: "IX_Students_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_School_AddressId",
                schema: "app",
                table: "Schools",
                newName: "IX_Schools_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Class_TeacherId",
                schema: "app",
                table: "Classes",
                newName: "IX_Classes_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Class_SchoolId",
                schema: "app",
                table: "Classes",
                newName: "IX_Classes_SchoolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                schema: "app",
                table: "Teachers",
                column: "TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                schema: "app",
                table: "Students",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schools",
                schema: "app",
                table: "Schools",
                column: "SchoolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classes",
                schema: "app",
                table: "Classes",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                schema: "app",
                table: "Classes",
                column: "SchoolId",
                principalSchema: "app",
                principalTable: "Schools",
                principalColumn: "SchoolId",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Schools_Addresses_AddressId",
                schema: "app",
                table: "Schools",
                column: "AddressId",
                principalSchema: "app",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId",
                schema: "app",
                table: "Students",
                column: "ClassId",
                principalSchema: "app",
                principalTable: "Classes",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Residents_ResidentId",
                schema: "app",
                table: "Students",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolId",
                schema: "app",
                table: "Students",
                column: "SchoolId",
                principalSchema: "app",
                principalTable: "Schools",
                principalColumn: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Residents_ResidentId",
                schema: "app",
                table: "Teachers",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                schema: "app",
                table: "Teachers",
                column: "SchoolId",
                principalSchema: "app",
                principalTable: "Schools",
                principalColumn: "SchoolId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Schools_SchoolId",
                schema: "app",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Teachers_TeacherId",
                schema: "app",
                table: "Classes");

            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Addresses_AddressId",
                schema: "app",
                table: "Schools");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId",
                schema: "app",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Residents_ResidentId",
                schema: "app",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                schema: "app",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Residents_ResidentId",
                schema: "app",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                schema: "app",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                schema: "app",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                schema: "app",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schools",
                schema: "app",
                table: "Schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classes",
                schema: "app",
                table: "Classes");

            migrationBuilder.RenameTable(
                name: "Teachers",
                schema: "app",
                newName: "Teacher",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Students",
                schema: "app",
                newName: "Student",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Schools",
                schema: "app",
                newName: "School",
                newSchema: "app");

            migrationBuilder.RenameTable(
                name: "Classes",
                schema: "app",
                newName: "Class",
                newSchema: "app");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_SchoolId",
                schema: "app",
                table: "Teacher",
                newName: "IX_Teacher_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Teachers_ResidentId",
                schema: "app",
                table: "Teacher",
                newName: "IX_Teacher_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_SchoolId",
                schema: "app",
                table: "Student",
                newName: "IX_Student_SchoolId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ResidentId",
                schema: "app",
                table: "Student",
                newName: "IX_Student_ResidentId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ClassId",
                schema: "app",
                table: "Student",
                newName: "IX_Student_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_Schools_AddressId",
                schema: "app",
                table: "School",
                newName: "IX_School_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_TeacherId",
                schema: "app",
                table: "Class",
                newName: "IX_Class_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Classes_SchoolId",
                schema: "app",
                table: "Class",
                newName: "IX_Class_SchoolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                schema: "app",
                table: "Teacher",
                column: "TeacherId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                schema: "app",
                table: "Student",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_School",
                schema: "app",
                table: "School",
                column: "SchoolId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Class",
                schema: "app",
                table: "Class",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_School_SchoolId",
                schema: "app",
                table: "Class",
                column: "SchoolId",
                principalSchema: "app",
                principalTable: "School",
                principalColumn: "SchoolId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Teacher_TeacherId",
                schema: "app",
                table: "Class",
                column: "TeacherId",
                principalSchema: "app",
                principalTable: "Teacher",
                principalColumn: "TeacherId",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_School_Addresses_AddressId",
                schema: "app",
                table: "School",
                column: "AddressId",
                principalSchema: "app",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Class_ClassId",
                schema: "app",
                table: "Student",
                column: "ClassId",
                principalSchema: "app",
                principalTable: "Class",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Residents_ResidentId",
                schema: "app",
                table: "Student",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Student_School_SchoolId",
                schema: "app",
                table: "Student",
                column: "SchoolId",
                principalSchema: "app",
                principalTable: "School",
                principalColumn: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_Residents_ResidentId",
                schema: "app",
                table: "Teacher",
                column: "ResidentId",
                principalSchema: "app",
                principalTable: "Residents",
                principalColumn: "ResidentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teacher_School_SchoolId",
                schema: "app",
                table: "Teacher",
                column: "SchoolId",
                principalSchema: "app",
                principalTable: "School",
                principalColumn: "SchoolId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
