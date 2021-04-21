# Anchor Tag Helper in ASP.NET Core
## asp-controller
```
If the asp-controller attribute is specified and asp-action isn't, the 
default asp-action value is the controller action associated with the 
currently executing view. If asp-action is omitted from the preceding markup, 
and the Anchor Tag Helper is used in HomeController's Index view (/Home)
```
## asp-action
```
The asp-action attribute value represents the controller action name included in the generated href attribute.
```
```
If no asp-controller attribute is specified, the default controller calling the view executing the current view is used.
```
```
If no asp-controller attribute is specified, the default controller calling the view executing the current view is used.

If the asp-action attribute value is Index, then no action is appended to the URL, leading to the invocation of the default
Index action. The action specified (or defaulted), must exist in the controller referenced in asp-controller.
```
## asp-route-{value}
```
The asp-route-{value} attribute enables a wildcard route prefix. Any value occupying the {value} placeholder 
is interpreted as a potential route parameter. If a default route isn't found, this route prefix is appended 
to the generated href attribute as a request parameter and value. Otherwise, it's substituted in the route template.
```
```
If either asp-controller or asp-action aren't specified, then the same default processing is followed as is in the asp-route attribute.
To avoid a route conflict, asp-route shouldn't be used with the asp-controller and asp-action attributes.
```
## asp-all-route-data
