using SmartSchool.Core.Models.CourseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Repository.Repositories.Contracts
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAllAsync();

        Task<Course> GetByIdAsync(int id);

        Task CreateAsync(Course course);
        Task UpdateAsync(Course course);
        Task RemoveAsync(Course course);
        Task SaveAsync();
    }
}
