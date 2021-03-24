```
слагането на два default-ни маршрути предизвиква:
AmbiguousMatchException: The request matched multiple endpoints. Matches:
WebApi.Demo.Controllers.HomeController.Index (WebApi.Demo)
WebApi.Demo.Controllers.TokenController.TokenIndex (WebApi.Demo) 
```

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
