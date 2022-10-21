using FluentValidation;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityRequests;

namespace TrialsSystem.UsersService.Api.Application.Validation.CityManagementValidators
{
    public class UpdateCityRequestValidator : AbstractValidator<UpdateCityRequest>
    {
        public UpdateCityRequestValidator()
        {
            RuleFor(u => u)
                .Must(u => string.IsNullOrEmpty(u.Name)).WithMessage("City's name should not be null.");
        }
    }
}
