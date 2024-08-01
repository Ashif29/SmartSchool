using Microsoft.AspNetCore.Mvc;
using SmartSchool.Service.Services.Contracts;

namespace SmartSchool.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public async Task<IActionResult> Index()
        {
            var courses = await _courseService.GetAllAsync();
            return View(courses);
        }
    }
}
