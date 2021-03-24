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