using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {

        public ColorValidator()
        {

            RuleFor(c => c.ColorName)
            .NotEmpty()
            .WithMessage("ColorName is required.")
            .MinimumLength(1)
            .WithMessage("ColorName must be longer than 1 character.");

        }
    }
}
