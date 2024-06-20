using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplicationExperiments.Filters.AttributeFilters
{
    public class SampleActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("SampleActionFilterAttribute -> OnActionExecuting -> Action is executing");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("SampleActionFilterAttribute -> OnActionExecuted -> Action is executed");
        }
    }
}
