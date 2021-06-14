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
След създване на успешна комуникация, не се разчита вече на на концепцията на http протокола, 
тоест нямаме request-и, response-и или body, а се стартира stream-ване.
```
```
От гледна точка на използването на websockets, не е най-лесното нещо но и не е трудното.
Трудността идва от това че трябва да си менажираме съобщенията, които идват, какво се е пратило
какво се получили, какво се иска в момента от нас, какво състояние сме и т.н:
 socket.onmessage = event => {
        document.getElementById("status").innerHTML = JSON.parse(event.data);
```
![websockets](https://pasteboard.co/K6yrMig.jpg)

