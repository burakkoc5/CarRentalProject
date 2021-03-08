using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator : AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            //throw new Exception("Benim hatam");
            //Buraya kadar çalışıyor
            RuleFor(p => p.BrandName).NotEmpty();
            RuleFor(p => p.BrandName).MinimumLength(2).WithMessage("Marka adı en az 2 karakter olmalıdır.");

            
        }



    }
}
