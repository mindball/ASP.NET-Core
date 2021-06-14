# Tutorial use
[Tutorial: Get started with ASP.NET Core SignalR]

[Tutorial: Get started with ASP.NET Core SignalR]: <https://docs.microsoft.com/en-us/aspnet/core/tutorials/signalr?view=aspnetcore-5.0&tabs=visual-studio>

```
SignalR е доста интелигентна библиотека, евентуално ако browser-а не поддържа WebSockets, тя превключва
на SSE(server-sent-events) и ако това не се поддържа преминава на LongPooling или на Shortpooling
```

# WebSockets
```
Инициализира се на http-ниво, но после слиза на комуникация TCP връзка.
Java script инициализра websock connection и я генерира чрез request
```
![websockets](https://ibb.co/LdhPTXm)