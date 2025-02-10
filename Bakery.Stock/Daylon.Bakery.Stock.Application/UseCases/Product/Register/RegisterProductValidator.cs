using Daylon.Bakery.Stock.Communication.Requests;
using FluentValidation;

namespace Daylon.Bakery.Stock.Application.UseCases.Product.Register
{
    public class RegisterProductValidator : AbstractValidator<RequestRegisterProductJson>
    {
        public RegisterProductValidator()
        {
            RuleFor(name => name.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(150).WithMessage("Name must be less than 150 characters");

            RuleFor(description => description.Description)
                .NotEmpty().WithMessage("Description is required")
                .MaximumLength(1000).WithMessage("Name must be less than 1000 characters");

            RuleFor(category => category.Category)
                .NotEmpty().WithMessage("Category is required")
                .IsInEnum().WithMessage("Category is invalid");

            RuleFor(price => price.Price)
                .NotEmpty().WithMessage("Price is required")
                .GreaterThan(0).WithMessage("Price must be greater than 0");

            RuleFor(quantity => quantity.Quantity)
                .NotEmpty().WithMessage("Quantity is required");

        }
    }
}
