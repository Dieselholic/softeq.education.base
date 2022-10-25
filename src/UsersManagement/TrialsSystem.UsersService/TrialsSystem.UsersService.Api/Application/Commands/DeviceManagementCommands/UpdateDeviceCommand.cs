using System.Reflection;
using TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate;

namespace TrialsSystem.UsersService.Api.Application.Commands.DeviceManagementCommands
{
    public class UpdateDeviceCommand
    {
        public UpdateDeviceCommand(string id,
                                   string serialNumber,
                                   string model,
                                   DeviceType type,
                                   string firmwareVersion)
        {
            Id = id;
            SerialNumber = serialNumber;
            Model = model;
            Type = type;
            FirmwareVersion = firmwareVersion;
        }

        public string Id { get; }

        public string SerialNumber { get; }
        
        public string Model { get; }
        
        public DeviceType Type { get; }

        public string FirmwareVersion { get; }

    }
}
