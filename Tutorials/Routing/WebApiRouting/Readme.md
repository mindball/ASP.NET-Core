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