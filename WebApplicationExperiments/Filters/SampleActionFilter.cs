using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplicationExperiments.Filters
{
    public class SampleActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("SampleActionFilter -> OnActionExecuting -> Action is executing");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("SampleActionFilter -> OnActionExecuted -> Action is executed");
        }
    }
}
