using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UserTasksService.Api.Application.Commands.UserTaskManagementCommands
{
    public class CreateUserTaskCommand : IRequest<CreateUserTaskResponse>
    {
        public CreateUserTaskCommand(string name,
                                     string status,
                                     DateTime createdDateTime,
                                     DateTime lastUpdatedDateTime,
                                     Dictionary<string, string> additionalProperties)
        {
            Name = name;
            Status = status;
            CreatedDateTime = createdDateTime;
            LastUpdatedDateTime = lastUpdatedDateTime;
            AdditionalProperties = additionalProperties;
        }

        public string Name { get; }

        public string Status { get; }

        public DateTime CreatedDateTime { get; }

        public DateTime LastUpdatedDateTime { get; }

        public Dictionary<string, string> AdditionalProperties { get; }

    }
}
