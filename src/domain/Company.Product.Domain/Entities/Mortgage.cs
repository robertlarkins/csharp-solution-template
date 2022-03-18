using Company.Product.Domain.Enumerations;
using CSharpFunctionalExtensions;

namespace Company.Product.Domain.Entities
{
    /// <summary>
    /// Mortgage entity.
    /// </summary>
    public class Mortgage : Entity<int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mortgage"/> class.
        /// </summary>
        /// <param name="bank">The bank.</param>
        /// <param name="entity">The entity.</param>
        /// <param name="principal">The principal mortgage amount.</param>
        public Mortgage(Bank bank, Entity entity, decimal principal)
        {
            Bank = bank;
            Entity = entity;
            Principal = principal;
        }

        /// <summary>
        /// Gets the bank that this mortgage is with.
        /// </summary>
        public Bank Bank { get; }

        /// <summary>
        /// Gets the entity that this mortgage is linked to.
        /// </summary>
        public Entity Entity { get; }

        /// <summary>
        /// Gets the principal mortgage amount.
        /// </summary>
        public decimal Principal { get; }
    }
}
