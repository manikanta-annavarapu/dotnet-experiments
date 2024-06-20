using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplicationExperiments.Filters
{
    public class ResponseHeaderAttribute : ActionFilterAttribute
    {
        private readonly string _name;
        private readonly string _value;

        public ResponseHeaderAttribute(string name, string value)
        {
            _name = name;
            _value = value;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("ResponseHeaderAttribute with constructor parameters -> OnActionExecuting -> Action is executing");
            context.HttpContext.Response.Headers.Add(_name, _value);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("ResponseHeaderAttribute with constructor parameters -> OnActionExecuted -> Action executed");
        }
    }
}
