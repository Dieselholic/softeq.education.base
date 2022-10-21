using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityResponses;

namespace TrialsSystem.UsersService.Api.Application.Queries.CityManagementQueries
{
    public class CityByIdQuery : IRequest<IEnumerable<GetCityResponse>>
    {
        public string CityId { get; }

        public string Id { get; }

        public CityByIdQuery(string cityId, string id)
        {
            CityId = cityId;
            Id = id;
        }
    }
}
