# TempData
```
TempData is a storage container for data that needs to be available to a separate HTTP request.
```
```
TempData keys are only cleared if they’ve been read (or after the user’s session expires)
```

```Scenario
Needed to display a message to the users after they did some kind of action, 
but that message needed to disappear before the next request. To do this using Session, 
but that didn't work out very well; after all, there's another construct we can use 
that does exactly this kind of thing: TempData.

TempData stores data placed into it until either you read it or until the completion 
of the next request, whichever is first.
```
## Limitations 
```
You can store simple values in TempData - strings, booleans and numeric types, 
but if you try to store complex types, you will encounter an InvalidOperationException:
```
```
If you want to use TempData to store complex types, you must serialize it to a 
string-based format yourself(Json is recommended format).
```

## Transfer data
```
TempData is used to transfer data from view to controller, controller to view, 
or from one action method to another action method of the same or a different controller.
```

## Keep data
```
Although, TempData removes a key-value once accessed, you can still keep it 
for the subsequent request by calling TempData.Keep() and TempData.Keep() method.
```
```
You can use Peek when you always want to retain the value for another request. Use Keep when retaining the 
value depends on additional logic.
```

### Keep()
* Keep() - Marks all keys in the dictionary for retention.
* Keep(String) - Marks the specified key in the dictionary for retention.