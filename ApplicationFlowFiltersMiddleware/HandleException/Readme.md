# Global Error Handler Middleware very popular in Webapi
```
The global error handler middleware is used catch all exceptions thrown by the api in a single place, 
removing the need for duplicated error handling code throughout the application. 
Result is Webapi json response
```
[GetFrom](https://jasonwatmore.com/post/2020/10/02/aspnet-core-31-global-error-handler-tutorial)

```
Even though there is nothing wrong with the try-catch blocks in our Actions in Web API project, 
we can extract all the exception handling logic into a single centralized place. By doing that, 
we make our actions more readable and the error handling process more maintainable. 
```

## Handling Errors Globally with the Built-In Middleware
[Codemaze](https://code-maze.com/global-error-handling-aspnetcore/)

```
The UseExceptionHandler middleware is a built-in middleware that we can use to handle exceptions
```
```
In the code above, we’ve created an extension method in which we’ve registered the UseExceptionHandler middleware. 
Then, we’ve populated the status code and the content type of our response, logged the error message, and 
finally returned the response with the custom created object.
Our action method is much cleaner now and what’s more important we can reuse this 
functionality to write more readable actions in the future.
```

## Handling Errors Globally with the Custom Middleware

## UseStatusCodePages
```
By default, an ASP.NET Core app doesn't provide a status code page for HTTP error status codes, 
such as 404 - Not Found. When the app encounters an HTTP 400-599 error status code that doesn't 
have a body, it returns the status code and an empty response body. To provide status code pages, 
use the status code pages middleware. To enable default text-only handlers for common error status 
codes, call UseStatusCodePages.

UseStatusCodePages before the Static File Middleware and the Endpoints Middleware.

UseStatusCodePages isn't typically used in production because it returns a message that isn't useful to users.
```

## UseStatusCodePagesWithRedirects
```Important
Sends a 302 - Found status code to the client.
Redirects the client to the error handling endpoint provided in the URL template. 
The error handling endpoint typically displays error information and returns HTTP 200.
```
### This method is commonly used when the app:
* Should redirect the client to a different endpoint, usually in cases where a different app processes the error. 
* For web apps, the client's browser address bar reflects the redirected endpoint.
* Shouldn't preserve and return the original status code with the initial redirect response.

## UseStatusCodePagesWithReExecute
```Important
Returns the original status code to the client.
Generates the response body by re-executing the request pipeline using an alternate path.
```
```
If an endpoint within the app is specified, create an MVC view or Razor page for the endpoint. 
Ensure UseStatusCodePagesWithReExecute is placed before UseRouting so the request can be rerouted to the status page.
```

## Exception filters
```
In MVC apps, exception filters can be configured globally or on a per-controller or per-action basis. 
In Razor Pages apps, they can be configured globally or per page model. 
These filters handle any unhandled exceptions that occur during the execution of a controller action or 
another filter.
```
```
Exception filters are useful for trapping exceptions that occur within MVC actions, 
but they're not as flexible as the built-in exception handling middleware, UseExceptionHandler. 
We recommend using UseExceptionHandler, unless you need to perform error handling 
differently based on which MVC action is chosen.
```

