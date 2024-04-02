using System.ComponentModel.DataAnnotations;
using TasksEvaluation.Core.Entities.Common;

namespace TasksEvaluation.Core.Entities.Business
{
    public class Student : Base
    {
        [Required(ErrorMessage = "Full name is required")]
        [MaxLength(100, ErrorMessage = "Full name cannot exceed 100 characters")]
        public string FullName { get; set; }

        [Display(Name = "Mobile Number")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Mobile number must be 10 digits")]
        public string MobileNumber { get; set; }

        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [MaxLength(100, ErrorMessage = "Email cannot exceed 100 characters")]
        public string Email { get; set; }

        [Display(Name = "Profile Picture")]
        //[MaxLength(255, ErrorMessage = "Profile picture path cannot exceed 255 characters")]
        public string ProfilePic { get; set; }
        public int? GroupId { get; set; }
        public Group Group { get; set; }
        public ICollection<Solution> Solutions { get; set; }

    }
}
