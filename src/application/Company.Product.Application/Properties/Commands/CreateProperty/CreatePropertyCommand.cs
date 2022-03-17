using MediatR;

namespace Company.Product.Application.Properties.Commands.CreateProperty
{
    /// <summary>
    /// Create property command example.
    /// </summary>
    public class CreatePropertyCommand : IRequest<CreatePropertyResponse>
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable SA1600 // Elements should be documented
        public string Name { get; set; }

        public AddressDto Address { get; set; }

        public class AddressDto
        {
            public string StreetAddress { get; set; }

            public string Suburb { get; set; }

            public string City { get; set; }

            public string PostCode { get; set; }
        }
    }
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
