## Conventional routing order
```
Conventional routing only matches a combination of action and controller that are defined by the app.
Matches from a route that appears earlier have a higher priority. Conventional routing is order-dependent. 
In general, routes with areas should be placed earlier as they're more specific than routes without an area.
```
```
```
Маршрутизирането с атрибутите изисква повече данни, за да се посочи маршрут. Конвенционалният маршрут 
по подразбиране обработва маршрутите по-кратко.
```
```

## Multiple conventional routes
```cs
app.UseEndpoints(endpoints =>
{
    //blog route has a higher priority for matches than the default route because it is added first.
    endpoints.MapControllerRoute(name: "blog",
                pattern: "blog/{*article}",
                defaults: new { controller = "Blog", action = "Article" });
    endpoints.MapControllerRoute(name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
});
```
### Because controller and action don't appear in the route template "blog/{*article}" as parameters:
```
    'defaults: new { controller = "Blog", action = "Article" });'
They can only have the default values { controller = "Blog", action = "Article" }.
This route always maps to the action BlogController.Article.
```
## Resolving ambiguous actions
```cs
public IActionResult Edit(int id)
        {
            return ControllerContext.MyDisplayRouteInfo(id);
        }

        [HttpPost]
        public IActionResult Edit(int id, Product product)
        {
            return ControllerContext.MyDisplayRouteInfo(id, product.name);
        }
```
> Edit(int, Product) is selected when the request is an HTTP POST.
> Edit(int) is selected when the HTTP verb is anything else. Edit(int) is generally called via GET
```
If routing can't choose a best candidate, an AmbiguousMatchException is thrown, listing the 
multiple matched endpoints.
```

## Parameter Transformers
```
Transformers are service layer classes that modify the route segments and transform them into a new string value.
```
 > Finally, we can generate a link to this action. We do so using tag helpers:
 > Note that we still use the non-hyphenated name of the action in this anchor tag. We need to do this because the route uses that name; 
 > the transforming happens after the route is matched.

```html
<a class="nav-link text-dark" asp-controller="User" asp-action="NamesAndHealthData">Parameter Transformer</a>
```
## Multiple Parameters in Routes
```
We could use the a default route for this action, where the parameters are found in the query string of the URL
Which means that our URLs would look like this:
/parameters?level=2&type=default&id=81

This works perfectly fine! But what if we expect our action parameters to exist as part of the URL?
/parameters/2/default/81
```
```cs
[Route("Store")]
[Route("[controller]")]
public class Products6Controller : Controller
{
    [HttpPost("Buy")]       // Matches 'Products6/Buy' and 'Store/Buy'
    [HttpPost("Checkout")]  // Matches 'Products6/Checkout' and 'Store/Checkout'
    public IActionResult Buy()
    {
        return ControllerContext.MyDisplayRouteInfo();
    }
}

[Route("api/[controller]")]
public class Products7Controller : ControllerBase
{
    [HttpPut("Buy")]        // Matches PUT 'api/Products7/Buy'
    [HttpPost("Checkout")]  // Matches POST 'api/Products7/Checkout'
    public IActionResult Buy()
    {
        return ControllerContext.MyDisplayRouteInfo();
    }
}
```
## Combining attribute routes
> [Route("")] -> access  https://localhost:5001 
> [Route("Home")] -> access  https://localhost:5001/home 
> [Route("Home/Index")] -> access  https://localhost:5001/home/index 
> [Route("Home/Index/{id?}")] -> access  https://localhost:5001/home/index/1 
> [Route("Index")] -> access  https://localhost:5001/index 
> [Route("/")] -> access  https://localhost:5001  if combime with [Route("")] throw AmbiguousMatchException
> Set HomeController -> public IActionResult Index()
```
Ako [Route("")] или [Route("/")]   е set-нат нa друг action всъщият или друг controller throw AmbiguousMatchException
```

## Attribute route order
```
You can use the [Route] attribute to explicitly set when a particular route is going to be checked against 
via the Order property. By default, all defined routes have an Order value of 0 and routes are processed 
from lowest to highest. 
```