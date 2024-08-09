using SmartSchool.Core.Models.TeacherModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Service.Services.Contracts
{
    public interface ITeacherService
    {
        Task<List<Teacher>> GetAllAsync();

        Task<Teacher> GetAsync(int id);

        Task CreateAsync(Teacher teacher);
        Task UpdateAsync(Teacher teacher);

        Task RemoveAsync(Teacher teacher);

    }
}
