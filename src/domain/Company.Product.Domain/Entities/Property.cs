using Company.Product.Domain.ValueObjects;

namespace Company.Product.Domain.Entities;

/// <summary>
/// Property entity.
/// </summary>
public class Property : Entity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Property"/> class.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="address">The address.</param>
    public Property(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    /// <summary>
    /// Gets the name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the address.
    /// </summary>
    public Address Address { get; }
}
