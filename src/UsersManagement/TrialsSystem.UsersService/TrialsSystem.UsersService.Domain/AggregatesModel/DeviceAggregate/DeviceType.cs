namespace TrialsSystem.UsersService.Domain.AggregatesModel.DeviceAggregate
{
    public class DeviceType
    {
        public DeviceType(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}
