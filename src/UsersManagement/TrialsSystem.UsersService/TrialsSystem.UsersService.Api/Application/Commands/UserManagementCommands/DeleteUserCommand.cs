namespace TrialsSystem.UsersService.Api.Application.Commands.UserManagementCommands
{
    public class DeleteUserCommand
    {
        public DeleteUserCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }

    }
}
