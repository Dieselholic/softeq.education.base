using MediatR;

namespace TrialsSystem.UsersService.Api.Application.Commands.CityManagementCommands
{
    public class DeleteCityCommand : IRequest
    {
        public DeleteCityCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }

    }
}
