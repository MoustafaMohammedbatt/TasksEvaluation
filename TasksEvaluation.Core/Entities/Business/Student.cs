using TasksEvaluation.Core.Entities.Common;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Student : Base
    {

        public string FullName { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string ProfilePic { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<Solution> Solutions { get; set; }

    }
}
