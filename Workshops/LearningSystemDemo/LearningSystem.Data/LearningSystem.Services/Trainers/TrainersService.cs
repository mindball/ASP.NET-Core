using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Data.Enums;
using LearningSystem.Data.Models;
using LearningSystem.Services.Courses.Models;
using LearningSystem.Services.Trainers.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Services.Trainers
{
    public class TrainersService : ITrainersService
    {
        private readonly LearningSystemDbContext db;

        public TrainersService(LearningSystemDbContext db)
        {
            this.db = db;
        }

        public async Task<bool> AddGradeAsync(string courseId, string studentId, Grade grade)
        {
            var studentInCourse = await this.db
                .FindAsync<StudentCourse>(courseId, studentId);

            if (studentInCourse == null)
            {
                return false;
            }

            studentInCourse.Grade = grade;
            await this.db.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<CourseListingServiceModel>> GetCoursesAsync(string treinerId)
            => await this.db.Courses
                    .Where(c => c.TrainerId == treinerId)
                    .ProjectTo<CourseListingServiceModel>()
                    .ToListAsync();

        public async Task<byte[]> GetExamSubmissionAsync(string courseId, string studentId)
            => (await this.db.StudentsCourses
                    .FindAsync(courseId, studentId))
                ?.ExamSubmission;

        public async Task<bool> IsTrainerAsync(string courseId, string trainerId)
         => await this.db
                .Courses
                .AnyAsync(c => c.Id == courseId && c.TrainerId == trainerId);

        public async Task<StudentInCourseNameServiceModel> StudentInCourseNamesAsync(string courseId, string studentId)
            => await this.db.Users
            .Where(s => s.Id == studentId)            
            .ProjectTo<StudentInCourseNameServiceModel>(new { courseId })
            .FirstOrDefaultAsync();

        public async Task<IEnumerable<StudentInCourseServiceModel>> StudentsInCourseAsync(string courseId)
        {
            var st = await this.db
                    .StudentsCourses
                    .Where(c => c.CourseId == courseId)
                    .Select(c => c.Student)
                    .ProjectTo<StudentInCourseServiceModel>(new { courseId })
                    .ToListAsync();            

            return st;
        }
    }
}
