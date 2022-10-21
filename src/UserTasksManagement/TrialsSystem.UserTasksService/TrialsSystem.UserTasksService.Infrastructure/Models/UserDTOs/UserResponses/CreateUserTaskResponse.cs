using TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserRequests;

namespace TrialsSystem.UserTasksService.Infrastructure.Models.UserDTOs.UserResponses
{
    public class CreateUserTaskResponse : CreateUserTaskRequest
    {
        public string Id { get; set; }
    }
}