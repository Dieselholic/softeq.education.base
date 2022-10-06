﻿using FluentValidation;
using System.Text.RegularExpressions;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs.UserRequests;

namespace TrialsSystem.UsersService.Api.Application.Validation.UserManagementValidators
{
    public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        const string emailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

        public CreateUserRequestValidator()
        {
            RuleFor(u => u)
                .Must(u => new Regex(emailRegex).Match(u.Email).Success).WithMessage("Participant's email should be valid.")
                .Must(u => u.BirthDate < DateTime.Now.AddYears(-18)).WithMessage("The participant should be older than 18 years.")
                .Must(u => !string.IsNullOrEmpty(u.Name)).WithMessage("Participant's name should not be empty.")
                .Must(u => !string.IsNullOrEmpty(u.Surname)).WithMessage("Participant's surname should not be empty.")
                .Must(u => !string.Equals(u.Name, u.Surname)).WithMessage("Participant's name and surname should not be equals.");
        }
    }
}
