using TasksEvaluation.Core.Entities.Common;

namespace TasksEvaluation.Core.Entities.Business
{
    public class EvaluationGrade : Base
    {
        public string Grade { get; set; }
        public ICollection<Solution> Solutions { get; set; }
    }
}
