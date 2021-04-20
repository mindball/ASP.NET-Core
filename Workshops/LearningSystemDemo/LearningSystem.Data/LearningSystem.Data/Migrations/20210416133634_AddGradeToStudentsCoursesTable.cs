using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningSystem.Data.Migrations
{
    public partial class AddGradeToStudentsCoursesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "Grade", 
               table: "StudentsCourses", 
               nullable: false,
               defaultValue: 0
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {           
        }
    }
}
