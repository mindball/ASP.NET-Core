using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static LearningSystem.Web.WebConstants;

namespace LearningSystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = AdministratorRole)]
    public abstract class BaseAdminController : Controller
    {}
}
