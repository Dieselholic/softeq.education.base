using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityResponses;

namespace TrialsSystem.UsersService.Api.Application.Queries.CityManagementQueries
{
    public class CityByIdQuery : IRequest<IEnumerable<GetCityResponse>>
    {
        public CityByIdQuery(string cityId,
                             string id)
        {
            CityId = cityId;
            Id = id;
        }

        public string CityId { get; }

        public string Id { get; }

    }
}
