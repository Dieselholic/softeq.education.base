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

        public string Id { get; private set; }

        public string SerialNumber { get; set; }
        
        public string Model { get; set; }
        
        public DeviceType Type { get; set; }

        public string FirmwareVersion { get; set; }

    }
}
