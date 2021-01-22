using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace WorkingWithData.ModelBinders
{
    public class GlobalBinderProvider : IModelBinderProvider
    {
        //register in configure-services
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            foreach (var prop in context.Metadata.Properties)
            {
                if(prop.ModelType == typeof(int) && prop.DisplayName.ToLower() == "year")
                {
                    return new BinderTypeModelBinder(typeof(GetYearBinder));
                }
            }
            //if(context?.Metadata?.PropertyName. == "year" 
            //    && context?.Metadata?.ModelType == typeof(int))
            //{
            //    return new BinderTypeModelBinder(typeof(GetYearBinder));
            //}

            //if (context == null) throw new ArgumentNullException(nameof(context));

            //if (context.Metadata.ModelType == typeof(Student))

            //    return new BinderTypeModelBinder(typeof(StudentEntityBinder));

            return null;
        }
    }
}
