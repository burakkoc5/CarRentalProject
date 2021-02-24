﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.ModelYear).GreaterThan(0);
            RuleFor(c => c.ModelYear).LessThanOrEqualTo(DateTime.Now.Year);
            RuleFor(c => c.Description).MinimumLength(5);

        }


    }
}
