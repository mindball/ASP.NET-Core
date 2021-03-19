# Configuration in ASP.NET Core
```
Configuration in ASP.NET Core is performed using one or more configuration providers. 
Configuration providers read configuration data from key-value pairs using a variety of 
configuration sources:
```
* Settings files, such as appsettings.json
* Environment variables
* Azure Key Vault
* Azure App Configuration
* Command-line arguments
* Custom providers, installed or created
* Directory files
* In-memory .NET objects

## Options interfaces

### Important software engineering principles:
> The options pattern uses classes to provide strongly typed access to groups of related settings. 
> When configuration settings are isolated by scenario into separate classes
> Options also provide a mechanism to validate configuration data
> Is registered as a Singleton and can be injected into any service lifetime.
> The Interface Segregation Principle (ISP) or Encapsulation: Scenarios (classes) that depend on 
> 	configuration settings depend only on the configuration settings that they use.
> Separation of Concerns: Settings for different parts of the app aren't dependent or coupled to one another.

### Bind hierarchical configuration
> An options class:
* Must be non-abstract with a public parameterless constructor.
* All public read-write properties of the type are bound.
* Fields are not bound. In the preceding code, Position is not bound. 
* The Position property is used so the string "Position" doesn't need to be hard coded in the app when binding the class to a configuration provider.

## IOptions<TOptions>:
```c#
 public void ConfigureServices(IServiceCollection services)
 {
	...
	var jwtSettingsSection =
                Configuration.GetSection("JwtSettings");
	var jwtSettings = jwtSettingsSection.Get<JwtSettings>();
	 var key = Encoding.ASCII.GetBytes(jwtSettings.Secret);
 }

 //DI configurations	
 public HomeController(IOptions<JwtSettings> jwtSettings)
 {...}
 
 public async Task<ActionResult<string>> Login([FromBody] LoginUserBindingModel loginUser)
 {
	...
	var secret = this.jwtSettings.Value.Secret; //from appsettings.json
	var key = Encoding.ASCII.GetBytes(secret);
	var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserName)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(
                                 new SymmetricSecurityKey(key),
                                 SecurityAlgorithms.HmacSha256Signature
            )
            };
			...
 }
```
### Does not support:
* Reading of configuration data after the app has started.
* Named options

## IOptionsSnapshot<TOptions>
* Is useful in scenarios where options should be recomputed on every request. 
	For more information [LookHere](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/options?view=aspnetcore-5.0#ios)
* Is registered as Scoped and therefore cannot be injected into a Singleton service.

## IOptionsMonitor<TOptions>
* Is used to retrieve options and manage options notifications for TOptions instances.
* Is registered as a Singleton and can be injected into any service lifetime.
* Supports:
	1. Change notifications
	2. Named options
	3. Reloadable configuration
	4. Selective options invalidation (IOptionsMonitorCache<TOptions>)
## Post-configuration 
```
enable setting or changing options after all IConfigureOptions<TOptions> configuration occurs.
```
## IOptionsFactory<TOptions>
```
is responsible for creating new options instances. It has a single Create method. 
The default implementation takes all registered IConfigureOptions<TOptions> and IPostConfigureOptions<TOptions> 
and runs all the configurations first, followed by the post-configuration. It distinguishes between 
IConfigureNamedOptions<TOptions> and IConfigureOptions<TOptions> and only calls the appropriate interface.
```
## IOptionsMonitorCache<TOptions>
```
 is used by IOptionsMonitor<TOptions> to cache TOptions instances. The IOptionsMonitorCache<TOptions> 
 invalidates options instances in the monitor so that the value is recomputed (TryRemove). Values can be manually
 introduced with TryAdd. The Clear method is used when all named instances should be recreated on demand.
 ```