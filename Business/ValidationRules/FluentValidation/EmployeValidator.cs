using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public  class EmployeValidator:AbstractValidator<Employee>
    {
        public EmployeValidator()
        {
            RuleFor(e => e.Age).GreaterThanOrEqualTo(18);
            RuleFor(e => e.Email).NotEmpty();
        }
    }
}
