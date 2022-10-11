﻿using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UsersService.Api.Application.Commands.UserManagementCommands
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

        public string Name { get; set; }

        public string Status { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }

        public Dictionary<string, string> AdditionalProperties { get; set; }

    }
}
