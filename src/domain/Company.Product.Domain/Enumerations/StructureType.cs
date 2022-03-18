using CSharpFunctionalExtensions;

namespace Company.Product.Domain.Enumerations
{
    /// <summary>
    /// Represents the type of structure.
    /// </summary>
    public class StructureType : EnumValueObject<StructureType, int>
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1600 // Elements should be documented
        public static readonly StructureType LookThroughCompany = new(1, "Look Through Company");

        public static readonly StructureType Trust = new(2, "Trust");

        public static readonly StructureType CloseCompany = new(3, "Close Company");

        public static readonly StructureType Private = new(4, "Private");
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        private StructureType(int id, string structureName)
            : base(id, structureName)
        {
        }
    }
}
