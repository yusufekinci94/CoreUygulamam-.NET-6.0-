using Microsoft.AspNetCore.Mvc;

namespace CoreUygulamam.Areas.Admin.Controllers
{
    public class AdminRoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
