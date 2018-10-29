# Entity.NET Concept

## Summary

A simple experiment prototyping a concept for strongly typed ORMs.

## Getting Started

The idea that Entity.NET is attempting to conceptualize is one where strongly-typed objects are used with an ORM system. The primary objective is to use strongly typed identifiers (`Keys.Customer`) that restricts the usages of an applications ORM. The concept is from the following scenario:

```csharp
var cust = new Models.Customer() { Name = "John Doe" };
var entity = Repository.Add(cust);
//entity.Key => underlying int (10)
Repository.Update(entity.Key, new Models.Customer() { Name = "David Smith" });

//...

var existing = (Keys.Customer)10;
var updatedCust = Repository.Find(entity.Key);
Console.WriteLine(updatedCust.Name); //David Smith
```

The code would be generated from the base definition of an entity below. Roslyn would generate the strongly-typed code using Attributes on the models to control the code outputs.

```csharp
[Entity(typeof(int))]
class Customer {
    public string Name { get; set; }
    public string Address { get; set; }
}
```

## Acknowledgements

The project icon is retrieved from [the Noun Project](docs/icon/icon.json). The original source material has been altered for the purposes of the project. The icon is used under the terms of the [Public Domain](https://creativecommons.org/publicdomain/zero/1.0/).

The project icon is by [Maxi Koichi from the Noun Project](https://thenounproject.com/term/storage/49270/).