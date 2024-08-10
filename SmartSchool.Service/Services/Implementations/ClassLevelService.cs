using SmartSchool.Core.Models;
using SmartSchool.Repository.Repositories.Contracts;
using SmartSchool.Service.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Service.Services.Implementations
{
    public class ClassLevelService : IClassLevelService
    {
        private readonly IClassLevelRepository _classLevelRepository;

        public ClassLevelService(IClassLevelRepository classLevelRepository)
        {
            _classLevelRepository = classLevelRepository;
        }
        public async Task<List<ClassLevel>> GetAllAsync()
        {
            return await _classLevelRepository.GetAllAsync();
        }
    }
}
