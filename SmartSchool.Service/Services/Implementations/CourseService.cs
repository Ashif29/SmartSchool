using SmartSchool.Core.Models.CourseModels;
using SmartSchool.Repository.Repositories.Contracts;
using SmartSchool.Service.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Service.Services.Implementations
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public async Task CreateAsync(Course course)
        {
            await _courseRepository.CreateAsync(course);
        }

        public async Task<List<Course>> GetAllAsync(Expression<Func<Course, bool>> filter = null)
        {
            return await _courseRepository.GetAllAsync(filter);
        }

        public async Task<Course> GetAsync(int id)
        {
            return await _courseRepository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(Course course)
        {
            await _courseRepository.RemoveAsync(course);
        }

        public async Task UpdateAsync(Course course)
        {
            await _courseRepository.UpdateAsync(course);
        }
    }
}
