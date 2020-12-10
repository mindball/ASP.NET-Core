# Razor Views
```
View Engine Essentials
Passing Data to a View
```
## View Engine Essentials
```
Views in ASP.NET Core MVC use the Razor View Engine to embed
.NET Code in HTML Markup.
Usually, they contain minimal logic, related only to presenting data
```
```
Data can be passed to a View by using the ViewData, ViewBag or
through a ViewModel (Strongly-Typed View).
```
## Passing Data to a View
```
ViewData, ViewBag or
through a ViewModel (preferred  method)
``` 
## Views – Dependency Injection
```
This can be useful for view-specific services, such as localization or data 
required only for populating view elements

!!! Most of the data your views display should be passed in from the controller.
```
```
View injection can be useful to populate options in UI elements, such as 
dropdown lists. Consider a user profile form that includes options for 
specifying gender, state, and other preferences. Rendering such a form 
using a standard MVC approach would require the controller to request 
data access services for each of these sets of options, and then populate a 
model or ViewBag with each set of options to be bound.

An alternative approach injects services directly into the view to obtain 
the options. This minimizes the amount of code required by the 
controller, moving this view element construction logic into the view 
itself. The controller action to display a profile editing form only 
needs to pass the form the profile instance
```

## Layout
```
Define a common site template (~/Views/Shared/_Layout.cshtml)
Razor View engine renders content inside-out
First the View is rendered, and after that – the Layout
```
### _ViewStart.cshtml
```
Views don't need to specify layout since their default layout is
set in their _ViewStart file:
```
### _ViewImports.cshtml
```
If a directive or a dependency is shared between many Views it
can be specified globally in the

@using WebApplication1.Models.ManageViewModels

@using Microsoft.AspNetCore.Identity
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
```

## Sections
```
@RenderSection(string name, bool required)
If the section is required and not defined, an exception will be
thrown (IsSectionDefined())
```
```
A layout can optionally reference one or more sections, by calling 
RenderSection. Sections provide a way to organize where certain page 
elements should be placed. Each call to RenderSection can specify whether 
that section is required or optional
```

## Tag Helpers
```
Tag Helpers enable the participation of Server-side code in the
HTML element creation and rendering, in Razor views
```
### Tag Helpers provide
* An HTML-friendly development experience
* A rich IntelliSense environment for creating Razor markup
* A more productive, reliable and maintainable code
```
Creating Your Own Tag Helper - inherit TagHelper
```

## Partial Views
```
Partial Views render portions of a page
Break up large markup files into smaller components
Reduce the duplication of common view code
```

## View Components
```
View Components are similar to Partial Views but much more powerful
```
* Render a chunk rather than a whole response (as in Html.Action())
* Can have parameters and business logic
* Is typically invoked from a Layout page
* Includes the same S-o-C and testability benefits between controller / view

### View Components consist of 2 parts:
* A class – typically derived from ViewComponent
* A result – typically a View