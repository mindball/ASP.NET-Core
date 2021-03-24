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