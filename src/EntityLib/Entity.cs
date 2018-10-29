namespace EntityLib
{
    public class Entity<TKey, TEntity>
    {
        public Entity(TKey key, TEntity value)
        {
            Key = key;
            Element = value;
        }

        public TKey Key { get; private set; }
        public TEntity Element { get; private set; }

        public static implicit operator TEntity(Entity<TKey, TEntity> entity)
        {
            return entity.Element;
        }
    }
}
