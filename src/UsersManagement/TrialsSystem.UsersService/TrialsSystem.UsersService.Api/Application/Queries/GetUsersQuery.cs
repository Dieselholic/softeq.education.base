﻿using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Queries
{
    public class GetUsersQuery : IRequest<IEnumerable<GetUsersResponse>>
    {
        public int? Take { get; }

        public int? Skip { get; }

        public string? Email { get; }

        public GetUsersQuery(int? take, int? skip, string email)
        {
            Take = take;
            Skip = skip;
            Email = email;
        }
    }
}
