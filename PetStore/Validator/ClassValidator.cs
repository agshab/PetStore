using FluentValidation;
using PetStore.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Validators
{
    public class ClassValidator<T> : AbstractValidator<T> where T : Product
    {
        public ClassValidator()
        {
            RuleFor(product => product.Name).NotEmpty();
            RuleFor(product => product.Price).GreaterThan(0);
            RuleFor(product => product.Quantity).GreaterThan(0);
            RuleFor(product => product.Description).MinimumLength(10).When(product => !string.IsNullOrEmpty(product.Description));
        }
    }
}