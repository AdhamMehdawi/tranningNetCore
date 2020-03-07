using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication38.Migrations
{
    public partial class CreateStudentTranTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentTrannings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDelete = table.Column<bool>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: false),
                    TrainingId = table.Column<int>(nullable: false),
                    StudentId = table.Column<int>(nullable: false),
                    IsCompleet = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTrannings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentTrannings_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTrannings_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentTrannings_StudentId",
                table: "StudentTrannings",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTrannings_TrainingId",
                table: "StudentTrannings",
                column: "TrainingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentTrannings");
        }
    }
}
