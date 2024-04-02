using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TasksEvaluation.Core.Entities.Common;
using TasksEvaluation.Core.Filters;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Assignment : Base
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [DateGreaterThan("Now")]
        public DateTime DeadLine { get; set; }
        
        public int? GroupId { get; set; }
        public Group Group { get; }
        
        public Solution Solution { get; set; }

        public DateTime Now { get; set; } = DateTime.Now;
    }
}
