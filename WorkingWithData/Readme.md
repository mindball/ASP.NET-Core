# Working with Data
```
Model Binding, Data Validation and Files in ASP.NET Core
```

## Model Binding
```
Model binding in ASP.NET Core MVC maps data from HTTP requests to
action method parameters.

The parameters may be primitive types or complex types
```

![Incoming Request to MVC](https://ibb.co/PYNJRTj)


### Model binding can look through several data sources(value providers)
* Form values – POST Request parameters
* Route values – The set of Route values provided by the Routing
* Query strings – The query string parameters in the URL
* Even in headers, cookies, session, etc. in custom model binders
* Data from these sources are stored as name-value pairs

### ModelState
```
Each entry in the controller's ModelState property is a ModelStateEntry,
each ModelStateEntry contains an Errors property - It's rarely necessary to query this collection
Колекция от грешки, които са се случили върху модела при изпълнение на валидацията.
```
#### The framework provides several attributes
```
[BindRequired]
Adds a model state error if binding cannot occur.

[BindNever]
Tells the model binder to never bind this parameter.

[From{source}]
Used to specify the exact binding source. [FromHeader], [FromQuery], [FromRoute],[FromForm]

[FromServices]
Uses dependency injection to bind parameters from services.

[FromBody]
Use configure formatters to bind data from request body. Formatter is selected based
on Content-Type of Request. Use configure formatters to bind data from request body. Formatter is selected based
on Content-Type of Request. Различава се от FromForm. Използва се когато данните искаме да ги вземем 
от body но като json(body-то на заявката е json-string)-used SPA, WebApi

[ModelBinder]
Used to override the default model binder, binding source and name.
```

### Custom Model Binder
```
IModelBinder, IModelBinderProvider(look Insert order)
```

![IModelBinderProvider](https://ibb.co/6HJTCP1)

### Good practice

* добра практика е когато имаме много на брой параметри в метод, да изведем complex type object with properties
* Asp core взима данни от: route values, form data, query string, headers за да се опита да ги bind-не в action-ните
* Подаване на данни в request: с приоритet - body-то, друг случай чрез търсачките е добре да е Get
* ако има повтарящи се параметри например в formdata-има поле somedata и в query също има somedata може
* да използваме атрибути за да укажем от кое място да се bind-не([FromQuery], [FromHeader]) and etc.

## Model Validation
```
.NET provides us an abstracted validation through attributes,
```

### Implement own Custom validation attribute - ValidationAttribute class
```
Validation attributes не позовляват динамични данни например:
[Range(1900, DateTime.Now.Year)] затова си правим custom attributes
```

### Implement validation directly in the Binding Model - IValidatableObject interface

### Good practice
```
Когато правим валидация да кажем на 1 property e добре да направим custom attribute, ако вградените
не ни вършат работа и добре е когато имаме валидация на повече properties във view-model да го направим чрез 
IValidatableObject

Разликата е, че: custom attribute може да се преизползва
```
```
 Добра практика е да ипозлваме заедно <div asp-validation-summary="All" class="text-danger"></div>
 със <span asp-validation-for="" class="text-danger"></span>, защото валидацията във някои
 случай няма да бъде вързана към конкретно проперти
```
```
good practice да се визуализират грешните до input-тите, за да може потребитля да се ориентира добре.
```
```
good practice Use RedirectToAction for anything dealing with your application actions/controllers. 
If you use Redirect and provide the URL, you'll need to modify those URLs manually when your route table changes.
```

## Working with Files - IFormFile
```
IFormFile (for single file) or IEnumerable<IFormFile> (or List<IFormFile>)
```
### ASP.NET Core abstracts file system access through File Providers
```
File Providers are used throughout the ASP.NET Core framework
```
### Examples of where ASP.NET Core uses File Providers internally
* IWebHostEnvironment exposes the app’s content root and web root
* Static File Middleware uses File Providers to locate static files
* Razor uses File Providers to locate pages and views
* PhysicalFileProvider