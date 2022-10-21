using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UserTasksService.Api.Application.Queries.UserTaskManagementQueries
{
    public class GetUserTaskByIdQuery : IRequest<GetUserTaskResponse>
    {
        public string UserId { get; }

        public string Id { get; }

        public GetUserTaskByIdQuery(string userId, string id)
        {
            UserId = userId;
            Id = id;
        }
    }
}
