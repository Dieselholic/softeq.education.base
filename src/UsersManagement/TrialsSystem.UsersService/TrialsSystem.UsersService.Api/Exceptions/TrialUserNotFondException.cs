namespace TrialsSystem.UsersService.Api.Exceptions
{
    /// <summary>
    /// TrialUserNotFondException
    /// </summary>
    public class TrialUserNotFondException : Exception
    {
        public string Id { get; }

        public TrialUserNotFondException(string id)
        {
            Id = id;
        }
    }
}
