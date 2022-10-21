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

        public string Id { get; private set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public decimal? Weight { get; set; }

        public decimal? Height { get; set; }

        public string CityId { get; set; }

        public string GenderId { get; }

    }
}
