using LearningSystem.Data.Enums;
using LearningSystem.Data.Models;
using LearningSystem.Services.Courses;
using LearningSystem.Services.Courses.Models;
using LearningSystem.Services.Trainers;
using LearningSystem.Web.Models.Trainers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LearningSystem.Web.Controllers
{
    public class TrainersController : Controller
    {
        private readonly ITrainersService trainersService;
        private readonly UserManager<User> userManger;
        private readonly ICourseService coursesServices;
        public TrainersController(ITrainersService trainersService,
            UserManager<User> userManger,
            ICourseService coursesServices)
        {
            this.trainersService = trainersService;
            this.coursesServices = coursesServices;
            this.userManger = userManger;
        }

        public async Task<IActionResult> Courses()
        {
            var trainerId = this.userManger.GetUserId(this.User);
            var courses = await this.trainersService.GetCoursesAsync(trainerId);

            return View(courses);
        }

        //[HttpGet("/Students/courseId")]
        public async Task<IActionResult> Students([FromRoute(Name = "id")]string courseId)
        {
            var trainerId = this.userManger.GetUserId(this.User);
            if(!await this.trainersService.IsTrainerAsync(courseId, trainerId))
            {
                return this.NotFound();
            }

            var students = await this.trainersService.StudentsInCourseAsync(courseId);
            var course = await this.coursesServices.ByIdAsync<CourseListingServiceModel>(courseId);

            return View(new StudentsInCourseViewModel
            {
                Students = students,
                Course = course
            });
        }

        [HttpPost]
        public async Task<IActionResult> GradeStudent(Grade grade, string studentId, [FromRoute(Name = "id")] string courseId)
        {
            if (string.IsNullOrEmpty(studentId))
            {
                return BadRequest();
            }

            var userId = this.userManger.GetUserId(User);
            if(!await this.trainersService.IsTrainerAsync(courseId, userId))
            {
                return BadRequest();
            }

            var success = await this.trainersService.AddGradeAsync(courseId, studentId, grade);

            if (!success)
            {
                return BadRequest();
            }

            return this.RedirectToAction(nameof(Students), new { id = courseId });
        }
    }
}
