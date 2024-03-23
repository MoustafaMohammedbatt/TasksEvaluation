using FluentValidation;
using TasksEvaluation.Core.Entities.Business;

namespace TaskEvaluation.Web.EntityConfigs
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(student => student.FullName).NotEmpty().WithMessage("Full name is required");
            RuleFor(student => student.MobileNumber).NotEmpty().WithMessage("Mobile number is required"); //
            RuleFor(student => student.Email).NotEmpty().WithMessage("Email is required").EmailAddress().WithMessage("Invalid email format");
           

        }
    }
}
