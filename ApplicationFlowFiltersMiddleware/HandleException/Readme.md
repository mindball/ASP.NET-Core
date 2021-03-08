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
The UseExceptionHandler middleware is a built-in middleware that we can use to handle exceptions,
catch unhandled exceptions in your application and allows you to handle those gracefully for the end use
```
```
In the code above, we’ve created an extension method in which we’ve registered the UseExceptionHandler middleware. 
Then, we’ve populated the status code and the content type of our response, logged the error message, and 
finally returned the response with the custom created object.
Our action method is much cleaner now and what’s more important we can reuse this 
functionality to write more readable actions in the future.
```
## Limitations of Exception Handling During Client-Server Interaction
```
Web apps have certain limitations to their exception handling capabilities because of the nature 
of disconnected HTTP requests and responses. Keep these in mind as you design your app’s exception handling behavior.
```
> 1. Once the headers for a response have been sent, you cannot change the response’s status code, 
> 		nor can any exception pages or handlers run. The response must be completed or the connection aborted.
> 2. If the client disconnects mid-response, you cannot send them the rest of the content of that response.
> 3. There is always the possibility of an exception occuring one layer below your exception handling layer.
> 4. Don’t forget, exception handling pages can have exceptions, too. It’s often a good idea for production error 
> 		pages to consist of purely static content.




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

## Re-execute vs Redirect
### Redirect
```
The problem with redirects for error pages is that they somewhat abuse the return codes of HTTP, 
even though the end result for a user is essentially the same. With the redirect method, 
when an error occurs the pipeline will return a 302 response to the user, with a redirect to a 
provided error path. This will cause a second response to be made to the the URL that is used to 
generate the custom error page, which would then return a 200 OK code for the second request:
```
[pic](https://andrewlock.net/content/images/2017/03/Redirect-2.png)
```
Semantically this isn't really correct, as you're triggering a second response, and ultimately 
returning a success code when an error actually occurred. This could also cause issues for SEO. 
By re-executing the pipeline you keep the correct (error) status code, you just return user-friendly HTML with it.

You are still in the context of the initial response, but the whole pipeline after the StatusCodePagesMiddleware is 
executed for a second time. The content generated by this second response is combined with the original Status Code 
to generate the final response that gets sent to the user. This provides a workflow that is overall more 
semantically correct, and means you don't completely lose the context of the original request.
```
### Re-execute
```
Note, the order of middleware in the pipeline is important. The StatusCodePagesMiddleware should be one of the 
earliest middleware in the pipeline, as it can only modify the response of middleware that comes after it in the pipeline
```
```C#
IApplicationBuilder.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");
```
```
There are two arguments to the UseStatusCodePagesWithReExecute method. The first is a path that will be used to 
re-execute the request in the pipeline and the second is a querystring that will be used.
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
### Sources:
- https://andrewlock.net/re-execute-the-middleware-pipeline-with-the-statuscodepages-middleware-to-create-custom-error-pages/
- https://andrewlock.net/retrieving-the-path-that-generated-an-error-with-the-statuscodepages-middleware/
- https://andrewlock.net/creating-a-custom-error-handler-middleware-function/
- https://docs.microsoft.com/en-us/aspnet/core/fundamentals/error-handling?view=aspnetcore-3.1
