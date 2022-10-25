using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UsersService.Api.Application.Queries.UserManagementQueries
{
    public class GetUserByIdQuery : IRequest<GetUserResponse>
    {
        public GetUserByIdQuery(string userId,
                                string id)
        {
            UserId = userId;
            Id = id;
        }

        public string UserId { get; }

        public string Id { get; }

    }
}
