using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksEvaluation.Core.DTOs;

namespace TasksEvaluation.Core.Interfaces.IServices
{
    public interface ISolutionService
    {
        Task<IEnumerable<SolutionDTO>> GetCourses();
        Task<SolutionDTO> GetCourse(int id);
        Task<SolutionDTO> Create(SolutionDTO model);
        Task Update(SolutionDTO model);
        Task Delete(int id);
    }
}
