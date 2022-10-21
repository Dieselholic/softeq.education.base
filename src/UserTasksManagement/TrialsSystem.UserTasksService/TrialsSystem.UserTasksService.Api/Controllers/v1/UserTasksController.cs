using Microsoft.AspNetCore.Mvc;
using MediatR;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserRequests;
using TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserResponses;
using TrialsSystem.UserTasksService.Api.Application.Queries.UserTaskManagementQueries;
using TrialsSystem.UserTasksService.Api.Application.Commands.UserTaskManagementCommands;

namespace TrialsSystem.UserTasksService.Api.Controllers.v1
{
    /// <summary>
    /// User task management controller
    /// </summary>
    [Route("api/v1/{userId}/[controller]")]
    [ApiController]
    public class UserTasksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserTasksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all user tasks by setting parameters and filters
        /// </summary>
        /// <param name="userId">authorized user Id</param>
        /// <param name="skip">skip items (pagination parameters)</param>
        /// <param name="take">take items (pagination parameters)</param>
        /// <param name="name">part of name (filter)</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetUserTaskResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromQuery] int? skip = 0,
            [FromQuery] int? take = null,
            [FromQuery] string? name = null)
        {
            var response = await _mediator.Send(new GetUserTasksQuery(take, skip, name));
            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetUserTaskResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromRoute] string id)
        {
            var response = await _mediator.Send(new GetUserTaskByIdQuery(userId, id));
            return Ok(response);
        }


        [HttpPost]
        [ProducesResponseType(typeof(CreateUserTaskResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostAsync(CreateUserTaskRequest request)
        {
            var response = await _mediator.Send(new CreateUserTaskCommand(request.Name,
                                                                          request.Status,
                                                                          request.CreatedDateTime,
                                                                          request.LastUpdatedDateTime,
                                                                          request.AdditionalProperties));
            return Ok(response);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(UpdateUserTaskResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutAsync(string id, UpdateUserTaskRequest request)
        {
            var response = await _mediator.Send(new UpdateUserTaskCommand(id,
                                                                          request.Status,
                                                                          request.AdditionalProperties));
            return Ok(response);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAsync(string Id)
        {
            var response = await _mediator.Send(new DeleteUserTaskCommand(Id));
            return Ok(response);
        }
    }
}
