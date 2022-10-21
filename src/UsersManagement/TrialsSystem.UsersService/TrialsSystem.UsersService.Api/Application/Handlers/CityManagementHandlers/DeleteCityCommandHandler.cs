using System.Reflection.Metadata.Ecma335;
using MediatR;
using TrialsSystem.UsersService.Api.Application.Commands.CityManagementCommands;

namespace TrialsSystem.UsersService.Api.Application.Handlers.CityManagementHandlers
{
    public class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand, Unit>
    {
        public async Task<Unit> Handle(DeleteCityCommand command, CancellationToken cancellationToken)
        {
            return Unit.Value;
        }
    }
}