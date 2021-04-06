using LearningSystem.Data.Models;
using LearningSystem.Services.Admin;
using LearningSystem.Web.Areas.Admin.Models.Courses;
using LearningSystem.Web.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

using static LearningSystem.Web.WebConstants;
using LearningSystem.Web.Infrastructure.Extensions;

namespace LearningSystem.Web.Areas.Admin.Controllers
{
    public class CoursesController : BaseAdminController
    {
        private readonly IAdminCourseService adminCourse;
        private readonly UserManager<User> userManager;

        public CoursesController(IAdminCourseService adminCourse,
            UserManager<User> userManager)
        {
            this.adminCourse = adminCourse;
            this.userManager = userManager;
        }

        public async Task<IActionResult> CreateCourses()
            => this.View(new AddCoursesFormModel
            {
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(60),
                Trainers = await  GetTrainers()
            });

        [HttpPost]
        public async Task<IActionResult> CreateCourses(AddCoursesFormModel courseModel)
        {
            if(!ModelState.IsValid)
            {
                courseModel.Trainers = await GetTrainers();
                return this.View(courseModel);
            }

            await this.adminCourse.CreateAsync(courseModel.Name,
                courseModel.Description, 
                courseModel.StartDate, 
                courseModel.EndDate, 
                courseModel.TrainerId);

            TempData.AddSuccessMessage($"Course {courseModel.Name} created successfully!");

            //return Redirect(string url);

            return RedirectToAction(nameof(HomeController.Index), "Home", new { area = string.Empty });
        }

        private async Task<IEnumerable<SelectListItem>> GetTrainers()
        {
            var trainers = await this.userManager.GetUsersInRoleAsync(TrainerRole);

            return trainers.Select(t => new SelectListItem
            {
                Text = t.UserName,
                Value = t.Id
            }).ToList();
        }
    }
}
