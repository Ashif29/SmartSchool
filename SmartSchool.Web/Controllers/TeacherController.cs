using Microsoft.AspNetCore.Mvc;
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
    }
}
