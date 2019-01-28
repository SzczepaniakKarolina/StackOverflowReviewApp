using Microsoft.AspNetCore.Mvc;

namespace StackoverflowReviewApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Error() => View();
    }
}