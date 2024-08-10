using SmartSchool.Core.Models;
using SmartSchool.Core.Models.CourseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Repository.Repositories.Contracts
{
    public interface IClassLevelRepository
    {
        Task<List<ClassLevel>> GetAllAsync();
    }
}
