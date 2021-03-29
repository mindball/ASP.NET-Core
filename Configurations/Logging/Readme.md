# Logging
```
предполага се логването да бъде базисна информация и не трябва да забавя приложението.
Има значение и къде ще съхраняваме logs. По дизайн те са synchronise(това е някаквъ вид limitaion) и този процес
не трябва да е бавен и дълъг.
Но ако искаме да съхраняваме логването да кажем в SQL сървъри, трябва да подходим за съхранението на някакво 
междинно място(intermediate place) и после да ги изпращаме(background process) към сървърът.
```
### Most used logs:
* Information
* Warning

## Log category
```
When an ILogger object is created, a category is specified. That category is included with each log 
message created by that instance of ILogger. The category string is arbitrary, but the convention 
is to use the class name. For example, in a controller the name might be "TodoApi.Controllers.TodoController". 
The ASP.NET Core web apps use ILogger<T> to automatically get an ILogger instance that uses the fully 
qualified type name of T as the category
```
### Explicitly specify the category(call ILoggerFactory.CreateLogger):
```
Calling CreateLogger with a fixed name can be useful when used in multiple methods so the events can be organized by category.
ILogger<T> is equivalent to calling CreateLogger with the fully qualified type name of T.
```
## Call the appropriate Log{LogLevel} method to control how much log output is written to a particular storage medium.
* In Production:
	1. Logging at the Trace or Information levels produces a high-volume of detailed log messages. 
		low-cost data store. Consider limiting Trace and Information to specific categories.
	2. Logging at Warning through Critical levels should produce few log messages
		> Costs and storage limits usually aren't a concern.
		> Few logs allow more flexibility in data store choices.
* In development:
	1. Set to Warning.
	2. Add Trace or Information messages when troubleshooting. 
		To limit utput, set Trace or Information only for the categories under investigation.
## Log exceptions
> The logger methods have overloads that take an exception parameter
```cs
 try
    {
        if (id == 3)
        {
            throw new Exception("Test exception");
        }
    }
    catch (Exception ex)
    {
        _logger.LogWarning(MyLogEvents.GetItemNotFound, ex, "TestExp({Id})", id);
        return NotFound();
    }
```
> Exception logging is provider-specific.

## Default log level
```
If the default log level is not set, the default log level value is Information.
```
### Set default log level when the default log level is not set in configuration
```cs
public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureLogging(logging => logging.SetMinimumLevel(LogLevel.Warning))
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}
```
## Filter function
```
A filter function is invoked for all providers and categories that don't have rules assigned to them by CONFIGURATION or code
```
```cs
//The preceding code displays console logs when the category contains Controller or Microsoft and the log level is Information or higher.
//Generally, log levels should be specified in configuration and not code.
	public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureLogging(logging =>
            {
                logging.AddFilter((provider, category, logLevel) =>
                {
                    if (provider.Contains("ConsoleLoggerProvider")
                        && category.Contains("Controller")
                        && logLevel >= LogLevel.Information)
                    {
                        return true;
                    }
                    else if (provider.Contains("ConsoleLoggerProvider")
                        && category.Contains("Microsoft")
                        && logLevel >= LogLevel.Information)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                });
            })
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
```
## Explane override settings
```cs
public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureLogging((context, logging) =>
            {
                logging.Clear
            })

```
