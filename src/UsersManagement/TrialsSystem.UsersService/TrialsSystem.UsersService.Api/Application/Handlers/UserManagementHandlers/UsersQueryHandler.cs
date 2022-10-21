using MediatR;
using TrialsSystem.UsersService.Api.Application.Queries.UserManagementQueries;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UsersService.Api.Application.Handlers.UserManagementHandlers
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, IEnumerable<GetUserResponse>>
    {
        public GetUsersQueryHandler()
        {

        }

        public async Task<IEnumerable<GetUserResponse>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            return new List<GetUserResponse>();
        }
    }
}
