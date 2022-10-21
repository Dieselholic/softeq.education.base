using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs.DeviceRequests;

namespace TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs.DeviceResponses
{
    public class CreateDeviceResponse : CreateDeviceRequest
    {
        public string Id { get; set; }
    }
}