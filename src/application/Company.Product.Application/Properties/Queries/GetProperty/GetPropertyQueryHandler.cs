using System.Threading;
using System.Threading.Tasks;

namespace Company.Product.Application.Properties.Queries.GetProperty;

/// <summary>
/// Handler for getting a property.
/// </summary>
public class GetPropertyQueryHandler : IRequestHandler<GetPropertyQuery, GetPropertyResponse>
{
    /// <summary>
    /// Handles the specified request.
    /// </summary>
    /// <param name="request">The request.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>Blah.</returns>
    public Task<GetPropertyResponse> Handle(GetPropertyQuery request, CancellationToken cancellationToken)
    {
        var response = new GetPropertyResponse
        {
            Address = "123 Fake St."
        };

        return Task.FromResult(response);
    }
}
