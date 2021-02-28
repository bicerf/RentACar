using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ImageValidator:AbstractValidator<ImagesCar>
    {
        public ImageValidator()
        {
            RuleFor(i => i.CarId).NotNull();

            RuleFor(i => i.Id).NotNull();
        }
    }
}
