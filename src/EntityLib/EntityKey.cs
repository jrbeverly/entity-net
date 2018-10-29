namespace EntityLib
{
    public abstract class EntityKey<TType>
    {
        public TType Key { get; private set; }

        public EntityKey(TType value)
        {
            Key = value;
        }
    }
}
