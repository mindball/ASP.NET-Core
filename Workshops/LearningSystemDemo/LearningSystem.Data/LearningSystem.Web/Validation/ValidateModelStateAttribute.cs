using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;

namespace LearningSystem.Web.Validation
{
    /// <summary>
    ///    This is action filter validated the model state, .....
    ///    Controller-a трябва да наследява Controller иначе няма да запали.
    ///    Модел в пост action-a трябва да Contain("model")
    ///    Също така ако ModelState.IsValid е невалиден в някои случай 
    ///    имаме логика когато влезнем в if. Например: няма работи
    ///     if(!context.ModelState.IsValid)
    ///     {
    ///          courseModel.Trainers = await GetTrainers();
    ///          return this.View(courseModel);
    ///     }          
    /// </summary>
    public class ValidateModelStateAttribute : ActionFilterAttribute
    {
        /*
         * Всеки път пишем 
         * if(!ModelState.IsValid)
         * {}
         * В такива ситуаций е правилно да пишем Summary
         */
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
    }
}
