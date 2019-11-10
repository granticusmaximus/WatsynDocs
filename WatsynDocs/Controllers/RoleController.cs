using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WatsynDocs.Controllers
{
    [Authorize(Roles = Services.App.Pages.Role.RoleName)]
    public class RoleController : Controller
    {
        private readonly Services.Security.ICommon _security;

        //dependency injection through constructor, to directly access services
        public RoleController(Services.Security.ICommon security)
        {
            _security = security;
        }

        //consume custom security service to get all roles
        public IActionResult Index()
        {
            List<string> roles = new List<string>();
            roles = _security.GetAllRoles();
            return View(roles);
        }
    }
}
