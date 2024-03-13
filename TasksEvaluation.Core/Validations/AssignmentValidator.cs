﻿using FluentValidation;
using TasksEvaluation.Core.Entities.Business;

namespace TasksEvaluation.Core.Validations
{
    public class AssignmentValidator : AbstractValidator<Assignment>
    {
        public AssignmentValidator()
        {
            RuleFor(task => task.Title).NotNull().NotEmpty().WithMessage("Title is required");
            RuleFor(task => task.Description).NotNull().NotEmpty().WithMessage("Description is required");
            RuleFor(task => task.DeadLine).NotNull().NotEmpty().WithMessage("Deadline is required");
        }
    }
}
