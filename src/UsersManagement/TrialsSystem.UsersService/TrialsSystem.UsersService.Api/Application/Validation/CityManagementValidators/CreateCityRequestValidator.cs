using FluentValidation;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityRequests;

namespace TrialsSystem.UsersService.Api.Application.Validation.CityManagementValidators
{
    public class CreateCityRequestValidator : AbstractValidator<CreateCityRequest>
    {
        public CreateCityRequestValidator()
        {
            RuleFor(u => u)
                .Must(u => string.IsNullOrEmpty(u.Name)).WithMessage("City's name should not be null.");
        }
    }
}
