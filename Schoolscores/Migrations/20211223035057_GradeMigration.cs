using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Schoolscores.Migrations
{
    public partial class GradeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "Exams",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_StudentId",
                table: "Exams",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Students_StudentId",
                table: "Exams",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Students_StudentId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_StudentId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Exams");
        }
    }
}
