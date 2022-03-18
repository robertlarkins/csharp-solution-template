using CSharpFunctionalExtensions;

namespace Company.Product.Domain.Enumerations
{
    /// <summary>
    /// Enumeration for banks.
    /// </summary>
    public class Bank : EnumValueObject<Bank, int>
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable SA1600 // Elements should be documented
        public static readonly Bank Asb = new(1, "ASB");

        public static readonly Bank Anz = new(2, "ANZ");

        public static readonly Bank Tsb = new(3, "TSB");
#pragma warning restore SA1600 // Elements should be documented
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

        private Bank(int id, string bankName)
            : base(id, bankName)
        {
        }
    }
}
