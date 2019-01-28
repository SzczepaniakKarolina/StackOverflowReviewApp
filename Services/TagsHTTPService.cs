using StackoverflowReviewApp.Models;
using StackoverflowReviewApp.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StackoverflowReviewApp.Services
{
    public class TagsHTTPService : HTTPService
    {
        private readonly string URL_KEY = "tags";

        private StackoverflowUrlBuilder urlBuilder;

        public TagsHTTPService()
        {
            urlBuilder = new StackoverflowUrlBuilder(URL_KEY);
            SetDefaultFilterParameters();
        }

        public async Task<IList<Tag>> GetTagsAsync(int tagsAmount)
        {
            var pagesCount = tagsAmount / MAX_PAGE_SIZE;
            var tasks = new List<Task<Request<Tag>>>();
            for (int index = 1; index <= pagesCount; index++)
            {
                urlBuilder.UpdateQuery("page", index.ToString());
                tasks.Add(Get<Request<Tag>>(urlBuilder.GetURL()));
            }
            return (await Task.WhenAll(tasks.ToArray())).ToList()
                   .Where(t => t != null)
                   .SelectMany(t => t.Items).ToList();
        }

        private void SetDefaultFilterParameters()
        {
            var filterParameters = new Dictionary<string, string>()
            {
                ["site"] = "stackoverflow",
                ["order"] = "desc",
                ["sort"] = "popular",
                ["pagesize"] = MAX_PAGE_SIZE.ToString(),
            };
            urlBuilder.SetQuery(filterParameters);
        }
    }
}