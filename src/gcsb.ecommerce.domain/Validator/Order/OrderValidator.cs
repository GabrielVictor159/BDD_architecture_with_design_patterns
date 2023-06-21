using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace gcsb.ecommerce.domain.Validator.Order
{
    public class OrderValidator : AbstractValidator<domain.Order.Order>
    {
        public OrderValidator()
        {
        RuleFor(order => order.Id)
            .NotEqual(Guid.Empty)
            .WithMessage("The Id field is required.");
        RuleFor(order => order.TotalOrder)
            .GreaterThan(0)
            .WithMessage("The TotalOrder field must be greater than zero.");
        RuleFor(order => order.OrderDate)
            .LessThanOrEqualTo(DateTime.UtcNow)
            .WithMessage("The OrderDate field must be a date earlier than the current date.");
        }
    }
}