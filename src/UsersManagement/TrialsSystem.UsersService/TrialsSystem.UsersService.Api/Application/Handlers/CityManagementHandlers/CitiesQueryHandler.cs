using MediatR;
using TrialsSystem.UsersService.Api.Application.Queries.CityManagementQueries;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityResponses;

namespace TrialsSystem.UsersService.Api.Application.Handlers.CityManagementHandlers
{
    public class CitiesQueryHandler : IRequestHandler<CitiesQuery, IEnumerable<GetCityResponse>>
    {
        public CitiesQueryHandler()
        {

        }

        public async Task<IEnumerable<GetCityResponse>> Handle(CitiesQuery request, CancellationToken cancellationToken)
        {
            return new List<GetCityResponse>();
        }
    }
}
