using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(x => x.CustomerId).NotEmpty();
            RuleFor(x => x.CustomerId).NotNull();
            RuleFor(x => x.CarId).NotEmpty();
            RuleFor(x => x.CarId).NotNull();
            RuleFor(x => x.RentDate).GreaterThanOrEqualTo(DateTime.Today);
            RuleFor(x => x.RentDate).NotNull();
            RuleFor(x => x.RentDate).NotEmpty();
            RuleFor(x => x.ReturnDate).GreaterThanOrEqualTo(DateTime.Today);
        }
    }
}
