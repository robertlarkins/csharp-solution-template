using FluentValidation;

namespace Company.Product.Application.Mortgages.Commands.CreateMortgage
{
    /// <summary>
    /// Validate the create mortgage command values.
    /// </summary>
    public class CreateMortgageCommandValidator : AbstractValidator<CreateMortgageCommand>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMortgageCommandValidator"/> class.
        /// </summary>
        public CreateMortgageCommandValidator()
        {
            RuleFor(x => x.BankId).GreaterThan(0);
        }
    }
}
