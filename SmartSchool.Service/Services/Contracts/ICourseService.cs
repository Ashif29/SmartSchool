using SmartSchool.Core.Models.CourseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Service.Services.Contracts
{
    public interface ICourseService
    {
        Task<List<Course>> GetAllAsync();

        Task<Course> GetAsync(int id);

        Task CreateAsync(Course course);
        Task UpdateAsync(Course course);

        Task RemoveAsync(Course course);
    }
}
