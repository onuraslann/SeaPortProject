using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public  class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Price).GreaterThanOrEqualTo(1);
            RuleFor(p => p.ProductName).NotEmpty();
        }
    }
}
