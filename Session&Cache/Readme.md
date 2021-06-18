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
### System.Collection.Concurrent

### Encapsulate items (readonly collection)
