using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs.DeviceResponses;

namespace TrialsSystem.UsersService.Api.Application.Queries.DeviceManagementQueries
{
    public class DevicesQuery : IRequest<IEnumerable<GetDeviceResponse>>
    {
        public DevicesQuery(int? take,
                            int? skip)
        {
            Take = take;
            Skip = skip;
        }

        public int? Take { get; }

        public int? Skip { get; }

    }
}
