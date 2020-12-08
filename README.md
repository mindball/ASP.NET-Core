# ASP.NET Core
```
ASP.NET Core is a cross-platform, open-source web framework
You can build web applications and services, IoT apps, mobile
backends and any web-based solution with ASP.NET Core
It can be deployed to the cloud (e.g. Azure) or on-premises
```
## ASP.NET Core Main Features
* A unified framework for building web UI and web APIs, architected for testability
* Ability to develop and run on Windows, macOS, and Linux
* Built-in dependency injection
* A lightweight, high-performance, and modular HTTP request pipeline (middlewares)
* Razor Pages is a page-based programming model that makes building web UI easier
* Blazor lets you use C# in the browser and share server-side and client-side app logic
* Razor markup provides syntax for Razor Pages, MVC views and Tag Helpers
* Cloud-ready, environment-based configuration system

## ASP.NET Core MVC Overview
* Uses the Model-View-Controller (MVC) design pattern
* Lightweight, Open Source, Testable, Good Tooling
* Razor markup for Razor Pages and MVC views
* RESTful services with ASP.NET Core Web API
* Built-in support for multiple data formats, content negotiation and CORS
* Achieve high-quality architecture design, optimizing developer work
* Convention over Configuration
* Model binding automatically maps data from HTTP requests
* Model validation with client-side and server-side validation

### Along with those ASP.NET Core MVC provides features like:
*Routing
*Dependency injection
*Strongly-typed views with the Razor view engine
*Tag Helpers enable server-side code in HTML elements
*Partial views and view components
*Filters, Areas, Middlewares
*Built-in security features
*Identity with users, roles and external providers

## Controllers and actions
### Controller
```
The core component of the MVC pattern. All the controllers should be available in a folder name 
Controllers. Controller naming standard should be {name}Controller (convention)
Every controller should inherit the Controller class
Access to Request, Response, HttpContext, RouteData, TempData, ModelState, User, ViewBag / ViewData, etc.
Routes select Controllers in every request
All requests are mapped to a specific action
```
### Action
```
Actions are the ultimate Request destination
Public controller methods
Non-static
No return value restrictions
Actions typically return an IActionResult
```
### Action Parameters
```
ASP.NET Core maps the data from the HTTP request to action parameters in few ways
```
* Routing engine can pass parameters to actions
```
http://localhost/Users/Niki
Routing pattern: Users/{username}
```
* URL query string can contains parameters
```
/Users/ByUsername?username=NikolayIT
```
* HTTP post data can also contain parameters

## ASP.NET Core MVC Routing
```
ASP.NET Core MVC uses a middleware for Routing on client requests.
(Middleware: Middleware is software that's assembled into an app pipeline to handle requests and responses.
Each component:
Chooses whether to pass the request to the next component in the pipeline.
Can perform work before and after the next component in the pipeline.)
```
* Routes describe how request URL paths should be mapped to Controller Actions.
* There are 2 types of Action routing
```
Conventional
Attribute
```
### Conventional
```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
    app.UseMvc(routes =>
    {
        routes.MapRoute(
            name: "default",
            template: "{controller=Home}/{action=Index}/{id?}");
    });
}
```