using System.Threading.Tasks;
using Company.Product.Application.Properties.Commands.CreateProperty;
using Company.Product.Application.Properties.Queries.GetProperty;
using Microsoft.AspNetCore.Mvc;

namespace Company.Product.Api.Controllers;

/// <summary>
/// Controller for performing property related actions.
/// </summary>
[ApiController]
[Route("api/properties/")]
public class PropertyController : BaseController
{
    /// <summary>
    /// Creates the property.
    /// </summary>
    /// <param name="command">The command.</param>
    /// <returns>The response from creating this property.</returns>
    [HttpPost]
    public async Task<ActionResult<CreatePropertyResponse>> CreateProperty(
        [FromBody] CreatePropertyCommand command)
    {
        return await Mediator.Send(command);
    }

    /// <summary>
    /// Gets the property.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>The property related to the id.</returns>
    [HttpGet("{id}")]
    public async Task<ActionResult<GetPropertyResponse>> GetProperty([FromRoute]int id)
    {
        var query = new GetPropertyQuery
        {
            Id = id
        };

        var response = await Mediator.Send(query);

        return response;
    }
}
