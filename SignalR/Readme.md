# Tutorial use
## Security 
```
Винаги escap-вайте!!!! html-a
```
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
```
Данните през websock-тите са или съобщения и ли byte arrays, трябва да се грижим за сериализацията
и за десерилизацията(encoding). При SignalR, той се грижи за това
```
![websockets](https://pasteboard.co/K6yrMig.jpg)

## RPC
```
Обменянето на информация не е чрез пакети, а чрез извикване на методи. Всеки метод си има име и параметри.
```

## SignalR 
```
При изграждането на връза, разбирането кои е потребителя зад тази връзка става с
помоща на cookie на потребителя, при дроп това се повтаря.
```
```
Библиотека, която опростява добавянето на RTC (Real Time Communications) между web приложенията.
```
```
SignalR servers don't know if the client is dead or not and they rely on notification from the 
underlying websocket for connection failures, that is, the OnClose callback. One solution to 
this problem is to configure IIS websockets to do the ping/pong for you. 
```
```
конкуренция за SIgnalR e Socket.io
```
### Group of clients
```
Пример чат стая, това е стая и ако някои изпрати съобщение на тази стая идеята е всички, които са вътре
да го видят,
```
### Azure SignalR Service
```
позволява да създадем SignalR приложение, което да е дистрибутирано и да работи на няколко сървъра едновременно
```
### SIgnalR supports 3 techniques for handling RTC (транспортния протокол с приоритет от горе надолу)
* WebSockets
* Server-Sent Events
* LongPooling

### Hub conceptions
```
Manage: conections, groups, messaging, identity system
```
```
При всеки извикан метод чрез SignalR се създава нова инстанция на Hub-a, както при контролерите,
всичко се inject-ва наново. Това е добре за чистия state, при извикването на нов метод. 
```

### MessagePack
```
Ефективен механизъм за binary сериализация
```

### Notifications scenario
```
Имам сценарий за изпращане на notifications, това може да се случи и от някои контролер(или от ), а не директно от Hub, 
това става чрез Injection IHubContext<ИметоНаХъба> в конструктора на контролера. Вече от там имаме достъп 
до signalR. Само че има една малка подробност, този notifications, трябва да го съхраним в базата-данни, като 
потребителят има връзка едно към много за notifications(всеки от тях може да има състояние прочетен/непрочетен).
```

### Предимсва и недостатъци
> При WebSockets, ако дропне връзката, ние я менажираме трябва да я създадем наново.
> При WebSockets, при изтичане на 120 сек, връзката се дропва 
> SignalR поддържа ping/pong request to keep ASP.net sessions
> SignalR има опцията за reconnect