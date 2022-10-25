using TrialsSystem.UsersService.Domain.AggregatesModel.Base;

namespace TrialsSystem.UsersService.Domain.AggregatesModel.UserAggregate
{
    public class City : Entity
    {
        public City(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
