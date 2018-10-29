using System;

public class Program
{
	public static void Main()
	{
		var cust = new Models.Customer()
		{Name = "John Smith"};
		Console.WriteLine("Hello World");
	}
}

public interface IEntity<TKey, TEntity>
{
	TKey Key
	{
		get;
	}

	TEntity Element
	{
		get;
	}
}

public interface IEntityKey<TType>
{
	TType Key
	{
		get;
	}
}

public static class Keys
{
	public interface ICustomer : IEntityKey<int>
	{
	}
}

public static class Entity
{
	public interface ICustomer : IEntity<Keys.ICustomer, Models.Customer>
	{
	}
}

public static class Db
{
	public sealed class Customer : Entity.ICustomer
	{
		public Keys.ICustomer Key
		{
			get;
			private set;
		}

		public Models.Customer Element
		{
			get;
			private set;
		}

		public Customer(Keys.ICustomer key, Models.Customer element)
		{
			Key = key;
			Element = element;
		}
	}
}

namespace Models
{
	public class Customer
	{
		public string Name
		{
			get;
			set;
		}
	}
}