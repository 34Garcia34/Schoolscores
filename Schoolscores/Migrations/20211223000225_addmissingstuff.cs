using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolscores.Migrations
{
    public partial class addmissingstuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Exams",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Exams");
        }
    }
}
