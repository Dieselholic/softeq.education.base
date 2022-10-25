namespace TrialsSystem.UsersService.Api.Application.Commands.DeviceManagementCommands
{
    public class DeleteDeviceCommand
    {
        public DeleteDeviceCommand(string id)
        {
            Id = id;
        }

        public string Id { get; }

    }
}
