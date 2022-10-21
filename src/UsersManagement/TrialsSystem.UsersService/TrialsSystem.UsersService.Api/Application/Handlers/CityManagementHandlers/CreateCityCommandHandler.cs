using System.Reflection.Metadata.Ecma335;
using MediatR;
using TrialsSystem.UsersService.Api.Application.Commands.CityManagementCommands;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityResponses;

namespace TrialsSystem.UsersService.Api.Application.Handlers.CityManagementHandlers
{
    public class CreateCityCommandHandler : IRequestHandler<CreateCityCommand, CreateCityResponse>
    {
        public async Task<CreateCityResponse> Handle(CreateCityCommand request, CancellationToken cancellationToken)
        {
            return new CreateCityResponse();
        }
    }
}
