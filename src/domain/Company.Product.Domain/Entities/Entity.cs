using Company.Product.Domain.Enumerations;
using CSharpFunctionalExtensions;

namespace Company.Product.Domain.Entities;

/// <summary>
/// Represents an entity that owns property.
/// </summary>
public class Entity : Entity<int>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Entity"/> class.
    /// </summary>
    /// <param name="name">The entity's name.</param>
    /// <param name="structureType">The entity's structure type.</param>
    public Entity(string name, StructureType structureType)
    {
        Name = name;
        StructureType = structureType;
    }

    /// <summary>
    /// Gets the name.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Gets the entity's structure type.
    /// </summary>
    public StructureType StructureType { get; }
}
