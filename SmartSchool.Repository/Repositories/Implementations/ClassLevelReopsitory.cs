using Microsoft.EntityFrameworkCore;
using SmartSchool.Core.Models;
using SmartSchool.Repository.DataAccess;
using SmartSchool.Repository.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Repository.Repositories.Implementations
{
    public class ClassLevelReopsitory : IClassLevelRepository
    {
        private readonly ApplicationDbContext _db;

        public ClassLevelReopsitory(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<List<ClassLevel>> GetAllAsync()
        {
            return await _db.ClassLevels.ToListAsync();
        }
    }
}
