namespace csharphashset
{
    public class Address : IEquatable<Address>
    {
        public readonly string? Unit;
        public readonly string Street;
        public readonly string State;
        public readonly string PostalCode;
        public Address(string street, string state, string postalCode, string? unit = null)
        {
            Street = street;
            State = state;
            PostalCode = postalCode;
            Unit = unit;
        }

        public override string ToString()
        {
            return $"Unit: {Unit}, Street: {Street}, State: {State}, PostalCode: {PostalCode}";
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Address);
        }

        public bool Equals(Address? other)
        {
            return other is not null &&
                   Unit == other.Unit &&
                   Street == other.Street &&
                   State == other.State &&
                   PostalCode == other.PostalCode;
        }

        public static bool operator ==(Address left, Address right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Address left, Address right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            int hash = Unit?.GetHashCode() ?? 0;
            hash ^= Street.GetHashCode();
            hash ^= State.GetHashCode();
            hash ^= PostalCode.GetHashCode();
            return hash;
        }
    }
}