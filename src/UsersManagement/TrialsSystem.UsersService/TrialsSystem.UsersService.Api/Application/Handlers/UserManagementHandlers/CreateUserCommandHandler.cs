using FluentValidation;
using MediatR;
using TrialsSystem.UsersService.Api.Application.Commands.UserManagementCommands;
using TrialsSystem.UsersService.Domain.AggregatesModel.UserAggregate;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UsersService.Api.Application.Handlers.UserManagementHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserResponse>
    {
        public async Task<CreateUserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.Email,
                                request.Name,
                                request.Surname,
                                request.CityId,
                                request.GenderId,
                                request.BirthDate);

            return new CreateUserResponse() { Id = user.Id };
        }
    }
}
