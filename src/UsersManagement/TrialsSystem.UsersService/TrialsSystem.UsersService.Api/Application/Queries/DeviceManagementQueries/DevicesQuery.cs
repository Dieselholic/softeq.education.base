using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs.DeviceResponses;

namespace TrialsSystem.UsersService.Api.Application.Queries.DeviceManagementQueries
{
    public class DevicesQuery : IRequest<IEnumerable<GetDeviceResponse>>
    {
        public int? Take { get; }

        public int? Skip { get; }

        public DevicesQuery(int? take, int? skip)
        {
            Take = take;
            Skip = skip;
        }
    }
}
