using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityLib
{
    /// <summary>
    /// A generic repository.
    /// </summary>
    /// <remarks>
    /// A simple implementation designed for a rough repository.
    /// </remarks>
    /// <typeparam name="TKey">The key</typeparam>
    /// <typeparam name="TEntity">The value type</typeparam>
    public abstract class Repository<TKey, TEntity>
    {
        private Dictionary<TKey, TEntity> _underlying;
        private IKeyGenerator<TKey> _generator;

        public Repository(IKeyGenerator<TKey> generator)
        {
            _generator = generator;
            _underlying = new Dictionary<TKey, TEntity>();
        }

        public Entity<TKey, TEntity> Find(TKey key)
        {
            if (_underlying.TryGetValue(key, out TEntity value))
            {
                return new Entity<TKey, TEntity>(key, value);
            }
            return default(Entity<TKey, TEntity>);
        }

        public Entity<TKey, TEntity> Add(TEntity value)
        {
            TKey key = _generator.Generate();
            _underlying.Add(key, value);
            return new Entity<TKey, TEntity>(key, value);
        }


        public Entity<TKey, TEntity> Update(TKey key, TEntity value)
        {
            _underlying[key] = value;
            return new Entity<TKey, TEntity>(key, value);
        }
    }
}
