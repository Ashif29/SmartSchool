using Microsoft.AspNetCore.Mvc;
using SmartSchool.Core.Models.CourseModels;
using SmartSchool.Core.Models.StudentModels;
using SmartSchool.Service.Services.Contracts;
using SmartSchool.Service.Services.Implementations;

namespace SmartSchool.Web.Controllers
{
    public class AssignCourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly ITeacherService _teacherService;

        public AssignCourseController(ICourseService courseService, ITeacherService teacherService)
        {
            _courseService = courseService;
            _teacherService = teacherService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<JsonResult> GetNotTakenCourseList()
        {
            var notTakenCourseList = await _courseService.GetAllAsync(u => u.IsTaken == false);
            return new JsonResult(notTakenCourseList);
        }

        [HttpPost]
        public async Task<JsonResult> AssignCourse(Course Obj)
        {

            var course = await _courseService.GetAsync(Obj.Id);

            course.TeacherId = Obj.TeacherId;
            course.IsTaken = true;

            await _courseService.UpdateAsync(course);
            return new JsonResult("Course Assigned Successfully");
        }
    }
}
