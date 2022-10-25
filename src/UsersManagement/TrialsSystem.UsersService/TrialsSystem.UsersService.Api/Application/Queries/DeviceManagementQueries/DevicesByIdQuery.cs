using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs.DeviceResponses;

namespace TrialsSystem.UsersService.Api.Application.Queries.DeviceManagementQueries
{
    public class DeviceByIdQuery : IRequest<IEnumerable<GetDeviceResponse>>
    {
        public DeviceByIdQuery(string deviceId,
                               string id)
        {
            DeviceId = deviceId;
            Id = id;
        }

        public string DeviceId { get; }

        public string Id { get; }

    }
}
