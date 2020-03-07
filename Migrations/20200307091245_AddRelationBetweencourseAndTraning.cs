using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication38.Migrations
{
    public partial class AddRelationBetweencourseAndTraning : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Trainings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_CourseId",
                table: "Trainings",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainings_Courses_CourseId",
                table: "Trainings",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainings_Courses_CourseId",
                table: "Trainings");

            migrationBuilder.DropIndex(
                name: "IX_Trainings_CourseId",
                table: "Trainings");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Trainings");
        }
    }
}
