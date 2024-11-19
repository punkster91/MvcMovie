using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    // REF: https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-8.0&tabs=visual-studio

    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome
        // EXAMPLE: /HelloWorld/Welcome?name=Rick&numTimes=4
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //Use HtmlEncoder.Default.Encode() to safely use the parameter values from the client

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
