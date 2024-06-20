using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplicationExperiments.Filters
{
    public class SampleAsyncActionFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(
            ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine("SampleActionFilter -> OnActionExecutionAsync -> before next");
            await next();
            Console.WriteLine("SampleActionFilter -> OnActionExecutionAsync -> after next");
        }
    }
}
