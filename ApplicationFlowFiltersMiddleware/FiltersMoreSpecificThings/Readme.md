[detailed explain](https://jakeydocs.readthedocs.io/en/latest/mvc/controllers/filters.html)

## Good practice
```
Auditting and logging процесите са тежки и отнемат доста от ресурсите на сървърите.
Добре е да се правят на sensitive places(admin panell), administrative data.
Един такъв филтър ако се сложи глобално не е правилно.
```

## Custom authorization filters
```
To implement a custom authorization filter, we need to create a class that derives either 
AuthorizeAttribute, AuthorizationFilterAttribute, or IAuthorizationFilter.
```
* AuthorizeAttribute: An action is authorized based on the current user and the user's roles.
* AuthorizationFilterAttribute: Synchronous authorization logic is applied and it may not be based on the current user or role.
* IAuthorizationFilter:
```
Both AuthorizeAttribute and AuthorizationFilterAttribute implement IAuthorizationFilter. 
IAuthorizationFilter is to be implemented if advanced authorization logic is required.
```