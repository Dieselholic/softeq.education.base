using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs.DeviceResponses;

namespace TrialsSystem.UsersService.Api.Application.Queries.DeviceManagementQueries
{
    public class DeviceByIdQuery : IRequest<IEnumerable<GetDeviceResponse>>
    {
        public string DeviceId { get; }

        public string Id { get; }

        public DeviceByIdQuery(string deviceId, string id)
        {
            DeviceId = deviceId;
            Id = id;
        }
    }
}
