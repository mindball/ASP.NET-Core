```cs
//In the preceding code, MapControllers is called inside UseEndpoints to map attribute routed controllers.
app.UseEndpoints(endpoints =>
    {
        endpoints.MapControllers();
    });

```

```
���������������� � ���������� ������� ������ �����, �� �� �� ������ �������. ���������������� ������� 
�� ������������ ��������� ���������� ��-������.
���������������� �� �������� ����� ��������� � ������� �������� �������, ��� �������� �������� 
�� �������� �� ����� ��������.
```

> ��� �������������� �� �������� ������� �� ���������� � ���������� �� ������ ������� ����, � 
> ����� ������ �������� � �����������, ����� ��� �� �� �������� ������ �� �����.
> ���������� ������ ������� ��� ������ URL ������ ���� ��������� ������:

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
������ ���������� REST API, ������������ �� Attribute Routing [Route (...)] � �� ����� � action-����, ��� ���� 
action-���� ������ ������ HTTP ������. ��-����� � �� ���������� ��-����������� HTTP verb attribut�, 
�� �� ��� �� ���������� �� ���� ����� �������� ������ API. �� ��������� �� REST API �� ������ �� ����� ����� 
������ � HTTP verb �� ���-��� � ��������� ��������� ��������.
```
> REST API ������ �� ��������� attribute routing, �� �� ��������� ���������������� �� ������������ 
> ���� ����� �� �������, ������ ���������� �� ����������� �� HTTP verbs. ���� ��������, �� ����� ��������, 
> �������� GET � POST �� �� ���� � ��� ��������� ������, ��������� ���� � ��� URL �����.  
> �ttribute routing ��������� ���� �� �������, ���������� �� ���������� ����������� 'API's public endpoint layout'.
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

����� ���� ����� �� ����� � ������ �� �� �������� � context-�� �� BookController-a.
������ ������� ���� �� �������� ����� �� ������ ����� ������ ����� ����� �� � �������� route.
��������:
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
POST � PUT �� ����� ������ �� ����, �� �������� ����� ��� �������, ����� �������� �� ������ �� ��������� ������. 
���������� ����������, ������ �� ���������� ��� �� ��������� ��� �������������, ����� �� ������ �����. �� ���� � ���������
PUT � idempotent(������������). ���� ��������, �� ��� ��������� ���� � ���� ������ ��� ���� ���� PUT, 
� ���� � ���� ��������� � ����� ����, ������� ������ ���� �� ��� �����. ��� ���� PUT ���������� �� �������� �� 
�������� �� �������������; ��������� Update ������ �� ������ ��� ������ ��������� �� ����� ���� ������ �� ������� request.

https://stackoverflow.com/questions/630453/put-vs-post-in-rest?page=1&tab=votes#tab-top
```