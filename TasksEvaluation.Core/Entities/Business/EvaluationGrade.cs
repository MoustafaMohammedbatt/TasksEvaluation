using System.ComponentModel.DataAnnotations;
using TasksEvaluation.Core.Entities.Common;

namespace TasksEvaluation.Core.Entities.Business
{
    public class EvaluationGrade : Base
    {

        [Required(ErrorMessage = "Grade is required")]
        public string Grade { get; set; }
        public ICollection<Solution> Solutions { get; set; }
    }
}
