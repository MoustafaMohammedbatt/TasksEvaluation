using FluentValidation;
using TasksEvaluation.Core.Entities.Business;

namespace TaskEvaluation.Core.Validation
{
    public class GroupValidator : AbstractValidator<Group>
    {
        public GroupValidator()
        {
            RuleFor(group => group.Title).NotEmpty().WithMessage("Title is required");


        }
    }
}
