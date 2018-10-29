using EntityLib;

namespace Entity.NET.Models
{
    [Entity(typeof(int))]
    public sealed class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
