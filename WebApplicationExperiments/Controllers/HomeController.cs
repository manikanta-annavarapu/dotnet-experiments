using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApplicationExperiments.Filters;
using WebApplicationExperiments.Filters.AttributeFilters;
using WebApplicationExperiments.Models;

namespace WebApplicationExperiments.Controllers
{
    [SampleActionFilterAttribute]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine(
                $"- {nameof(HomeController)}.{nameof(OnActionExecuting)}");

            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine(
                $"- {nameof(HomeController)}.{nameof(OnActionExecuted)}");

            base.OnActionExecuted(context);
        }

        // GET: HomeController
        [HttpGet]
        [ResponseHeader("HeaderKey","HeaderValue")]
        public IList<HomeItem> Index()
        {
            return new List<HomeItem>
            {
                new HomeItem { Id = 1, Name = "Item 1", Description = "Description 1" },
                new HomeItem { Id = 2, Name = "Item 2", Description = "Description 2" },
                new HomeItem { Id = 3, Name = "Item 3", Description = "Description 3" }
            };
        }
    }
}
