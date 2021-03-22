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

## Areas
```
Ако имаме комбиниран случай с Areas + global controllers е важно да осигурим 
help-tag asp-area="" - празно, по този начин линковете ще работят!!!
```
```
за всяка ареа трябва да добавим _ViewStart, _ViewImports
```
### Ако генерираме линковете и имаме areas например products
> Лош пример
```html
<a asp-area="Products" asp-controller="Home" asp-action="Index">Products</a>
<a asp-controller="Home" asp-action="Index">Home</a>
при този вариант когато сме в http://localhost/Products и и изберем link-a Home ние ще бъдем в http://localhost/Products/Home-контолера,
ако излезнем от http://localhost/Products и се върнем в http://localhost и изберем линк-а Home ние ще влезнем в Global-контролера
Home това не е правилно!!!
```
> Добър пример изрично да се каже празна area тоест не искаме area искаме глобални контролери 
> или искаме конкретна area-Products
```html
<a asp-area="Products" asp-controller="Home" asp-action="Index">Products</a>
<a asp-area="" asp-controller="Home" asp-action="Index">Home</a>
```
```
Ако във view-то нa нечиа area решим да генерираме линк, няма смисъл от изричното и споменаване.
пример <a asp-area> тук е излишно. 
```
> Извод: В която и area да се намираме, ASP.NET генерира линк за нея, както е описано в лошият пример

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
#### Using Conventional Routing, with the default route:
* Optimizes an application by preventing the creation of a new URL pattern for every Action
* Ensures URL consistency in CRUD style applications
* Simplifies code and makes the UI more predictable
#### Route Constraints
* Route Constraints are rules on the URL segments
* All the constraints are regular expression compatible with the Regex class
```C#
routes.MapRoute(
    name: "blog",
    template: "{year}/{month}/{day}",
    defaults: new { controller = "Blog", action = "ByDate" },
    constraints: new { year = @"\d{4}", month = @"\d{1,2}", day = @"\d{1,2}", });
```
### Attribute Routing
```
Attribute routing uses a set of attributes to map actions directly to route templates
```
```C#
public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        return View();
    }
}
```
Attribute routing can also directly define the Request Method
```C#
[HttpGet("/")]
    public IActionResult Index()
    {
        return View();
    }

[HttpPost("Login")]
    public IActionResult Login()
    {
        return View();
    }
```

# Good practice
```
Добра практика за е описателния Route /Blog/{year}/{month}/{day}/ това е добре за SEO-то на google.

Също така е удобство за потребителите

Server site validation and client-side - да не влизат невалидни данни а при клиента да не се генерират излишни заявки(може да имаме големи форми и тежки заявки)

Винаги при post (success)заявка или промяна на Server-state(запис в базаданните) трябва да RedirectToAction(някъдето където е удачно),
може да стане проблем ако потребителя натисне F5 да добваи същите данни. При redirect
browser-а redirect към GET заявка
```


