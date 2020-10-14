using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkigWithMethods
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(p => p.Firstname).NotEmpty().WithMessage(" Adı bos olamaz ");
            RuleFor(p => p.LastName).NotEmpty().WithMessage(" Soyadı bos olamaz ");
            RuleFor(p => p.IdentityNumber).NotEmpty().WithMessage(" T.C kimlik numara bos olamaz   ");
        }
    }
}
