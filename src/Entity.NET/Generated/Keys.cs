using System;
using EntityLib;

namespace Entity.NET.Generated
{
    public static class Keys
    {
        public sealed class Customer : EntityKey<int>
        {
            public Customer(int key) : base(key)
            {
            }

            public static explicit operator Customer(int v)
            {
                return new Customer(v);
            }
        }
    }
}
