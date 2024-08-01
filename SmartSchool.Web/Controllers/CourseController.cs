using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.Core.Models.Course;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (course.Name == course.Description)
            {
                ModelState.AddModelError("Name", "Name and Description cannot be the same");
                ModelState.AddModelError("Description", "Name and Description cannot be the same");
            }
            if (ModelState.IsValid)
            {
                _courseService.CreateAsync(course);
                TempData["success"] = "The villa has been created successfully.";
            }
            return View();
        }
    }
}
