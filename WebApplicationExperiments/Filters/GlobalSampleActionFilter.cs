using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplicationExperiments.Filters
{
    public class GlobalSampleActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("GlobalSampleActionFilter -> OnActionExecuting -> Action is executing");
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("GlobalSampleActionFilter -> OnActionExecuted -> Action is executed");
        }
    }
}
