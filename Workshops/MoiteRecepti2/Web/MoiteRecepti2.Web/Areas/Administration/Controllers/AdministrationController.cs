namespace MoiteRecepti2.Web.Areas.Administration.Controllers
{
    using MoiteRecepti2.Common;
    using MoiteRecepti2.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
