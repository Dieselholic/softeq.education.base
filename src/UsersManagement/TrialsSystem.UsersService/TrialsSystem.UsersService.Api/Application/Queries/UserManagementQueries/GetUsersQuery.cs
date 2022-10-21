using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UsersService.Api.Application.Queries.UserManagementQueries
{
    public class GetUsersQuery : IRequest<IEnumerable<GetUserResponse>>
    {
        public int? Take { get; }

        public int? Skip { get; }

        public string? Email { get; }

        public GetUsersQuery(int? take, int? skip, string email)
        {
            Take = take;
            Skip = skip;
            Email = email;
        }
    }
}
