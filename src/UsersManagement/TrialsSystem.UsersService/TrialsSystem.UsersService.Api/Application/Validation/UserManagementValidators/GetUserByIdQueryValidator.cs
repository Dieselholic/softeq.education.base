using FluentValidation;
using TrialsSystem.UsersService.Api.Application.Queries.UserManagementQueries;

namespace TrialsSystem.UsersService.Api.Application.Validation.UserManagementValidators
{
    public class GetUserByIdQueryValidator : AbstractValidator<GetUserByIdQuery>
    {
        public GetUserByIdQueryValidator()
        {
            RuleFor(u => u)
                .Must(u => !string.IsNullOrEmpty(u.UserId)).WithMessage("Participant's id can't be null.")
                .Must(u => !string.IsNullOrEmpty(u.Id)).WithMessage("Id can't be null");
        }
    }
}
