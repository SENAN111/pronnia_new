using Microsoft.AspNetCore.Mvc;

namespace PRONIYE_NEW.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DashboardController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
