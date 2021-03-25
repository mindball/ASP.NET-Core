```cs
//In the preceding code, MapControllers is called inside UseEndpoints to map attribute routed controllers.
app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });

```

```
Маршрутизирането с атрибутите изисква повече данни, за да се посочи маршрут. Конвенционалният маршрут 
по подразбиране обработва маршрутите по-кратко.
Маршрутизирането на атрибути обаче позволява и изисква прецизен контрол, кои шаблонни маршрути 
се прилагат за всяко действие.
```

> При маршрутизиране на атрибути имената на контролера и действията не играят никаква роля, в 
> която дадено действие е съпоставено, освен ако не се използва замяна на токен.
> Следващият пример съвпада със същите URL адреси като предишния пример:

```cs
[Route("[controller]/[action]")]
    public IActionResult About()
    {
        return ControllerContext.MyDisplayRouteInfo();
    }
```
```
Advantages of Tokens in Attribute Routing:
The main advantage is that in the future if you rename the controller name or the action method 
name then you do not have to change the route templates. The application is going to works with 
the new controller and action method names.
```
```cs
//Default actions
 [Route("")]
 public IActionResult Index()
 {....}
```
```
Когато изграждате REST API, използването на Attribute Routing [Route (...)] е по рядко в action-ните, тъй като 
action-ните приема всички HTTP методи. По-добре е да използвате по-специфичния HTTP verb attributе, 
за да сме по специфични за това какво поддържа вашият API. От клиентите на REST API се очаква да знаят какви 
пътища и HTTP verb се мап-ват с конкретни логически операции.
```
> REST API трябва да използват attribute routing, за да моделират функционалността на приложението 
> като набор от ресурси, където операциите са представени от HTTP verbs. Това означава, че много операции, 
> например GET и POST са на един и същ логически ресурс, използват един и същ URL адрес.  
> Аttribute routing осигурява ниво на контрол, необходимо за внимателно проектиране 'API's public endpoint layout'.
> 

## HTTP verb templates
### Route templates
```
All the HTTP verb templates are route templates.
[Route]
```
## Attribute routing with Http verb attributes
```cs
//if /api/test2/int/abc => Doesn't match this action, Returns a 404 Not Found error
[HttpGet("int/{id:int}")] // GET /api/HttpVerb/int/3
public string GetIntProduct(int id)
{
    return $"/api/te{nameof(GetIntProduct)}/int/{id} constraint";
}
```
> GetInt2Product action contains {id} in the template, but doesn't constrain id to values that can be converted 
> to an integer. A GET request to /api/test2/int2/abc:
> Happen: 
* Matches this route.
* Model binding fails to convert abc to an integer. The id parameter of the method is integer.
* Returns a 400 Bad Request because model binding failed to convertabc to an integer.
```cs
 [HttpGet("int2/{id}")]  // GET /api/HttpVerb/int2/3
public string GetInt2Product(int id)
{
    return $"/api/test2/int2/{id}";
}
```
### Specific case:
```
'This example is interesting because "books" is treated a child resource of "authors". 
This pattern is quite common in RESTful APIs.'

Имаме база данни от книги и автори но се намираме в context-та на BookController-a.
Съвсем логично може да изкараме данни на всички книги според даден автор но с различен route.
Например:
```
```cs
[[Route("api/books")]
public class BooksController : ApiController
{
...
		//The tilde (~) in the route template overrides the route prefix in the RoutePrefix attribute.
		[Route("~/api/authors/{authorId}/books")]
        public IQueryable<BookDto> GetBooksByAuthor(int authorId)
        {
            return db.Books.Include(b => b.Author)
                .Where(b => b.AuthorId == authorId)
                .Select(AsBookDto);
        }
...	
}
```
```
POST vs PUT
POST и PUT са много сходни по това, че изпращат данни към сървъра, които сървърът ще трябва да съхранява някъде. 
Технически погледнато, можете да използвате или за Създаване или Актуализиране, което се случва често. Но къде е разликата
PUT е idempotent(идемпотентен). Това означава, че ако направите една и съща заявка два пъти чрез PUT, 
с едни и същи параметри и двата пъти, втората заявка няма да има ефект. Ето защо PUT обикновено се използва за 
сценария за актуализиране; повикване Update повече от веднъж със същите параметри не прави нищо повече от първото request.

https://stackoverflow.com/questions/630453/put-vs-post-in-rest?page=1&tab=votes#tab-top
```