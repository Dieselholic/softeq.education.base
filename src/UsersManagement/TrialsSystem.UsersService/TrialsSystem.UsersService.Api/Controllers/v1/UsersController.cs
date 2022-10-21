using Microsoft.AspNetCore.Mvc;
using MediatR;
using TrialsSystem.UsersService.Api.Filters;
using TrialsSystem.UsersService.Api.Application.Queries.UserManagementQueries;
using TrialsSystem.UsersService.Api.Application.Commands.UserManagementCommands;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs.UserRequests;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs.UserResponses;

namespace TrialsSystem.UsersService.Api.Controllers.v1
{
    /// <summary>
    /// User management controller
    /// </summary>
    [Route("api/v1/{userId}/[controller]")]
    [ServiceFilter(typeof(UserExceptionFilter))]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Get all users by setting parameters and filters
        /// </summary>
        /// <param name="userId">authorized user Id</param>
        /// <param name="skip">skip items (pagination parameters)</param>
        /// <param name="take">take items (pagination parameters)</param>
        /// <param name="email">part of email (filter)</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<GetUserResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromQuery] int? skip = 0,
            [FromQuery] int? take = null,
            [FromQuery] string? email = null)
        {
            var response = await _mediator.Send(new GetUsersQuery(take, skip, email));
            return Ok(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetUserResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAsync(
            [FromRoute] string userId,
            [FromRoute] string id)
        {
            var response = await _mediator.Send(new GetUserByIdQuery(userId, id));
            return Ok(response);
        }


        [HttpPost]
        [ProducesResponseType(typeof(CreateUserResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostAsync(CreateUserRequest request)
        {

            var response = await _mediator.Send(new CreateUserCommand(request.Email,
                                                                      request.Name,
                                                                      request.Surname,
                                                                      request.CityId,
                                                                      request.BirthDate,
                                                                      request.Weight,
                                                                      request.Height,
                                                                      request.GenderId));
            return Ok(response);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(UpdateUserResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PutAsync(string id, UpdateUserRequest request)
        {
            var response = await _mediator.Send(new UpdateUserCommand(id,
                                                                      request.Name,
                                                                      request.Surname,
                                                                      request.CityId,
                                                                      request.BirthDate,
                                                                      request.Weight,
                                                                      request.Height,
                                                                      request.GenderId));
            return Ok(response);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteAsync(string Id)
        {
            var response = await _mediator.Send(new DeleteUserCommand(Id));
            return Ok(response);
        }
    }
}
