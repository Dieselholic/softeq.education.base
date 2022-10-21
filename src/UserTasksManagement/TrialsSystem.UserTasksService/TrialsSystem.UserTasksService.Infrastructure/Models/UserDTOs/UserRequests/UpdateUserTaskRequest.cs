namespace TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserRequests
{
    public class UpdateUserTaskRequest
    {
        public string Status { get; set; }

        public Dictionary<string, string> AdditionalProperties { get; set; }
    }
}
