using Microsoft.EntityFrameworkCore;
using SmartSchool.Core.Models.CourseModels;
using SmartSchool.Repository.DataAccess;
using SmartSchool.Repository.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Repository.Repositories.Implementations
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _db;

        public CourseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task CreateAsync(Course course)
        {
            await _db.Courses.AddAsync(course);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Course>> GetAllAsync(Expression<Func<Course, bool>> filter = null)
        {
            IQueryable<Course> query = _db.Courses;

            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }

        public async Task<Course> GetByIdAsync(int id)
        {
            return await _db.Courses.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task RemoveAsync(Course course)
        {
            _db.Courses.Remove(course);
            await _db.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Course course)
        {
            _db.Courses.Update(course);
            await _db.SaveChangesAsync();
        }
    }
}
