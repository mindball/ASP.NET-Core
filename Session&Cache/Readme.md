## some persistence mechanisms
### TempData
```
Пази се в два request-a
``` 
### Cache
```
Глобален, ако някои добави нещо, всички ще го виждат
```
### Session
```
Ако създваме например shoppingcart приложение, тук сесията ни идва в 
помощ защото ще регистрираме<Singleton> carManager, той от своя страна
ще имплементира ConcurrentDictionary<stringId, ShoppingCart> carts, а ShoppingCart ще
енкапсулира readonly collection от items.
```

### Type of usage
* Потребителска кошница
* И по генерално можем да пазим настройки, данни, които сме готови да загубим ако потребителя се премести на друга машина или се логне от друг броусер

### Configure session
* AddDistributed(Memory or Sql)Cache
* Cooki.HttpOnly - XSS security: JS няма достъп до бисквитката за сесията.
* Add-middlewareSession 

### System.Collection.Concurrent

### Encapsulate items (readonly collection)


