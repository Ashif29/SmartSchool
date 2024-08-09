using SmartSchool.Core.Models.TeacherModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Repository.Repositories.Contracts
{
    public interface ITeacherRepository
    {
        Task<List<Teacher>> GetAllAsync();

        Task<Teacher> GetByIdAsync(int id);

        Task CreateAsync(Teacher teacher);
        Task UpdateAsync(Teacher teacher);
        Task RemoveAsync(Teacher teacher);
        Task SaveAsync();
    }
}
