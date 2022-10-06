﻿using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.CityDTOs.Responses;

namespace TrialsSystem.UsersService.Api.Application.Queries.CityManagementQueries
{
    public class CitiesQuery : IRequest<IEnumerable<GetCityResponse>>
    {
        public int? Take { get; }

        public int? Skip { get; }

        public string? Name { get; }

        public CitiesQuery(int? take, int? skip, string name)
        {
            Take = take;
            Skip = skip;
            Name = name;
        }
    }
}
