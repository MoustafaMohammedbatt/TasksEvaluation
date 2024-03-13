using FluentValidation;
using TasksEvaluation.Core.Entities.Business;

namespace TaskEvaluation.Web.EntityConfigs
{
    public class CourseValidator : AbstractValidator<Course>
    {
        public CourseValidator() 
        {

            RuleFor(course => course.Title).NotNull().NotEmpty().WithMessage("Title is required");
            RuleFor(course => course.IsCompleted).NotNull().NotEmpty().WithMessage("Completion status is required");
            RuleFor(c=>c.Title).NotNull().NotEmpty();
        }
    }
}
