# Tag helpers
```
My custom tag helper derives from TagHelper base class. It has a string property called BackgroundColor. 
The ASP.NET Core inspects all the properties of the Custom Tag Helper and sets the values of all the 
properties whose name matches the attribute applied to the HTML element. It will also convert the attribute 
value to the type of the property defined in the C# class.
```
* The name of the attribute should be in html style like background-color. 
* You cannot set the names of attribute starting with asp- or data-.
```
Example – when adding the attribute background-color="danger" to an HTML element. The BackgroundColor 
property value will be automatically assigned the value danger.
```


## Registering the Custom Tag Helper
```
adding in _ViewImports.cshtml file -> @addTagHelper CustomTagHelpers.TagHelpers.*, CustomTagHelpers
```
```
Tag Helpers receive information about the element they are transforming through TagHelperContext class object. 
It is provided as the first parameter of the Process() function
```

## Demystify Process()
```
The TagName property is used to specify to make aspbutton a html button element. 
The TagMode property is used to specify that the element is written using start and end tags.
I used the SetAttribute() method to add class attribute with bootstrap classes and type attribute value to the one provided in the attribute.
Finally with the SetContent() method I added the content to this button.
```
### The Process function has 2 parameters which are of type:
1. TagHelperContext
```
Tag Helpers receive information about the element they are transforming
```
2. TagHelperOutput
```
TagHelperOutput class is provided as the 2nd parameter of the Process() function. This class object contains the 
HTML element to be transformed and the transformation is done by configuring it’s object.
Tag Helper output use to read and change the actual content that’s in the scope of our Tag Helper.
```

## Appending and Prepending Elements with Tag Helper
```
The PreElement and PostElement properties of the TagHelperOutput class is used to add elements before and after the output element.
```
> PreContent : Contents are inserted before all the already existing contents.
> PostContent : Contents are inserted after all the already existing contents.

## Managing the Scope of a Tag Helper
```
You can manage the scope of a Tag Helper i.e. controlling to which element the tag helper applies
by [HtmlTargetElement()]
```
* Attributes see index.cshtml -> <aspbutton /> without override
> This property states that the tag helper should be applied to elements that have given set 
> of attributes. More than one attribute can be supplied in comma separated manner. If an 
> attribute name end with ‘*’, like background-color-* then it will match background-color-*, 
> background-color-white, background-color-black, etc
* ParentTag
> This property states that the tag helper should be applied to elements which are 
> contained inside an element of a given type.
* TagStructure
> This property states that the tag helper should be applied to elements having tag 
> structure corresponds to a given value. This value is given from the TagStructure enumeration 
> which defines ‘Unspecified’, ‘NormalOrSelfClosing’ and ‘WithoutEndTag’

## TagHelperContext.Items Property to Coordinate between Tag Helpers
```
The TagHelperContext.Items property is used to coordinate between tag helpers that operate on 
elements and those that operate on their descendants.
```

## Suppressing the Output Element
```
The SupressOutput() method of the TagHelperOutput class prevents the output element from being included in the View.
```

## Usefull case - IHtmlGenerator to generate the label asp-for,input asp-for,asp-validation-for taghelper's codes.
> InputHelper

## Summary and used links
* With Tag Helpers, we can extend existing elements with attributes or create new elements
* Once we create a Tag Helper, we usually have a reusable attribute or element
* TagHelper class that ships with MVC provides methods and properties for writing Tag Helpers
* Tag Helpers use a naming convention (just like controllers in MVC):
```
so if you use class name CoolTagHelper, you will be able to use <cool> tag in your code
```
[Custom-tag1](https://codingblast.com/asp-net-core-mvc-custom-tag-helpers/)
[Custom-tag2](https://www.yogihosting.com/aspnet-core-custom-tag-helpers/)
[auto generated identifier upon rendering multiple input elements with the same property name?](https://stackoverflow.com/questions/63033109/how-to-use-an-alternative-auto-generated-identifier-upon-rendering-multiple-inpu)

