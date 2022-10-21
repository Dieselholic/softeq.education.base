using MediatR;
using TrialsSystem.UserTasksService.Api.Application.Queries.UserTaskManagementQueries;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UserTasksService.Api.Application.Handlers.UserManagementHandlers
{
    public class GetUserTasksQueryHandler : IRequestHandler<GetUserTasksQuery, IEnumerable<GetUserTaskResponse>>
    {
        public GetUserTasksQueryHandler()
        {

        }

        public async Task<IEnumerable<GetUserTaskResponse>> Handle(GetUserTasksQuery request, CancellationToken cancellationToken)
        {
            return new List<GetUserTaskResponse>();
        }
    }
}
