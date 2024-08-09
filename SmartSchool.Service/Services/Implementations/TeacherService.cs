using SmartSchool.Core.Models.TeacherModels;
using SmartSchool.Repository.Repositories.Contracts;
using SmartSchool.Service.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Service.Services.Implementations
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task CreateAsync(Teacher teacher)
        {
            await _teacherRepository.CreateAsync(teacher);
        }

        public async Task<List<Teacher>> GetAllAsync()
        {
            return await _teacherRepository.GetAllAsync();
        }

        public async Task<Teacher> GetAsync(int id)
        {
            return await _teacherRepository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(Teacher teacher)
        {
            await _teacherRepository.RemoveAsync(teacher);
        }

        public async Task UpdateAsync(Teacher teacher)
        {
            await _teacherRepository.UpdateAsync(teacher);
        }
    }
}
