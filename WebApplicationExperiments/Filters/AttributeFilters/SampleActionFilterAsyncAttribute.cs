using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplicationExperiments.Filters.AttributeFilters
{
    public class SampleActionFilterAsyncAttribute : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine("SampleActionFilterAsyncAttribute -> OnActionExecuting -> Action is executing");
            await next();
            Console.WriteLine("SampleActionFilterAsyncAttribute -> OnActionExecuted -> Action is executed");
        }
    }
}
