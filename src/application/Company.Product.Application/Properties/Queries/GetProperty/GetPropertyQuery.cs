using MediatR;

namespace Company.Product.Application.Properties.Queries.GetProperty
{
    /// <summary>
    /// Example of get property.
    /// </summary>
    public class GetPropertyQuery : IRequest<GetPropertyResponse>
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public int Id { get; set; }
    }
}
