using TasksEvaluation.Core.Entities.Common;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Assignment : Base
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; }
        public Solution Solution { get; set; }
    }
}
