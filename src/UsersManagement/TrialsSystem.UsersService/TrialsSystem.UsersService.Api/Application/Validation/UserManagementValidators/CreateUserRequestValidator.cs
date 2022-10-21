using FluentValidation;
using System.Text.RegularExpressions;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs.UserRequests;

namespace TrialsSystem.UsersService.Api.Application.Validation.UserManagementValidators
{
    public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        const string emailBaseRegex = @"^.+@.+(\.|:).+$";



        const string emailSpecialSymbolsRegex = @"[\._\-]{2,}";

        const string emailPartsValidSymbolsRegex = @"[^\w\-\.]+";

        const string emailPartsFirstLastSymbolsRegex = @"^[a-zA-Z0-9]+(.*[a-zA-Z0-9]+)*$";

        const string emailDomainPartsNotOnlyNumbersRegex = @"[a-zA-Z]+";

        public CreateUserRequestValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty()
                .WithMessage("Participant's name should not be empty.");

            RuleFor(u => u.Surname)
                .NotEmpty()
                .WithMessage("Participant's surname should not be empty.");

            RuleFor(u => u)
                .Must(u => !u.Name.Equals(u.Surname))
                .WithName("Name&Surname")
                .WithMessage("Participant's name and surname should not be equals.");

            RuleFor(u => u.BirthDate)
                .LessThanOrEqualTo(DateTime.Now.AddYears(-18))
                .WithMessage("The participant should be older than 18 years.");

            bool isDomainPartIPv = false;

            When(u =>
            {
                if (Regex.IsMatch(u.Email, emailBaseRegex))
                {
                    var emailDomainPart = u.Email.Substring(u.Email.IndexOf('@') + 1);

                    isDomainPartIPv = Uri.CheckHostName(emailDomainPart) == UriHostNameType.IPv4 || Uri.CheckHostName(emailDomainPart) == UriHostNameType.IPv6;

                    return Regex.IsMatch(emailDomainPart, @"[\w\-\.]+\.[\w\-\.]+") || isDomainPartIPv;
                }
                return false;
            }, () =>
            {
                RuleFor(u => u.Email)
                    .Length(5, 256).WithMessage("Email adress can't be less 5 and longer than 256 symbols.").WithName("Email")
                    .Must(ue => !Regex.IsMatch(ue, emailSpecialSymbolsRegex)).WithMessage("Email adress can't contain two or more special symbols in a row.").WithName("Email");

                RuleFor(u => u.Email.Substring(0, u.Email.IndexOf('@')))
                    .Must(uel => !Regex.IsMatch(uel, emailPartsValidSymbolsRegex)).WithMessage("Email adress can contains : latin letters (a-z, A-Z), numbers (0-9), special symbols('.', '-', '_').").WithName("Email")
                    .Must(uel => Regex.IsMatch(uel, emailPartsFirstLastSymbolsRegex)).WithMessage("Email adress local part fist/last symbol should be a latin letter (a-z) or a number (0-9).").WithName("Email")
                    .Length(1, 63).WithMessage("Email adress local part can't be less than 2 and longer than 63 symbols.").WithName("Email");

                When(u => isDomainPartIPv == false, () =>
                {
                    RuleFor(u => u.Email.Substring(u.Email.IndexOf('@') + 1))
                        .Must(u => false).WithMessage("{PropertyValue}")
                        .Must(ued => !Regex.IsMatch(ued, emailPartsValidSymbolsRegex)).WithMessage("Email adress can contains : latin letters (a-z, A-Z), numbers (0-9), special symbols('.', '-', '_').").WithName("Email")
                        .Length(3, 253).WithMessage("Email adress domain part can't be less than 3 and longer than 253 symbols.").WithName("Email");

                    RuleForEach(u => u.Email.Substring(u.Email.IndexOf('@') + 1).Split('.', StringSplitOptions.None).ToList())
                        .Must(uedp => Regex.IsMatch(uedp, emailPartsFirstLastSymbolsRegex)).WithMessage("Email adress domain parts fist/last symbol should be a latin letter (a-z) or a number (0-9).").WithName("Email")
                        .Must(uedp => Regex.IsMatch(uedp, emailDomainPartsNotOnlyNumbersRegex)).WithMessage("Email adress domains part must contains at least one lattin letter.").WithName("Email")
                        .Length(1, 63).WithMessage("Email adress domain part can't be less than 3 and longer than 63 symbols.").WithName("Email");
                });
            }).Otherwise(() => RuleFor(u => u.Email).Must(ue => false).WithMessage("Domain/Local part of email in invalid."));


        }
    }
}
