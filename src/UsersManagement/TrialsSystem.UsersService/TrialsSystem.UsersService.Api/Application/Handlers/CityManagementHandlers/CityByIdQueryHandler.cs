using MediatR;
using TrialsSystem.UsersService.Api.Application.Queries.CityManagementQueries;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityResponses;

namespace TrialsSystem.UsersService.Api.Application.Handlers.CityManagementHandlers
{
    public class CityByIdQueryHandler : IRequestHandler<CityByIdQuery, IEnumerable<GetCityResponse>>
    {
        public CityByIdQueryHandler()
        {

        }

        public async Task<IEnumerable<GetCityResponse>> Handle(CityByIdQuery request, CancellationToken cancellationToken)
        {
            return new List<GetCityResponse>();
        }
    }
}
