using Microsoft.AspNetCore.Mvc;
using SmartSchool.Core.Models.Course;
using SmartSchool.Core.Models.Teacher;
using SmartSchool.Service.Services.Contracts;
using SmartSchool.Service.Services.Implementations;

namespace SmartSchool.Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]

        public async Task<JsonResult> GetTeacherList()
        {
            var teachers = await _teacherService.GetAllAsync();
            return new JsonResult(teachers);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Create(Teacher teacherObj)
        {
            var teacher = new Teacher()
            {
                Name = teacherObj.Name,
                Designation = teacherObj.Designation,
                Gender = teacherObj.Gender,
                Address = teacherObj.Address,
                DateOfBirth = teacherObj.DateOfBirth
            };

            await _teacherService.CreateAsync(teacher);
            return new JsonResult("Teacher Added Successfully");
        }


        public async Task<JsonResult> Remove(int id)
        {
            var teacher = await _teacherService.GetAsync(id);
            if (teacher != null)
            {
                await _teacherService.RemoveAsync(teacher);
            }
            return new JsonResult("Data Deleted");
        }
    }
}
