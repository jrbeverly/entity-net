using EntityLib;

namespace Entity.NET.Generated
{
    public static class Repository
    {
        public sealed class Customer : Repository<Keys.Customer, Models.Customer>
        {
            public Customer() : base(new CountKeyGenerator<Keys.Customer>((k) => (Keys.Customer)k))
            {
            }
        }
    }
}
