using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs.UserRequests;

namespace TrialsSystem.UsersService.Infrastructure.Models.UserDTOs.UserResponses;

public class CreateUserResponse : CreateUserRequest
{
    public string Id { get; set; }
}