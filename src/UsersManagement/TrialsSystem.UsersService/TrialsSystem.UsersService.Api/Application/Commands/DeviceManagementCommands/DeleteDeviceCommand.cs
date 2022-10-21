namespace TrialsSystem.UsersService.Api.Application.Commands.DeviceManagementCommands
{
    public class DeleteDeviceCommand
    {
        public string Id { get; private set; }

        public DeleteDeviceCommand(string id)
        {
            Id = id;
        }
    }
}
