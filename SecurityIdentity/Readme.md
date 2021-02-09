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