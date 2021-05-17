# View components
```
View components are similar to partial views, but they're much more powerful. View components don't 
use model binding, and only depend on the data provided when calling into it. 
view components are invoked directly with explicit data.
They can contain business logic, and separate the UI generation from the underlying behaviour.
```
```
View components seem to fit best in situations where you would want to use a partial, 
but that the rendering logic is complicated and may need to be tested.
```
## A view component:
> Renders a chunk rather than a whole response.
> Includes the same separation-of-concerns and testability benefits found between a controller and view.
> Can have parameters and business logic.
> Is typically invoked from a layout page.

### Intended anywhere you have reusable rendering logic that's too complex for a partial view, such as:
> Dynamic navigation menus
> Tag cloud (where it queries the database)
> Login panel
> Shopping cart
> Recently published articles
> Sidebar content on a typical blog
> A login panel that would be rendered on every page and show either the links to log out or log in, depending on the log in state of the user

## Invoking a view component
### Component.InvokeAsync Method
```csharp
@await Component.InvokeAsync("Name of view component", {Anonymous Type Containing Parameters})
```
### as a Tag Helper
> Name: Tag Helpers are translated into their kebab case
```cshtml
<vc:viewComponent-name max-priority="2" is-done="false">
</vc:priority-list>
```
> also add to import
```
@addTagHelper *, namespace of project
```
### Invoking directly from a controller
```cs
public IActionResult IndexVC()
{
    return ViewComponent("LoginStatus");
}
```

## Get from
[Andrewlock](https://andrewlock.net/an-introduction-to-viewcomponents-a-login-status-view-component/)

### LoginStatusViewComponent
```
Rendering a different template depending on whether the user is logged in or not. 
That means we could test this ViewComponent in isolation, testing that the correct 
template is displayed depending on our business requirements, without having to 
inspect the HTML output, which would be our only choice if this logic was embedded 
in a partial view instead.
```

## Rendering View templates
```
When you use return View() in your view component, you are returning a ViewViewComponentResult 
which is analogous to the ViewResult you typically return from MVC action methods.

return View("LoggedIn", user),
if you don't specify the name of the template to find, then the engine will assume the file is called default.cshtml
```

