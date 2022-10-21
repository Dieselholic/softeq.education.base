using MediatR;
using Microsoft.AspNetCore.Mvc;
using TrialsSystem.UsersService.Api.Application.Commands.CityManagementCommands;
using TrialsSystem.UsersService.Api.Application.Queries.CityManagementQueries;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityRequests;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.CityResponses;

namespace TrialsSystem.UsersService.Api.Controllers.v1
{
    /// <summary>
    /// City management controller
    /// </summary>
    [Route("api/v1/{cityId}/[controller]")]
    public class CitiesController : Controller
    {
        private readonly IMediator _mediator;

        public CitiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all cities by setting parameters and filters
        /// </summary>
        /// <param name="userId">authorized user Id</param>
        /// <param name="skip">skip items (pagination parameters)</param>
        /// <param name="take">take items (pagination parameters)</param>
        /// <param name="email">part of email (filter)</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetCityResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromQuery] int? skip = 0,
            [FromQuery] int? take = null,
            [FromQuery] string? name = null)
        {
            var response = await _mediator.Send(new CitiesQuery(take, skip, name));
            return Ok(response);
        }

        /// <summary>
        /// Get city by it's id
        /// </summary>
        /// <param name="cityId">city id</param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetCityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAsync(
            [FromRoute] string cityId,
            [FromRoute] string id)
        {
            var response = await _mediator.Send(new CityByIdQuery(cityId, id));
            return Ok(response);
        }

        /// <summary>
        /// Post new city
        /// </summary>
        /// <param name="request">Create city request</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(CreateCityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostAsync(CreateCityRequest request)
        {
            var response = await _mediator.Send(new CreateCityCommand(request.Name));
            return Ok(response);

        }

        /// <summary>
        /// Update city bu it's id
        /// </summary>
        /// <param name="id">City id</param>
        /// <param name="request">Update city request</param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(UpdateCityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutAsync(string id, UpdateCityRequest request)
        {
            var response = await _mediator.Send(new UpdateCityCommand(id, request.Name));
            return Ok(response);
        }

        /// <summary>
        /// Delete city by it's id
        /// </summary>
        /// <param name="id">City id</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var response = await _mediator.Send(new DeleteCityCommand(id));
            return Ok(response);
        }
    }
}
