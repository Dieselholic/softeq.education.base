using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UserTasksService.Api.Application.Queries.UserTaskManagementQueries
{
    public class GetUserTasksQuery : IRequest<IEnumerable<GetUserTaskResponse>>
    {
        public int? Take { get; }

        public int? Skip { get; }

        public string? Name { get; }

        public GetUserTasksQuery(int? take, int? skip, string name)
        {
            Take = take;
            Skip = skip;
            Name = name;
        }
    }
}
