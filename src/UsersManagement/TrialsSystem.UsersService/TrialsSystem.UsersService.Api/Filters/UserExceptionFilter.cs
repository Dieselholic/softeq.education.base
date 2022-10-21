using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using TrialsSystem.UsersService.Api.Exceptions;

namespace TrialsSystem.UsersService.Api.Filters
{
    public class UserExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<UserExceptionFilter> _logger;

        public UserExceptionFilter(ILogger<UserExceptionFilter> logger)
        {
            _logger = logger;
        }

        public void OnException(ExceptionContext context)
        {
            if (context.ExceptionHandled) return;

            switch (context.Exception)
            {
                case TrialUserNotFondException userNotFoundexception:
                    _logger.LogCritical("User with Id {id} not found", userNotFoundexception.Id);
                    SetContextResult(context, new BadRequestResult());
                    break;
                case UserAlreadyExistsException userAlreadyExistsException:
                    _logger.LogCritical("User with Email {email} already exists", userAlreadyExistsException.Email);
                    SetContextResult(context, new BadRequestResult());
                    break;
                default:
                    _logger.LogCritical("System error occurred. Message: {message}. Inner exception: {innerException}. Stack trace: {stackTrace}",
                        context.Exception.Message,
                        context.Exception.InnerException?.Message,
                        context.Exception.StackTrace);
                    SetContextResult(context, new StatusCodeResult(StatusCodes.Status500InternalServerError));
                    break;
            }
        }

        private void SetContextResult(ExceptionContext context, IActionResult result)
        {
            context.Result = result;
            context.ExceptionHandled = true;
        }
    }
}
