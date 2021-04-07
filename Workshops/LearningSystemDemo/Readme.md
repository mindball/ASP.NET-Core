# Learning System
## Some useful cases
### Винаги да redirect-ваме
```cs
	//добра практика
	[HttpPost]
        public async Task<IActionResult> CreateCourses(AddCoursesFormModel courseModel)
        {
            ....
			//routeValue = new { area = string.Empty } пропуска Area-та, защото е по напред в EndPoint-a
            return RedirectToAction(nameof(HomeController.Index), "Home", new { area = string.Empty });
        }
		//лоша практика
		public async Task<IActionResult> CreateCourses(AddCoursesFormModel courseModel)
        {
            ....
            return Redirect(string URL);
        }
```
### Validation in viewModel (compare startDate, endDate)
```cs
public class AddCoursesFormModel : IValidatableObject
{
	...
	[DataType(DataType.Date)]        
    public DateTime StartDate { get; set; }

    [DataType(DataType.Date)]        
    public DateTime EndDate { get; set; }
	...
	public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.StartDate < DateTime.UtcNow)
            {
                yield return new ValidationResult("Start date should be in the future.");
            }

            if (this.StartDate > this.EndDate)
            {
                yield return new ValidationResult("Start date should be before end date.");
            }
        }
}
```
### If validattion is repeated in other models
```cs
//call from 
public class AddCoursesFormModel : IValidatableObject
    {
		...
        [DataType(DataType.Date)]
        [DateTimeFromValidateTo(nameof(EndDate))]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]        
        public DateTime EndDate { get; set; }
	}
	
[AttributeUsage(AttributeTargets.Property)]
    public class DateTimeFromValidateToAttribute : ValidationAttribute
    {
        public DateTimeFromValidateToAttribute(string dateToCompareToFieldName)
        {
            this.DateToCompareToFieldName = dateToCompareToFieldName;
        }

        private string DateToCompareToFieldName { get; set; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime earlierDate = (DateTime)value;

            DateTime laterDate = (DateTime)validationContext.ObjectType.GetProperty(this.DateToCompareToFieldName).GetValue(validationContext.ObjectInstance, null);

            if (laterDate > earlierDate)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Date is not later");
            }
        }
    }
```

### Article contrller
```
понеже е един и няма да създваме друг няма нужда от basecontroller, при User and Course controller имаме обща логика.
Но ако се разшири 
```

> Insert tinymce from cloud

### HTML sanitizer
```
Винаги когато имаме HTML, който го рендерираме на страница и до, която имат достъп всякакви user-ите.
```
```
Service, който идва от
вън, inject-вамего, и не ползва базаданните.
```
### ValidateModelStateAttribute - когато имаме много повтарящо validate model state действие

```cs
...
		if (!ModelState.IsValid)
        {
            return RedirectToAction(nameof(Index) or viewModel);
        }
...
public class ValidateModelStateAttribute : ActionFilterAttribute
    {       
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var controller = context.Controller as Controller;

                if (controller == null)
                {
                    return;
                }

                var model = context
                    .ActionArguments
                    .FirstOrDefault(a => a.Key.ToLower().Contains("model"))
                    .Value;

                if (model == null)
                {
                    return;
                }

                context.Result = controller.View(model);
            }
        }
```