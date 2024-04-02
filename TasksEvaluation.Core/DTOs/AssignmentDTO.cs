using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksEvaluation.Core.Filters;
using TasksEvaluation.Core.Const;

namespace TasksEvaluation.Core.DTOs
{
    public class AssignmentDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
