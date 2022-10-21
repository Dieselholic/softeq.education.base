using TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate;

namespace TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs.DeviceRequests
{
    public class UpdateDeviceRequest
    {
        public string SerialNumber { get; set; }
        
        public string Model { get; set; }
        
        public DeviceType Type { get; set; }

        public string FirmwareVersion { get; set; }
    }
}
