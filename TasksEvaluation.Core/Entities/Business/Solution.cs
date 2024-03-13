using TasksEvaluation.Core.Entities.Common;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Solution : Base
    {

        public string SolutionFile { get; set; }
        public string Notes { get; set; }
        public int? GradeId { get; set; }
        public EvaluationGrade Grade { get; set; }
        public int? StudentId { get; set; }
        public Student Student { get; set; }
        public int? AssignmentId { get; set; }
        public Assignment Assignment { get; set; }


    }
}
