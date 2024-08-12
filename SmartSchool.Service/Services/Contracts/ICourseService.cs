using SmartSchool.Core.Models.CourseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Service.Services.Contracts
{
    public interface ICourseService
    {
        Task<List<Course>> GetAllAsync(Expression<Func<Course, bool>> filter = null);

        Task<Course> GetAsync(int id);

        Task CreateAsync(Course course);
        Task UpdateAsync(Course course);

        Task RemoveAsync(Course course);
    }
}
