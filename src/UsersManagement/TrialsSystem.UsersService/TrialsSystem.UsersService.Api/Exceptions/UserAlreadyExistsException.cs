namespace TrialsSystem.UsersService.Api.Exceptions
{
    /// <summary>
    /// InvalidOperationException
    /// </summary>
    public class UserAlreadyExistsException : Exception
    {
        public string Email { get; }

        public UserAlreadyExistsException(string email)
        {
            Email = email;
        }
    }
}
