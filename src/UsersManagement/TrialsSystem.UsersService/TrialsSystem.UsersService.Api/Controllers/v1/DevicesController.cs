using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrialsSystem.UsersService.Api.Application.Commands.DeviceManagementCommands;
using TrialsSystem.UsersService.Api.Application.Queries.DeviceManagementQueries;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs.DeviceRequests;
using TrialsSystem.UsersService.Infrastructure.Models.DeviceDTOs.DeviceResponses;

namespace TrialsSystem.UsersService.Api.Controllers.v1
{
    /// <summary>
    /// Device management controller
    /// </summary>
    [Route("api/v1/{deviceId}/[controller]")]
    public class DevicesController : Controller
    {
        private readonly IMediator _mediator;

        public DevicesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all devices by setting parameters and filters
        /// </summary>
        /// <param name="userId">authorized user Id</param>
        /// <param name="skip">skip items (pagination parameters)</param>
        /// <param name="take">take items (pagination parameters)</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetDeviceResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromQuery] int? skip = 0,
            [FromQuery] int? take = null)
        {
            var response = await _mediator.Send(new DevicesQuery(take, skip));
            return Ok(response);
        }

        /// <summary>
        /// Get device by it's id
        /// </summary>
        /// <param name="deviceId">device id</param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetDeviceResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAsync(
            [FromRoute] string deviceId,
            [FromRoute] string id)
        {
            var response = await _mediator.Send(new DeviceByIdQuery(deviceId, id));
            return Ok(response);
        }

        /// <summary>
        /// Post new device
        /// </summary>
        /// <param name="request">Create device request</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(CreateDeviceResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostAsync(CreateDeviceRequest request)
        {
            var response = await _mediator.Send(new CreateDeviceCommand(request.SerialNumber,
                                                                        request.Model,
                                                                        request.Type,
                                                                        request.FirmwareVersion));
            return Ok(response);

        }

        /// <summary>
        /// Update device bu it's id
        /// </summary>
        /// <param name="id">Device id</param>
        /// <param name="request">Update device request</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(UpdateDeviceResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutAsync(string id, UpdateDeviceRequest request)
        {
            var response = await _mediator.Send(new UpdateDeviceCommand(id,
                                                                        request.SerialNumber,
                                                                        request.Model,
                                                                        request.Type,
                                                                        request.FirmwareVersion));
            return Ok(response);
        }

        /// <summary>
        /// Delete device by it's id
        /// </summary>
        /// <param name="id">Device id</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var response = await _mediator.Send(new DeleteDeviceCommand(id));
            return Ok(response);
        }
    }
}
