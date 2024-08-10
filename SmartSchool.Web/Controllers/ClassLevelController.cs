using Microsoft.AspNetCore.Mvc;
using SmartSchool.Service.Services.Contracts;
using SmartSchool.Service.Services.Implementations;

namespace SmartSchool.Web.Controllers
{
    public class ClassLevelController : Controller
    {
        private readonly IClassLevelService _classLevelService;

        public ClassLevelController(IClassLevelService classLevelService)
        {
            _classLevelService = classLevelService;
        }



        [HttpGet]
        public async Task<JsonResult> GetClassLevelList()
        {
            var classes = await _classLevelService.GetAllAsync();
            return new JsonResult(classes);
        }
    }
}
