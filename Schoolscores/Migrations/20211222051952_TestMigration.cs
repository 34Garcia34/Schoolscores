using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolscores.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeachersTeacherId",
                table: "Students",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "examscore",
                table: "Students",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Students_TeachersTeacherId",
                table: "Students",
                column: "TeachersTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_TeachersTeacherId",
                table: "Students",
                column: "TeachersTeacherId",
                principalTable: "Teachers",
                principalColumn: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_TeachersTeacherId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_TeachersTeacherId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TeachersTeacherId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "examscore",
                table: "Students");
        }
    }
}
