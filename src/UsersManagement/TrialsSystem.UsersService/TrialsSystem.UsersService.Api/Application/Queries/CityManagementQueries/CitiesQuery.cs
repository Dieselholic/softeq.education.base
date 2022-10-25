using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityResponses;

namespace TrialsSystem.UsersService.Api.Application.Queries.CityManagementQueries
{
    public class CitiesQuery : IRequest<IEnumerable<GetCityResponse>>
    {
        public CitiesQuery(int? take,
                           int? skip,
                           string name)
        {
            Take = take;
            Skip = skip;
            Name = name;
        }

        public int? Take { get; }

        public int? Skip { get; }

        public string? Name { get; }

    }
}
