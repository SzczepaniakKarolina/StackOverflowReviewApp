using Microsoft.AspNetCore.Mvc;
using StackoverflowReviewApp.Services;

namespace StackoverflowReviewApp.Controllers
{
    public class TagsController : Controller
    {
        private ITagsService tagsService;

        public TagsController(ITagsService tagsService)
        {
            this.tagsService = tagsService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var tagViewModels = tagsService.Get();
            return View(tagViewModels);
        }
    }
}
