using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksEvaluation.Core.DTOs;

namespace TasksEvaluation.Core.Interfaces.IServices
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentDTO>> GetCourses();
        Task<StudentDTO> GetCourse(int id);
        Task<StudentDTO> Create(StudentDTO model);
        Task Update(StudentDTO model);
        Task Delete(int id);
    }
}
