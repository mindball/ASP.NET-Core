# Web API
```
There is nothing drastically different from a casual web app
You build controllers, and they have actions
In this case though, the actions are in the role of endpoints
And the controllers have to be annotated as API Controllers
```
* We derive from ControllerBase
* We should annotate the class with [ApiController] and [Route]

## What is json schemas and namespaces

#Api controllers
```
В един апп може да имаме както api controller-и, така и обикновенни контолери
как да ги различим чрез атрибута [ApiController]

Ако в апп имаме само api-controller-и тогава може да използваме [assembly: ApiController]
```
* Automatic HTTP 400 responses (for model state errors)
* Binding source parameter inference
* Multipart / Form-data request inference
* Attribute routing requirement
* Problem details responses for error status codes

```
Има значение какъв метод идва от заявката(get, post, delete and etc.) за да може да изпълни конкретния 
action(няма значение името на action-a). Добра практика е да нямаме повтарящи се action-и само
един и същ request-method
```
```
Лоша практика и трябва да се избягва IFormFile (post method със файл)
```
```
[ApiController] осигурява автоматичен model state и връща HTTP 400 ако bind-га не 
се получи чрез автоматичния филтър ModelStateInvalidFilter
```
### Binding source parameter inference
```
При asp net приложенията, bind-а се извлича от или от body-то или от другите data value provider-и(
route, query ....) като key=value pair, но в web-api то си го търси от бодито заявката като json
```
```
Bind-ването разбира по типа на параметрите(да знае къде да ги търси спрямо типа на параметъра)
Ако е примитивен тип търси от Query-то, ако е complect-object от body-то
```
```C#
[HttpPost]
public IActionResult Create(   
	Product product, // [FromBody] is inferred
    string name) // [FromQuery] is inferred
{
	//Ако обект който идва е от примитивен тип се търси от query string, 
	//ако е сложен тип се търсе от FromBody-то
}

```
### Attribute routing requirement ([Route("controller")] или друг [Route("api/controller")] и т.н.)

## Error responses
```
Problem details responses for error status codes, MVC transforms error results,
errors are transformed into ProblemDetails
```
### ProblemDetails
* A type based on a HTTP Api Specification for error presentation
* A standardized format for machine-readable error details (Json format)
```JSON
{
    type: "https://tools.ietf.org/html/rfc7231#section-6.5.4",
    title: "Not Found",
    status: 404,
    traceId: "0HLHLV31KRN83:00000001"
}
```

## Default behavior can be overridden ConfigureApiBehaviorOptions


### AddXmlSerializerFormatters() заедно със Header-a "Accept=application/xml" ще позволи api-то да обработва и връща XML
### Content Negotiation
* Content-Type
* Accept
```
Content-Type and Accept header are the important elements while requesting a service. It tells the 
service in which format he will be receiving the input and in which format he needs to send the data back respectively.
 If you are making an Ajax call, below is the basic structure
```
[![ContentType](https://dotnettrickscloud.blob.core.windows.net/img/webapi/webapi-negotiationwebapi2-1.png)](https://dotnettrickscloud.blob.core.windows.net/img/webapi/webapi-negotiationwebapi2-1.png)
```Summary
Content-Type and Accept header are the important elements while requesting a service. It tells the 
service in which format he will be receiving the input and in which format he needs to send the data 
back respectively. If you are making an Ajax call, below is the basic structure:
```
```Ajax
$.ajax({
 url: "http://localhost:1240/api/Products",
 dataType: "application/xml",
 contentType: "application/json; charset=utf-8",
 data: JSON.stringify(inputdata),
 success: function(result) { },
});
```
## API Endpoint return types or controller action return types in ASP.NET Core web API:

### Specific type - primitive or complex data type
```
The simplest action returns a primitive or complex data type (for example, string or a custom object type)
Example: Return IEnumerable<T> or IAsyncEnumerable<T>
```
```C#
[HttpGet]
public IEnumerable<Product> Get()
{
	//ако връщаме Specific type данни и имаме проверка BadRequest не е от тип IEnumerable<Product> 
	//Затова ActionResult<Т> ни дава повече гъвкавост
	// (id != productModel.Id) return BadRequest();

    return this.productService.GetAllProducts();
}

```
### IActionResult type
```
The IActionResult return type is appropriate when multiple ActionResult return types are possible in an action. 
The ActionResult types represent various HTTP status codes. Any non-abstract class deriving from ActionResult 
qualifies as a valid return type
```

### ActionResult<T> type - implicit casting 
```
Return type for web API controller actions
It enables you to return a type deriving from ActionResult or return a specific type
```

### ActionResult<T> vs IActionResult

```ActionResult<T>
Позволява да върнем тип от ActionResult или определен тип например ActionResult<IEnumerable<complex object>>
```
```C#
[HttpGet]
public ActionResult<IEnumerable<Product>> Get()
{
	
	//Тук това в позволено защото BadRequest е ActionResult
	(id != productModel.Id) return BadRequest();

    return this.productService.GetAllProducts(); //-> ActionResult
}

```

## RESTful API
```
Концепцията: url да са едни и същи за CRUD операции. Зависи от http методите.
```
[![restful-Pic.jpg](https://i.postimg.cc/9MMnCBc5/restful-Pic.jpg)](https://postimg.cc/8F2HbMFt)

### Примери:
```
https://softuni.bg/trainings/1797/c-sharp-mvc-frameworks-asp-net-core-october2017#lesson-7069 този
url е SEO-friendly, 
https://softuni.bg/trainings/ -> GET query return all trainings и т.н.
```

### Odata RESTfull api
```
Добавя автоматични филтрации в URL. Пример:
http://host/service/Products?$filter=Name eq 'Milk' - All products with a Name equal to 'Milk'
http://host/service/Products?$filter=Name ne 'Milk' - All products with a Name not equal to 'Milk'
GET http://host/service/Categories?$orderby=Products/$count - Return all Categories ordered by the number of Products within each category
```

## Some stuff from the lectures

### Method HEAD - върни само headers без body

### Method OPTIONS - cross origin request sharing какви са правата ни да правим заявки при определен адрес



## CORS
```
Ако някои тръгне да прави заявка със postman, друг тоол, никои няма да му забрани да направи заявката
ограничава и дава насоки на BROWSE-рите. Кой домейни могат да ни достъпват api-то
```

## Good practice
```
Добре е да връщаме status code, според спецефичните резултати. Пример: Unauthorize, OK, NotFound, BadRequest
```