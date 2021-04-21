using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningSystem.Data.Migrations
{
    public partial class ExamSubmissionInMappingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    CourseId = table.Column<string>(nullable: false),
                    ExamSubmission = table.Column<byte[]>(maxLength: 2097152, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => new { x.CourseId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_Exam_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exam_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddColumn<byte[]>(
                maxLength: 2097152,
                name: "ExamSubmission",
               table: "StudentsCourses",
               nullable: true               
                );

            migrationBuilder.CreateIndex(
                name: "IX_Exam_StudentId",
                table: "Exam",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {   
            migrationBuilder.DropTable(
                name: "Exam");
        }
    }
}
