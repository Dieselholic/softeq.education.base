namespace TrialsSystem.UsersService.Domain.AggregatesModel.UserAggregate
{
    public class Gender
    {
        public Gender(string id,
                      string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
    }
}
