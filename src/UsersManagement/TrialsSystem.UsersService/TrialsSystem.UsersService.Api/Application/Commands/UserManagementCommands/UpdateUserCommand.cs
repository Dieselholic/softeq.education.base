namespace TrialsSystem.UsersService.Api.Application.Commands.UserManagementCommands
{
    public class UpdateUserCommand
    {
        public UpdateUserCommand(string id,
                                 string name,
                                 string surname,
                                 string cityId,
                                 DateTime birthDate,
                                 decimal? weight,
                                 decimal? height,
                                 string genderId)
        {
            Id = id;
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
            CityId = cityId;
            GenderId = genderId;
        }

        public string Id { get; }

        public string Name { get; }

        public string Surname { get; }

        public DateTime BirthDate { get; }

        public decimal? Weight { get; }

        public decimal? Height { get; }

        public string CityId { get; }

        public string GenderId { get; }

    }
}
