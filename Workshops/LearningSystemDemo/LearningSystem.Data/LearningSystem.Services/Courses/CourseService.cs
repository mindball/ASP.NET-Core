using AutoMapper.QueryableExtensions;
using LearningSystem.Data;
using LearningSystem.Data.Models;
using LearningSystem.Services.Courses.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningSystem.Services.Courses
{
    public class CourseService : ICourseService
    {
        private readonly LearningSystemDbContext dbContext;

        public CourseService(LearningSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<CourseListingServiceModel>> ActiveAsync()
        {
            var date = DateTime.UtcNow;
            var courseData = await this.dbContext.Courses
                  .Select(c => c.StartDate).FirstAsync();

            bool com = date > courseData;

            var result = await this.dbContext.Courses                  
                  .Where(c => c.StartDate >= date)
                  .ProjectTo<CourseListingServiceModel>()
                  .ToListAsync();

            return result;
        }

        public async Task<TModel> ByIdAsync<TModel>(string id) where TModel : class
            => await this.dbContext
                .Courses
                .Where(c => c.Id == id)
                .ProjectTo<TModel>()
                .FirstOrDefaultAsync();

        public async Task<bool> SignUpStudentAsync(string courseId, string studentId)
        {
            if(await this.dbContext.StudentsCourses
                .AnyAsync(cs => cs.CourseId == courseId && cs.StudentId == studentId))
            {
                return false;
            }

            //TODO: check start date

            var student = await this.dbContext.Users.FirstOrDefaultAsync(s => s.Id == studentId);
            if (student == null) 
                throw new ArgumentException("No such user in db");

            var course = await this.dbContext.Courses.FirstOrDefaultAsync(c => c.Id == courseId);
            if (course == null)
                throw new ArgumentException("No such course in db");

            var addStudentsCourses = new StudentCourse
            {
                Course = course,
                Student = (User)student
            };

            await this.dbContext.StudentsCourses.AddAsync(addStudentsCourses);
            await this.dbContext.SaveChangesAsync();

            return true;           
        }

        public async Task<bool> SignOutStudentAsync(string courseId, string studentId)
        {
            if (!await this.dbContext.StudentsCourses
                .AnyAsync(cs => cs.CourseId == courseId && cs.StudentId == studentId))
            {
                return false;
            }
            //TODO: check start date


            var student = await this.dbContext.Users.FirstOrDefaultAsync(s => s.Id == studentId);
            if (student == null)
                throw new ArgumentException("No such user in db");

            var course = await this.dbContext.Courses.FirstOrDefaultAsync(c => c.Id == courseId);
            if (course == null)
                throw new ArgumentException("No such course in db");

            var studentCourse =
                await this.dbContext.StudentsCourses
                .FirstOrDefaultAsync(sc => sc.StudentId == student.Id && sc.CourseId == course.Id);

            this.dbContext.Remove(studentCourse);
            await this.dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> StudentIsEnrolledCourseAsync(string courseId, string userId)
            => await this.dbContext
                .StudentsCourses
                .AnyAsync(c => c.CourseId == courseId && c.StudentId == userId);

        public async Task<IEnumerable<CourseListingServiceModel>> FindCoursesAsync(string searchText)
        {
            if(string.IsNullOrEmpty(searchText))
            {
                throw new ArgumentException("search text is empty");
            }

            var courses = await this.dbContext.Courses
                .OrderBy(c => c.Name)
                .Where(c => c.Name.ToLower().Contains(searchText.ToLower()))
                .ProjectTo<CourseListingServiceModel>()
                .ToListAsync();

            return courses;
        }
    }
}
