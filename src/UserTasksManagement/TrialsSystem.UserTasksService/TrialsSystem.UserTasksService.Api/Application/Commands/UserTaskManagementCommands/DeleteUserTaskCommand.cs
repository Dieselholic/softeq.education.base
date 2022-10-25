namespace TrialsSystem.UserTasksService.Api.Application.Commands.UserTaskManagementCommands
{
    public class DeleteUserTaskCommand
    {
        public DeleteUserTaskCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }

    }
}
