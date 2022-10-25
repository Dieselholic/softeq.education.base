namespace TrialsSystem.UserTasksService.Api.Application.Commands.UserTaskManagementCommands
{
    public class UpdateUserTaskCommand
    {
        public UpdateUserTaskCommand(string id,
                                     string status,
                                     Dictionary<string, string> additionalProperties)
        {
            Id = id;
            Status = status;
            AdditionalProperties = additionalProperties;
        }



        public string Id { get; }

        public string Status { get; }

        public Dictionary<string, string> AdditionalProperties { get; }

    }
}
