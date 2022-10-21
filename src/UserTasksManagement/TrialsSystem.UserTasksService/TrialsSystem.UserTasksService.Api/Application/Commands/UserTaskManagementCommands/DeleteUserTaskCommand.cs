namespace TrialsSystem.UserTasksService.Api.Application.Commands.UserTaskManagementCommands
{
    public class DeleteUserTaskCommand
    {
        public string Id { get; private set; }

        public DeleteUserTaskCommand(string id)
        {
            Id = id;
        }
    }
}
