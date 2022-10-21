using MediatR;
using TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UsersService.Api.Application.Commands.DeviceManagementCommands
{
    public class CreateDeviceCommand : IRequest<CreateUserResponse>
    {
        public CreateDeviceCommand(string serialNumber,
                                   string model,
                                   DeviceType type,
                                   string firmwareVersion)
        {
            SerialNumber = serialNumber;
            Model = model;
            Type = type;
            FirmwareVersion = firmwareVersion;
        }

        public string SerialNumber { get; }

        public string Model { get; }

        public DeviceType Type { get; }

        public string FirmwareVersion { get; }

    }
}
