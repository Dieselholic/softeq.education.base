using MediatR;
using TrialsSystem.UserTasksService.Api.Application.Commands.UserTaskManagementCommands;
using TrialsSystem.UserTasksService.Domain.AggregatesModel.UserTasksAggregate;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UserTasksService.Api.Application.Handlers.UserManagementHandlers
{
    public class CreateUserTaskCommandHandler : IRequestHandler<CreateUserTaskCommand, CreateUserTaskResponse>
    {
        public async Task<CreateUserTaskResponse> Handle(CreateUserTaskCommand request, CancellationToken cancellationToken)
        {
            var userTask = new UserTask(request.Name,
                                request.Status,
                                request.CreatedDateTime,
                                request.LastUpdatedDateTime,
                                request.AdditionalProperties);

            return new CreateUserTaskResponse() { Id = userTask.Id.ToString() };
        }
    }
}
