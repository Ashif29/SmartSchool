using Microsoft.AspNetCore.Mvc;
using SmartSchool.Core.Models.StudentModels;
using SmartSchool.Service.Services.Contracts;

namespace SmartSchool.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]

        public async Task<JsonResult> GetStudentList()
        {
            var students = await _studentService.GetAllAsync();
            return new JsonResult(students);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> Create(Student studentObj)
        {
            var student = new Student()
            {
                Name = studentObj.Name,
                Gender = studentObj.Gender,
                Address = studentObj.Address,
                DateOfBirth = studentObj.DateOfBirth
            };

            await _studentService.CreateAsync(student);
            return new JsonResult("Student Added Successfully");
        }


        [HttpGet]
        public async Task<JsonResult> Update(int id)
        {
            var student = await _studentService.GetAsync(id);
            return new JsonResult(student);
        }


        [HttpPost]
        public async Task<JsonResult> Update(Student student)
        {
            await _studentService.UpdateAsync(student);
            return new JsonResult("Student Updated");
        }


        public async Task<JsonResult> Remove(int id)
        {
            var student = await _studentService.GetAsync(id);
            if (student != null)
            {
                await _studentService.RemoveAsync(student);
            }
            return new JsonResult("Data Deleted");
        }
    }
}
