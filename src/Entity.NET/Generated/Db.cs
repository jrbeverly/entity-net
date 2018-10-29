using EntityLib;

namespace Entity.NET.Generated
{
    public static class Db
    {
        public sealed class Customer : Entity<Keys.Customer, Models.Customer>
        {
            public Customer(Keys.Customer key, Models.Customer value) : base(key, value)
            {

            }
        }
    }
}
