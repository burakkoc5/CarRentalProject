using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {

        public UserValidator()
        {

            RuleFor(u => u.FirstName)
            .NotEmpty()
            .WithMessage("FirstName is required.")
            .MinimumLength(1)
            .WithMessage("FirstName must be longer than 1 character.");

            RuleFor(u => u.LastName)
            .NotEmpty()
            .WithMessage("LastName is required.")
            .MinimumLength(1)
            .WithMessage("LastName must be longer than 1 character.");

            RuleFor(u => u.Email)
            .NotEmpty()
            .WithMessage("Email address is required.")
            .EmailAddress()
            .WithMessage("A valid email address is required.");
        }
    }
}
