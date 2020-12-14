# Razor Views
```
Разгледай HTMLSanitizer
```
```
View Engine Essentials
Passing Data to a View

в едно view може да има само един viewmodel, 
ако искаме да има и други viewmodel-и трябва да го вкараме вкараме
този, който е описан във view пример
```
```c#
public class IndexViewModel
{        
        public string Description { get; set; }

        
        public int Year { get; set; }

        public int UsersCount { get; set; }
		
		public AnotherViewModel modelName {get; set; }
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
Избягвайте да изпозлваме data services(DBContext-a) (други в отделни случай може) във view. Всички данни към view да само
от viewmodel-a
```
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
## Flow
```
1. Action
2. _ViewStart.cshtml
3. View.cshtml -> execute tag helpers + view components
4. _Layout или ако е дефиниран друг layout във view-то: execute Sections
@{
    Layout = "_Layout"; тук може и друго layout  да сме посочили    
}
```
### _ViewStart.cshtml
```
Views don't need to specify layout since their default layout is
set in their _ViewStart file:
```
### _ViewImports.cshtml
```
тук using-ите важат за всичките view-ta

@using WebApplication1.Models.ManageViewModels

@using Microsoft.AspNetCore.Identity
@addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
ако имаме custom tagHelper-и, които ние сме писали в проекта тук е мястото да
ги добавим
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
```
@*Добра практика да се използват sections*@ виж _Layout файла
    @RenderSection("Links", true)
    @*С тази проверка нарушаваме принципа на polymorphism в ООП*@
    @*Тук layout знае за своите "наследници" а той не трябва да знае за 
    тези view-a, който влизат при него и когато искаме да добавим
    ново view трябва да добавим нова проверка!!!*@
    @if (ViewContext.RouteData.Values["Action"] as string == "Index")
	
	Вместо проверката да се прави от наследниците се прави от базовия клас
```
```
@RenderSection("Scripts", required: false)
Добра практика при RenderSection когато изпълнява scripts да е най отдолу
Най отгоре всички CSS
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

```
Когато TagHelper добавя много промени, по добре да използваме partial view
или view компонента
```

## Partial Views
```
Partial Views render portions of a page
Break up large markup files into smaller components
Reduce the duplication of common view code (като правим промяна го правим
на едно място)
```
```
Могат да се добавят viewmodel-и и да се изпозлват
```
```
първо се търси в логалната директория после в другите
```
```
Пример: Виж използването на partial във index и privacy, за viewmodel в index.cshtml се взима IndexViewModel,
а в Privacy.cshtml се взима DateTime.Now.ToString(), това идва от описаното в partialView-_HomePageStart
model string. Тук се преизползва partialView. За модел във partialView-то sme дали стринг =>
които използва това partialView трябва да се съобрази с това.
```
```
когато имаме много големи view-ta е добра практира да се използват partial view, ползата даваме имена на парченцата от
дългото view - то става по четимо!!
```
```
ако ще се ползва от Index and Privacy да сложи в директория Home,
ако ще се ползва от _Layout се слага в директория Shared
```
## View Components
```
View Components могат да бъдат извикани само от друго view
```
```
Когато ни трябва partial view с логика правим view component-a
View-тата инициализират view component-тите(user-a не може, заявка е може)
```
### How works and when to use
```
извиква се view със синтаксиса:
<vc:registered-users title="Registered users"></vc:registered-users> и връща
view за което е закрепено към този метод, този метод не може да върне redirect
Например: в общия layout искаме да се показват послените съобщения от форума, 
или последните видео клипове. Layout си няма actions, достъп до база данните, 
няма service, Layout ima някакви view-ta (section-a не е опция). 
Как подаваме данни на Layout - това става с view component-a, защото тя, както и action-nite имат достъп до база
данните, сървисите, могат да си inject-нат каквото им трябва, да си дръпнат данните
да си направят view model и да го подадат на view component-a. За разлика от tagHelper-и,
тук имаме достъп до база данните, сървисите и обикновенно view component-тите само
свързани с някакви реални данни, докато tagHelper-и те алтернират съществуващ таг, partial 
view-тата показват парче от view използвайки view model.

Ако искаме да имаме функционалност и view и да не правим отделна заявка това се попълва от тези view component-и
Dynamic navigation menus - Ако искаме менютата на нашият сайт да зареждат от база данните, ще използваме view component-a ()
Login panels
Shopping carts
Sidebar content дърпа данни от базада.
Recently published articles
Tag cloud
```

```
View componets directory convención and consist:
class -> Folder: ViewComponents
result View -> Folder: ViewModel/ViewComponents -> viewModel
View -> Shared/Component/"Името на view component-a" -> Default
```

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

### ViewComponent has paramaters
```
ViewComponent-тата се използва като Tag, която може да има атрибути. Атрибутите отиват като параметри на ViewComponent-тата
```

## Difference partial view, tagHelper-и, view component-a
```
partial view са view-ta;
tagHelper-и ca код
view component-a са view + tagHelper-и
```