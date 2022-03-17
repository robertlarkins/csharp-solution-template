using FluentValidation;

namespace Company.Product.Application.Properties.Commands.CreateProperty
{
    /// <summary>
    /// Validator for creating a property.
    /// </summary>
    public class CreatePropertyCommandValidator : AbstractValidator<CreatePropertyCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePropertyCommandValidator"/> class.
        /// </summary>
        public CreatePropertyCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
