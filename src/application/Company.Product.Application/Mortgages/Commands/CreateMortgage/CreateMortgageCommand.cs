using MediatR;

namespace Company.Product.Application.Mortgages.Commands.CreateMortgage;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable SA1600 // Elements should be documented
public class CreateMortgageCommand : IRequest<CreateMortgageResponse>
{
    public int BankId { get; set; }

    public int EntityId { get; set; }

    public decimal PrincipalAmount { get; set; }

    public double InterestRate { get; set; }
}
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
