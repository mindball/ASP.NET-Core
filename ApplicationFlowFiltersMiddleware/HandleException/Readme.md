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

