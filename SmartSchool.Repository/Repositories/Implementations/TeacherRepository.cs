
using Microsoft.EntityFrameworkCore;
using SmartSchool.Core.Models.Student;
using SmartSchool.Core.Models.Teacher;
using SmartSchool.Repository.DataAccess;
using SmartSchool.Repository.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Repository.Repositories.Implementations
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext _db;

        public TeacherRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task CreateAsync(Teacher teacher)
        {
            await _db.Teachers.AddAsync(teacher);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Teacher>> GetAllAsync()
        {
            return await _db.Teachers.ToListAsync();
        }

        public async Task<Teacher> GetByIdAsync(int id)
        {
            return await _db.Teachers.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task RemoveAsync(Teacher teacher)
        {
            _db.Teachers.Remove(teacher);
            await _db.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Teacher teacher)
        {
            _db.Teachers.Update(teacher);
            await _db.SaveChangesAsync();
        }
    }
}
