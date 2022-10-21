using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityRequests;

namespace TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityResponses
{
    public class CreateCityResponse : CreateCityRequest
    {
        public string Id { get; set; }
    }
}