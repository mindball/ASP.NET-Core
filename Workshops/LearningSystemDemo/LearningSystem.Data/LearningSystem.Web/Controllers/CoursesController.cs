using LearningSystem.Data.Models;
using LearningSystem.Services.Courses;
using LearningSystem.Services.Courses.Models;
using LearningSystem.Web.Models.Courses;
using Microsoft.AspNetCore.Authorization;
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
               
            }

            return this.View(courseDetails);
        }
    }
}
