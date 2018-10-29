using System;

namespace EntityLib
{
    public sealed class CountKeyGenerator<TKey> : IKeyGenerator<TKey>
    {
        private int _count;
        private Func<int, TKey> _transform;

        public CountKeyGenerator(Func<int, TKey> transform, int start = 0)
        {
            _count = start;
            _transform = transform;
        }

        public TKey Generate()
        {
            _count++;
            return _transform(_count);
        }
    }
}
