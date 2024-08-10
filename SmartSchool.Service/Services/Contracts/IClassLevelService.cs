using SmartSchool.Core.Models;
using SmartSchool.Core.Models.CourseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Service.Services.Contracts
{
    public interface IClassLevelService
    {
        Task<List<ClassLevel>> GetAllAsync();
    }
}
