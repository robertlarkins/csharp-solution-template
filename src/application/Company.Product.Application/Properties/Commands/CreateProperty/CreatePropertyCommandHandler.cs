using System.Threading;
using System.Threading.Tasks;
using Company.Product.Domain.Entities;
using Company.Product.Domain.ValueObjects;

namespace Company.Product.Application.Properties.Commands.CreateProperty;

/// <summary>
/// Handler for getting a property.
/// </summary>
public class CreatePropertyCommandHandler : IRequestHandler<CreatePropertyCommand, CreatePropertyResponse>
{
    /// <summary>
    /// Handles the specified command.
    /// </summary>
    /// <param name="command">The command.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>Response from creating a property.</returns>
    public Task<CreatePropertyResponse> Handle(
        CreatePropertyCommand command,
        CancellationToken cancellationToken)
    {
        var addressDto = command.Address;
        var addressResult = Address.Create(
            addressDto.StreetAddress,
            addressDto.Suburb,
            addressDto.City,
            addressDto.PostCode);

        if (addressResult.IsFailure)
        {
            // log issue and return error message.
        }

        var property = new Property(command.Name, addressResult.Value);

        // add property to the database and get its new Id.
        var propertyResponse = new CreatePropertyResponse
        {
            Id = 123
        };

        return Task.FromResult(propertyResponse);
    }
}
