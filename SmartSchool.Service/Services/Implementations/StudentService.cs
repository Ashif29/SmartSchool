using SmartSchool.Core.Models.Student;
using SmartSchool.Core.Models.Teacher;
using SmartSchool.Repository.Repositories.Contracts;
using SmartSchool.Repository.Repositories.Implementations;
using SmartSchool.Service.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartSchool.Service.Services.Implementations
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task CreateAsync(Student student)
        {
            await _studentRepository.CreateAsync(student);
        }

        public async Task<List<Student>> GetAllAsync()
        {
            return await _studentRepository.GetAllAsync();
        }

        public async Task<Student> GetAsync(int id)
        {
            return await _studentRepository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(Student student)
        {
            await _studentRepository.RemoveAsync(student);
        }

        public async Task UpdateAsync(Student student)
        {
            await _studentRepository.UpdateAsync(student);
        }
    }
}
