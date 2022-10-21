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



        public string Id { get; private set; }

        public string Status { get; set; }

        public Dictionary<string, string> AdditionalProperties { get; set; }

    }
}
