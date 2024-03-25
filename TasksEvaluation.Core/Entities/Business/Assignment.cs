using System.ComponentModel.DataAnnotations.Schema;
using TasksEvaluation.Core.Entities.Common;
using TasksEvaluation.Core.Filters;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Assignment : Base
    {
        public string Title { get; set; }
        public string Description { get; set; }

        [DateGreaterThan("Now")]
        public DateTime DeadLine { get; set; }
        
        public int? GroupId { get; set; }
        public Group Group { get; }
        
        public Solution Solution { get; set; }

        [NotMapped]
        public DateTime Now { get; set; } = DateTime.Now;
    }
}
