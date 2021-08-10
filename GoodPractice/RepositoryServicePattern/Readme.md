# The Repository-Service Pattern with DI and ASP.NET Core
```
Разликата между services и Repository, е че при Repository имам CRUD операции, 
тоест със сигурност работим с базаданни, докато при сървисите може и да нямаме
такива операции
```
```
Get this tutorial and thx https://exceptionnotfound.net/
```

This example project is used in the following blog posts:

* [The Repository-Service Pattern with DI and ASP.NET Core](https://exceptionnotfound.net/the-repository-service-pattern-with-dependency-injection-and-asp-net-core/)

## When use it
```
The Repository-Service Pattern is a great pattern for situations in which you need to 
query for data from a complex data store or need some layers of separation between what 
happens for single models vs combinations of models
```

## The Repository-Service pattern breaks up the business layer of the app into two distinct layers
```
The lower layer is the Repositories. These classes handle getting data into and out of 
our data store, with the important caveat that each Repository only works against a 
single Model class.
```
```
The upper layer is the Services. These classes can query multiple Repository classes 
and combine their data to form new, more complex business objects.
```

## Building the Repositories
```
The Repositories are intended to deal with operations for a single business model. 
This commonly includes CRUD functionality, and might also include more complex 
methods (e.g. querying for a collection of objects, or running stats against said collection). 

In this example we have two business models(objects) Food and Ticket
```

## Building the Services
```
Inherit from the Repository classes AND
```
```
Implement their own functionality, which is only necessary when said functionality 
deals with MORE THAN ONE BUSINESS OBJECT.

public interface IFoodService : IFoodRepository { }
public class FoodService : FoodRepository, IFoodService { }

public interface ITicketService : ITicketRepository { }
public class TicketService : TicketRepository, ITicketService { }
```
```
But we need to keep in mind our Goal #3 from earlier, which is that we want to 
display the average item profit for both tickets and food items on every page of the app. 
In order to do this, we will need a method which queries both FoodItem and Ticket, 
and because the Repository-Service Pattern says Repositories cannot do this, 
we need to create a new Service for this functionality.

To accomplish this we need a new service class, one that queries both FoodRepository 
and TicketRepository and constructs a complex object. Here's the new FinancialsService class
```
![Architecture Diagram](https://exceptionnotfound.net/content/images/2019/10/repository-service-pattern-diagram.png)

## Drawback
```
LOT of code, some of which might be totally unnecessary
```

## Summary
```
The Repository-Service Pattern is a great way to architect a real-world, 
complex application. Each of the layers (Repository and Service) have a well 
defined set of concerns and abilities, and by keeping the layers intact we can 
create an easily-modified, maintainable program architecture.
```