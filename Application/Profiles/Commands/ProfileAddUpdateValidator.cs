using Domain.Entities;
using FluentValidation;
using Application.Common.Validators;
namespace Application.Profiles.Commands
{
    public class ProfileAddUpdateValidator : AbstractValidator<Profile>
    {
        public ProfileAddUpdateValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.EmailAddress).EmailAddress();

            RuleFor(p => p.DOB).Must(Validators.IsLegalAge);
        }
    }
}