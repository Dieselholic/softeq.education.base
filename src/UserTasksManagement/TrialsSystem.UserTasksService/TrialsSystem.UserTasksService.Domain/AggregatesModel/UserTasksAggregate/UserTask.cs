using System.ComponentModel.DataAnnotations;
using TrialsSystem.UserTasksService.Domain.AggregatesModel.Base;

namespace TrialsSystem.UserTasksService.Domain.AggregatesModel.UserTasksAggregate
{
    public class UserTask : Entity
    {
        public UserTask(string name,
                        string status,
                        DateTime createdDateTime,
                        DateTime lastUpdatedDateTime,
                        Dictionary<string, string> additionalProperties)
        {
            Id = Guid.NewGuid();
            Name = name;
            Status = status;
            CreatedDateTime = createdDateTime;
            LastUpdatedDateTime = lastUpdatedDateTime;
            AdditionalProperties = additionalProperties;
        }

        [Key]
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Status { get; private set; }

        public DateTime CreatedDateTime { get; private set; }

        public DateTime LastUpdatedDateTime { get; private set; }

        public Dictionary<string, string> AdditionalProperties { get; private set; }

    }
}
