namespace Entity.NET.Model {

    public sealed class ModelId : 
        IEquatable<ModelId>, 
        IComparable<ModelId> 
    {
        // Alias Option needed:
        // Entity<TValue> : Entity<ModelId, TValue>
        //  'var' works in most cases
        // but what about params?
        // Customer.Entity where Entity IEntity<ModelId, Value>
        // IEntity<TKey, TValue>

        // Object key: Guid / Int / Long / Byte[]
        private readonly IEntityObjectKey _key;

        internal ModelId(IEntityObjectKey key) {
            _key = key;
        }

        // Equals
        // GetHashCode
        // ToString

        // IEqualityComparer
        // IEquatable
        // IComparable
        // At Clone Mechanism
        // Equality Operators
        // Operators for Ordering (if necessary)
    }

    public interface IEntityKey<TType> : 
        IEquatable<TType> {

        byte[] ToByteArray();
        
    }

    public interface IOrderableEntityKey<TType> : 
        IEntityKey<TType> {
    }

    public interface IEntity<TKey, TValue> {

        TKey Key { get; }
        TValue Value { get; }

    }

    public sealed class CustomerDto : IEntity<CustomerId, Customer>
    {
        public CustomerId Key { get; }
        public Customer Value { get; }
        // Has Key
        // Has Value
    }

    public sealed class Entity<TKey, TValue> : IEntity<TKey, TValue> {

        public Entity(TKey key, TValue value) {
            Key = key;
            Value = value;
        }

        public TValue Value { get; }
        public TKey Key { get; }

        //GetHashCode
        //IEquality
        //Other important elements
    }
}