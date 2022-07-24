using FluentValidation;

namespace N5.Challenge.Application.Features.Permission.Commands.Update
{
    public class UpdatePermissionCommandValidator  : AbstractValidator<UpdatePermissionCommand>
    {

        public UpdatePermissionCommandValidator()
        {
            RuleFor(p => p.EmployeeName)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .NotNull()
            .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.EmployeeLastname)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.PermissionTypeId).NotEmpty().WithMessage("{PropertyName} is required.");
            RuleFor(p => p.Id).NotEmpty().WithMessage("{PropertyName} is required.");
        }

    }
}
