## Attribute Routing vs Conventional Routing in ASP.NET Core:
```
In Attribute Routing, we need to define the routes using the Route attribute within the 
controller and action methods. The Attribute routing offers a bit more flexibility than 
conventional based routing. However, in general, the conventional based routings are useful 
for controllers that serve HTML pages. On the other hand, the attribute routings are useful 
for controllers that serve RESTful APIs.
```

### Ignore the Route Template
```
/ or ~/
```

## The most specific routes have a chance to execute before the more general routes.
```
For example, an attribute route like blog/search/{topic} is more specific than an 
attribute route like blog/{*article}. The blog/search/{topic} route has higher priority, 
by default, because it's more specific. Using conventional routing, the developer is 
responsible for placing routes in the desired order.
```