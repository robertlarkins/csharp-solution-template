using System.Threading.Tasks;
using Company.Product.Application.Mortgages.Commands.CreateMortgage;
using Microsoft.AspNetCore.Mvc;

namespace Company.Product.Api.Controllers;

/// <summary>
/// Controller for performing mortgage related actions.
/// </summary>
[ApiController]
[Route("api/mortgages")]
public class MortgageController : BaseController
{
    /// <summary>
    /// Creates the mortgage.
    /// </summary>
    /// <param name="command">The command.</param>
    /// <returns>The response from creating this mortgage.</returns>
    [HttpPost]
    public async Task<ActionResult<CreateMortgageResponse>> CreateMortgage(
        [FromBody] CreateMortgageCommand command)
    {
        return await Mediator.Send(command);
    }
}
