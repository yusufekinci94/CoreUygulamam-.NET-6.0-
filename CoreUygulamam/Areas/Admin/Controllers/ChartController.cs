using CoreUygulamam.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreUygulamam.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass { categoryname = "TEKNOLOJİ", categorycount = 10 });
            list.Add(new CategoryClass { categoryname = "YAZILIM", categorycount = 14 });
            list.Add(new CategoryClass { categoryname = "SPOR", categorycount = 5 });
            list.Add(new CategoryClass { categoryname = "OYUN", categorycount = 13 });
            

            return Json(list);
        }
    }
}
