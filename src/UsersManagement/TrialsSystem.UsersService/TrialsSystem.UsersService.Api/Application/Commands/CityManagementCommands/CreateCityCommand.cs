﻿using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.Responses;

namespace TrialsSystem.UsersService.Api.Application.Commands.CityManagementCommands
{
    public class CreateCityCommand : IRequest<CreateCityResponse>
    {
        public CreateCityCommand(string name)
        {
            Name = name;
        }

        public string Name { get; }

    }
}
