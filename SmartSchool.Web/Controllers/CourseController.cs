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
            //var courses = await _courseService.GetAllAsync();
            return View();
        }

        [HttpGet]

        public async Task<JsonResult> GetCourseList()
        {
            var courses = await _courseService.GetAllAsync();
            return new JsonResult(courses);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Create(Course courseObj)
        {
            var course = new Course()
            {
                CourseCode = courseObj.CourseCode,
                Name = courseObj.Name,
                Description = courseObj.Description,
                CourseType = courseObj.CourseType,
            };
            if (course.Name == course.Description)
            {
                ModelState.AddModelError("Name", "Name and Description cannot be the same");
                ModelState.AddModelError("Description", "Name and Description cannot be the same");
            }
            if (ModelState.IsValid)
            {
                await _courseService.CreateAsync(course);
                TempData["success"] = "The course has been created successfully.";
            }
            return new JsonResult("Course Saved Successfully");
        }

        [HttpGet]
        public async Task<JsonResult> Update(int id)
        {
            var course = await _courseService.GetAsync(id);
            return new JsonResult(course);
        }


        [HttpPost]
        public async Task<JsonResult> Update(Course course)
        {
            await _courseService.UpdateAsync(course);
            return new JsonResult("Course Updated");
        }


        public async Task<JsonResult> Remove(int id)
        {
            var course = await _courseService.GetAsync(id);
            if (course != null)
            {
                await _courseService.RemoveAsync(course);
            }
            return new JsonResult("Data Deleted");
        }

    }
}
