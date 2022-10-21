using FluentValidation;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityRequests;

namespace TrialsSystem.UsersService.Api.Application.Validation.CityManagementValidators
{
    public class GetCityByIdQueryValidator : AbstractValidator<GetCityByIdRequest>
    {
        public GetCityByIdQueryValidator()
        {
            RuleFor(u => u)
                .Must(u => string.IsNullOrEmpty(u.Name)).WithMessage("City's name should not be null.");
        }
    }
}
