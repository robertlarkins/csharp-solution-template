using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Company.Product.Api.Controllers
{
    /// <summary>
    /// BaseController used for mediator.
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public abstract class BaseController : ControllerBase
    {
        private IMediator? mediator;

        /// <summary>
        /// Gets the Mediator object.
        /// </summary>
        protected IMediator Mediator =>
            mediator ??= HttpContext.RequestServices.GetService<IMediator>()!;
    }
}
