using System.Threading;
using System.Threading.Tasks;
using Company.Product.Domain.Enumerations;
using MediatR;

namespace Company.Product.Application.Mortgages.Commands.CreateMortgage
{
    /// <summary>
    /// Handler for creating a mortgage.
    /// </summary>
    public class CreateMortgageCommandHandler : IRequestHandler<CreateMortgageCommand, CreateMortgageResponse>
    {
        /// <summary>
        /// Handles the specified command.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>The response of the created mortgage.</returns>
        public Task<CreateMortgageResponse> Handle(
            CreateMortgageCommand command,
            CancellationToken cancellationToken)
        {
            // Get the entity by its Id.
            var bank = Bank.FromId(command.BankId).GetValueOrDefault();

            if (bank is null)
            {
                // log the error
                // return an exception
            }

            var response = new CreateMortgageResponse
            {
                Id = 5
            };

            return Task.FromResult(response);
        }
    }
}
