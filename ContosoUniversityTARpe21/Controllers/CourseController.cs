using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversityTARpe21.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
