using LearningSystem.Data;
using LearningSystem.Data.Models;
using LearningSystem.Services.Courses;
using LearningSystem.Services.Courses.Models;
using LearningSystem.Web.Infrastructure.Extensions;
using LearningSystem.Web.Models.Courses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LearningSystem.Web.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;
        private readonly UserManager<User> userManager;

        public CoursesController(ICourseService courseService,
            UserManager<User> userManager)
        {
            this.courseService = courseService;
            this.userManager = userManager;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details([FromRoute(Name = "id")] string courseId)
        {
            var courseDetails = new CourseDetailViewModel();
            courseDetails.Course =
                await this.courseService.ByIdAsync<CourseDetailsServiceModel>(courseId);

            if (courseDetails.Course == null)
            {
                return NotFound();
            }

            if (User.Identity.IsAuthenticated)
            {
                var userId = this.userManager.GetUserId(User);

                courseDetails.UserIsEnrolledCourse = 
                   await this.courseService.StudentIsEnrolledCourseAsync(courseId, userId);
            }

            return this.View(courseDetails);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SignUp([FromRoute(Name = "id")] string courseId)
        {
            var userId = this.userManager.GetUserId(User);

            var success = await this.courseService.SignUpStudentAsync(courseId, userId);

            if (!success)
            {
                return BadRequest();
            }

            TempData.AddSuccessMessage("Thank you for your registration!");

            return this.RedirectToAction(nameof(Details), new { id = courseId });
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SignOut([FromRoute(Name = "id")] string courseId)
        {
            var userId = this.userManager.GetUserId(User);
            var success = await this.courseService.SignOutStudentAsync(courseId, userId);

            if (!success)
            {
                return BadRequest();
            }

            var courseName = await this.courseService.ByIdAsync<CourseDetailsServiceModel>(courseId);
            TempData.AddSuccessMessage($"You have successfully sign out of {courseName.Name}");

            return this.RedirectToAction(nameof(Details), new { id = courseId });
        }

        //select multiple files
        //[Authorize]
        //[HttpPost]
        //public async Task<IActionResult> SubmitExam([FromRoute(Name = "id")]string courseId, List<IFormFile> exams)
        //{
        //    long size = exams.Sum(f => f.Length);


        //    return this.RedirectToAction(nameof(Details), new { id = courseId });
        //}

        //Get one file
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> SubmitExam([FromRoute(Name = "id")] string courseId, IFormFile exam)
        {
            if (!exam.FileName.EndsWith(".zip")
                || exam.Length > DataConstants.CourseExamSubmissionFileLength)
            {
                TempData.AddErrorMessage("Your submission should be a '.zip' file with no more than 2 MB in size!");
                return RedirectToAction(nameof(Details), new { id = courseId });
            }

            var fileContents = await exam.ToByteArrayAsync();
            var userId = this.userManager.GetUserId(User);

            var success = await this.courseService.SaveExamSubmission(courseId, userId, fileContents);


            return this.RedirectToAction(nameof(Details), new { id = courseId });
        }
    }
}
