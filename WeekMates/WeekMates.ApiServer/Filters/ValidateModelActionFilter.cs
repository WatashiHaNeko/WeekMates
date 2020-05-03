using Microsoft.AspNetCore.Mvc.Filters;
using System;
using WeekMates.ApiServer.ActionResults;

namespace WeekMates.ApiServer.Filters
{
    public class ValidateModelActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid) {
                context.Result = new ValidationErrorResult(context.ModelState);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("OnActionExecuted");
        }
    }
}