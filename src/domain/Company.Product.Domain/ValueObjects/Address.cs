using System.Collections.Generic;
using CSharpFunctionalExtensions;

namespace Company.Product.Domain.ValueObjects
{
    /// <summary>
    /// The Address ValueObject.
    /// </summary>
    public class Address : ValueObject
    {
        private Address(
            string streetAddress,
            string suburb,
            string city,
            string postCode)
        {
            StreetAddress = streetAddress;
            Suburb = suburb;
            City = city;
            PostCode = postCode;
        }

        /// <summary>
        /// Gets the street address.
        /// </summary>
        public string StreetAddress { get; }

        /// <summary>
        /// Gets the suburb.
        /// </summary>
        public string Suburb { get; }

        /// <summary>
        /// Gets the city.
        /// </summary>
        public string City { get; }

        /// <summary>
        /// Gets the post code.
        /// </summary>
        public string PostCode { get; }

        /// <summary>
        /// Creates the specified street address.
        /// </summary>
        /// <param name="streetAddress">The street address.</param>
        /// <param name="suburb">The suburb.</param>
        /// <param name="city">The city.</param>
        /// <param name="postCode">The post code.</param>
        /// <returns>The result of the Address creation.</returns>
        public static Result<Address> Create(
            string streetAddress,
            string suburb,
            string city,
            string postCode)
        {
            return new Address(streetAddress, suburb, city, postCode);
        }

        /// <summary>
        /// Gets the equality components.
        /// </summary>
        /// <returns>The components to determine Address equality.</returns>
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return StreetAddress;
            yield return Suburb;
            yield return City;
            yield return PostCode;
        }
    }
}
