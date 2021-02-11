## good practice
```
Винаги да валидираме данните на сървъра!!!
```
```
Когато получаваме и трябва да обработим html code е добре да бъде Sanitize с 
HtmlSanitizer и тогава да го визуализираме HTML.Raw е лоша практика
HtmlSanitizer е добре да се използва когато показваме полете от HTML.Raw
```

```
Винаги е добре да си правим Imput модели. Това ще ни предпази от даване на информация,
която не бихме искали да я достъпват(mass assignment or over posting).
Mass assignment, also known as over-posting, is an attack used on websites that involve 
some sort of model-binding to a request. It is used to set values on the server that a 
developer did not expect to be set.
```
```
регистриране на глобален филтър AutoValidateAntiforgeryTokenAttribute() in Configure service
```

```
комбинация [Authorize] с [AllowAnonymous] приорите взима атрибута, които е върху action-а а не 
върху контролера.
```
```
userManager.GetUserAsync(ClaimsPrincipal principal) ClaimsPrincipal principal = текущият логнат user = this.User
```

```c#
//Add Role services to Identity
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(
            Configuration.GetConnectionString("DefaultConnection")));
			
    services.AddDefaultIdentity<IdentityUser>()
        .AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>();

    services.AddControllersWithViews();
    services.AddRazorPages();
}
```

```
При смяна на role-лите на даден потребител force-ваме го да се logout-не, заради cook-тата
```
### Identity model customization in ASP.NET Core

[customization identity model 2:56:00](https://www.youtube.com/watch?v=itT73BVRuEQ) 
```
В контролерите this.User е доста ограничен, но ако искаме да извлечем даден потребител от DB
DI -> UserManager<T> в конструктора на controller-a
```
## Claims
```
Абстрактен начин за ре-презентиране на потребителска информация 
Е ключ-стойност допълнителна информация за потребител
```
```
конкретната употреба на claims-вете е да се стандартизират определени потребителски данни.(под общо наименование)
Пример: две системи си обменят информация за потребителите си, и тази информация да бъде представена посредством 
тези claims-ве(facebook login, gmail login and etc.) 
```
## Въпроси и отговори:
```
бавни ли са policy-тата - Не! и са доста удобни в някои ситуации.
Ако добавим clail къде отива: отива в таблицата userclaim и след това се добавя в cook-тата при login
```
```
Дали е добра практика да scaffold-ваме, ако трябва да custom-зираме нещо да, но ако 
след време се появи нова версия на библиотеките при scaffold-натите items мяма да се отрязят промените
вариант да ги затрием и отново да scaffold-ваме
```
```
Защо logout е форма а не anker ?
Ако беше logout anker ще може само по линка да извършим действието logout и тогава всеки от вън
ще може да ви logout-ва. Но когато logout е направен от форма: 1. никои с метод get не може да
ни принуда да се logout-не. 2. никой отвън не може да ни logout-не, поради наличието на VerificationToken => 
Cross-Site Request Forgery няма да проработи.
```
```
Правилно ли е Services-те да имат достъп до потребителите?
Не, може да се направи чрез IHttpContextAccessor но не е правилно(Не правилно se)
Правилно е Controller-рите, да извличат потребителите и да ги подават на services-те като id 
```
```
Къде се добавят други dbcontext-и:  
	services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();
Добавянето на други contexт-и е за големи с две бази данни едната за приложението другата за потребителите.
```


## JWT Authentication
```
Ползва се предимно SPA и web api;
```
```
2 web api едното да ни връща login, а другото че сме успели да се логнем показваме какво изпраще към сървъра като HEADER
за да разбера, че сме се логнали. Тоест не работим с бисквитка а работим с HEADER, като съдържанието(Value) на HEADER-a е
като съдържанието на бисквитката. Този сценарий се ползва, когато нямаме UI, а имаме api
```

[Прочитане на settings from appsettings.json](https://youtu.be/itT73BVRuEQ?t=16264)
```
името на класа трябва да съвпада с key(секцията) в appsettings. 
```


