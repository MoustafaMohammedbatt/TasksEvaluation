using FluentValidation;
using TasksEvaluation.Core.Entities.Business;

namespace TaskEvaluation.Web.EntityConfigs
{
    public class EvaluationGradeValidator : AbstractValidator<EvaluationGrade>
    {
        public EvaluationGradeValidator()
        {
            RuleFor(grade => grade.Grade).NotEmpty().WithMessage("Grade is required");

        }
    }
}
