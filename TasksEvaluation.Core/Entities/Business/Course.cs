using TasksEvaluation.Core.Entities.Common;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Course : Base
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; } = false;
        public ICollection<Group> Groups { get; set; }
    }
}
