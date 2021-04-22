using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Services.Users.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Services.Users
{
    public class UsersService : IUsersService
    {
        private readonly LearningSystemDbContext db;
        private readonly IPdfGeneratorService pdfGenerator;

        public UsersService(LearningSystemDbContext db,
            IPdfGeneratorService pdfGenerator)
        {
            this.db = db;
            this.pdfGenerator = pdfGenerator;
        }

        public async Task<IEnumerable<UserListingServiceModel>> FindUsersAsync(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                throw new ArgumentException("search text is empty");
            }

            var users = await this.db.Users
                .OrderBy(c => c.UserName)
                .Where(c => c.Name.ToLower().Contains(searchText.ToLower()))
                .ProjectTo<UserListingServiceModel>()
                .ToListAsync();

            return users;
        }

        public async Task<byte[]> GetPdfCertificate(string courseId, string userId)
        {
            var studentInCourse = await this.db.StudentsCourses.FindAsync(courseId, userId);

            if (studentInCourse == null)
            {
                return null;
            }

            var certificateInfo = await this.db.Courses
                .Where(c => c.Id == courseId)
                .Select(c => new
                {
                    CourseName = c.Name,
                    CourseStartdate = c.StartDate,
                    CourseEnddate = c.EndDate,
                    StudentName = c.Students.
                        Where(s => s.StudentId == userId)
                        .Select(s => s.Student.Name)
                        .FirstOrDefault(),
                    StudentGrade = c.Students.Where(s => s.StudentId == userId)
                        .Select(s => s.Grade)
                        .FirstOrDefault(),
                    Trainer = c.Trainer.Name
                })
                .FirstAsync();

            return this.pdfGenerator.GeneratePdfFromHtml(string.Format(
                ServiceConstants.PdfCertificateFormat,
                certificateInfo.CourseName,
                certificateInfo.CourseStartdate.ToShortDateString(),
                certificateInfo.CourseEnddate.ToShortDateString(),
                certificateInfo.StudentName,
                certificateInfo.StudentGrade,
                certificateInfo.Trainer,
                DateTime.UtcNow.ToShortDateString()));
        }

        public async Task<UserProfileServiceModel> ProfileAsync(string userId)
        {      
            var userProfile =   await this.db
                      .Users
                      .Where(u => u.Id == userId)
                      .ProjectTo<UserProfileServiceModel>(new { studentId = userId })
                      .FirstOrDefaultAsync();

            return userProfile;           
        }
    }
}
