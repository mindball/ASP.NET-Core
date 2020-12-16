# Application Fundamentals
```
ASP.NET Core uses the Configure() method in the StartUp.cs
```
* Configure the HTTP Request Pipeline
* Define behavior for different environments
* This is done using the IApplicationBuilder and IHostingEnvironment
```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
	if (env.IsDevelopment()) { app.UseDeveloperExceptionPage(); }
	else { app.UseExceptionHandler("/Home/Error"); }
	
	app.UseHttpsRedirection();
	app.UseStaticFiles();
	app.UseRouting();
	app.UseAuthorization();
	app.UseEndpoints(...);
}
```

## Application Environments
```
Most environment architectures use the following environments:
```
* Dev – Where the program or component is developed
* Test – Where the product (component) is tested & verified by developers
* Stage – Where the customer tests if the product meets their expectations
* Production – Where the product is made available to all users
```C#
public void Configure(IApplicationBuilder app, IHostingEnvironment env)
{
	if(env.IsDevelopment()) //TODO: Do Development
	if(env.IsStaging()) //TODO: Do Staging
	if(env.IsProduction()) //TODO: Do Production
	if(env.IsEnvironment("some_environment")) //TODO: Do Something
	
	...
}
```

## Application Configuration - appsettings.js
```
Configuration providers read data from configuration sources: Azure Key Vault, Command-line arguments,
Custom providers (installed or created), Directory files, Environment variables, etc.

One of the default sources is appsettings.json
```
```
Какви настройки се слагат в appsettings.js: всякакви конфигурации, api-key-ве за външни ресурси,
cloudinary, email server и др. После тези настройки се можем да ги достъп чрез IConfiguration
App configuration is read at app startup from the providers
Configuration properties are mapped in IConfiguration
IConfiguration is available in the app's DI container - от него най често се използва неговия
индексатор []
За примера може да го инжектираме в View-то и слагаме наши измислени настройки appsettings.js
За по сложните json обекти използваме разделителя : например @this.Configuration["EmailServer:ServerUrl"]
```

### appsettings.js - > Production and Development state
```
в appsettings.json има закачени сателитни класове (appsettings.Development.json, appsettings.Production.json)
когато сме в Development appsettings.json може да взима настройки(може да ги презаписва) от appsettings.Development.json, 
и когато е в Production от appsettings.Production.json(по default има само Development), този файл ние си го 
създаваме като спазим наименованието и директно се прикача към appsettings.json
VS променя state-вете в Properties->Debug->Aspnetcore_environment-> Value=Production/Development или 
в launchSettings.json
```

## ConfigureServices
```
Register all services. Called before the Configure() method, by the WebHost
```

### Type of ConfigureServices (look at ApplicationsServicesConfiguration example)
 As write 'akazemis' and edit by 'David Pine' on the [AddTransient, AddScoped and AddSingleton Services Differences](https://tinyurl.com/y5n2hdgt)
*  Singleton
*  Scoped
*  Transient
```
най често е transient, а за repository-тата и dbContexta се иползва scoped
```

# Error Handling

### There are several ways to configure Error handling
* Developer Exception Page - ASP net core пълната информация(stack trace, code и друга служебна инф.) 
* Exception Handler - В конкретния action в конкретен контролер
```C#
	app.UseExceptionHandler("/Home/Error"); -> When call /Home/Exception
```
* Status Code Pages - спрямо грешката(status code) се визуализира определен page
```C#
app.UseStatusCodePagesWithRedirects("/Home/StatusCodeError?errorCode={0}");

localhost:8000/Home/non-existent-action > redirect to StatusCodeErrorErrorView
```
```
При този Error Handling layout се запазва
Може да се използва и като endpoint -> /Home/Error{0}/ като Error{0} може да са различни 
action-и зависещи от errorCode
според errorCode може да визуализираме различни view-ta
UseStatusCodePagesWithReExecute работи с грешки (без exception-ните) 404, 403, 400 and etc.
app.UseExceptionHandler обработва exception-ните 500
```

### ASP.NET Core MVC apps have additional options for handling errors
* Exception Filters
* Model Validation (ModelState)

### Good practice:
```
Ако искаме exception in action тогава използваме подхода с ЕxceptionFilter(good practice)
Ако искаме exception на генерално ниво (middleware level) тогава използваме middleware-exception
```
```
Когато възникне exception някъде в нашето приложение, ще се случи само при заявката, която е 
предизвикала exception-a, приложението продължава да работи !!! и другите заявки продължават 
работят
```
