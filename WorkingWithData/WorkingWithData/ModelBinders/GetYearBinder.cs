using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Threading.Tasks;

namespace WorkingWithData.ModelBinders
{
    public class GetYearBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var value = bindingContext.ValueProvider.GetValue("date").FirstValue;

            if (DateTime.TryParse(value, out var date))
            {
                bindingContext.Result = ModelBindingResult.Success(date.Year);
            }           

            return Task.CompletedTask;
        }
    }
}
